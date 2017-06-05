using System.Collections.Generic;

namespace Logistics.Models.Load
{
    public class CargoViewModel
    {
        public string Description { get; set; }

        public string Packaging { get; set; }

        public double WeightKg { get; set; }

        public double VolumeMCube { get; set; }

        public string WeightKgFormatted => this.WeightKg.ToString("F");

        public string VolumeMCubeFormatted => this.VolumeMCube.ToString("F");

        public string LoadingKind { get; set; }

        public int LoadedQuantity { get; set; }

        public List<CargoClassificationViewModel> ClassificationList { get; set; }
    }
}