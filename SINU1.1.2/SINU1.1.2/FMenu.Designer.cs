
namespace SINU1._1._2
{
    partial class FMenu
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
            this.BPersonalData = new System.Windows.Forms.Button();
            this.BYear1 = new System.Windows.Forms.Button();
            this.BYear2 = new System.Windows.Forms.Button();
            this.BYear3 = new System.Windows.Forms.Button();
            this.BYear4 = new System.Windows.Forms.Button();
            this.BSchoolSituation = new System.Windows.Forms.Button();
            this.BTDisconect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BPersonalData
            // 
            this.BPersonalData.Location = new System.Drawing.Point(18, 12);
            this.BPersonalData.Name = "BPersonalData";
            this.BPersonalData.Size = new System.Drawing.Size(128, 23);
            this.BPersonalData.TabIndex = 1;
            this.BPersonalData.Text = "Personal Data";
            this.BPersonalData.UseVisualStyleBackColor = true;
            this.BPersonalData.Click += new System.EventHandler(this.BPersonalData_Click);
            // 
            // BYear1
            // 
            this.BYear1.Location = new System.Drawing.Point(18, 41);
            this.BYear1.Name = "BYear1";
            this.BYear1.Size = new System.Drawing.Size(262, 23);
            this.BYear1.TabIndex = 2;
            this.BYear1.Text = "Year 1";
            this.BYear1.UseVisualStyleBackColor = true;
            this.BYear1.Click += new System.EventHandler(this.BYear1_Click);
            // 
            // BYear2
            // 
            this.BYear2.Location = new System.Drawing.Point(18, 70);
            this.BYear2.Name = "BYear2";
            this.BYear2.Size = new System.Drawing.Size(262, 23);
            this.BYear2.TabIndex = 3;
            this.BYear2.Text = "Year 2";
            this.BYear2.UseVisualStyleBackColor = true;
            this.BYear2.Click += new System.EventHandler(this.BYear2_Click);
            // 
            // BYear3
            // 
            this.BYear3.Location = new System.Drawing.Point(18, 99);
            this.BYear3.Name = "BYear3";
            this.BYear3.Size = new System.Drawing.Size(262, 23);
            this.BYear3.TabIndex = 4;
            this.BYear3.Text = "Year 3";
            this.BYear3.UseVisualStyleBackColor = true;
            this.BYear3.Click += new System.EventHandler(this.BYear3_Click);
            // 
            // BYear4
            // 
            this.BYear4.Location = new System.Drawing.Point(18, 128);
            this.BYear4.Name = "BYear4";
            this.BYear4.Size = new System.Drawing.Size(262, 23);
            this.BYear4.TabIndex = 5;
            this.BYear4.Text = "Year 4";
            this.BYear4.UseVisualStyleBackColor = true;
            this.BYear4.Click += new System.EventHandler(this.BYear4_Click);
            // 
            // BSchoolSituation
            // 
            this.BSchoolSituation.Location = new System.Drawing.Point(152, 12);
            this.BSchoolSituation.Name = "BSchoolSituation";
            this.BSchoolSituation.Size = new System.Drawing.Size(128, 23);
            this.BSchoolSituation.TabIndex = 6;
            this.BSchoolSituation.Text = "School Situation";
            this.BSchoolSituation.UseVisualStyleBackColor = true;
            this.BSchoolSituation.Click += new System.EventHandler(this.BSchoolSituation_Click);
            // 
            // BTDisconect
            // 
            this.BTDisconect.Location = new System.Drawing.Point(18, 157);
            this.BTDisconect.Name = "BTDisconect";
            this.BTDisconect.Size = new System.Drawing.Size(262, 36);
            this.BTDisconect.TabIndex = 7;
            this.BTDisconect.Text = "Disconect";
            this.BTDisconect.UseVisualStyleBackColor = true;
            this.BTDisconect.Click += new System.EventHandler(this.BTDisconect_Click);
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 205);
            this.Controls.Add(this.BTDisconect);
            this.Controls.Add(this.BSchoolSituation);
            this.Controls.Add(this.BYear4);
            this.Controls.Add(this.BYear3);
            this.Controls.Add(this.BYear2);
            this.Controls.Add(this.BYear1);
            this.Controls.Add(this.BPersonalData);
            this.Name = "FMenu";
            this.Text = "FMenu";
            this.Load += new System.EventHandler(this.FMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BPersonalData;
        private System.Windows.Forms.Button BYear1;
        private System.Windows.Forms.Button BYear2;
        private System.Windows.Forms.Button BYear3;
        private System.Windows.Forms.Button BYear4;
        private System.Windows.Forms.Button BSchoolSituation;
        private System.Windows.Forms.Button BTDisconect;
    }
}