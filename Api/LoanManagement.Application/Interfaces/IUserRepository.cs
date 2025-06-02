using LoanManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanManagement.Application.Interfaces
{
      public interface IUserRepository
    {
        Task<User?> GetUserByUsernameAsync(string username);
        Task AddUserAsync(User user);
        Task<bool> SaveChangesAsync();
        Task<IEnumerable<User>> GetAllAsync();
        Task<User?> GetByIdAsync(Guid id);
        void RemoveUser(User user);


    }
}
