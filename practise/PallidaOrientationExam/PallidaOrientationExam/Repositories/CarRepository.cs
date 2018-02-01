using PallidaOrientationExam.Entities;
using PallidaOrientationExam.Models;
using System.Collections.Generic;
using System.Linq;

namespace PallidaOrientationExam.Repositories
{
    public class CarRepository
    {
        private CarContext carContext;

        public CarRepository(CarContext carContext)
        {
            this.carContext = carContext;
        }

        public List<Car> GetList()
        {
            return carContext.Cars.ToList();
        }

        public List<Car> GetPoliceCars()
        {
            return carContext.Cars.Where(x => x.LicencePlate.StartsWith("RB")).ToList();
        }

        public List<Car> GetDiplomatCars()
        {
            return carContext.Cars.Where(x => x.LicencePlate.StartsWith("DT")).ToList();
        }

        public List<Car> FilteredCars(string q)
        {
            return carContext.Cars.Where(x => x.LicencePlate.Contains(q)).ToList();
        }

        public List<Car> CarsByBrand(string brand)
        {
            return carContext.Cars.Where(x => x.Brand.Equals(brand)).ToList();
        }
    }
}
