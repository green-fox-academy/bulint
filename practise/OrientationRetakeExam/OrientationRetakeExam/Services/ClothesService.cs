using OrientationRetakeExam.Models;
using OrientationRetakeExam.Reporitories;
using OrientationRetakeExam.ViewModels;
using System.Collections.Generic;

namespace OrientationRetakeExam.Services
{
    public class ClothesService
    {
        private ClothesRepository clothesRepository;

        public ClothesService(ClothesRepository clothesRepository)
        {
            this.clothesRepository = clothesRepository;
        }

        public List<string> DropdownNameFilterer(List<Clothing> clothes)
        {
            List<string> filteredClothes = new List<string>();

            foreach (var clothing in clothes)
            {
                if (!filteredClothes.Contains(clothing.ItemName))
                {
                    filteredClothes.Add(clothing.ItemName);
                }
            }

            return filteredClothes;
        }

        public List<string> DropdownSizeFilterer(List<Clothing> clothes)
        {
            List<string> filteredClothes = new List<string>();

            foreach (var clothing in clothes)
            {
                if (!filteredClothes.Contains(clothing.Size))
                {
                    filteredClothes.Add(clothing.Size);
                }
            }

            return filteredClothes;
        }

        public ClothesViewModel GetViewModel()
        {
            List<Clothing> filteredClothes = new List<Clothing>();
            return new ClothesViewModel()
            {
                AllClothes = clothesRepository.GetList(),
                UniqueNames = DropdownNameFilterer(clothesRepository.GetList()),
                UniqueSizes = DropdownSizeFilterer(clothesRepository.GetList())
            };
        }
    }
}
