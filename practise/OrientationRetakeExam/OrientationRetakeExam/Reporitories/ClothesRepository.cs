using OrientationRetakeExam.Entities;
using OrientationRetakeExam.Models;
using OrientationRetakeExam.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace OrientationRetakeExam.Reporitories
{
    public class ClothesRepository
    {
        private ClothesContext clothesContext;

        public ClothesRepository(ClothesContext clothesContext)
        {
            this.clothesContext = clothesContext;
        }

        public List<Clothing> GetList()
        {
            return clothesContext.Clothes.ToList();
        }
    }
}
