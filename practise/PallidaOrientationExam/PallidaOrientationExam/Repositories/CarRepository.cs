using PallidaOrientationExam.Entities;

namespace PallidaOrientationExam.Repositories
{
    public class CarRepository
    {
        private CarContext carContext;

        public CarRepository(CarContext carContext)
        {
            this.carContext = carContext;
        }
    }
}
