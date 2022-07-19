namespace ITFCodeWA.Extensions.ListExtendors
{
    public static class ListExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TList"></typeparam>
        /// <typeparam name="TItem"></typeparam>
        /// <param name="self"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static TList Append<TList, TItem>(this TList self, TItem item)
            where TList : class, IList<TItem>
        {
            ArgumentNullException.ThrowIfNull(self, nameof(self));

            self.Add(item);

            return self;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TList"></typeparam>
        /// <typeparam name="TItem"></typeparam>
        /// <param name="self"></param>
        /// <param name="item0"></param>
        /// <param name="item1"></param>
        /// <param name="items"></param>
        /// <returns></returns>
        public static TList Append<TList, TItem>(this TList self, TItem item0, TItem item1, params TItem[] items)
            where TList : class, IList<TItem>
        {
            ArgumentNullException.ThrowIfNull(self, nameof(self));

            return self.Append(new TItem[] { item0, item1 }.Concat(items));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TList"></typeparam>
        /// <typeparam name="TItem"></typeparam>
        /// <param name="self"></param>
        /// <param name="items"></param>
        /// <returns></returns>
        public static TList Append<TList, TItem>(this TList self, IEnumerable<TItem> items)
            where TList : class, IList<TItem>
        {
            ArgumentNullException.ThrowIfNull(self, nameof(self));
            ArgumentNullException.ThrowIfNull(items, nameof(items));

            foreach (var item in items)
                self.Add(item);

            return self;
        }
    }
}