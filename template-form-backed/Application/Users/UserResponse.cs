namespace template_form_backed.Application.Users
{
    public class UserResponse
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Profile { get; set; } = null!;
        public DateTime Birthday { get; set; }
        public string Occupation { get; set; } = null!;
        public string Sex { get; set; } = null!;
    }
}
