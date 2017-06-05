using System;
using System.Collections.Generic;
using System.Linq;

namespace Logistics.Models.Load
{
    public class LoadViewModel
    {
        public int LoadOrder { get; set; }
        public string DeliveryAddress { get; set; }

        public DateTime PlannedLoadingDate { get; set; }

        public string Sender { get; set; }

        public string Receiver { get; set; }

        public string ContactPersonName { get; set; }

        public string ContactPersonPhone { get; set; }

        public string PlannedDate => PlannedLoadingDate.Date.ToString("d");

        public string PlannedTime => PlannedLoadingDate.ToString("t");

        public List<CargoViewModel> CargoList { get; set; }

        public string TotalWeightKg => CargoList.Sum(c => c.WeightKg).ToString("F");

        public string TotalVolumeMCube { get { return CargoList.Sum(c => c.VolumeMCube).ToString("F"); } }

    }
}