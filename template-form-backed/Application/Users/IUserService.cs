using template_form_backed.Api.Common;
using template_form_backed.Domain.Users;

namespace template_form_backed.Application.Users
{
    public interface IUserService
    {
        Task<Result<UserDetail>> CreateUserAsync(CreateUserRequest request);
        Task<List<UserDetail>> GetUsersAsync();
        Task<Result<UserDetail>> GetUserByIdAsync(Guid id);
    }
}
