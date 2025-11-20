using Microsoft.EntityFrameworkCore;
using System;
using template_form_backed.Domain.Users;

namespace template_form_backed.Infrastructure.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _db;
        public UserRepository(AppDbContext db)
        {
            _db = db;
        }
        public Task AddAsync(UserDetail userDetail)
        {
            _db.Users.Add(userDetail);
            return _db.SaveChangesAsync();
        }
        public Task<List<UserDetail>> GetUsersAsync()
        {
            return _db.Users.ToListAsync();
        }
        public Task<UserDetail> GetByEmailAsync(string email)
        {
            return _db.Users.FirstOrDefaultAsync(x => x.Email == email);
        }

        public Task<UserDetail> GetByIdAsync(Guid id)
        {
            return _db.Users.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
