namespace Shared.Instrastructure
{
    public class PageResult<T> where T : class, new()
    {
        public long PageIndex { get; set; }

        public long PageSize { get; set; }

        public long TotalCount { get; set; }

        public long TotalPage { get; set; }

        public List<T> Rows { get; set; }
    }

}
