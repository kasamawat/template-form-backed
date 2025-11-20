namespace template_form_backed.Domain.Users
{
    public class UserDetail
    {
        public Guid Id { get; private set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Profile { get; set; } = null!;
        public DateTime Birthday { get; set; }
        public string Occupation { get; set; } = null!;
        public string Sex { get; set; } = null!;

        private UserDetail() { }
        public UserDetail(string firstName, string lastName, string email, string phone, string profile, DateTime birthday, string occupation, string sex)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Profile = profile;
            Birthday = birthday;
            Occupation = occupation;
            Sex = sex;
        }
    }
}
