using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOE2DE_EcoCalculator
{
    public class Civilization
    {
        public string Name;
        public double FarmerGatheringRateMod = 1;
        public double FishermanGatheringRateMod = 1;
        public double HunterGatheringRateMod = 1;
        public double LumberjackGatheringRateMod = 1;
        public double GoldMinerGatheringRateMod = 1;
        public double StoneMinerGatheringRateMod = 1;
        public double ShepherdGatheringRateMod = 1;
        public double ForagerGatheringRateMod = 1;
        public double FarmCostMod = 1;
        public double RelicIncomeMod = 1;
        public double RelicFoodIncomeMod = 0;
        public Civilization(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
