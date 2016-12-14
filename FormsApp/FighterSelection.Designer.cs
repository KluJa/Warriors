namespace FormsApp
{
    partial class FighterSelection
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
            this.radioPretorian = new System.Windows.Forms.RadioButton();
            this.radioMag = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioPretorian
            // 
            this.radioPretorian.Location = new System.Drawing.Point(89, 99);
            this.radioPretorian.Name = "radioPretorian";
            this.radioPretorian.Size = new System.Drawing.Size(104, 24);
            this.radioPretorian.TabIndex = 1;
            this.radioPretorian.TabStop = true;
            this.radioPretorian.Text = "   Pretorian";
            this.radioPretorian.UseVisualStyleBackColor = true;
            this.radioPretorian.Click += new System.EventHandler(this.radioPretorian_Click);
            // 
            // radioMag
            // 
            this.radioMag.Location = new System.Drawing.Point(89, 132);
            this.radioMag.Name = "radioMag";
            this.radioMag.Size = new System.Drawing.Size(85, 17);
            this.radioMag.TabIndex = 1;
            this.radioMag.TabStop = true;
            this.radioMag.Text = "Mag";
            this.radioMag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioMag.UseVisualStyleBackColor = true;
            this.radioMag.Click += new System.EventHandler(this.radioMag_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(45, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vyber si bojovnika";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FighterSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioMag);
            this.Controls.Add(this.radioPretorian);
            this.Name = "FighterSelection";
            this.Text = "FighterSelection";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radioMag;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RadioButton radioPretorian;
    }
}