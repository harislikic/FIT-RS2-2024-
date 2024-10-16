namespace Request
{
    public class UserInsertRequest
    {
        public string? UserName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Adress { get; set; }
        public string? Gender { get; set; }
        public required string Password { get; set; }
        public required string PasswordConfirmation { get; set; }
        public bool IsAdmin { get; set; } = false;
        public DateTime DateOfBirth { get; set; }

        public IFormFile? ProfilePicture { get; set; }
        public int CityId { get; set; }

    }
}