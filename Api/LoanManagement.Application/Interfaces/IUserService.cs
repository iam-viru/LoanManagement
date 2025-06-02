using LoanManagement.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanManagement.Application.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserDto>> GetAllAsync();
        Task<UserDto?> GetByIdAsync(Guid id);
        Task CreateAsync(RegisterRequest request);
        Task UpdateAsync(Guid id, UserDto userDto);
        Task DeleteAsync(Guid id);
    }
}
