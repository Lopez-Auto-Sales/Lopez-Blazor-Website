using System;
using System.Collections.Generic;

namespace LopezBlazorWebsite.Shared
{
    public class JSONFile
    {
        public Car[] Cars { get; set; }
        public DateTime Date { get; set; }
    }

    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string VIN { get; set; }
        public bool IsSalvage { get; set; }
        public int? Mileage { get; set; }
        public decimal Price { get; set; }
        public IList<JSONExtra> Extras { get; set; }
        public string Path { get { return Constants.imgPrepend + VIN + Constants.imgAppend; } }
        public string Name { get { return string.Format("{0} {1} {2}",Year, Make, Model); } }
        public override string ToString()
        {
            return VIN;
        }
        public string MileageString { get { return Mileage == null ? "Exempt" : Mileage.Value.ToString("N0"); } }
    }

    public class JSONExtra
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            if (Name == "Note")
                return Value;
            return Name + ": " + Value;
        }
    }
}
