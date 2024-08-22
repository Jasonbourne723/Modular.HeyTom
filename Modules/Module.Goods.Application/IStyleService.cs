namespace Module.Goods.Application
{
    public interface IStyleService
    {
        Task Add(StyleDto dto);
        Task<StyleDto> Get(long id);
    }
}