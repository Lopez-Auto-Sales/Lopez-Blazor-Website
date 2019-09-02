using System.Linq;

namespace LopezBlazorWebsite.Shared
{
    public enum SortMethod
    {
        HighestPrice = 0,
        LowestPrice = 1,
        HighestMileage = 2,
        LowestMileage = 3
    };

    public class CarManager
    {
        public Car[] Cars { get; private set; }
        public SortMethod SortMethod { get; private set; }

        public CarManager(Car[] cars)
        {
            Cars = cars;
            SortCars(SortMethod.HighestPrice);
        }

        internal void SortCars(SortMethod method)
        {
            SortMethod = method;

            switch (method)
            {
                case SortMethod.HighestPrice:
                    Cars = Cars.OrderByDescending(car => car.Price).ToArray();
                    break;
                case SortMethod.LowestPrice:
                    Cars = Cars.OrderBy(car => car.Price).ToArray();
                    break;
                case SortMethod.HighestMileage:
                    Cars = Cars.OrderByDescending(car => car.Mileage).ToArray();
                    break;
                case SortMethod.LowestMileage:
                    Cars = Cars.OrderBy(car => car.Mileage).ToArray();
                    break;

            }
        }
    }
}
