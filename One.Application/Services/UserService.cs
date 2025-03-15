using AutoMapper;
using One.Application.Interfaces;
using One.Application.Dto;
using One.Domain.Entities;
using One.Domain.Interfaces;

namespace One.Application.Services
{
    public class UserService(IUnitOfWork _unitOfWork, IMapper _mapper) : IUserService
    {
        public async Task<IEnumerable<UserDetailDto>> GetAllUsersAsync()
        {
            var users = await _unitOfWork.UserRepository.GetAllAsync();
            var userDtos = _mapper.Map<IEnumerable<UserDetailDto>>(users);
            return userDtos;
        }

        public async Task<UserDetailDto?> GetUserByIdAsync(int id)
        {
            var user = await _unitOfWork.UserRepository.GetByIdAsync(id);
            var userDto = _mapper.Map<UserDetailDto>(user);
            return userDto;
        }

        public async Task CreateUserAsync(UserDetailDto userDto)
        {
            var user = _mapper.Map<UserDetail>(userDto);
            await _unitOfWork.UserRepository.AddAsync(user);
            await _unitOfWork.CompleteAsync();
        }

        public async Task UpdateUserAsync(UserDetailDto userDto)
        {
            var user = _mapper.Map<UserDetail>(userDto);
            await _unitOfWork.UserRepository.UpdateAsync(user);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteUserAsync(int id)
        {
            await _unitOfWork.UserRepository.DeleteAsync(id);
            await _unitOfWork.CompleteAsync();
        }
    }
}
