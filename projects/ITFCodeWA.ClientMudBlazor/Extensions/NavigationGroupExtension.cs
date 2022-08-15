using ITFCodeWA.ClientMudBlazor.Models.NavigationMenuItems;

namespace ITFCodeWA.ClientMudBlazor.Extensions
{
    public static class NavigationGroupExtension
    {
        public static NavigationGroup AddLink(this NavigationGroup self, NavigationLink navLink)
        {
            self.Links.Add(navLink);
            return self;
        }
    }
}
