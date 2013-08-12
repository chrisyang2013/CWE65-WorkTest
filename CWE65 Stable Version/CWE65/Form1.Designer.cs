namespace CWE65
{
    partial class cweForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cweForm));
            this.typeCalc2 = new System.Windows.Forms.TabPage();
            this.numPerfsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calculatePerfsButton = new System.Windows.Forms.Button();
            this.addPerfButton = new System.Windows.Forms.Button();
            this.helpmessageLabel = new System.Windows.Forms.Label();
            this.numPerfsSizeLabel = new System.Windows.Forms.Label();
            this.perfSizePromptLabel = new System.Windows.Forms.Label();
            this.perfDropBoxDiam = new System.Windows.Forms.ComboBox();
            this.perfSizeTextBox = new System.Windows.Forms.TextBox();
            this.dataTab1 = new System.Windows.Forms.TabPage();
            this.anularSpaceTextBox = new System.Windows.Forms.TextBox();
            this.AnularSpaceLabel = new System.Windows.Forms.Label();
            this.calculate70Function = new System.Windows.Forms.Button();
            this.qualityDropBox = new System.Windows.Forms.ComboBox();
            this.pipeSizeTextLabel = new System.Windows.Forms.Label();
            this.velocityTextBox = new System.Windows.Forms.TextBox();
            this.pressureTextBox = new System.Windows.Forms.TextBox();
            this.pipeSizeDropBox = new System.Windows.Forms.ComboBox();
            this.qualitiesTextLabel = new System.Windows.Forms.Label();
            this.velocityTextLabel = new System.Windows.Forms.Label();
            this.pressureTextLabel = new System.Windows.Forms.Label();
            this.formTabControl = new System.Windows.Forms.TabControl();
            this.outputTab = new System.Windows.Forms.TabPage();
            this.defaultChosenRate = new System.Windows.Forms.Label();
            this.thirdDefaultQualityTextBox = new System.Windows.Forms.TextBox();
            this.qualityLabel3 = new System.Windows.Forms.Label();
            this.theoreticalQualityBox = new System.Windows.Forms.TextBox();
            this.rateLabel = new System.Windows.Forms.Label();
            this.bdLabel4 = new System.Windows.Forms.Label();
            this.totalTheoreticalRateLabel = new System.Windows.Forms.Label();
            this.totalTheoreticalTextBox = new System.Windows.Forms.TextBox();
            this.secondDefaultQualityTextBox = new System.Windows.Forms.TextBox();
            this.firstDefaultQualityTextBox = new System.Windows.Forms.TextBox();
            this.default70Rate = new System.Windows.Forms.Label();
            this.default65Rate = new System.Windows.Forms.Label();
            this.pdiLabel = new System.Windows.Forms.Label();
            this.typeCalc2.SuspendLayout();
            this.dataTab1.SuspendLayout();
            this.formTabControl.SuspendLayout();
            this.outputTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeCalc2
            // 
            this.typeCalc2.Controls.Add(this.numPerfsTextBox);
            this.typeCalc2.Controls.Add(this.label1);
            this.typeCalc2.Controls.Add(this.calculatePerfsButton);
            this.typeCalc2.Controls.Add(this.addPerfButton);
            this.typeCalc2.Controls.Add(this.helpmessageLabel);
            this.typeCalc2.Controls.Add(this.numPerfsSizeLabel);
            this.typeCalc2.Controls.Add(this.perfSizePromptLabel);
            this.typeCalc2.Controls.Add(this.perfDropBoxDiam);
            this.typeCalc2.Controls.Add(this.perfSizeTextBox);
            this.typeCalc2.Location = new System.Drawing.Point(4, 22);
            this.typeCalc2.Name = "typeCalc2";
            this.typeCalc2.Padding = new System.Windows.Forms.Padding(3);
            this.typeCalc2.Size = new System.Drawing.Size(530, 468);
            this.typeCalc2.TabIndex = 1;
            this.typeCalc2.Text = "setPerfs";
            this.typeCalc2.UseVisualStyleBackColor = true;
            // 
            // numPerfsTextBox
            // 
            this.numPerfsTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.numPerfsTextBox.ForeColor = System.Drawing.Color.Red;
            this.numPerfsTextBox.Location = new System.Drawing.Point(112, 232);
            this.numPerfsTextBox.Name = "numPerfsTextBox";
            this.numPerfsTextBox.ReadOnly = true;
            this.numPerfsTextBox.Size = new System.Drawing.Size(46, 20);
            this.numPerfsTextBox.TabIndex = 152;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(14, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 151;
            this.label1.Text = "You have Entered:                   sets of Perfs\r\n";
            // 
            // calculatePerfsButton
            // 
            this.calculatePerfsButton.ForeColor = System.Drawing.Color.Blue;
            this.calculatePerfsButton.Location = new System.Drawing.Point(220, 102);
            this.calculatePerfsButton.Name = "calculatePerfsButton";
            this.calculatePerfsButton.Size = new System.Drawing.Size(84, 53);
            this.calculatePerfsButton.TabIndex = 150;
            this.calculatePerfsButton.Text = "Calculate perf Theoreticals";
            this.calculatePerfsButton.UseVisualStyleBackColor = true;
            this.calculatePerfsButton.Click += new System.EventHandler(this.calculatePerfTheoreticals);
            // 
            // addPerfButton
            // 
            this.addPerfButton.ForeColor = System.Drawing.Color.Blue;
            this.addPerfButton.Location = new System.Drawing.Point(17, 102);
            this.addPerfButton.Name = "addPerfButton";
            this.addPerfButton.Size = new System.Drawing.Size(91, 53);
            this.addPerfButton.TabIndex = 149;
            this.addPerfButton.Text = "press to Add entered perf";
            this.addPerfButton.UseVisualStyleBackColor = true;
            this.addPerfButton.Click += new System.EventHandler(this.addPerfButton_Click);
            // 
            // helpmessageLabel
            // 
            this.helpmessageLabel.AutoSize = true;
            this.helpmessageLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.helpmessageLabel.Location = new System.Drawing.Point(14, 77);
            this.helpmessageLabel.Name = "helpmessageLabel";
            this.helpmessageLabel.Size = new System.Drawing.Size(314, 13);
            this.helpmessageLabel.TabIndex = 137;
            this.helpmessageLabel.Text = "If not one of the 3 just type diameter into the Perf Size Blank Spot";
            // 
            // numPerfsSizeLabel
            // 
            this.numPerfsSizeLabel.AutoSize = true;
            this.numPerfsSizeLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.numPerfsSizeLabel.Location = new System.Drawing.Point(131, 13);
            this.numPerfsSizeLabel.Name = "numPerfsSizeLabel";
            this.numPerfsSizeLabel.Size = new System.Drawing.Size(138, 13);
            this.numPerfsSizeLabel.TabIndex = 136;
            this.numPerfsSizeLabel.Text = "Enter Number at That Size :";
            // 
            // perfSizePromptLabel
            // 
            this.perfSizePromptLabel.AutoSize = true;
            this.perfSizePromptLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.perfSizePromptLabel.Location = new System.Drawing.Point(14, 13);
            this.perfSizePromptLabel.Name = "perfSizePromptLabel";
            this.perfSizePromptLabel.Size = new System.Drawing.Size(80, 13);
            this.perfSizePromptLabel.TabIndex = 135;
            this.perfSizePromptLabel.Text = "Enter Perf Size:";
            // 
            // perfDropBoxDiam
            // 
            this.perfDropBoxDiam.ForeColor = System.Drawing.Color.Red;
            this.perfDropBoxDiam.FormattingEnabled = true;
            this.perfDropBoxDiam.Items.AddRange(new object[] {
            "",
            ".250",
            ".220",
            ".188"});
            this.perfDropBoxDiam.Location = new System.Drawing.Point(17, 41);
            this.perfDropBoxDiam.Name = "perfDropBoxDiam";
            this.perfDropBoxDiam.Size = new System.Drawing.Size(91, 21);
            this.perfDropBoxDiam.TabIndex = 134;
            // 
            // perfSizeTextBox
            // 
            this.perfSizeTextBox.ForeColor = System.Drawing.Color.Red;
            this.perfSizeTextBox.Location = new System.Drawing.Point(134, 41);
            this.perfSizeTextBox.Name = "perfSizeTextBox";
            this.perfSizeTextBox.Size = new System.Drawing.Size(73, 20);
            this.perfSizeTextBox.TabIndex = 133;
            // 
            // dataTab1
            // 
            this.dataTab1.Controls.Add(this.anularSpaceTextBox);
            this.dataTab1.Controls.Add(this.AnularSpaceLabel);
            this.dataTab1.Controls.Add(this.calculate70Function);
            this.dataTab1.Controls.Add(this.qualityDropBox);
            this.dataTab1.Controls.Add(this.pipeSizeTextLabel);
            this.dataTab1.Controls.Add(this.velocityTextBox);
            this.dataTab1.Controls.Add(this.pressureTextBox);
            this.dataTab1.Controls.Add(this.pipeSizeDropBox);
            this.dataTab1.Controls.Add(this.qualitiesTextLabel);
            this.dataTab1.Controls.Add(this.velocityTextLabel);
            this.dataTab1.Controls.Add(this.pressureTextLabel);
            this.dataTab1.Location = new System.Drawing.Point(4, 22);
            this.dataTab1.Name = "dataTab1";
            this.dataTab1.Padding = new System.Windows.Forms.Padding(3);
            this.dataTab1.Size = new System.Drawing.Size(530, 468);
            this.dataTab1.TabIndex = 0;
            this.dataTab1.Text = "DataPage";
            this.dataTab1.UseVisualStyleBackColor = true;
            this.dataTab1.Click += new System.EventHandler(this.dataTab1_Click);
            // 
            // anularSpaceTextBox
            // 
            this.anularSpaceTextBox.ForeColor = System.Drawing.Color.Red;
            this.anularSpaceTextBox.Location = new System.Drawing.Point(314, 17);
            this.anularSpaceTextBox.Name = "anularSpaceTextBox";
            this.anularSpaceTextBox.Size = new System.Drawing.Size(67, 20);
            this.anularSpaceTextBox.TabIndex = 150;
            this.anularSpaceTextBox.TextChanged += new System.EventHandler(this.anularSpace_TextChanged);
            // 
            // AnularSpaceLabel
            // 
            this.AnularSpaceLabel.AutoSize = true;
            this.AnularSpaceLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.AnularSpaceLabel.Location = new System.Drawing.Point(207, 20);
            this.AnularSpaceLabel.Name = "AnularSpaceLabel";
            this.AnularSpaceLabel.Size = new System.Drawing.Size(101, 13);
            this.AnularSpaceLabel.TabIndex = 149;
            this.AnularSpaceLabel.Text = "Anular Space Value";
            // 
            // calculate70Function
            // 
            this.calculate70Function.ForeColor = System.Drawing.Color.Blue;
            this.calculate70Function.Location = new System.Drawing.Point(210, 70);
            this.calculate70Function.Name = "calculate70Function";
            this.calculate70Function.Size = new System.Drawing.Size(100, 47);
            this.calculate70Function.TabIndex = 148;
            this.calculate70Function.Text = "Press after variables initialized\r\n";
            this.calculate70Function.UseVisualStyleBackColor = true;
            this.calculate70Function.Click += new System.EventHandler(this.calculate70FunctionClick);
            // 
            // qualityDropBox
            // 
            this.qualityDropBox.ForeColor = System.Drawing.Color.Red;
            this.qualityDropBox.FormattingEnabled = true;
            this.qualityDropBox.Items.AddRange(new object[] {
            "",
            "100",
            "70",
            "65"});
            this.qualityDropBox.Location = new System.Drawing.Point(96, 96);
            this.qualityDropBox.Name = "qualityDropBox";
            this.qualityDropBox.Size = new System.Drawing.Size(91, 21);
            this.qualityDropBox.TabIndex = 146;
            this.qualityDropBox.SelectedIndexChanged += new System.EventHandler(this.qualityTextChanged);
            // 
            // pipeSizeTextLabel
            // 
            this.pipeSizeTextLabel.AutoSize = true;
            this.pipeSizeTextLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pipeSizeTextLabel.Location = new System.Drawing.Point(8, 20);
            this.pipeSizeTextLabel.Name = "pipeSizeTextLabel";
            this.pipeSizeTextLabel.Size = new System.Drawing.Size(82, 13);
            this.pipeSizeTextLabel.TabIndex = 4;
            this.pipeSizeTextLabel.Text = "Enter Pipe Size:";
            // 
            // velocityTextBox
            // 
            this.velocityTextBox.ForeColor = System.Drawing.Color.Red;
            this.velocityTextBox.Location = new System.Drawing.Point(96, 44);
            this.velocityTextBox.Name = "velocityTextBox";
            this.velocityTextBox.Size = new System.Drawing.Size(38, 20);
            this.velocityTextBox.TabIndex = 132;
            this.velocityTextBox.TextChanged += new System.EventHandler(this.velocityTextChanged);
            // 
            // pressureTextBox
            // 
            this.pressureTextBox.ForeColor = System.Drawing.Color.Red;
            this.pressureTextBox.Location = new System.Drawing.Point(96, 70);
            this.pressureTextBox.Name = "pressureTextBox";
            this.pressureTextBox.Size = new System.Drawing.Size(38, 20);
            this.pressureTextBox.TabIndex = 136;
            this.pressureTextBox.TextChanged += new System.EventHandler(this.pressureTextChanged);
            // 
            // pipeSizeDropBox
            // 
            this.pipeSizeDropBox.ForeColor = System.Drawing.Color.Red;
            this.pipeSizeDropBox.FormattingEnabled = true;
            this.pipeSizeDropBox.Items.AddRange(new object[] {
            "",
            "2-3/8\"",
            "2-7/8\"",
            "3-1/2\"",
            "4-1/2\"",
            "5-1/2\"",
            "6-5/8\"",
            "7\"",
            "8-5/8\"",
            "9-5/8\""});
            this.pipeSizeDropBox.Location = new System.Drawing.Point(96, 17);
            this.pipeSizeDropBox.Name = "pipeSizeDropBox";
            this.pipeSizeDropBox.Size = new System.Drawing.Size(91, 21);
            this.pipeSizeDropBox.TabIndex = 131;
            this.pipeSizeDropBox.SelectedIndexChanged += new System.EventHandler(this.pipeSizeChanged);
            // 
            // qualitiesTextLabel
            // 
            this.qualitiesTextLabel.AutoSize = true;
            this.qualitiesTextLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.qualitiesTextLabel.Location = new System.Drawing.Point(8, 104);
            this.qualitiesTextLabel.Name = "qualitiesTextLabel";
            this.qualitiesTextLabel.Size = new System.Drawing.Size(50, 13);
            this.qualitiesTextLabel.TabIndex = 142;
            this.qualitiesTextLabel.Text = "Qualities:";
            // 
            // velocityTextLabel
            // 
            this.velocityTextLabel.AutoSize = true;
            this.velocityTextLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.velocityTextLabel.Location = new System.Drawing.Point(8, 51);
            this.velocityTextLabel.Name = "velocityTextLabel";
            this.velocityTextLabel.Size = new System.Drawing.Size(47, 13);
            this.velocityTextLabel.TabIndex = 138;
            this.velocityTextLabel.Text = "Velocity:";
            // 
            // pressureTextLabel
            // 
            this.pressureTextLabel.AutoSize = true;
            this.pressureTextLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pressureTextLabel.Location = new System.Drawing.Point(8, 78);
            this.pressureTextLabel.Name = "pressureTextLabel";
            this.pressureTextLabel.Size = new System.Drawing.Size(51, 13);
            this.pressureTextLabel.TabIndex = 137;
            this.pressureTextLabel.Text = "Pressure:";
            // 
            // formTabControl
            // 
            this.formTabControl.Controls.Add(this.dataTab1);
            this.formTabControl.Controls.Add(this.typeCalc2);
            this.formTabControl.Controls.Add(this.outputTab);
            this.formTabControl.Location = new System.Drawing.Point(0, 0);
            this.formTabControl.Name = "formTabControl";
            this.formTabControl.SelectedIndex = 0;
            this.formTabControl.Size = new System.Drawing.Size(538, 494);
            this.formTabControl.TabIndex = 147;
            // 
            // outputTab
            // 
            this.outputTab.Controls.Add(this.defaultChosenRate);
            this.outputTab.Controls.Add(this.thirdDefaultQualityTextBox);
            this.outputTab.Controls.Add(this.qualityLabel3);
            this.outputTab.Controls.Add(this.theoreticalQualityBox);
            this.outputTab.Controls.Add(this.rateLabel);
            this.outputTab.Controls.Add(this.bdLabel4);
            this.outputTab.Controls.Add(this.totalTheoreticalRateLabel);
            this.outputTab.Controls.Add(this.totalTheoreticalTextBox);
            this.outputTab.Controls.Add(this.secondDefaultQualityTextBox);
            this.outputTab.Controls.Add(this.firstDefaultQualityTextBox);
            this.outputTab.Controls.Add(this.default70Rate);
            this.outputTab.Controls.Add(this.default65Rate);
            this.outputTab.Controls.Add(this.pdiLabel);
            this.outputTab.Location = new System.Drawing.Point(4, 22);
            this.outputTab.Name = "outputTab";
            this.outputTab.Padding = new System.Windows.Forms.Padding(3);
            this.outputTab.Size = new System.Drawing.Size(530, 468);
            this.outputTab.TabIndex = 2;
            this.outputTab.Text = "Output";
            this.outputTab.UseVisualStyleBackColor = true;
            this.outputTab.Click += new System.EventHandler(this.outputTab_Click);
            // 
            // defaultChosenRate
            // 
            this.defaultChosenRate.AutoSize = true;
            this.defaultChosenRate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.defaultChosenRate.Location = new System.Drawing.Point(131, 100);
            this.defaultChosenRate.Name = "defaultChosenRate";
            this.defaultChosenRate.Size = new System.Drawing.Size(87, 13);
            this.defaultChosenRate.TabIndex = 28;
            this.defaultChosenRate.Text = "B/D @ % Quality";
            // 
            // thirdDefaultQualityTextBox
            // 
            this.thirdDefaultQualityTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.thirdDefaultQualityTextBox.ForeColor = System.Drawing.Color.Red;
            this.thirdDefaultQualityTextBox.Location = new System.Drawing.Point(25, 97);
            this.thirdDefaultQualityTextBox.Name = "thirdDefaultQualityTextBox";
            this.thirdDefaultQualityTextBox.ReadOnly = true;
            this.thirdDefaultQualityTextBox.Size = new System.Drawing.Size(100, 20);
            this.thirdDefaultQualityTextBox.TabIndex = 27;
            // 
            // qualityLabel3
            // 
            this.qualityLabel3.AutoSize = true;
            this.qualityLabel3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.qualityLabel3.Location = new System.Drawing.Point(275, 156);
            this.qualityLabel3.Name = "qualityLabel3";
            this.qualityLabel3.Size = new System.Drawing.Size(50, 13);
            this.qualityLabel3.TabIndex = 26;
            this.qualityLabel3.Text = "% Quality";
            // 
            // theoreticalQualityBox
            // 
            this.theoreticalQualityBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.theoreticalQualityBox.ForeColor = System.Drawing.Color.Red;
            this.theoreticalQualityBox.Location = new System.Drawing.Point(224, 153);
            this.theoreticalQualityBox.Name = "theoreticalQualityBox";
            this.theoreticalQualityBox.ReadOnly = true;
            this.theoreticalQualityBox.Size = new System.Drawing.Size(45, 20);
            this.theoreticalQualityBox.TabIndex = 25;
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rateLabel.Location = new System.Drawing.Point(20, 156);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(42, 13);
            this.rateLabel.TabIndex = 24;
            this.rateLabel.Text = "Rate = ";
            // 
            // bdLabel4
            // 
            this.bdLabel4.AutoSize = true;
            this.bdLabel4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bdLabel4.Location = new System.Drawing.Point(174, 156);
            this.bdLabel4.Name = "bdLabel4";
            this.bdLabel4.Size = new System.Drawing.Size(44, 13);
            this.bdLabel4.TabIndex = 23;
            this.bdLabel4.Text = "B/D @ ";
            // 
            // totalTheoreticalRateLabel
            // 
            this.totalTheoreticalRateLabel.AutoSize = true;
            this.totalTheoreticalRateLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.totalTheoreticalRateLabel.Location = new System.Drawing.Point(22, 124);
            this.totalTheoreticalRateLabel.Name = "totalTheoreticalRateLabel";
            this.totalTheoreticalRateLabel.Size = new System.Drawing.Size(113, 13);
            this.totalTheoreticalRateLabel.TabIndex = 22;
            this.totalTheoreticalRateLabel.Text = "Total Theoretical Rate";
            // 
            // totalTheoreticalTextBox
            // 
            this.totalTheoreticalTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.totalTheoreticalTextBox.ForeColor = System.Drawing.Color.Red;
            this.totalTheoreticalTextBox.Location = new System.Drawing.Point(68, 153);
            this.totalTheoreticalTextBox.Name = "totalTheoreticalTextBox";
            this.totalTheoreticalTextBox.ReadOnly = true;
            this.totalTheoreticalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTheoreticalTextBox.TabIndex = 4;
            // 
            // secondDefaultQualityTextBox
            // 
            this.secondDefaultQualityTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.secondDefaultQualityTextBox.ForeColor = System.Drawing.Color.Red;
            this.secondDefaultQualityTextBox.Location = new System.Drawing.Point(25, 71);
            this.secondDefaultQualityTextBox.Name = "secondDefaultQualityTextBox";
            this.secondDefaultQualityTextBox.ReadOnly = true;
            this.secondDefaultQualityTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondDefaultQualityTextBox.TabIndex = 1;
            // 
            // firstDefaultQualityTextBox
            // 
            this.firstDefaultQualityTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.firstDefaultQualityTextBox.ForeColor = System.Drawing.Color.Red;
            this.firstDefaultQualityTextBox.Location = new System.Drawing.Point(25, 45);
            this.firstDefaultQualityTextBox.Name = "firstDefaultQualityTextBox";
            this.firstDefaultQualityTextBox.ReadOnly = true;
            this.firstDefaultQualityTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstDefaultQualityTextBox.TabIndex = 0;
            // 
            // default70Rate
            // 
            this.default70Rate.AutoSize = true;
            this.default70Rate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.default70Rate.Location = new System.Drawing.Point(131, 74);
            this.default70Rate.Name = "default70Rate";
            this.default70Rate.Size = new System.Drawing.Size(99, 13);
            this.default70Rate.TabIndex = 10;
            this.default70Rate.Text = "B/D @ 70% Quality";
            // 
            // default65Rate
            // 
            this.default65Rate.AutoSize = true;
            this.default65Rate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.default65Rate.Location = new System.Drawing.Point(131, 48);
            this.default65Rate.Name = "default65Rate";
            this.default65Rate.Size = new System.Drawing.Size(99, 13);
            this.default65Rate.TabIndex = 9;
            this.default65Rate.Text = "B/D @ 65% Quality";
            // 
            // pdiLabel
            // 
            this.pdiLabel.AutoSize = true;
            this.pdiLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pdiLabel.Location = new System.Drawing.Point(22, 17);
            this.pdiLabel.Name = "pdiLabel";
            this.pdiLabel.Size = new System.Drawing.Size(56, 13);
            this.pdiLabel.TabIndex = 6;
            this.pdiLabel.Text = "PDI Rates";
            // 
            // cweForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 506);
            this.Controls.Add(this.formTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cweForm";
            this.Text = "cweForm";
            this.Load += new System.EventHandler(this.cweForm_Load);
            this.typeCalc2.ResumeLayout(false);
            this.typeCalc2.PerformLayout();
            this.dataTab1.ResumeLayout(false);
            this.dataTab1.PerformLayout();
            this.formTabControl.ResumeLayout(false);
            this.outputTab.ResumeLayout(false);
            this.outputTab.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region CreationOfForms
        private System.Windows.Forms.TabPage typeCalc2;
        private System.Windows.Forms.TextBox perfSizeTextBox;
        private System.Windows.Forms.TabPage dataTab1;
        private System.Windows.Forms.ComboBox qualityDropBox;
        private System.Windows.Forms.Label pipeSizeTextLabel;
        private System.Windows.Forms.TextBox velocityTextBox;
        private System.Windows.Forms.TextBox pressureTextBox;
        private System.Windows.Forms.ComboBox pipeSizeDropBox;
        private System.Windows.Forms.Label qualitiesTextLabel;
        private System.Windows.Forms.Label velocityTextLabel;
        private System.Windows.Forms.Label pressureTextLabel;
        private System.Windows.Forms.TabControl formTabControl;
        private System.Windows.Forms.TabPage outputTab;
        private System.Windows.Forms.Label totalTheoreticalRateLabel;
        private System.Windows.Forms.TextBox totalTheoreticalTextBox;
        private System.Windows.Forms.TextBox secondDefaultQualityTextBox;
        private System.Windows.Forms.TextBox firstDefaultQualityTextBox;
        private System.Windows.Forms.Label default70Rate;
        private System.Windows.Forms.Label default65Rate;
        private System.Windows.Forms.Label pdiLabel;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.Label bdLabel4;
        private System.Windows.Forms.Label qualityLabel3;
        private System.Windows.Forms.TextBox theoreticalQualityBox;
        #endregion
        private System.Windows.Forms.Button calculate70Function;
        private System.Windows.Forms.TextBox anularSpaceTextBox;
        private System.Windows.Forms.Label AnularSpaceLabel;
        private System.Windows.Forms.ComboBox perfDropBoxDiam;
        private System.Windows.Forms.Label numPerfsSizeLabel;
        private System.Windows.Forms.Label perfSizePromptLabel;
        private System.Windows.Forms.Label helpmessageLabel;
        private System.Windows.Forms.Button addPerfButton;
        private System.Windows.Forms.Button calculatePerfsButton;
        private System.Windows.Forms.TextBox numPerfsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label defaultChosenRate;
        private System.Windows.Forms.TextBox thirdDefaultQualityTextBox;
    }
}

