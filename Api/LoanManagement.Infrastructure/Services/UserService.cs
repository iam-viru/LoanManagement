using LoanManagement.Application.DTOs;
using LoanManagement.Application.Interfaces;
using LoanManagement.Domain.Entities;

namespace LoanManagement.Infrastructure.Services
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _repo;

        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<UserDto>> GetAllAsync()
        {
            var users = await _repo.GetAllAsync();
            return users.Select(u => new UserDto
            {
                Id = u.Id,
                Username = u.Username,
                Email = u.Email,
                Role = u.Role
            });
        }

        public async Task<UserDto?> GetByIdAsync(Guid id)
        {
            var user = await _repo.GetByIdAsync(id);
            if (user == null) return null;

            return new UserDto
            {
                Id = user.Id,
                Username = user.Username,
                Email = user.Email,
                Role = user.Role
            };
        }

        public async Task CreateAsync(RegisterRequest request)
        {
            var user = new User
            {
                Id = Guid.NewGuid(),
                Username = request.Username,
                Email = request.Email,
                PasswordHash = request.Password, // NOTE: Should be hashed
                Role = request.Role
            };

            await _repo.AddUserAsync(user);
            await _repo.SaveChangesAsync();
        }

        public async Task UpdateAsync(Guid id, UserDto dto)
        {
            var user = await _repo.GetByIdAsync(id);
            if (user == null) throw new KeyNotFoundException("User not found.");

            user.Username = dto.Username;
            user.Email = dto.Email;
            user.Role = dto.Role;

            await _repo.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var user = await _repo.GetByIdAsync(id);
            if (user != null)
            {
                _repo.RemoveUser(user);
                await _repo.SaveChangesAsync();
            }
        }
    }
}
