namespace SearchObject
{
    public class AutomobileAdSearchObject : BaseSerachObject
    {
        public string? Title { get; set; }
        public double? MinPrice { get; set; }
        public double? MaxPrice { get; set; }
        public double? MinMilage { get; set; }
        public double? MaxMilage { get; set; }
        public int? YearOfManufacture { get; set; }
        public bool? Registered { get; set; }
        public int? CarBrandId { get; set; }
        public int? CarCategoryId { get; set; }
        public int? CarModelId { get; set; }
        public int? FuelTypeId { get; set; }
        public int? TransmissionTypeId { get; set; }
        public int? CityId { get; set; }
        public string? OrderBy { get; set; }
        public string? OrderDirection { get; set; }

    }
}