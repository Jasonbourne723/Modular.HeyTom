using Microsoft.AspNetCore.Mvc;
using Module.Goods.Application;
using Shared.Instrastructure;

namespace Module.Goods.Controller
{
    [Route("api/[Controller]")]
    public class StyleController : ControllerBase
    {
        private readonly IStyleService _styleService;

        public StyleController(IStyleService styleService)
        {
            _styleService = styleService;
        }

        [HttpPost]
        public async Task Post([FromBody] StyleDto dto)
        {
            await _styleService.Add(dto);
        }

        [HttpGet("{id}")]
        public async Task<StyleDto> Get(long id)
        {
            return await _styleService.Get(id);
        }
    }
}