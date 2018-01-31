using OrientationRetakeExam.Models;
using OrientationRetakeExam.Reporitories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrientationRetakeExam.ViewModels
{
    public class ClothesViewModel
    {
        public List<Clothing> AllClothes { get; set; }
        public List<string> UniqueNames { get; set; }
        public List<string> UniqueSizes { get; set; }
    }
}
