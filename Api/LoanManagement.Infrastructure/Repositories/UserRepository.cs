using LoanManagement.Application.Interfaces;
using LoanManagement.Domain.Entities;
using LoanManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanManagement.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User?> GetUserByUsernameAsync(string username)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
        }

        public async Task AddUserAsync(User user)
        {
            await _context.Users.AddAsync(user);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public void RemoveUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
