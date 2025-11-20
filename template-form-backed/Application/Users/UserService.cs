using template_form_backed.Api.Common;
using template_form_backed.Domain.Users;

namespace template_form_backed.Application.Users
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _users;

        public UserService(IUserRepository users)
        {
            _users = users;
        }
        public async Task<Result<UserDetail>> CreateUserAsync(CreateUserRequest request)
        {
            var existing = await _users.GetByEmailAsync(request.Email);
            if (existing != null)
            {
                return Result<UserDetail>.Failure("Email already exists.");
            }

            var user = new UserDetail(request.FirstName, request.LastName, request.Email, request.Phone, request.Profile, request.Birthday, request.Occupation, request.Sex);

            await _users.AddAsync(user);
            return Result<UserDetail>.Success(user);
        }
        public async Task<List<UserDetail>> GetUsersAsync()
        {
            var users = await _users.GetUsersAsync();

            return users;
        }
        public async Task<Result<UserDetail>> GetUserByIdAsync(Guid id)
        {
            var user = await _users.GetByIdAsync(id);

            if(user == null)
            {
                return Result<UserDetail>.Failure("User not Found.");
            }

            return Result<UserDetail>.Success(user);
        }
    }
}
