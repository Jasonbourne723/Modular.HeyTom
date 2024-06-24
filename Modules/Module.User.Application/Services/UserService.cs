using Mapster;
using Module.User.Application.Dtos;
using Module.User.Domain;
using Shared.Instrastructure;

namespace Module.User.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<PageResult<UserDto>> PageList(long pageIndex, long pageSize)
        {
            return await Task.FromResult(new PageResult<UserDto>());
        }

        public async Task Add(UserDto userDto)
        {
            await _userRepository.Add(userDto.Adapt<Domain.User>());
        }

        public async Task Update(UserDto userDto)
        {
            await _userRepository.Update(userDto.Adapt<Domain.User>());
        }

        public async Task Delete(long userId)
        {
            await _userRepository.Delete(userId);
        }


    }
}