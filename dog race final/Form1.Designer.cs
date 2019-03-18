namespace dog_race_final
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.makeRun = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.dogNumberSelect = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.betValueSelect = new System.Windows.Forms.NumericUpDown();
            this.betButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.jobanBetLabel = new System.Windows.Forms.Label();
            this.manpreetBetLabel = new System.Windows.Forms.Label();
            this.shivamBetLabel = new System.Windows.Forms.Label();
            this.betLabel = new System.Windows.Forms.Label();
            this.jobanRadioButton = new System.Windows.Forms.RadioButton();
            this.manpreetRadioButton = new System.Windows.Forms.RadioButton();
            this.shivamRadioButton = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.bettingGroupBox = new System.Windows.Forms.GroupBox();
            this.dog3Pict = new System.Windows.Forms.PictureBox();
            this.dog2Pict = new System.Windows.Forms.PictureBox();
            this.dog1Pict = new System.Windows.Forms.PictureBox();
            this.dog0Pict = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumberSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betValueSelect)).BeginInit();
            this.bettingGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dog3Pict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2Pict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1Pict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog0Pict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // makeRun
            // 
            this.makeRun.BackColor = System.Drawing.Color.Black;
            this.makeRun.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.makeRun.Location = new System.Drawing.Point(633, 32);
            this.makeRun.Name = "makeRun";
            this.makeRun.Size = new System.Drawing.Size(141, 117);
            this.makeRun.TabIndex = 15;
            this.makeRun.Text = "Run";
            this.makeRun.UseVisualStyleBackColor = false;
            this.makeRun.Click += new System.EventHandler(this.makeRun_Click_1);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timerLabel.Location = new System.Drawing.Point(496, 81);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(76, 19);
            this.timerLabel.TabIndex = 14;
            this.timerLabel.Text = "timerLabel";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(407, 22);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(52, 17);
            this.infoLabel.TabIndex = 13;
            this.infoLabel.Text = "label1";
            // 
            // dogNumberSelect
            // 
            this.dogNumberSelect.BackColor = System.Drawing.SystemColors.InfoText;
            this.dogNumberSelect.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.dogNumberSelect.Location = new System.Drawing.Point(396, 130);
            this.dogNumberSelect.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNumberSelect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumberSelect.Name = "dogNumberSelect";
            this.dogNumberSelect.Size = new System.Drawing.Size(57, 22);
            this.dogNumberSelect.TabIndex = 12;
            this.dogNumberSelect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "bucks on dog number";
            // 
            // betValueSelect
            // 
            this.betValueSelect.BackColor = System.Drawing.SystemColors.InfoText;
            this.betValueSelect.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.betValueSelect.Location = new System.Drawing.Point(165, 130);
            this.betValueSelect.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.betValueSelect.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betValueSelect.Name = "betValueSelect";
            this.betValueSelect.Size = new System.Drawing.Size(58, 22);
            this.betValueSelect.TabIndex = 10;
            this.betValueSelect.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // betButton
            // 
            this.betButton.BackColor = System.Drawing.Color.Black;
            this.betButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.betButton.Location = new System.Drawing.Point(67, 129);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(75, 23);
            this.betButton.TabIndex = 9;
            this.betButton.Text = "Bets";
            this.betButton.UseVisualStyleBackColor = false;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 132);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(43, 17);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "name";
            // 
            // jobanBetLabel
            // 
            this.jobanBetLabel.AutoSize = true;
            this.jobanBetLabel.Location = new System.Drawing.Point(248, 108);
            this.jobanBetLabel.Name = "jobanBetLabel";
            this.jobanBetLabel.Size = new System.Drawing.Size(181, 17);
            this.jobanBetLabel.TabIndex = 7;
            this.jobanBetLabel.Text = "joban hasn\'t placed bet yet!";
            // 
            // manpreetBetLabel
            // 
            this.manpreetBetLabel.AutoSize = true;
            this.manpreetBetLabel.Location = new System.Drawing.Point(248, 81);
            this.manpreetBetLabel.Name = "manpreetBetLabel";
            this.manpreetBetLabel.Size = new System.Drawing.Size(206, 17);
            this.manpreetBetLabel.TabIndex = 6;
            this.manpreetBetLabel.Text = "manpreet hasn\'t placed bet yet!";
            // 
            // shivamBetLabel
            // 
            this.shivamBetLabel.AutoSize = true;
            this.shivamBetLabel.Location = new System.Drawing.Point(248, 53);
            this.shivamBetLabel.Name = "shivamBetLabel";
            this.shivamBetLabel.Size = new System.Drawing.Size(190, 17);
            this.shivamBetLabel.TabIndex = 5;
            this.shivamBetLabel.Text = "shivam hasn\'t placed bet yet!";
            this.shivamBetLabel.Click += new System.EventHandler(this.joeBetLabel_Click);
            // 
            // betLabel
            // 
            this.betLabel.AutoSize = true;
            this.betLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betLabel.Location = new System.Drawing.Point(245, 22);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(40, 17);
            this.betLabel.TabIndex = 4;
            this.betLabel.Text = "Bets";
            // 
            // jobanRadioButton
            // 
            this.jobanRadioButton.AutoSize = true;
            this.jobanRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobanRadioButton.Location = new System.Drawing.Point(16, 108);
            this.jobanRadioButton.Name = "jobanRadioButton";
            this.jobanRadioButton.Size = new System.Drawing.Size(69, 21);
            this.jobanRadioButton.TabIndex = 3;
            this.jobanRadioButton.TabStop = true;
            this.jobanRadioButton.Text = "joban";
            this.jobanRadioButton.UseVisualStyleBackColor = true;
            this.jobanRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged_1);
            // 
            // manpreetRadioButton
            // 
            this.manpreetRadioButton.AutoSize = true;
            this.manpreetRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manpreetRadioButton.Location = new System.Drawing.Point(16, 81);
            this.manpreetRadioButton.Name = "manpreetRadioButton";
            this.manpreetRadioButton.Size = new System.Drawing.Size(97, 21);
            this.manpreetRadioButton.TabIndex = 2;
            this.manpreetRadioButton.TabStop = true;
            this.manpreetRadioButton.Text = "manpreet";
            this.manpreetRadioButton.UseVisualStyleBackColor = true;
            this.manpreetRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged_1);
            // 
            // shivamRadioButton
            // 
            this.shivamRadioButton.AutoSize = true;
            this.shivamRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shivamRadioButton.Location = new System.Drawing.Point(16, 53);
            this.shivamRadioButton.Name = "shivamRadioButton";
            this.shivamRadioButton.Size = new System.Drawing.Size(79, 21);
            this.shivamRadioButton.TabIndex = 1;
            this.shivamRadioButton.TabStop = true;
            this.shivamRadioButton.Text = "shivam";
            this.shivamRadioButton.UseVisualStyleBackColor = true;
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumBetLabel.Location = new System.Drawing.Point(13, 22);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(134, 17);
            this.minimumBetLabel.TabIndex = 0;
            this.minimumBetLabel.Text = "minimumBetLabel";
            // 
            // bettingGroupBox
            // 
            this.bettingGroupBox.BackColor = System.Drawing.Color.Gray;
            this.bettingGroupBox.Controls.Add(this.makeRun);
            this.bettingGroupBox.Controls.Add(this.timerLabel);
            this.bettingGroupBox.Controls.Add(this.infoLabel);
            this.bettingGroupBox.Controls.Add(this.dogNumberSelect);
            this.bettingGroupBox.Controls.Add(this.label4);
            this.bettingGroupBox.Controls.Add(this.betValueSelect);
            this.bettingGroupBox.Controls.Add(this.betButton);
            this.bettingGroupBox.Controls.Add(this.nameLabel);
            this.bettingGroupBox.Controls.Add(this.jobanBetLabel);
            this.bettingGroupBox.Controls.Add(this.manpreetBetLabel);
            this.bettingGroupBox.Controls.Add(this.shivamBetLabel);
            this.bettingGroupBox.Controls.Add(this.betLabel);
            this.bettingGroupBox.Controls.Add(this.jobanRadioButton);
            this.bettingGroupBox.Controls.Add(this.manpreetRadioButton);
            this.bettingGroupBox.Controls.Add(this.shivamRadioButton);
            this.bettingGroupBox.Controls.Add(this.minimumBetLabel);
            this.bettingGroupBox.Location = new System.Drawing.Point(98, 371);
            this.bettingGroupBox.Name = "bettingGroupBox";
            this.bettingGroupBox.Size = new System.Drawing.Size(799, 171);
            this.bettingGroupBox.TabIndex = 11;
            this.bettingGroupBox.TabStop = false;
            this.bettingGroupBox.Text = "Betting Parlor";
            // 
            // dog3Pict
            // 
            this.dog3Pict.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dog3Pict.BackgroundImage")));
            this.dog3Pict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dog3Pict.Location = new System.Drawing.Point(53, 275);
            this.dog3Pict.Name = "dog3Pict";
            this.dog3Pict.Size = new System.Drawing.Size(100, 50);
            this.dog3Pict.TabIndex = 10;
            this.dog3Pict.TabStop = false;
            // 
            // dog2Pict
            // 
            this.dog2Pict.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dog2Pict.BackgroundImage")));
            this.dog2Pict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dog2Pict.Location = new System.Drawing.Point(53, 193);
            this.dog2Pict.Name = "dog2Pict";
            this.dog2Pict.Size = new System.Drawing.Size(100, 50);
            this.dog2Pict.TabIndex = 9;
            this.dog2Pict.TabStop = false;
            // 
            // dog1Pict
            // 
            this.dog1Pict.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dog1Pict.BackgroundImage")));
            this.dog1Pict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dog1Pict.Location = new System.Drawing.Point(53, 105);
            this.dog1Pict.Name = "dog1Pict";
            this.dog1Pict.Size = new System.Drawing.Size(100, 50);
            this.dog1Pict.TabIndex = 8;
            this.dog1Pict.TabStop = false;
            // 
            // dog0Pict
            // 
            this.dog0Pict.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dog0Pict.BackgroundImage")));
            this.dog0Pict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dog0Pict.Location = new System.Drawing.Point(53, 21);
            this.dog0Pict.Name = "dog0Pict";
            this.dog0Pict.Size = new System.Drawing.Size(100, 50);
            this.dog0Pict.TabIndex = 7;
            this.dog0Pict.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1014, 326);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 688);
            this.Controls.Add(this.bettingGroupBox);
            this.Controls.Add(this.dog3Pict);
            this.Controls.Add(this.dog2Pict);
            this.Controls.Add(this.dog1Pict);
            this.Controls.Add(this.dog0Pict);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dogNumberSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betValueSelect)).EndInit();
            this.bettingGroupBox.ResumeLayout(false);
            this.bettingGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dog3Pict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2Pict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1Pict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog0Pict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button makeRun;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.NumericUpDown dogNumberSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown betValueSelect;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label jobanBetLabel;
        private System.Windows.Forms.Label manpreetBetLabel;
        private System.Windows.Forms.Label shivamBetLabel;
        private System.Windows.Forms.Label betLabel;
        private System.Windows.Forms.RadioButton jobanRadioButton;
        private System.Windows.Forms.RadioButton manpreetRadioButton;
        private System.Windows.Forms.RadioButton shivamRadioButton;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.GroupBox bettingGroupBox;
        private System.Windows.Forms.PictureBox dog3Pict;
        private System.Windows.Forms.PictureBox dog2Pict;
        private System.Windows.Forms.PictureBox dog1Pict;
        private System.Windows.Forms.PictureBox dog0Pict;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

