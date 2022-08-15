using ITFCodeWA.Core.Domain.EntityConfigurations;
using ITFCodeWA.Core.Domain.Extensions;
using ITFCodeWA.Data.References;

namespace ITFCodeWA.Domain.EntityConfigurations.References
{
    public class FoodConfiguration : ReferenceConfiguration<Food>
    {
        public override void Configure()
        {
            base.Configure();

            _builder
                .ConfigProperty(x => x.Proteins, nameof(Food.Proteins), (10, 2), true)
                .ConfigProperty(x => x.Fats, nameof(Food.Fats), (10, 2), true)
                .ConfigProperty(x => x.Carbohydrates, nameof(Food.Carbohydrates), (10, 2), true)
                .ConfigProperty(x => x.Calories, nameof(Food.Calories), (10, 2), true)
                .ConfigProperty(x => x.FoodGroupId, nameof(Food.FoodGroupId), true)
                .AddIndex(x => x.FoodGroupId, isUnique: false)
            ;
        }
    }
}