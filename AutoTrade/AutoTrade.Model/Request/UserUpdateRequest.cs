namespace Request
{
    public class UserUpdateRequest
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Adress { get; set; }
        public string? Gender { get; set; }
        public  string? Password { get; set; }
        public  string? PasswordConfirmation { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime DateOfBirth { get; set; }

        public byte[]? ProfilePicture { get; set; }

    }
}