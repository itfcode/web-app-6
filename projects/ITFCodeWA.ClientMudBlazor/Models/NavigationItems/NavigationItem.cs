using MudBlazor;

namespace ITFCodeWA.ClientMudBlazor.Models.NavigationMenuItems
{
    public abstract record NavigationItem
    {
        public string Title { get; set; } = "No Title";
        public string Icon { get; set; } = @Icons.Filled.QuestionMark;
        public Color IconColor { get; set; } = Color.Dark;
        public bool Expanded { get; set; } = false;
    }
}