using One.Application.Dto;

namespace One.Application.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserDetailDto>> GetAllUsersAsync();
        Task<UserDetailDto?> GetUserByIdAsync(int id);
        Task CreateUserAsync(UserDetailDto user);
        Task UpdateUserAsync(UserDetailDto user);
        Task DeleteUserAsync(int id);
    }
}
