namespace VRSSSetter
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
            this.SSNumber = new System.Windows.Forms.NumericUpDown();
            this.submitSS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SSNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // SSNumber
            // 
            this.SSNumber.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SSNumber.DecimalPlaces = 1;
            this.SSNumber.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SSNumber.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.SSNumber.Location = new System.Drawing.Point(142, 29);
            this.SSNumber.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.SSNumber.Minimum = new decimal(new int[] {
            13,
            0,
            0,
            65536});
            this.SSNumber.Name = "SSNumber";
            this.SSNumber.Size = new System.Drawing.Size(120, 29);
            this.SSNumber.TabIndex = 0;
            this.SSNumber.Value = new decimal(new int[] {
            13,
            0,
            0,
            65536});
            // 
            // submitSS
            // 
            this.submitSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitSS.Location = new System.Drawing.Point(140, 64);
            this.submitSS.Name = "submitSS";
            this.submitSS.Size = new System.Drawing.Size(122, 71);
            this.submitSS.TabIndex = 1;
            this.submitSS.Text = "SET";
            this.submitSS.UseVisualStyleBackColor = true;
            this.submitSS.Click += new System.EventHandler(this.submitSS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(433, 159);
            this.Controls.Add(this.submitSS);
            this.Controls.Add(this.SSNumber);
            this.Name = "Form1";
            this.Text = "VRSSForm";
            ((System.ComponentModel.ISupportInitialize)(this.SSNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown SSNumber;
        private System.Windows.Forms.Button submitSS;
    }
}

