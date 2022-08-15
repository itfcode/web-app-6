namespace ITFCodeWA.ClientMudBlazor.Models.ColumnSettings
{
    public abstract record ColumnSetting 
    {
        public string Name { get; init; }
        public string FilterName { get; init; }
        public string Label { get; init; }
        public bool Visible { get; init; }
        public bool Fixed { get; init; }
        public bool Sortable { get; init; }
        public Type FilterType { get; init; }
    }

    public record ColumnSetting<T> : ColumnSetting
    {
        public Func<T, object> View { get; init; }
    }
}
