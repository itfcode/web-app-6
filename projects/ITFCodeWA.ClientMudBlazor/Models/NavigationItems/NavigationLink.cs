using Microsoft.AspNetCore.Components.Routing;

namespace ITFCodeWA.ClientMudBlazor.Models.NavigationMenuItems
{
    public record NavigationLink : NavigationItem
    {
        public string Href { get; set; }
        public NavLinkMatch Match { get; set; } = NavLinkMatch.Prefix;
        public NavigationLinkTooltip Tooltip { get; set; }
    }
}