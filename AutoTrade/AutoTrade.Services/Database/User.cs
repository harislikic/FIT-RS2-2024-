using Database;

namespace AutoTrade.Services.Database;
public partial class User
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Adress { get; set; }
    public string Gender { get; set; }
    public string? PasswordHash { get; set; }
    public string? PasswordSalt { get; set; }
    public bool IsAdmin { get; set; } = false;
    public DateTime DateOfBirth { get; set; }
    public DateTime CreatedAt { get; set; }
    public string? ProfilePicture { get; set; }

    public int CityId { get; set; }
    public City City { get; set; }

    public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    public ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();
    public ICollection<AutomobileAd> AutomobileAds { get; set; } = new List<AutomobileAd>();
    public ICollection<MoodTracker> MoodTrackings { get; set; } = new List<MoodTracker>();


}