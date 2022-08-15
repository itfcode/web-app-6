namespace ITFCodeWA.Extensions.TypeExtendors.Tests.UnitTests
{
    using ITFCodeWA.Extensions.TypeExtendors.Tests.Classes;
    using Newtonsoft.Json;
    using System.Reflection;

    public partial class TypeExtensionsUnitTests
    {
        private readonly Type _type = typeof(TestClass);

        private void SaveResult(string filePathPrefix, bool? canRead, bool? canWrite, string contained, string notcontained, IList<PropertyInfo> props)
        {
            var result = props.Select(x => new
            {
                x.Name,
                x.CanRead,
                x.CanWrite,
            });

            var filePath = $@"d:\tests\{filePathPrefix}_{canRead}_{canWrite}_{contained}_{notcontained}.json";
            File.WriteAllText(filePath,
                JsonConvert.SerializeObject(new
                {
                    Condition = new
                    {
                        CanRead = canRead,
                        CanWrite = canWrite,
                        Contained = contained,
                        Notcontained = notcontained,
                    },
                    Result = result,
                }));
        }

        private void SaveResult(string filePathPrefix, bool? canRead, bool? canWrite, string[] contained, string[] notcontained, IList<PropertyInfo> props)
        {
            var result = props.Select(x => new
            {
                x.Name,
                x.CanRead,
                x.CanWrite,
            });

            var filePath = $@"d:\tests\{filePathPrefix}_{canRead}_{canWrite}_{contained}_{notcontained}.json";
            File.WriteAllText(filePath,
                JsonConvert.SerializeObject(new
                {
                    Condition = new
                    {
                        CanRead = canRead,
                        CanWrite = canWrite,
                        Contained = contained,
                        Notcontained = notcontained,
                    },
                    Result = result,
                }));
        }
    }
}