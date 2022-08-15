using ITFCodeWA.Core.Models.QueryFilters.Base.Interfaces;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Reflection;

namespace ITFCodeWA.API.Binders
{
    public class FilterInfoModelBinder : IModelBinder
    {
        private readonly IModelMetadataProvider _metadataProvider;
        private readonly Dictionary<string, IModelBinder> _binders;

        public FilterInfoModelBinder(IModelMetadataProvider metadataProvider, Dictionary<string, IModelBinder> binders)
        {
            _metadataProvider = metadataProvider;
            _binders = binders;
        }

        public async Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
            {
                throw new ArgumentNullException(nameof(bindingContext));
            }

            if (bindingContext.ModelType == typeof(IQueryFilter))
            {
                var type = bindingContext.ValueProvider.GetValue($"{bindingContext.ModelName.ToLowerInvariant()}.typeFilter");
                if (type == ValueProviderResult.None)
                {
                    bindingContext.Result = ModelBindingResult.Failed();
                    return;
                }
                var filterType = Assembly.GetAssembly(typeof(IQueryFilter)).GetTypes()
                    .FirstOrDefault(a => a.GetTypeInfo().IsSubclassOf(typeof(IQueryFilter)) && !a.IsAbstract && 
                        string.Equals(a.Name, $"{type.FirstValue}", StringComparison.InvariantCultureIgnoreCase));

                if (filterType == null)
                {
                    bindingContext.Result = ModelBindingResult.Failed();
                    return;
                }

                var binder = _binders[filterType.FullName];
                var metadata = _metadataProvider.GetMetadataForType(filterType);

                ModelBindingResult result;
                using (bindingContext.EnterNestedScope(metadata, bindingContext.FieldName, bindingContext.ModelName, null))
                {
                    await binder.BindModelAsync(bindingContext);
                    result = bindingContext.Result;
                }

                bindingContext.Result = result;
            }
        }
    }

    public class FilterInfoModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context.Metadata.ModelType != typeof(IQueryFilter)) return null;

            var binders = new Dictionary<string, IModelBinder>();
            var filterTypes = Assembly.GetAssembly(typeof(IQueryFilter)).GetTypes()
                .Where(a => a.GetTypeInfo().IsSubclassOf(typeof(IQueryFilter)) && !a.IsAbstract);

            foreach (var type in filterTypes)
            {
                var metadata = context.MetadataProvider.GetMetadataForType(type);
                var binder = context.CreateBinder(metadata);
                binders.Add(type.FullName, binder);
            }

            return new FilterInfoModelBinder(context.MetadataProvider, binders);
        }
    }
}
