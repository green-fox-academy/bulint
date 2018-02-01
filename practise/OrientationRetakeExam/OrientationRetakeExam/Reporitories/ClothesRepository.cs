using OrientationRetakeExam.Entities;
using OrientationRetakeExam.Models;
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

        public Clothing RepoSelectedItem(long id, int amount)
        {
            var clothing = clothesContext.Clothes.FirstOrDefault(x => x.Id == id);
            clothing.UnitPrice *= amount;
            return clothing;
        }
    }
}
