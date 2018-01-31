using OrientationRetakeExam.Reporitories;

namespace OrientationRetakeExam.Services
{
    public class ClothesService
    {
        private ClothesRepository clothesRepository;

        public ClothesService(ClothesRepository clothesRepository)
        {
            this.clothesRepository = clothesRepository;
        }
    }
}
