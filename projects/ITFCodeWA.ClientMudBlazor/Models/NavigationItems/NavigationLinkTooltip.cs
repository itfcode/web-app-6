using MudBlazor;

namespace ITFCodeWA.ClientMudBlazor.Models.NavigationMenuItems
{
    public record NavigationLinkTooltip
    {
        public string Text { get; set; } = "Not Defined";    
        public bool Arrow { get; set; } = true;
        public Placement Placement { get; set; } = Placement.Right;
    }
}
