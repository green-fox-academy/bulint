using PallidaOrientationExam.Models;
using PallidaOrientationExam.Repositories;
using System.Collections.Generic;

namespace PallidaOrientationExam.Services
{
    public class CarService
    {
        private CarRepository carRepository;

        public CarService(CarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        public List<Car> GetList()
        {
            return carRepository.GetList();
        }

        public List<Car> GetFilteredCars(string q, string police, string diplomat)
        {
            if (police == "1")
            {
                return carRepository.GetPoliceCars();
            }

            if (diplomat == "1")
            {
                return carRepository.GetDiplomatCars();
            }

            if (q != null)
            {
                return carRepository.FilteredCars(q);
            }

            return carRepository.GetList();
        }

        public List<Car> GetCarsByBrand(string brand)
        {
                return carRepository.CarsByBrand(brand);
        }
    }
}
