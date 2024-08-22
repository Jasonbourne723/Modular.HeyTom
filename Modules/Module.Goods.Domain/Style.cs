using Shared.Instrastructure;

namespace Module.Goods.Domain
{
    public class Style : Entity<long>
    {
        public string Name { get; set; }

        public string StyleNo { get; set; }

        public List<string> Images { get; set; }

        public List<string> Tags { get; set; }

    }

    public interface IStyleRepository : IRepository<Style>
    { 
        
    }
}