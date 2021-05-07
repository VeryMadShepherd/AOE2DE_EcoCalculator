
namespace AOE2DE_EcoCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Calculate = new System.Windows.Forms.Button();
            this.FarmersCount = new System.Windows.Forms.TextBox();
            this.FarmersCountText = new System.Windows.Forms.Label();
            this.ForagersCountText = new System.Windows.Forms.Label();
            this.ForagersCount = new System.Windows.Forms.TextBox();
            this.HuntersCountText = new System.Windows.Forms.Label();
            this.HuntersCountTB = new System.Windows.Forms.TextBox();
            this.ShepherdsCountText = new System.Windows.Forms.Label();
            this.ShepherdCountTB = new System.Windows.Forms.TextBox();
            this.FishermansCountText = new System.Windows.Forms.Label();
            this.FishermansCountTB = new System.Windows.Forms.TextBox();
            this.LumberjackCountText = new System.Windows.Forms.Label();
            this.LumberjackCountTB = new System.Windows.Forms.TextBox();
            this.MinerCountText = new System.Windows.Forms.Label();
            this.MinerCountTB = new System.Windows.Forms.TextBox();
            this.StoneCollectorsCountText = new System.Windows.Forms.Label();
            this.StoneCollectorsCountTB = new System.Windows.Forms.TextBox();
            this.DoubleBitAxe = new System.Windows.Forms.CheckBox();
            this.BowSaw = new System.Windows.Forms.CheckBox();
            this.TwoManSaw = new System.Windows.Forms.CheckBox();
            this.GoldShaftMining = new System.Windows.Forms.CheckBox();
            this.GoldMining = new System.Windows.Forms.CheckBox();
            this.StoneShaftMining = new System.Windows.Forms.CheckBox();
            this.StoneMining = new System.Windows.Forms.CheckBox();
            this.CropRotation = new System.Windows.Forms.CheckBox();
            this.HeavyPlow = new System.Windows.Forms.CheckBox();
            this.HorseCollar = new System.Windows.Forms.CheckBox();
            this.HandCart = new System.Windows.Forms.CheckBox();
            this.Wheelbarrow = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FoodCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WoodCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GoldCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.StoneCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FarmCostPerMinute = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FarmLifeTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RelicCountText = new System.Windows.Forms.Label();
            this.RelicCount = new System.Windows.Forms.TextBox();
            this.ForagerDistanceTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.HuntersDistanceTB = new System.Windows.Forms.TextBox();
            this.ShepherdsDistanceTB = new System.Windows.Forms.TextBox();
            this.FishermansDistanceTB = new System.Windows.Forms.TextBox();
            this.LumberjackDistanceTB = new System.Windows.Forms.TextBox();
            this.MinerDistanceTB = new System.Windows.Forms.TextBox();
            this.StoneCollectorsDistanceTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(364, 550);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "Рассчитать";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // FarmersCount
            // 
            this.FarmersCount.Location = new System.Drawing.Point(13, 60);
            this.FarmersCount.Name = "FarmersCount";
            this.FarmersCount.Size = new System.Drawing.Size(42, 20);
            this.FarmersCount.TabIndex = 1;
            // 
            // FarmersCountText
            // 
            this.FarmersCountText.AutoSize = true;
            this.FarmersCountText.Location = new System.Drawing.Point(62, 63);
            this.FarmersCountText.Name = "FarmersCountText";
            this.FarmersCountText.Size = new System.Drawing.Size(59, 13);
            this.FarmersCountText.TabIndex = 2;
            this.FarmersCountText.Text = "фермеров";
            // 
            // ForagersCountText
            // 
            this.ForagersCountText.AutoSize = true;
            this.ForagersCountText.Location = new System.Drawing.Point(62, 93);
            this.ForagersCountText.Name = "ForagersCountText";
            this.ForagersCountText.Size = new System.Drawing.Size(64, 13);
            this.ForagersCountText.TabIndex = 4;
            this.ForagersCountText.Text = "фуражиров";
            // 
            // ForagersCount
            // 
            this.ForagersCount.Location = new System.Drawing.Point(13, 90);
            this.ForagersCount.Name = "ForagersCount";
            this.ForagersCount.Size = new System.Drawing.Size(42, 20);
            this.ForagersCount.TabIndex = 3;
            // 
            // HuntersCountText
            // 
            this.HuntersCountText.AutoSize = true;
            this.HuntersCountText.Location = new System.Drawing.Point(62, 121);
            this.HuntersCountText.Name = "HuntersCountText";
            this.HuntersCountText.Size = new System.Drawing.Size(59, 13);
            this.HuntersCountText.TabIndex = 6;
            this.HuntersCountText.Text = "охотников";
            // 
            // HuntersCountTB
            // 
            this.HuntersCountTB.Location = new System.Drawing.Point(13, 118);
            this.HuntersCountTB.Name = "HuntersCountTB";
            this.HuntersCountTB.Size = new System.Drawing.Size(42, 20);
            this.HuntersCountTB.TabIndex = 5;
            // 
            // ShepherdsCountText
            // 
            this.ShepherdsCountText.AutoSize = true;
            this.ShepherdsCountText.Location = new System.Drawing.Point(62, 152);
            this.ShepherdsCountText.Name = "ShepherdsCountText";
            this.ShepherdsCountText.Size = new System.Drawing.Size(52, 13);
            this.ShepherdsCountText.TabIndex = 8;
            this.ShepherdsCountText.Text = "пастухов";
            // 
            // ShepherdCountTB
            // 
            this.ShepherdCountTB.Location = new System.Drawing.Point(13, 149);
            this.ShepherdCountTB.Name = "ShepherdCountTB";
            this.ShepherdCountTB.Size = new System.Drawing.Size(42, 20);
            this.ShepherdCountTB.TabIndex = 7;
            // 
            // FishermansCountText
            // 
            this.FishermansCountText.AutoSize = true;
            this.FishermansCountText.Location = new System.Drawing.Point(62, 180);
            this.FishermansCountText.Name = "FishermansCountText";
            this.FishermansCountText.Size = new System.Drawing.Size(51, 13);
            this.FishermansCountText.TabIndex = 10;
            this.FishermansCountText.Text = "рыбаков";
            // 
            // FishermansCountTB
            // 
            this.FishermansCountTB.Location = new System.Drawing.Point(13, 177);
            this.FishermansCountTB.Name = "FishermansCountTB";
            this.FishermansCountTB.Size = new System.Drawing.Size(42, 20);
            this.FishermansCountTB.TabIndex = 9;
            // 
            // LumberjackCountText
            // 
            this.LumberjackCountText.AutoSize = true;
            this.LumberjackCountText.Location = new System.Drawing.Point(62, 209);
            this.LumberjackCountText.Name = "LumberjackCountText";
            this.LumberjackCountText.Size = new System.Drawing.Size(67, 13);
            this.LumberjackCountText.TabIndex = 12;
            this.LumberjackCountText.Text = "дровосеков";
            // 
            // LumberjackCountTB
            // 
            this.LumberjackCountTB.Location = new System.Drawing.Point(13, 206);
            this.LumberjackCountTB.Name = "LumberjackCountTB";
            this.LumberjackCountTB.Size = new System.Drawing.Size(42, 20);
            this.LumberjackCountTB.TabIndex = 11;
            // 
            // MinerCountText
            // 
            this.MinerCountText.AutoSize = true;
            this.MinerCountText.Location = new System.Drawing.Point(62, 237);
            this.MinerCountText.Name = "MinerCountText";
            this.MinerCountText.Size = new System.Drawing.Size(102, 13);
            this.MinerCountText.TabIndex = 14;
            this.MinerCountText.Text = "золотодобытчиков";
            // 
            // MinerCountTB
            // 
            this.MinerCountTB.Location = new System.Drawing.Point(13, 234);
            this.MinerCountTB.Name = "MinerCountTB";
            this.MinerCountTB.Size = new System.Drawing.Size(42, 20);
            this.MinerCountTB.TabIndex = 13;
            // 
            // StoneCollectorsCountText
            // 
            this.StoneCollectorsCountText.AutoSize = true;
            this.StoneCollectorsCountText.Location = new System.Drawing.Point(62, 264);
            this.StoneCollectorsCountText.Name = "StoneCollectorsCountText";
            this.StoneCollectorsCountText.Size = new System.Drawing.Size(54, 13);
            this.StoneCollectorsCountText.TabIndex = 16;
            this.StoneCollectorsCountText.Text = "горняков";
            // 
            // StoneCollectorsCountTB
            // 
            this.StoneCollectorsCountTB.Location = new System.Drawing.Point(13, 261);
            this.StoneCollectorsCountTB.Name = "StoneCollectorsCountTB";
            this.StoneCollectorsCountTB.Size = new System.Drawing.Size(42, 20);
            this.StoneCollectorsCountTB.TabIndex = 15;
            // 
            // DoubleBitAxe
            // 
            this.DoubleBitAxe.AutoSize = true;
            this.DoubleBitAxe.Location = new System.Drawing.Point(276, 208);
            this.DoubleBitAxe.Name = "DoubleBitAxe";
            this.DoubleBitAxe.Size = new System.Drawing.Size(115, 17);
            this.DoubleBitAxe.TabIndex = 17;
            this.DoubleBitAxe.Text = "Двуострый топор";
            this.DoubleBitAxe.UseVisualStyleBackColor = true;
            this.DoubleBitAxe.CheckedChanged += new System.EventHandler(this.DoubleBitAxe_CheckedChanged);
            // 
            // BowSaw
            // 
            this.BowSaw.AutoSize = true;
            this.BowSaw.Location = new System.Drawing.Point(401, 209);
            this.BowSaw.Name = "BowSaw";
            this.BowSaw.Size = new System.Drawing.Size(101, 17);
            this.BowSaw.TabIndex = 18;
            this.BowSaw.Text = "Лучковая пила";
            this.BowSaw.UseVisualStyleBackColor = true;
            this.BowSaw.CheckedChanged += new System.EventHandler(this.BowSaw_CheckedChanged);
            // 
            // TwoManSaw
            // 
            this.TwoManSaw.AutoSize = true;
            this.TwoManSaw.Location = new System.Drawing.Point(517, 209);
            this.TwoManSaw.Name = "TwoManSaw";
            this.TwoManSaw.Size = new System.Drawing.Size(107, 17);
            this.TwoManSaw.TabIndex = 19;
            this.TwoManSaw.Text = "Двуручная пила";
            this.TwoManSaw.UseVisualStyleBackColor = true;
            this.TwoManSaw.CheckedChanged += new System.EventHandler(this.TwoManSaw_CheckedChanged);
            // 
            // GoldShaftMining
            // 
            this.GoldShaftMining.AutoSize = true;
            this.GoldShaftMining.Location = new System.Drawing.Point(401, 237);
            this.GoldShaftMining.Name = "GoldShaftMining";
            this.GoldShaftMining.Size = new System.Drawing.Size(114, 17);
            this.GoldShaftMining.TabIndex = 21;
            this.GoldShaftMining.Text = "Золотые рудники";
            this.GoldShaftMining.UseVisualStyleBackColor = true;
            this.GoldShaftMining.CheckedChanged += new System.EventHandler(this.GoldShaftMining_CheckedChanged);
            // 
            // GoldMining
            // 
            this.GoldMining.AutoSize = true;
            this.GoldMining.Location = new System.Drawing.Point(276, 236);
            this.GoldMining.Name = "GoldMining";
            this.GoldMining.Size = new System.Drawing.Size(99, 17);
            this.GoldMining.TabIndex = 20;
            this.GoldMining.Text = "Золотодобыча";
            this.GoldMining.UseVisualStyleBackColor = true;
            this.GoldMining.CheckedChanged += new System.EventHandler(this.GoldMining_CheckedChanged);
            // 
            // StoneShaftMining
            // 
            this.StoneShaftMining.AutoSize = true;
            this.StoneShaftMining.Location = new System.Drawing.Point(401, 263);
            this.StoneShaftMining.Name = "StoneShaftMining";
            this.StoneShaftMining.Size = new System.Drawing.Size(123, 17);
            this.StoneShaftMining.TabIndex = 23;
            this.StoneShaftMining.Text = "Каменные рудники";
            this.StoneShaftMining.UseVisualStyleBackColor = true;
            this.StoneShaftMining.CheckedChanged += new System.EventHandler(this.StoneShaftMining_CheckedChanged);
            // 
            // StoneMining
            // 
            this.StoneMining.AutoSize = true;
            this.StoneMining.Location = new System.Drawing.Point(276, 262);
            this.StoneMining.Name = "StoneMining";
            this.StoneMining.Size = new System.Drawing.Size(97, 17);
            this.StoneMining.TabIndex = 22;
            this.StoneMining.Text = "Каменоломни";
            this.StoneMining.UseVisualStyleBackColor = true;
            this.StoneMining.CheckedChanged += new System.EventHandler(this.StoneMining_CheckedChanged);
            // 
            // CropRotation
            // 
            this.CropRotation.AutoSize = true;
            this.CropRotation.Location = new System.Drawing.Point(517, 64);
            this.CropRotation.Name = "CropRotation";
            this.CropRotation.Size = new System.Drawing.Size(86, 17);
            this.CropRotation.TabIndex = 26;
            this.CropRotation.Text = "Севооборот";
            this.CropRotation.UseVisualStyleBackColor = true;
            this.CropRotation.CheckedChanged += new System.EventHandler(this.CropRotation_CheckedChanged);
            // 
            // HeavyPlow
            // 
            this.HeavyPlow.AutoSize = true;
            this.HeavyPlow.Location = new System.Drawing.Point(401, 64);
            this.HeavyPlow.Name = "HeavyPlow";
            this.HeavyPlow.Size = new System.Drawing.Size(98, 17);
            this.HeavyPlow.TabIndex = 25;
            this.HeavyPlow.Text = "Тяжёлый плуг";
            this.HeavyPlow.UseVisualStyleBackColor = true;
            this.HeavyPlow.CheckedChanged += new System.EventHandler(this.HeavyPlow_CheckedChanged);
            // 
            // HorseCollar
            // 
            this.HorseCollar.AutoSize = true;
            this.HorseCollar.Location = new System.Drawing.Point(276, 63);
            this.HorseCollar.Name = "HorseCollar";
            this.HorseCollar.Size = new System.Drawing.Size(57, 17);
            this.HorseCollar.TabIndex = 24;
            this.HorseCollar.Text = "Хомут";
            this.HorseCollar.UseVisualStyleBackColor = true;
            this.HorseCollar.CheckedChanged += new System.EventHandler(this.HorseCollar_CheckedChanged);
            // 
            // HandCart
            // 
            this.HandCart.AutoSize = true;
            this.HandCart.Location = new System.Drawing.Point(401, 295);
            this.HandCart.Name = "HandCart";
            this.HandCart.Size = new System.Drawing.Size(106, 17);
            this.HandCart.TabIndex = 28;
            this.HandCart.Text = "Ручная повозка";
            this.HandCart.UseVisualStyleBackColor = true;
            this.HandCart.CheckedChanged += new System.EventHandler(this.HandCart_CheckedChanged);
            // 
            // Wheelbarrow
            // 
            this.Wheelbarrow.AutoSize = true;
            this.Wheelbarrow.Location = new System.Drawing.Point(276, 294);
            this.Wheelbarrow.Name = "Wheelbarrow";
            this.Wheelbarrow.Size = new System.Drawing.Size(107, 17);
            this.Wheelbarrow.TabIndex = 27;
            this.Wheelbarrow.Text = "Ручная тележка";
            this.Wheelbarrow.UseVisualStyleBackColor = true;
            this.Wheelbarrow.CheckedChanged += new System.EventHandler(this.Wheelbarrow_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Итого:";
            // 
            // FoodCount
            // 
            this.FoodCount.AutoSize = true;
            this.FoodCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FoodCount.Location = new System.Drawing.Point(13, 387);
            this.FoodCount.Name = "FoodCount";
            this.FoodCount.Size = new System.Drawing.Size(60, 26);
            this.FoodCount.TabIndex = 30;
            this.FoodCount.Text = "????";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(78, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "пищи/мин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(78, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "дерева/мин";
            // 
            // WoodCount
            // 
            this.WoodCount.AutoSize = true;
            this.WoodCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WoodCount.Location = new System.Drawing.Point(13, 416);
            this.WoodCount.Name = "WoodCount";
            this.WoodCount.Size = new System.Drawing.Size(60, 26);
            this.WoodCount.TabIndex = 32;
            this.WoodCount.Text = "????";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(78, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "золота/мин";
            // 
            // GoldCount
            // 
            this.GoldCount.AutoSize = true;
            this.GoldCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoldCount.Location = new System.Drawing.Point(13, 446);
            this.GoldCount.Name = "GoldCount";
            this.GoldCount.Size = new System.Drawing.Size(60, 26);
            this.GoldCount.TabIndex = 34;
            this.GoldCount.Text = "????";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(78, 479);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "камня/мин";
            // 
            // StoneCount
            // 
            this.StoneCount.AutoSize = true;
            this.StoneCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StoneCount.Location = new System.Drawing.Point(13, 475);
            this.StoneCount.Name = "StoneCount";
            this.StoneCount.Size = new System.Drawing.Size(60, 26);
            this.StoneCount.TabIndex = 36;
            this.StoneCount.Text = "????";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(78, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "дерева/мин на содержание ферм";
            // 
            // FarmCostPerMinute
            // 
            this.FarmCostPerMinute.AutoSize = true;
            this.FarmCostPerMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FarmCostPerMinute.Location = new System.Drawing.Point(13, 504);
            this.FarmCostPerMinute.Name = "FarmCostPerMinute";
            this.FarmCostPerMinute.Size = new System.Drawing.Size(60, 26);
            this.FarmCostPerMinute.TabIndex = 38;
            this.FarmCostPerMinute.Text = "????";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(424, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "сек. живёт ферма";
            // 
            // FarmLifeTime
            // 
            this.FarmLifeTime.AutoSize = true;
            this.FarmLifeTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FarmLifeTime.Location = new System.Drawing.Point(359, 385);
            this.FarmLifeTime.Name = "FarmLifeTime";
            this.FarmLifeTime.Size = new System.Drawing.Size(60, 26);
            this.FarmLifeTime.TabIndex = 40;
            this.FarmLifeTime.Text = "????";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(653, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Цивилизация";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(598, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 21);
            this.comboBox1.TabIndex = 43;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // RelicCountText
            // 
            this.RelicCountText.AutoSize = true;
            this.RelicCountText.Location = new System.Drawing.Point(62, 296);
            this.RelicCountText.Name = "RelicCountText";
            this.RelicCountText.Size = new System.Drawing.Size(55, 13);
            this.RelicCountText.TabIndex = 45;
            this.RelicCountText.Text = "реликвий";
            // 
            // RelicCount
            // 
            this.RelicCount.Location = new System.Drawing.Point(13, 293);
            this.RelicCount.Name = "RelicCount";
            this.RelicCount.Size = new System.Drawing.Size(42, 20);
            this.RelicCount.TabIndex = 44;
            // 
            // ForagerDistanceTB
            // 
            this.ForagerDistanceTB.Location = new System.Drawing.Point(184, 90);
            this.ForagerDistanceTB.Name = "ForagerDistanceTB";
            this.ForagerDistanceTB.Size = new System.Drawing.Size(42, 20);
            this.ForagerDistanceTB.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(144, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 47;
            this.label9.Text = "Расстояние";
            // 
            // HuntersDistanceTB
            // 
            this.HuntersDistanceTB.Location = new System.Drawing.Point(184, 121);
            this.HuntersDistanceTB.Name = "HuntersDistanceTB";
            this.HuntersDistanceTB.Size = new System.Drawing.Size(42, 20);
            this.HuntersDistanceTB.TabIndex = 48;
            // 
            // ShepherdsDistanceTB
            // 
            this.ShepherdsDistanceTB.Location = new System.Drawing.Point(184, 149);
            this.ShepherdsDistanceTB.Name = "ShepherdsDistanceTB";
            this.ShepherdsDistanceTB.Size = new System.Drawing.Size(42, 20);
            this.ShepherdsDistanceTB.TabIndex = 49;
            // 
            // FishermansDistanceTB
            // 
            this.FishermansDistanceTB.Location = new System.Drawing.Point(184, 177);
            this.FishermansDistanceTB.Name = "FishermansDistanceTB";
            this.FishermansDistanceTB.Size = new System.Drawing.Size(42, 20);
            this.FishermansDistanceTB.TabIndex = 50;
            // 
            // LumberjackDistanceTB
            // 
            this.LumberjackDistanceTB.Location = new System.Drawing.Point(184, 206);
            this.LumberjackDistanceTB.Name = "LumberjackDistanceTB";
            this.LumberjackDistanceTB.Size = new System.Drawing.Size(42, 20);
            this.LumberjackDistanceTB.TabIndex = 51;
            // 
            // MinerDistanceTB
            // 
            this.MinerDistanceTB.Location = new System.Drawing.Point(184, 234);
            this.MinerDistanceTB.Name = "MinerDistanceTB";
            this.MinerDistanceTB.Size = new System.Drawing.Size(42, 20);
            this.MinerDistanceTB.TabIndex = 52;
            // 
            // StoneCollectorsDistanceTB
            // 
            this.StoneCollectorsDistanceTB.Location = new System.Drawing.Point(184, 264);
            this.StoneCollectorsDistanceTB.Name = "StoneCollectorsDistanceTB";
            this.StoneCollectorsDistanceTB.Size = new System.Drawing.Size(42, 20);
            this.StoneCollectorsDistanceTB.TabIndex = 53;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 604);
            this.Controls.Add(this.StoneCollectorsDistanceTB);
            this.Controls.Add(this.MinerDistanceTB);
            this.Controls.Add(this.LumberjackDistanceTB);
            this.Controls.Add(this.FishermansDistanceTB);
            this.Controls.Add(this.ShepherdsDistanceTB);
            this.Controls.Add(this.HuntersDistanceTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ForagerDistanceTB);
            this.Controls.Add(this.RelicCountText);
            this.Controls.Add(this.RelicCount);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FarmLifeTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FarmCostPerMinute);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.StoneCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GoldCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WoodCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FoodCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HandCart);
            this.Controls.Add(this.Wheelbarrow);
            this.Controls.Add(this.CropRotation);
            this.Controls.Add(this.HeavyPlow);
            this.Controls.Add(this.HorseCollar);
            this.Controls.Add(this.StoneShaftMining);
            this.Controls.Add(this.StoneMining);
            this.Controls.Add(this.GoldShaftMining);
            this.Controls.Add(this.GoldMining);
            this.Controls.Add(this.TwoManSaw);
            this.Controls.Add(this.BowSaw);
            this.Controls.Add(this.DoubleBitAxe);
            this.Controls.Add(this.StoneCollectorsCountText);
            this.Controls.Add(this.StoneCollectorsCountTB);
            this.Controls.Add(this.MinerCountText);
            this.Controls.Add(this.MinerCountTB);
            this.Controls.Add(this.LumberjackCountText);
            this.Controls.Add(this.LumberjackCountTB);
            this.Controls.Add(this.FishermansCountText);
            this.Controls.Add(this.FishermansCountTB);
            this.Controls.Add(this.ShepherdsCountText);
            this.Controls.Add(this.ShepherdCountTB);
            this.Controls.Add(this.HuntersCountText);
            this.Controls.Add(this.HuntersCountTB);
            this.Controls.Add(this.ForagersCountText);
            this.Controls.Add(this.ForagersCount);
            this.Controls.Add(this.FarmersCountText);
            this.Controls.Add(this.FarmersCount);
            this.Controls.Add(this.Calculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox FarmersCount;
        private System.Windows.Forms.Label FarmersCountText;
        private System.Windows.Forms.Label ForagersCountText;
        private System.Windows.Forms.TextBox ForagersCount;
        private System.Windows.Forms.Label HuntersCountText;
        private System.Windows.Forms.TextBox HuntersCountTB;
        private System.Windows.Forms.Label ShepherdsCountText;
        private System.Windows.Forms.TextBox ShepherdCountTB;
        private System.Windows.Forms.Label FishermansCountText;
        private System.Windows.Forms.TextBox FishermansCountTB;
        private System.Windows.Forms.Label LumberjackCountText;
        private System.Windows.Forms.TextBox LumberjackCountTB;
        private System.Windows.Forms.Label MinerCountText;
        private System.Windows.Forms.TextBox MinerCountTB;
        private System.Windows.Forms.Label StoneCollectorsCountText;
        private System.Windows.Forms.TextBox StoneCollectorsCountTB;
        private System.Windows.Forms.CheckBox DoubleBitAxe;
        private System.Windows.Forms.CheckBox BowSaw;
        private System.Windows.Forms.CheckBox TwoManSaw;
        private System.Windows.Forms.CheckBox GoldShaftMining;
        private System.Windows.Forms.CheckBox GoldMining;
        private System.Windows.Forms.CheckBox StoneShaftMining;
        private System.Windows.Forms.CheckBox StoneMining;
        private System.Windows.Forms.CheckBox CropRotation;
        private System.Windows.Forms.CheckBox HeavyPlow;
        private System.Windows.Forms.CheckBox HorseCollar;
        private System.Windows.Forms.CheckBox HandCart;
        private System.Windows.Forms.CheckBox Wheelbarrow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FoodCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label WoodCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label GoldCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label StoneCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FarmCostPerMinute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label FarmLifeTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label RelicCountText;
        private System.Windows.Forms.TextBox RelicCount;
        private System.Windows.Forms.TextBox ForagerDistanceTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox HuntersDistanceTB;
        private System.Windows.Forms.TextBox ShepherdsDistanceTB;
        private System.Windows.Forms.TextBox FishermansDistanceTB;
        private System.Windows.Forms.TextBox LumberjackDistanceTB;
        private System.Windows.Forms.TextBox MinerDistanceTB;
        private System.Windows.Forms.TextBox StoneCollectorsDistanceTB;
    }
}

