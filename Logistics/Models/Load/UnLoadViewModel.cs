using System;
using System.Collections.Generic;
using System.Linq;

namespace Logistics.Models.Load
{
    public class UnLoadViewModel
    {
        public int UnLoadOrder { get; set; }
        public string Address { get; set; }
        public DateTime PlannedLoadingDate { get; set; }

        public string PlannedDate => PlannedLoadingDate.Date.ToString("d");

        public string PlannedTime => PlannedLoadingDate.ToString("t");

        public List<CargoViewModel> CargoList { get; set; }

        public string TotalWeightKg => CargoList.Sum(c => c.WeightKg).ToString("F");

        public string TotalVolumeMCube { get { return CargoList.Sum(c => c.VolumeMCube).ToString("F"); } }

    }
}