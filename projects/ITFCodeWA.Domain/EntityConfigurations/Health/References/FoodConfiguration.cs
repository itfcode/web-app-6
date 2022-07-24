using ITFCodeWA.Core.Domain.EntityConfigurations.Base;
using ITFCodeWA.Core.Domain.Extensions;
using ITFCodeWA.Data.Health.References;

namespace ITFCodeWA.Domain.EntityConfigurations.Health.References
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
            ;
        }
    }
}