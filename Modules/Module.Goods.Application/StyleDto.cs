namespace Module.Goods.Application
{
    public class StyleDto
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string StyleNo { get; set; }

        public List<string> Images { get; set; }

        public List<string> Tags { get; set; }

    }
}