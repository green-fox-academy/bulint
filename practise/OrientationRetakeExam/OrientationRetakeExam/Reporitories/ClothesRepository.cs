using OrientationRetakeExam.Entities;

namespace OrientationRetakeExam.Reporitories
{
    public class ClothesRepository
    {
        private ClothesContext clothesContext;

        public ClothesRepository(ClothesContext clothesContext)
        {
            this.clothesContext = clothesContext;
        }
    }
}
