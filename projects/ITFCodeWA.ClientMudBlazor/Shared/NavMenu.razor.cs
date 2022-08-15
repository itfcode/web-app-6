using ITFCodeWA.ClientMudBlazor.Extensions;
using ITFCodeWA.ClientMudBlazor.Models.NavigationMenuItems;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using MudBlazor;

namespace ITFCodeWA.ClientMudBlazor.Shared
{
    public partial class NavMenu : ComponentBase
    {
        private IList<NavigationItem> _navGroups = new List<NavigationItem>
        {
            new NavigationLink
            {
                Href = "demo",
                Match = NavLinkMatch.Prefix,
                IconColor = Color.Warning,
                Icon = @Icons.Material.Filled.DesktopWindows,
                Title = "Demo"
            },
            new NavigationGroup
            {
                Title = "General",
                Expanded = false,
                Icon = @Icons.Material.Filled.DensitySmall,
                IconColor = Color.Primary,
                Groups = new List<NavigationGroup>
                {
                    GenerateCatalogsGroup()
                        .AddLink(CreateLink("persons","Persons", @Icons.Material.Filled.People)),
                    GenerateRegistratorsGroup(),
                    GenerateAnalitycaGroup()
                }
            },
            new NavigationGroup
            {
                Title = "Finance",
                Expanded = false,
                Icon = @Icons.Material.Filled.MonetizationOn,
                IconColor = Color.Success,
                Groups = new List<NavigationGroup>
                {
                    GenerateCatalogsGroup()
                        .AddLink(CreateLink("contractors","Contractors", @Icons.Material.Filled.PeopleAlt))
                        .AddLink(CreateLink("contracts","Contracts", @Icons.Material.Filled.PeopleAlt))
                        .AddLink(CreateLink("currencies","Currencies", @Icons.Material.Filled.AttachMoney))
                        .AddLink(CreateLink("goods","Goods",@Icons.Material.Filled.Apps))
                        .AddLink(CreateLink("expense-items","Expense Items",@Icons.Material.Filled.Output))
                        .AddLink(CreateLink("revenue-items","Revenue Items",@Icons.Material.Filled.ExitToApp)),
                    GenerateRegistratorsGroup(),
                    GenerateAnalitycaGroup()
                }
            },
            new NavigationGroup
            {
                Title = "Health",
                Expanded = false,
                Icon = @Icons.Material.Filled.HealthAndSafety,
                IconColor = Color.Secondary,
                Groups = new List<NavigationGroup>
                {
                    GenerateCatalogsGroup()
                        .AddLink(CreateLink("foods", "Foods", @Icons.Material.Filled.FoodBank)),
                    GenerateRegistratorsGroup()
                        .AddLink(CreateLink("weight-registrators", "Weight Registrator", @Icons.Material.Filled.MonitorWeight)),                    
                    GenerateAnalitycaGroup()
                        .AddLink(CreateLink("weight-analityca", "Weight", @Icons.Material.Filled.LineWeight))
                }
            },
            new NavigationGroup
            {
                Title = "Other",
                Expanded = false,
            },
        };

        private static NavigationGroup GenerateCatalogsGroup()
        {
            return new NavigationGroup
            {
                Title = "Catalogs",
                Icon = @Icons.Filled.MenuBook,
                IconColor = Color.Warning,
            };
        }

        private static NavigationGroup GenerateRegistratorsGroup()
        {
            return new NavigationGroup
            {
                Title = "Registrators",
                Icon = @Icons.Filled.AppRegistration,
                IconColor = Color.Secondary,
            };
        }

        private static NavigationGroup GenerateAnalitycaGroup()
        {
            return new NavigationGroup
            {
                Title = "Analityca",
                Icon = @Icons.Filled.Analytics,
                IconColor = Color.Info,
            };
        }

        private static NavigationLink CreateLink(string href, string title, string icon = @Icons.Material.Filled.BrightnessLow) 
        {
            return new NavigationLink
            {
                Href = href,
                Match = NavLinkMatch.Prefix,
                IconColor = Color.Dark,
                Icon = icon,
                Title = title
            };
        }
    }
}