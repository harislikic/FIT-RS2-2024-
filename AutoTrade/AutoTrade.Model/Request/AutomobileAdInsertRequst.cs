using Microsoft.AspNetCore.Http;

namespace Request
{
    public class AutomobileAdInsertRequst
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Milage { get; set; }
        public int YearOfManufacture { get; set; }
        public bool Registered { get; set; }
        public DateTime? RegistrationExpirationDate { get; set; }
        public DateTime? FeaturedExpiryDate { get; set; }
        public DateTime? Last_Small_Service { get; set; }
        public DateTime? Last_Big_Service { get; set; }
        public int UserId { get; set; }
        public int? CarBrandId { get; set; }
        public int? CarCategoryId { get; set; }
        public int? CarModelId { get; set; }
        public int? FuelTypeId { get; set; }
        public int? TransmissionTypeId { get; set; }

        public List<IFormFile>? Images { get; set; }
    }
}