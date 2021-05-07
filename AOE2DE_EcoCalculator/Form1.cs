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
        const double BaseVillagerSpeed = 0.8;
        const double BaseVillagerCapacity = 10;
        const double WheelbarrowCapacityMod = 3;
        const double HandCartCapacityMod = 7;
        double WheelbarrowSpeedMod = 1;
        double HandCartSpeedMod = 1;
        //production rates
        const double BaseFarmerGatheringRate = 0.32;
        const double BaseFishermanGatheringRate = 0.43;
        const double BaseHunterGatheringRate = 0.41;
        const double BaseLumberjackGatheringRate = 0.39;
        const double BaseGoldMinerGatheringRate = 0.38;
        const double BaseStoneMinerGatheringRate = 0.36;
        const double BaseShepherdGatheringRate = 0.33;
        const double BaseForagerGatheringRate = 0.31;
        const double RelicBaseGoldIncome = 0.5;
        const double RelicBaseFoodIncome = 0.5;

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
        double WheelbarrowMod = 0;
        double HandCartMod = 0;
        //Farms data
        int HorseCollarMod = 0;
        int HeavyPlowMod = 0;
        int CropRotationMod = 0;
        int FarmBaseFoodAmount = 175;
        int FarmBaseBuildingTime = 15;
        int FarmBaseCost = 60;
        //civilizations
        List<Civilization> Civilizations = new List<Civilization>();
        Civilization CurrentCiv;
        public Form1()
        {
            InitializeComponent();
            InitializeCivs();
            comboBox1.Items.AddRange(Civilizations.ToArray());
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
            WheelbarrowMod = Wheelbarrow.Checked ? 1 : 0;
            WheelbarrowSpeedMod = Wheelbarrow.Checked ? 1.1 : 1;
        }   
        private void HandCart_CheckedChanged(object sender, EventArgs e)
        {
            HandCartMod = HandCart.Checked ? 1 : 0;
            HandCartSpeedMod = HandCart.Checked ? 1.1 : 1;
        }
        private void HorseCollar_CheckedChanged(object sender, EventArgs e) => HorseCollarMod = 75;

        private void HeavyPlow_CheckedChanged(object sender, EventArgs e) => HeavyPlowMod = 125;

        private void CropRotation_CheckedChanged(object sender, EventArgs e) => CropRotationMod = 175;
        #endregion
        private void Calculate_Click(object sender, EventArgs e)
        {
            //Calculate food income
            int.TryParse(FarmersCount.Text, out int iFarmersCount);
            int.TryParse(ForagersCount.Text, out int iForagersCount);
            int.TryParse(HuntersCountTB.Text, out int iHuntersCount);
            int.TryParse(ShepherdCountTB.Text, out int iShepherdsCount);
            int.TryParse(FishermansCountTB.Text, out int iFishermansCount);
            double CalculatedFarmProductionRate = BaseFarmerGatheringRate + 0.03 * WheelbarrowMod + 0.05 * HandCartMod;
            switch (CurrentCiv.Name)
            {
                case CivilizationNames.Slavs:
                    CalculatedFarmProductionRate = CalculatedFarmProductionRate * 1.1;
                    break;
                case CivilizationNames.Khmer:
                    CalculatedFarmProductionRate = 0.4;
                    break;
                case CivilizationNames.Aztecs:
                    CalculatedFarmProductionRate = 0.35 + 0.05 * WheelbarrowMod;
                    break;
                default:
                    break;
            }
            double VillagerCapacity = BaseVillagerCapacity + WheelbarrowCapacityMod * WheelbarrowMod + HandCartCapacityMod * HandCartMod;
            double VillagerSpeed = BaseVillagerSpeed * WheelbarrowSpeedMod * HandCartSpeedMod;
            int.TryParse(RelicCount.Text, out int iRelicCount);
            double.TryParse(ForagerDistanceTB.Text, out double ForagersDistance);
            double.TryParse(HuntersDistanceTB.Text, out double HuntersDistance);
            double.TryParse(ShepherdsDistanceTB.Text, out double ShepherdsDistance);
            double.TryParse(FishermansDistanceTB.Text, out double FishermansDistance);
            double CalculatedForagersGatheringRate = BaseForagerGatheringRate * CurrentCiv.ForagerGatheringRateMod;
            double CalculatedHuntersGatheringRate = BaseHunterGatheringRate * CurrentCiv.HunterGatheringRateMod;
            double CalculatedShepherdsGatheringRate = BaseShepherdGatheringRate * CurrentCiv.ShepherdGatheringRateMod;
            double CalculatedFishermansGatheringRate = BaseFishermanGatheringRate * CurrentCiv.FishermanGatheringRateMod;
            double FoodIncome =
                iFarmersCount * CalculatedFarmProductionRate * 60 +
                CalculateIncome(iForagersCount, VillagerSpeed, VillagerCapacity, CalculatedForagersGatheringRate, ForagersDistance) +
                CalculateIncome(iHuntersCount, VillagerSpeed, VillagerCapacity, CalculatedHuntersGatheringRate, HuntersDistance) +
                CalculateIncome(iShepherdsCount, VillagerSpeed, VillagerCapacity, CalculatedShepherdsGatheringRate, ShepherdsDistance) +
                CalculateIncome(iFishermansCount, VillagerSpeed, VillagerCapacity, CalculatedFishermansGatheringRate, FishermansDistance) +
                iRelicCount * RelicBaseFoodIncome * CurrentCiv.RelicFoodIncomeMod;
            //Calculate wood income
            double CalculatedWoodRate =
                BaseLumberjackGatheringRate *
                DoubleAxeMod *
                BowSawMod *
                TwoManSawMod *
                CurrentCiv.LumberjackGatheringRateMod;
            int.TryParse(LumberjackCountTB.Text, out int iLumberjackCount);
            double.TryParse(LumberjackDistanceTB.Text, out double WoodDistance);
            double WoodIncome = CalculateIncome(iLumberjackCount, VillagerSpeed, VillagerCapacity, CalculatedWoodRate, WoodDistance);

            //Calculate gold income
            double CalculatedGoldRate =
                BaseGoldMinerGatheringRate *
                GoldMiningMod *
                GoldShaftMiningMod *
                CurrentCiv.GoldMinerGatheringRateMod;
            double RelicIncome = iRelicCount * RelicBaseGoldIncome * CurrentCiv.RelicIncomeMod;
            int.TryParse(MinerCountTB.Text, out int iMinersCount);
            double.TryParse(MinerDistanceTB.Text, out double GoldDistance);
            double GoldIncome = CalculateIncome(iMinersCount, VillagerSpeed, VillagerCapacity, CalculatedGoldRate, GoldDistance) + RelicIncome;

            //Calculate stone income
            double CalculatedStoneRate =
                BaseStoneMinerGatheringRate * 
                StoneMiningMod * 
                StoneShaftMiningMod * 
                CurrentCiv.StoneMinerGatheringRateMod;
            int.TryParse(StoneCollectorsCountTB.Text, out int iStoneCollectorsCount);
            double.TryParse(MinerDistanceTB.Text, out double StoneDistance);
            double StoneIncome = CalculateIncome(iStoneCollectorsCount, VillagerSpeed, VillagerCapacity, CalculatedStoneRate, StoneDistance);

            //Calculate farm effectivity
            double FarmFoodAmount = FarmBaseFoodAmount + HorseCollarMod + HeavyPlowMod + CropRotationMod;
            double FarmLivingTime = (FarmFoodAmount / CalculatedFarmProductionRate) + FarmBaseBuildingTime;
            double FarmWoodCostRate = FarmBaseCost * CurrentCiv.FarmCostMod * iFarmersCount * (60 / FarmLivingTime);
            FarmCostPerMinute.Text = Math.Round(FarmWoodCostRate, 1).ToString();
            double dFarmLifeTime = (FarmBaseFoodAmount + HorseCollarMod + HeavyPlowMod + CropRotationMod) / CalculatedFarmProductionRate;
            //output
            FarmLifeTime.Text = dFarmLifeTime.ToString();
            FoodCount.Text = Math.Round(FoodIncome, 1).ToString();
            WoodCount.Text = Math.Round(WoodIncome, 1).ToString();
            GoldCount.Text = Math.Round(GoldIncome, 1).ToString();
            StoneCount.Text = Math.Round(StoneIncome, 1).ToString();
        }
        private double CalculateIncome(double VillagerCount, double VillagerSpeed, double VillagerCapacity, double GatheringRate, double AverageDistance)
        {
            double WalkingTime = AverageDistance / VillagerSpeed;
            double GatheringTime = VillagerCapacity / GatheringRate;
            double CycleTime = 2 * WalkingTime + GatheringTime;
            double CyclesCountPer10Min = 600 / CycleTime;
            double ResourceGetPer10Min = CyclesCountPer10Min * VillagerCapacity;
            double ResourceGetPerMin = ResourceGetPer10Min / 10;
            return VillagerCount * ResourceGetPerMin;
        }
        private void InitializeCivs()
        {
            Civilization civ = new Civilization(CivilizationNames.Britons);
            civ.ShepherdGatheringRateMod = 1.25;
            Civilizations.Add(civ);
            CurrentCiv = civ;

            civ = new Civilization(CivilizationNames.Byzantines);
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Celts);
            civ.LumberjackGatheringRateMod = 1.15;
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Chinese);
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Franks);
            civ.ForagerGatheringRateMod = 1.15;
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Goths);
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Japanese);
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Mongols);
            civ.HunterGatheringRateMod = 1.4;
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Persians);
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Saracens);
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Teutons);
            civ.FarmCostMod = 0.6;
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Turks);
            civ.GoldMinerGatheringRateMod = 1.2;
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Vikings);
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Aztecs);
            civ.RelicIncomeMod = 1.2;
            civ.VillagerCapacityMod = 3;
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Huns);
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Koreans);
            civ.StoneMinerGatheringRateMod = 1.2;
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Mayans);
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Spanish);
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Incas);
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Indians);
            civ.FishermanGatheringRateMod = 1.1;
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Italians);
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Magyars);
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Slavs);

            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Berbers);
            civ.VillagerSpeedMod = 1.1;
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Ethiopians);
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Malians);
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Portuguese);
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Burmese);
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Khmer);
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Malay);
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Vietnamese);
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Bulgarians);
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Cumans);
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Lithuanians);
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Tatars);
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Burgundians);
            civ.RelicFoodIncomeMod = 1;
            Civilizations.Add(civ);

            civ = new Civilization(CivilizationNames.Sicilians);
            Civilizations.Add(civ);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentCiv = comboBox1.SelectedItem as Civilization;
        }
    }
}
