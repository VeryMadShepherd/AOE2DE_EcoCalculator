using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOE2DE_EcoCalculator
{
    public partial class Form1 : Form
    {
        //production rates
        const double BaseFarmerGatheringRate = 0.32;
        const double BaseFishermanGatheringRate = 0.43;
        const double BaseHunterGatheringRate = 0.41;
        const double BaseLumberjackGatheringRate = 0.39;
        const double BaseGoldMinerGatheringRate = 0.38;
        const double BaseStoneMinerGatheringRate = 0.36;
        const double BaseShepherdMinerGatheringRate = 0.33;
        const double BaseForagerMinerGatheringRate = 0.31;
        //walking factor
        double ForagerWalkingFactor = 1;
        double HunterWalkingFactor = 1;
        double ShepherdWalkingFactor = 1;
        double FishermanWalkingFactor = 1;
        double LumberjackWalkingFactor = 1;
        double AllMinerWalkingFactor = 1;
        //wood upgrades
        double DoubleAxeMod = 1;
        double BowSawMod = 1;
        double TwoManSawMod = 1;
        //gold upgrades
        double GoldMiningMod = 1;
        double GoldShaftMiningMod = 1;
        //stone upgrades
        double StoneMiningMod = 1;
        double StoneShaftMiningMod = 1;
        //carts
        double WheelbarrowMod = 1;
        double HandCartMod = 1;
        //Farms data
        int HorseCollarMod = 0;
        int HeavyPlowMod = 0;
        int CropRotationMod = 0;
        int FarmBaseFoodAmount = 175;
        int FarmBaseBuildingTime = 15;
        int FarmBaseCost = 60;
        public Form1()
        {
            InitializeComponent();
        }
        #region events
        private void DoubleBitAxe_CheckedChanged(object sender, EventArgs e) => DoubleAxeMod = DoubleBitAxe.Checked ? 1 : 1.2;
        private void BowSaw_CheckedChanged(object sender, EventArgs e) => BowSawMod = BowSaw.Checked ? 1 : 1.2;
        private void TwoManSaw_CheckedChanged(object sender, EventArgs e) => TwoManSawMod = TwoManSaw.Checked ? 1 : 1.1;
        private void GoldMining_CheckedChanged(object sender, EventArgs e) => GoldMiningMod = GoldMining.Checked ? 1 : 1.15;
        private void GoldShaftMining_CheckedChanged(object sender, EventArgs e) => GoldShaftMiningMod = GoldShaftMining.Checked ? 1 : 1.15;
        private void StoneMining_CheckedChanged(object sender, EventArgs e) => StoneMiningMod = StoneMining.Checked ? 1 : 1.15;
        private void StoneShaftMining_CheckedChanged(object sender, EventArgs e) => StoneShaftMiningMod = StoneShaftMining.Checked ? 1 : 1.15;

        private void Wheelbarrow_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void HandCart_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void HorseCollar_CheckedChanged(object sender, EventArgs e) => HorseCollarMod = 75;

        private void HeavyPlow_CheckedChanged(object sender, EventArgs e) => HeavyPlowMod = 125;

        private void CropRotation_CheckedChanged(object sender, EventArgs e) => CropRotationMod = 175;
        #endregion
        private void Calculate_Click(object sender, EventArgs e)
        {

            int.TryParse(FarmersCount.Text, out int iFarmersCount);
            int.TryParse(ForagersCount.Text, out int iForagersCount);
            int.TryParse(HuntersCount.Text, out int iHuntersCount);
            int.TryParse(ShepherdCount.Text, out int iShepherdsCount);
            int.TryParse(FishermansCount.Text, out int iFishermansCount);
            int.TryParse(LumberjackCount.Text, out int iLumberjackCount);
            int.TryParse(MinerCount.Text, out int iMinersCount);
            int.TryParse(StoneCollectorsCount.Text, out int iStoneCollectorsCount);
            double CalculatedFarmProductionRate = BaseFarmerGatheringRate * WheelbarrowMod * HandCartMod;
            CalculatedFarmProductionRate = CalculatedFarmProductionRate > 0.44 ? 0.44 : CalculatedFarmProductionRate;
            double CalculatedFoodRate =
                iFarmersCount * CalculatedFarmProductionRate +
                iForagersCount * BaseForagerMinerGatheringRate * WheelbarrowMod * HandCartMod * ForagerWalkingFactor +
                iHuntersCount * BaseHunterGatheringRate * WheelbarrowMod * HandCartMod * HunterWalkingFactor +
                iShepherdsCount * BaseShepherdMinerGatheringRate * WheelbarrowMod * HandCartMod * ShepherdWalkingFactor+
                iFishermansCount * BaseFishermanGatheringRate * WheelbarrowMod * HandCartMod * FishermanWalkingFactor;
            double CalculatedWoodRate = iLumberjackCount * BaseLumberjackGatheringRate * DoubleAxeMod * BowSawMod * TwoManSawMod * WheelbarrowMod * HandCartMod;
            double CalculatedGoldRate = iMinersCount * BaseGoldMinerGatheringRate * GoldMiningMod * GoldShaftMiningMod * WheelbarrowMod * HandCartMod;
            double CalculatedStoneRate = iStoneCollectorsCount * BaseStoneMinerGatheringRate * StoneMiningMod * StoneShaftMiningMod * WheelbarrowMod * HandCartMod;
            FoodCount.Text = (CalculatedFoodRate * 60).ToString();
            WoodCount.Text = (CalculatedWoodRate * 60).ToString();
            GoldCount.Text = (CalculatedGoldRate * 60).ToString();
            StoneCount.Text = (CalculatedStoneRate * 60).ToString();
            double FarmFoodAmount = FarmBaseFoodAmount + HorseCollarMod + HeavyPlowMod + CropRotationMod;
            double FarmLivingTime = (FarmFoodAmount / CalculatedFarmProductionRate) + FarmBaseBuildingTime;
            double FarmWoodCostRate = FarmBaseCost * iFarmersCount * (60 / FarmLivingTime);
            FarmCostPerMinute.Text = Math.Round(FarmWoodCostRate, 1).ToString();
        }
    }
}
