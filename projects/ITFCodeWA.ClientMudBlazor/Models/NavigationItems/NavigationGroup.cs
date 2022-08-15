namespace ITFCodeWA.ClientMudBlazor.Models.NavigationMenuItems
{
    public record NavigationGroup : NavigationItem
    {
        public IList<NavigationGroup> Groups { get; set; } = new List<NavigationGroup>();
        public IList<NavigationLink> Links { get; set; } = new List<NavigationLink>();
    }
}