using OrientationRetakeExam.Models;
using System.Collections.Generic;

namespace OrientationRetakeExam.ViewModels
{
    public class ClothesViewModel
    {
        public List<Clothing> AllClothes { get; set; }
        public List<string> UniqueNames { get; set; }
        public List<string> UniqueSizes { get; set; }
    }
}
