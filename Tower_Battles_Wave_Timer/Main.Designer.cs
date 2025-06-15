namespace Tower_Battles_Wave_Timer
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            btnStartTimer = new Button();
            lblTimer = new Label();
            cmbPlayerCount = new ComboBox();
            lblTimerInfo = new Label();
            lblMoney = new Label();
            pcbFarm = new PictureBox();
            txtWaveOffset = new TextBox();
            chkUseWaveOffset = new CheckBox();
            lblZombiesInfo = new Label();
            txtZombies = new TextBox();
            btnKilledWave31 = new Button();
            lblLevel1Farms = new Label();
            lblLevel2Farms = new Label();
            lblLevel3Farms = new Label();
            lblLevel4Farms = new Label();
            lblLevel5Farms = new Label();
            nmrcLevel1 = new NumericUpDown();
            nmrcLevel2 = new NumericUpDown();
            nmrcLevel3 = new NumericUpDown();
            nmrcLevel4 = new NumericUpDown();
            nmrcLevel5 = new NumericUpDown();
            lblIncome = new Label();
            lblVersion = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbFarm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrcLevel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrcLevel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrcLevel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrcLevel4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrcLevel5).BeginInit();
            SuspendLayout();
            // 
            // btnStartTimer
            // 
            btnStartTimer.Location = new Point(257, 12);
            btnStartTimer.Name = "btnStartTimer";
            btnStartTimer.Size = new Size(75, 23);
            btnStartTimer.TabIndex = 0;
            btnStartTimer.Text = "START";
            btnStartTimer.UseVisualStyleBackColor = true;
            btnStartTimer.Click += btnStartTimer_Click;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimer.Location = new Point(44, 105);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(158, 50);
            lblTimer.TabIndex = 1;
            lblTimer.Text = "00:00.00";
            lblTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbPlayerCount
            // 
            cmbPlayerCount.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlayerCount.FormattingEnabled = true;
            cmbPlayerCount.Items.AddRange(new object[] { "1 Player", "2 Players", "3 Players", "4 Players" });
            cmbPlayerCount.Location = new Point(84, 12);
            cmbPlayerCount.Name = "cmbPlayerCount";
            cmbPlayerCount.Size = new Size(121, 23);
            cmbPlayerCount.TabIndex = 2;
            cmbPlayerCount.SelectedIndexChanged += cmbPlayerCount_SelectedIndexChanged;
            // 
            // lblTimerInfo
            // 
            lblTimerInfo.AutoSize = true;
            lblTimerInfo.Location = new Point(66, 81);
            lblTimerInfo.Name = "lblTimerInfo";
            lblTimerInfo.Size = new Size(109, 15);
            lblTimerInfo.TabIndex = 3;
            lblTimerInfo.Text = "Time left in wave 1:";
            lblTimerInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMoney
            // 
            lblMoney.AutoSize = true;
            lblMoney.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMoney.ForeColor = Color.Green;
            lblMoney.Location = new Point(96, 172);
            lblMoney.Name = "lblMoney";
            lblMoney.Size = new Size(49, 19);
            lblMoney.TabIndex = 4;
            lblMoney.Text = "~213$";
            lblMoney.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pcbFarm
            // 
            pcbFarm.Image = (Image)resources.GetObject("pcbFarm.Image");
            pcbFarm.Location = new Point(240, 65);
            pcbFarm.Name = "pcbFarm";
            pcbFarm.Size = new Size(133, 137);
            pcbFarm.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbFarm.TabIndex = 5;
            pcbFarm.TabStop = false;
            // 
            // txtWaveOffset
            // 
            txtWaveOffset.Location = new Point(206, 242);
            txtWaveOffset.Name = "txtWaveOffset";
            txtWaveOffset.ReadOnly = true;
            txtWaveOffset.Size = new Size(146, 23);
            txtWaveOffset.TabIndex = 7;
            txtWaveOffset.Text = "0";
            txtWaveOffset.KeyDown += txtWaveOffset_KeyDown;
            txtWaveOffset.Leave += txtWaveOffset_Leave;
            // 
            // chkUseWaveOffset
            // 
            chkUseWaveOffset.AutoSize = true;
            chkUseWaveOffset.Location = new Point(64, 246);
            chkUseWaveOffset.Name = "chkUseWaveOffset";
            chkUseWaveOffset.Size = new Size(108, 19);
            chkUseWaveOffset.TabIndex = 8;
            chkUseWaveOffset.Text = "Use wave offset";
            chkUseWaveOffset.UseVisualStyleBackColor = true;
            chkUseWaveOffset.CheckedChanged += chkUseWaveOffset_CheckedChanged;
            // 
            // lblZombiesInfo
            // 
            lblZombiesInfo.AutoSize = true;
            lblZombiesInfo.Location = new Point(396, 20);
            lblZombiesInfo.Name = "lblZombiesInfo";
            lblZombiesInfo.Size = new Size(165, 15);
            lblZombiesInfo.TabIndex = 9;
            lblZombiesInfo.Text = "Zombies spawning next wave:";
            // 
            // txtZombies
            // 
            txtZombies.Location = new Point(399, 65);
            txtZombies.Multiline = true;
            txtZombies.Name = "txtZombies";
            txtZombies.ReadOnly = true;
            txtZombies.ScrollBars = ScrollBars.Vertical;
            txtZombies.Size = new Size(155, 182);
            txtZombies.TabIndex = 10;
            // 
            // btnKilledWave31
            // 
            btnKilledWave31.Location = new Point(44, 115);
            btnKilledWave31.Name = "btnKilledWave31";
            btnKilledWave31.Size = new Size(158, 40);
            btnKilledWave31.TabIndex = 11;
            btnKilledWave31.Text = "Defeated wave 31";
            btnKilledWave31.UseVisualStyleBackColor = true;
            btnKilledWave31.Visible = false;
            btnKilledWave31.Click += btnKilledWave31_Click;
            // 
            // lblLevel1Farms
            // 
            lblLevel1Farms.AutoSize = true;
            lblLevel1Farms.Location = new Point(33, 299);
            lblLevel1Farms.Name = "lblLevel1Farms";
            lblLevel1Farms.Size = new Size(76, 15);
            lblLevel1Farms.TabIndex = 12;
            lblLevel1Farms.Text = "Level 1 farms";
            // 
            // lblLevel2Farms
            // 
            lblLevel2Farms.AutoSize = true;
            lblLevel2Farms.Location = new Point(141, 299);
            lblLevel2Farms.Name = "lblLevel2Farms";
            lblLevel2Farms.Size = new Size(76, 15);
            lblLevel2Farms.TabIndex = 13;
            lblLevel2Farms.Text = "Level 2 farms";
            // 
            // lblLevel3Farms
            // 
            lblLevel3Farms.AutoSize = true;
            lblLevel3Farms.Location = new Point(249, 299);
            lblLevel3Farms.Name = "lblLevel3Farms";
            lblLevel3Farms.Size = new Size(76, 15);
            lblLevel3Farms.TabIndex = 14;
            lblLevel3Farms.Text = "Level 3 farms";
            // 
            // lblLevel4Farms
            // 
            lblLevel4Farms.AutoSize = true;
            lblLevel4Farms.Location = new Point(359, 299);
            lblLevel4Farms.Name = "lblLevel4Farms";
            lblLevel4Farms.Size = new Size(76, 15);
            lblLevel4Farms.TabIndex = 15;
            lblLevel4Farms.Text = "Level 4 farms";
            // 
            // lblLevel5Farms
            // 
            lblLevel5Farms.AutoSize = true;
            lblLevel5Farms.Location = new Point(470, 299);
            lblLevel5Farms.Name = "lblLevel5Farms";
            lblLevel5Farms.Size = new Size(76, 15);
            lblLevel5Farms.TabIndex = 16;
            lblLevel5Farms.Text = "Level 5 farms";
            // 
            // nmrcLevel1
            // 
            nmrcLevel1.Location = new Point(44, 326);
            nmrcLevel1.Name = "nmrcLevel1";
            nmrcLevel1.Size = new Size(57, 23);
            nmrcLevel1.TabIndex = 17;
            // 
            // nmrcLevel2
            // 
            nmrcLevel2.Location = new Point(148, 326);
            nmrcLevel2.Name = "nmrcLevel2";
            nmrcLevel2.Size = new Size(57, 23);
            nmrcLevel2.TabIndex = 18;
            // 
            // nmrcLevel3
            // 
            nmrcLevel3.Location = new Point(257, 326);
            nmrcLevel3.Name = "nmrcLevel3";
            nmrcLevel3.Size = new Size(57, 23);
            nmrcLevel3.TabIndex = 19;
            // 
            // nmrcLevel4
            // 
            nmrcLevel4.Location = new Point(369, 326);
            nmrcLevel4.Name = "nmrcLevel4";
            nmrcLevel4.Size = new Size(57, 23);
            nmrcLevel4.TabIndex = 20;
            // 
            // nmrcLevel5
            // 
            nmrcLevel5.Location = new Point(478, 326);
            nmrcLevel5.Name = "nmrcLevel5";
            nmrcLevel5.Size = new Size(57, 23);
            nmrcLevel5.TabIndex = 21;
            // 
            // lblIncome
            // 
            lblIncome.AutoSize = true;
            lblIncome.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIncome.ForeColor = Color.Green;
            lblIncome.Location = new Point(33, 369);
            lblIncome.Name = "lblIncome";
            lblIncome.Size = new Size(173, 38);
            lblIncome.TabIndex = 22;
            lblIncome.Text = "Income next wave: 0\r\nIncome + wave bonus: 0";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(503, 402);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(63, 15);
            lblVersion.TabIndex = 23;
            lblVersion.Text = "Version 1.0";
            // 
            // Main
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(580, 426);
            Controls.Add(lblVersion);
            Controls.Add(lblIncome);
            Controls.Add(nmrcLevel5);
            Controls.Add(nmrcLevel4);
            Controls.Add(nmrcLevel3);
            Controls.Add(nmrcLevel2);
            Controls.Add(nmrcLevel1);
            Controls.Add(lblLevel5Farms);
            Controls.Add(lblLevel4Farms);
            Controls.Add(lblLevel3Farms);
            Controls.Add(lblLevel2Farms);
            Controls.Add(lblLevel1Farms);
            Controls.Add(btnKilledWave31);
            Controls.Add(txtZombies);
            Controls.Add(lblZombiesInfo);
            Controls.Add(chkUseWaveOffset);
            Controls.Add(txtWaveOffset);
            Controls.Add(pcbFarm);
            Controls.Add(lblMoney);
            Controls.Add(lblTimerInfo);
            Controls.Add(cmbPlayerCount);
            Controls.Add(lblTimer);
            Controls.Add(btnStartTimer);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Text = "Tower Battles Wave Timer";
            Load += Main_Load;
            Click += Main_Click;
            ((System.ComponentModel.ISupportInitialize)pcbFarm).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrcLevel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrcLevel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrcLevel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrcLevel4).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrcLevel5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStartTimer;
        private Label lblTimer;
        private ComboBox cmbPlayerCount;
        private Label lblTimerInfo;
        private Label lblMoney;
        private PictureBox pcbFarm;
        private TextBox txtWaveOffset;
        private CheckBox chkUseWaveOffset;
        private Label lblZombiesInfo;
        private TextBox txtZombies;
        private Button btnKilledWave31;
        private Label lblLevel1Farms;
        private Label lblLevel2Farms;
        private Label lblLevel3Farms;
        private Label lblLevel4Farms;
        private Label lblLevel5Farms;
        private NumericUpDown nmrcLevel1;
        private NumericUpDown nmrcLevel2;
        private NumericUpDown nmrcLevel3;
        private NumericUpDown nmrcLevel4;
        private NumericUpDown nmrcLevel5;
        private Label lblIncome;
        private Label lblVersion;
    }
}
