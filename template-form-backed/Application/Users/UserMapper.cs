using template_form_backed.Domain.Users;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace template_form_backed.Application.Users
{
    public static class UserMapper
    {
        public static UserResponse ToResponse(this UserDetail user)
        {
            if(user == null)
            {
                throw new ArgumentNullException(nameof(user), "User cannot be null in ToResponse()");
            }
            return new UserResponse
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Phone = user.Phone,
                Profile = user.Profile,
                Birthday = user.Birthday,
                Occupation = user.Occupation,
                Sex = user.Sex
            };
        }
        public static IEnumerable<UserResponse> ToResponse(this IEnumerable<UserDetail> users)
        {
            return users.Select(u => u.ToResponse());
        }
    }
}
