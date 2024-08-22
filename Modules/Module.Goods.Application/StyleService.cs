using Mapster;
using Module.Goods.Domain;
using Shared.Instrastructure;

namespace Module.Goods.Application
{
    public class StyleService : IStyleService
    {
        private readonly IStyleRepository _styleRepository;

        public StyleService(IStyleRepository styleRepository)
        {
            _styleRepository = styleRepository;
        }

        public async Task Add(StyleDto dto)
        {
            await _styleRepository.Add(dto.Adapt<Style>());
        }

        public async Task<StyleDto> Get(long id)
        {
            var style = await _styleRepository.Get(id);
            return style.Adapt<StyleDto>();
        }

    }
}