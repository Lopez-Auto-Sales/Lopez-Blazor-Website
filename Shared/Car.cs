namespace LopezBlazorWebsite.Shared
{
    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Series { get; set; }
        public string Color { get; set; }
        public string VIN { get; set; }
        public string DriveType { get; set; }
        public string VehicleType { get; set; }
        public bool IsSalvage { get; set; }
        public string FuelType { get; set; }
        public string Displacement { get; set; }
        public int? NumDoors { get; set; }
        public int? NumCylinders { get; set; }
        public int? Mileage { get; set; }
        public decimal Price { get; set; }

        public string Path { get { return "./CarImages/" + VIN + ".jpg"; } }
        public string Name { get { return string.Format("{0} {1} {2}",Year, Make, Model); } }
        public override string ToString()
        {
            return VIN;
        }
        public string MileageString { get { return Mileage == null ? "Exempt" : Mileage.Value.ToString("N0"); } }
    }
}
