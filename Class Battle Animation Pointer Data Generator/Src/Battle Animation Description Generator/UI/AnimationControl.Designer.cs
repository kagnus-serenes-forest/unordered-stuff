namespace UI {
    partial class AnimationControl {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.AnimationNumber = new System.Windows.Forms.NumericUpDown();
            this.WeaponTypeLabel = new System.Windows.Forms.Label();
            this.IndexLabel = new System.Windows.Forms.Label();
            this.IncludeCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.AnimationNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // AnimationNumber
            // 
            this.AnimationNumber.Hexadecimal = true;
            this.AnimationNumber.Location = new System.Drawing.Point(56, 20);
            this.AnimationNumber.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.AnimationNumber.Name = "AnimationNumber";
            this.AnimationNumber.Size = new System.Drawing.Size(36, 20);
            this.AnimationNumber.TabIndex = 0;
            this.AnimationNumber.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // WeaponTypeLabel
            // 
            this.WeaponTypeLabel.AutoSize = true;
            this.WeaponTypeLabel.Location = new System.Drawing.Point(3, 0);
            this.WeaponTypeLabel.Name = "WeaponTypeLabel";
            this.WeaponTypeLabel.Size = new System.Drawing.Size(0, 13);
            this.WeaponTypeLabel.TabIndex = 1;
            // 
            // IndexLabel
            // 
            this.IndexLabel.AutoSize = true;
            this.IndexLabel.Location = new System.Drawing.Point(3, 22);
            this.IndexLabel.Name = "IndexLabel";
            this.IndexLabel.Size = new System.Drawing.Size(33, 13);
            this.IndexLabel.TabIndex = 2;
            this.IndexLabel.Text = "Index";
            // 
            // IncludeCheckBox
            // 
            this.IncludeCheckBox.AutoSize = true;
            this.IncludeCheckBox.Location = new System.Drawing.Point(6, 43);
            this.IncludeCheckBox.Name = "IncludeCheckBox";
            this.IncludeCheckBox.Size = new System.Drawing.Size(66, 17);
            this.IncludeCheckBox.TabIndex = 3;
            this.IncludeCheckBox.Text = "include?";
            this.IncludeCheckBox.UseVisualStyleBackColor = true;
            // 
            // AnimationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.IncludeCheckBox);
            this.Controls.Add(this.IndexLabel);
            this.Controls.Add(this.WeaponTypeLabel);
            this.Controls.Add(this.AnimationNumber);
            this.Name = "AnimationControl";
            this.Size = new System.Drawing.Size(95, 61);
            ((System.ComponentModel.ISupportInitialize)(this.AnimationNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown AnimationNumber;
        private System.Windows.Forms.Label WeaponTypeLabel;
        private System.Windows.Forms.Label IndexLabel;
        private System.Windows.Forms.CheckBox IncludeCheckBox;
    }
}
