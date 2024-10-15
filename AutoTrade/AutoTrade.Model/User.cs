﻿namespace AutoTrade.Model;

public partial class User
{
    public int Id { get; set; }
    public string? UserName { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Adress { get; set; }
    public string? Gender { get; set; }
    public bool IsAdmin { get; set; }
    public DateTime DateOfBirth { get; set; }
    public byte[]? ProfilePicture { get; set; }

}
