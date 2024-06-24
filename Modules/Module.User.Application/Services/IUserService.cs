using Module.User.Application.Dtos;
using Shared.Instrastructure;

namespace Module.User.Application.Services
{
    public interface IUserService
    {
        Task Add(UserDto userDto);
        Task Delete(long userId);
        Task<PageResult<UserDto>> PageList(long pageIndex, long pageSize);
        Task Update(UserDto userDto);
    }
}