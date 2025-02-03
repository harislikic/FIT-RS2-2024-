namespace AutoTrade.Model
{
  public partial class AutomobileAd
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public DateTime DateOFadd { get; set; }
    public int ViewsCount { get; set; }
    public int YearOfManufacture { get; set; }

    public bool Registered { get; set; }
    public DateTime? RegistrationExpirationDate { get; set; }
    public string Status { get; set; }
    public DateTime? FeaturedExpiryDate { get; set; }
    public DateTime? Last_Small_Service { get; set; }
    public DateTime? Last_Big_Service { get; set; }

    public double Milage { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }

    public int? CarBrandId { get; set; }
    public CarBrand CarBrand { get; set; }

    public int? CarCategoryId { get; set; }
    public CarCategory CarCategory { get; set; }

    public int? CarModelId { get; set; }
    public CarModel CarModel { get; set; }

    public ICollection<Comment>? Comments { get; set; } = new List<Comment>();

    public int? FuelTypeId { get; set; }
    public FuelType FuelType { get; set; }

    //public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    public int? TransmissionTypeId { get; set; }
    public TransmissionType TransmissionType { get; set; }

    public ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();

    public ICollection<AutomobileAdImage>? Images { get; set; } = new List<AutomobileAdImage>();

    public ICollection<AutomobileAdEquipment>? AutomobileAdEquipments { get; set; } = new List<AutomobileAdEquipment>();

    public int? EnginePower { get; set; }
    public int? NumberOfDoors { get; set; }
    public double? CubicCapacity { get; set; }
    public int? HorsePower { get; set; }
    public string? Color { get; set; }
    public int? VehicleCondtionId { get; set; }
    public VehicleCondition VehicleCondition { get; set; }
    public bool? IsHighlighted { get; set; }
    public DateTime? HighlightExpiryDate { get; set; }
  }
}