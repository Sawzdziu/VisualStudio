namespace DinnerParty {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.numberOfPeopleLabel = new System.Windows.Forms.Label();
            this.numberOfPeopleUpDown = new System.Windows.Forms.NumericUpDown();
            this.decorationCheckButton = new System.Windows.Forms.CheckBox();
            this.healthyOptionCheckButton = new System.Windows.Forms.CheckBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.costVisualLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeopleUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // numberOfPeopleLabel
            // 
            this.numberOfPeopleLabel.AutoSize = true;
            this.numberOfPeopleLabel.Location = new System.Drawing.Point(26, 37);
            this.numberOfPeopleLabel.Name = "numberOfPeopleLabel";
            this.numberOfPeopleLabel.Size = new System.Drawing.Size(53, 13);
            this.numberOfPeopleLabel.TabIndex = 0;
            this.numberOfPeopleLabel.Text = "Ilość ludzi";
            // 
            // numberOfPeopleUpDown
            // 
            this.numberOfPeopleUpDown.Location = new System.Drawing.Point(29, 69);
            this.numberOfPeopleUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numberOfPeopleUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfPeopleUpDown.Name = "numberOfPeopleUpDown";
            this.numberOfPeopleUpDown.Size = new System.Drawing.Size(120, 20);
            this.numberOfPeopleUpDown.TabIndex = 1;
            this.numberOfPeopleUpDown.Tag = "";
            this.numberOfPeopleUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberOfPeopleUpDown.ValueChanged += new System.EventHandler(this.numberOfPeopleUpDown_ValueChanged);
            // 
            // decorationCheckButton
            // 
            this.decorationCheckButton.AutoSize = true;
            this.decorationCheckButton.Checked = true;
            this.decorationCheckButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.decorationCheckButton.Location = new System.Drawing.Point(29, 105);
            this.decorationCheckButton.Name = "decorationCheckButton";
            this.decorationCheckButton.Size = new System.Drawing.Size(126, 17);
            this.decorationCheckButton.TabIndex = 2;
            this.decorationCheckButton.Text = "Dekoracje fantazyjne";
            this.decorationCheckButton.UseVisualStyleBackColor = true;
            this.decorationCheckButton.CheckedChanged += new System.EventHandler(this.decorationCheckButton_CheckedChanged);
            // 
            // healthyOptionCheckButton
            // 
            this.healthyOptionCheckButton.AutoSize = true;
            this.healthyOptionCheckButton.Location = new System.Drawing.Point(29, 143);
            this.healthyOptionCheckButton.Name = "healthyOptionCheckButton";
            this.healthyOptionCheckButton.Size = new System.Drawing.Size(91, 17);
            this.healthyOptionCheckButton.TabIndex = 3;
            this.healthyOptionCheckButton.Text = "Opcja zdrowa";
            this.healthyOptionCheckButton.UseVisualStyleBackColor = true;
            this.healthyOptionCheckButton.CheckedChanged += new System.EventHandler(this.healthyOptionCheckButton_CheckedChanged);
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(26, 182);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(33, 13);
            this.costLabel.TabIndex = 4;
            this.costLabel.Text = "Koszt";
            // 
            // costVisualLabel
            // 
            this.costVisualLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costVisualLabel.Location = new System.Drawing.Point(90, 172);
            this.costVisualLabel.Name = "costVisualLabel";
            this.costVisualLabel.Size = new System.Drawing.Size(100, 23);
            this.costVisualLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 208);
            this.Controls.Add(this.costVisualLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.healthyOptionCheckButton);
            this.Controls.Add(this.decorationCheckButton);
            this.Controls.Add(this.numberOfPeopleUpDown);
            this.Controls.Add(this.numberOfPeopleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeopleUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numberOfPeopleLabel;
        private System.Windows.Forms.NumericUpDown numberOfPeopleUpDown;
        private System.Windows.Forms.CheckBox decorationCheckButton;
        private System.Windows.Forms.CheckBox healthyOptionCheckButton;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label costVisualLabel;
    }
}

