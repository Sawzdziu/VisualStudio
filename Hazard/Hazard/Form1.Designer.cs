namespace Hazard
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
            this.background = new System.Windows.Forms.PictureBox();
            this.jacksonDog = new System.Windows.Forms.PictureBox();
            this.haganDog = new System.Windows.Forms.PictureBox();
            this.harryDog = new System.Windows.Forms.PictureBox();
            this.fenderDog = new System.Windows.Forms.PictureBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.startButton = new System.Windows.Forms.Button();
            this.dogNumber = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.betAmount = new System.Windows.Forms.NumericUpDown();
            this.betButton = new System.Windows.Forms.Button();
            this.activeBooker = new System.Windows.Forms.Label();
            this.piotrekDescription = new System.Windows.Forms.Label();
            this.ignacyDescription = new System.Windows.Forms.Label();
            this.janekDescription = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.piotrekLabel = new System.Windows.Forms.Label();
            this.ignacyLabel = new System.Windows.Forms.Label();
            this.piotrekButton = new System.Windows.Forms.RadioButton();
            this.ignacyButton = new System.Windows.Forms.RadioButton();
            this.janekButton = new System.Windows.Forms.RadioButton();
            this.janekLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jacksonDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.haganDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.harryDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fenderDog)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.AccessibleName = "background";
            this.background.Image = ((System.Drawing.Image)(resources.GetObject("background.Image")));
            this.background.Location = new System.Drawing.Point(12, 12);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1367, 319);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            // 
            // jacksonDog
            // 
            this.jacksonDog.Image = ((System.Drawing.Image)(resources.GetObject("jacksonDog.Image")));
            this.jacksonDog.Location = new System.Drawing.Point(96, 30);
            this.jacksonDog.Name = "jacksonDog";
            this.jacksonDog.Size = new System.Drawing.Size(75, 20);
            this.jacksonDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.jacksonDog.TabIndex = 1;
            this.jacksonDog.TabStop = false;
            // 
            // haganDog
            // 
            this.haganDog.Image = global::Hazard.Properties.Resources.dog;
            this.haganDog.Location = new System.Drawing.Point(96, 113);
            this.haganDog.Name = "haganDog";
            this.haganDog.Size = new System.Drawing.Size(75, 20);
            this.haganDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.haganDog.TabIndex = 2;
            this.haganDog.TabStop = false;
            // 
            // harryDog
            // 
            this.harryDog.Image = global::Hazard.Properties.Resources.dog;
            this.harryDog.Location = new System.Drawing.Point(96, 200);
            this.harryDog.Name = "harryDog";
            this.harryDog.Size = new System.Drawing.Size(75, 20);
            this.harryDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.harryDog.TabIndex = 3;
            this.harryDog.TabStop = false;
            // 
            // fenderDog
            // 
            this.fenderDog.Image = global::Hazard.Properties.Resources.dog;
            this.fenderDog.Location = new System.Drawing.Point(96, 283);
            this.fenderDog.Name = "fenderDog";
            this.fenderDog.Size = new System.Drawing.Size(75, 20);
            this.fenderDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fenderDog.TabIndex = 4;
            this.fenderDog.TabStop = false;
            // 
            // groupBox
            // 
            this.groupBox.AutoSize = true;
            this.groupBox.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox.Controls.Add(this.startButton);
            this.groupBox.Controls.Add(this.dogNumber);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.betAmount);
            this.groupBox.Controls.Add(this.betButton);
            this.groupBox.Controls.Add(this.activeBooker);
            this.groupBox.Controls.Add(this.piotrekDescription);
            this.groupBox.Controls.Add(this.ignacyDescription);
            this.groupBox.Controls.Add(this.janekDescription);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.piotrekLabel);
            this.groupBox.Controls.Add(this.ignacyLabel);
            this.groupBox.Controls.Add(this.piotrekButton);
            this.groupBox.Controls.Add(this.ignacyButton);
            this.groupBox.Controls.Add(this.janekButton);
            this.groupBox.Controls.Add(this.janekLabel);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox.Location = new System.Drawing.Point(12, 346);
            this.groupBox.Name = "groupBox";
            this.groupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox.Size = new System.Drawing.Size(1367, 317);
            this.groupBox.TabIndex = 11;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Bukmacherka!";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(1038, 240);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(262, 52);
            this.startButton.TabIndex = 26;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // dogNumber
            // 
            this.dogNumber.Location = new System.Drawing.Point(672, 256);
            this.dogNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumber.Name = "dogNumber";
            this.dogNumber.Size = new System.Drawing.Size(120, 26);
            this.dogNumber.TabIndex = 25;
            this.dogNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "zł na psa numer";
            // 
            // betAmount
            // 
            this.betAmount.Location = new System.Drawing.Point(344, 256);
            this.betAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betAmount.Name = "betAmount";
            this.betAmount.Size = new System.Drawing.Size(129, 26);
            this.betAmount.TabIndex = 23;
            this.betAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(175, 254);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(129, 28);
            this.betButton.TabIndex = 22;
            this.betButton.Text = "Stawia";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // activeBooker
            // 
            this.activeBooker.AutoSize = true;
            this.activeBooker.Location = new System.Drawing.Point(80, 258);
            this.activeBooker.Name = "activeBooker";
            this.activeBooker.Size = new System.Drawing.Size(0, 20);
            this.activeBooker.TabIndex = 21;
            // 
            // piotrekDescription
            // 
            this.piotrekDescription.AutoSize = true;
            this.piotrekDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.piotrekDescription.Location = new System.Drawing.Point(833, 207);
            this.piotrekDescription.Name = "piotrekDescription";
            this.piotrekDescription.Size = new System.Drawing.Size(2, 22);
            this.piotrekDescription.TabIndex = 20;
            // 
            // ignacyDescription
            // 
            this.ignacyDescription.AutoSize = true;
            this.ignacyDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ignacyDescription.Location = new System.Drawing.Point(833, 133);
            this.ignacyDescription.Name = "ignacyDescription";
            this.ignacyDescription.Size = new System.Drawing.Size(2, 22);
            this.ignacyDescription.TabIndex = 19;
            // 
            // janekDescription
            // 
            this.janekDescription.AutoSize = true;
            this.janekDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.janekDescription.Location = new System.Drawing.Point(833, 66);
            this.janekDescription.Name = "janekDescription";
            this.janekDescription.Size = new System.Drawing.Size(2, 22);
            this.janekDescription.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(829, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Zakłady";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(80, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Minimalny zakład: 5 zł";
            // 
            // piotrekLabel
            // 
            this.piotrekLabel.AutoSize = true;
            this.piotrekLabel.Location = new System.Drawing.Point(62, 211);
            this.piotrekLabel.Name = "piotrekLabel";
            this.piotrekLabel.Size = new System.Drawing.Size(0, 20);
            this.piotrekLabel.TabIndex = 16;
            // 
            // ignacyLabel
            // 
            this.ignacyLabel.AutoSize = true;
            this.ignacyLabel.Location = new System.Drawing.Point(62, 137);
            this.ignacyLabel.Name = "ignacyLabel";
            this.ignacyLabel.Size = new System.Drawing.Size(0, 20);
            this.ignacyLabel.TabIndex = 15;
            // 
            // piotrekButton
            // 
            this.piotrekButton.AutoSize = true;
            this.piotrekButton.Location = new System.Drawing.Point(6, 211);
            this.piotrekButton.Name = "piotrekButton";
            this.piotrekButton.Size = new System.Drawing.Size(14, 13);
            this.piotrekButton.TabIndex = 14;
            this.piotrekButton.TabStop = true;
            this.piotrekButton.UseVisualStyleBackColor = true;
            this.piotrekButton.CheckedChanged += new System.EventHandler(this.piotrekButton_CheckedChanged);
            // 
            // ignacyButton
            // 
            this.ignacyButton.AutoSize = true;
            this.ignacyButton.Location = new System.Drawing.Point(6, 137);
            this.ignacyButton.Name = "ignacyButton";
            this.ignacyButton.Size = new System.Drawing.Size(14, 13);
            this.ignacyButton.TabIndex = 13;
            this.ignacyButton.TabStop = true;
            this.ignacyButton.UseVisualStyleBackColor = true;
            this.ignacyButton.CheckedChanged += new System.EventHandler(this.ignacyButton_CheckedChanged);
            // 
            // janekButton
            // 
            this.janekButton.AutoSize = true;
            this.janekButton.Location = new System.Drawing.Point(6, 70);
            this.janekButton.Name = "janekButton";
            this.janekButton.Size = new System.Drawing.Size(14, 13);
            this.janekButton.TabIndex = 12;
            this.janekButton.TabStop = true;
            this.janekButton.UseVisualStyleBackColor = true;
            this.janekButton.CheckedChanged += new System.EventHandler(this.janekButton_CheckedChanged);
            // 
            // janekLabel
            // 
            this.janekLabel.AutoSize = true;
            this.janekLabel.Location = new System.Drawing.Point(62, 70);
            this.janekLabel.Name = "janekLabel";
            this.janekLabel.Size = new System.Drawing.Size(0, 20);
            this.janekLabel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 657);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.fenderDog);
            this.Controls.Add(this.harryDog);
            this.Controls.Add(this.haganDog);
            this.Controls.Add(this.jacksonDog);
            this.Controls.Add(this.background);
            this.Name = "Form1";
            this.Text = "Zakłady bukmacherskie";
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jacksonDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.haganDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.harryDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fenderDog)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox jacksonDog;
        private System.Windows.Forms.PictureBox haganDog;
        private System.Windows.Forms.PictureBox harryDog;
        private System.Windows.Forms.PictureBox fenderDog;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label piotrekLabel;
        private System.Windows.Forms.Label ignacyLabel;
        private System.Windows.Forms.RadioButton piotrekButton;
        private System.Windows.Forms.RadioButton ignacyButton;
        private System.Windows.Forms.RadioButton janekButton;
        private System.Windows.Forms.Label janekLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label piotrekDescription;
        private System.Windows.Forms.Label ignacyDescription;
        private System.Windows.Forms.Label janekDescription;
        private System.Windows.Forms.Label activeBooker;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.NumericUpDown dogNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown betAmount;
        private System.Windows.Forms.Button startButton;
    }
}

