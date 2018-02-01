using PallidaOrientationExam.Repositories;

namespace PallidaOrientationExam.Services
{
    public class CarService
    {
        private CarRepository carRepository;

        public CarService(CarRepository carRepository)
        {
            this.carRepository = carRepository;
        }
    }
}
