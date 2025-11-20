namespace template_form_backed.Domain.Users
{
    public interface IUserRepository
    {
        Task AddAsync(UserDetail userDetail);
        Task<List<UserDetail>> GetUsersAsync();
        Task<UserDetail> GetByEmailAsync(string email);
        Task<UserDetail> GetByIdAsync(Guid id);
    }
}
