
namespace SINU1._1._2
{
    partial class FLogIn
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
            this.LUsername = new System.Windows.Forms.Label();
            this.LPassword = new System.Windows.Forms.Label();
            this.TBUsername = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.BSignUp = new System.Windows.Forms.Button();
            this.BSingIn = new System.Windows.Forms.Button();
            this.RadStudent = new System.Windows.Forms.RadioButton();
            this.RadProfesor = new System.Windows.Forms.RadioButton();
            this.RadSecretariat = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // LUsername
            // 
            this.LUsername.AutoSize = true;
            this.LUsername.Location = new System.Drawing.Point(28, 24);
            this.LUsername.Name = "LUsername";
            this.LUsername.Size = new System.Drawing.Size(73, 17);
            this.LUsername.TabIndex = 0;
            this.LUsername.Text = "Username";
            // 
            // LPassword
            // 
            this.LPassword.AutoSize = true;
            this.LPassword.Location = new System.Drawing.Point(32, 62);
            this.LPassword.Name = "LPassword";
            this.LPassword.Size = new System.Drawing.Size(69, 17);
            this.LPassword.TabIndex = 1;
            this.LPassword.Text = "Password";
            // 
            // TBUsername
            // 
            this.TBUsername.Location = new System.Drawing.Point(107, 24);
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Size = new System.Drawing.Size(160, 22);
            this.TBUsername.TabIndex = 2;
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(107, 57);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(160, 22);
            this.TBPassword.TabIndex = 3;
            // 
            // BSignUp
            // 
            this.BSignUp.Location = new System.Drawing.Point(16, 104);
            this.BSignUp.Name = "BSignUp";
            this.BSignUp.Size = new System.Drawing.Size(117, 35);
            this.BSignUp.TabIndex = 4;
            this.BSignUp.Text = "SignUp";
            this.BSignUp.UseVisualStyleBackColor = true;
            this.BSignUp.Click += new System.EventHandler(this.BSignUp_Click);
            // 
            // BSingIn
            // 
            this.BSingIn.Location = new System.Drawing.Point(150, 104);
            this.BSingIn.Name = "BSingIn";
            this.BSingIn.Size = new System.Drawing.Size(117, 35);
            this.BSingIn.TabIndex = 5;
            this.BSingIn.Text = "SignIn";
            this.BSingIn.UseVisualStyleBackColor = true;
            this.BSingIn.Click += new System.EventHandler(this.BSingIn_Click);
            // 
            // RadStudent
            // 
            this.RadStudent.AutoSize = true;
            this.RadStudent.Location = new System.Drawing.Point(283, 43);
            this.RadStudent.Name = "RadStudent";
            this.RadStudent.Size = new System.Drawing.Size(78, 21);
            this.RadStudent.TabIndex = 6;
            this.RadStudent.TabStop = true;
            this.RadStudent.Text = "Student";
            this.RadStudent.UseVisualStyleBackColor = true;
            // 
            // RadProfesor
            // 
            this.RadProfesor.AutoSize = true;
            this.RadProfesor.Location = new System.Drawing.Point(283, 70);
            this.RadProfesor.Name = "RadProfesor";
            this.RadProfesor.Size = new System.Drawing.Size(83, 21);
            this.RadProfesor.TabIndex = 7;
            this.RadProfesor.TabStop = true;
            this.RadProfesor.Text = "Profesor";
            this.RadProfesor.UseVisualStyleBackColor = true;
            // 
            // RadSecretariat
            // 
            this.RadSecretariat.AutoSize = true;
            this.RadSecretariat.Location = new System.Drawing.Point(283, 97);
            this.RadSecretariat.Name = "RadSecretariat";
            this.RadSecretariat.Size = new System.Drawing.Size(98, 21);
            this.RadSecretariat.TabIndex = 8;
            this.RadSecretariat.TabStop = true;
            this.RadSecretariat.Text = "Secretariat";
            this.RadSecretariat.UseVisualStyleBackColor = true;
            // 
            // FLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 161);
            this.Controls.Add(this.RadSecretariat);
            this.Controls.Add(this.RadProfesor);
            this.Controls.Add(this.RadStudent);
            this.Controls.Add(this.BSingIn);
            this.Controls.Add(this.BSignUp);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBUsername);
            this.Controls.Add(this.LPassword);
            this.Controls.Add(this.LUsername);
            this.Name = "FLogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.FLogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LUsername;
        public System.Windows.Forms.Label LPassword;
        public System.Windows.Forms.TextBox TBUsername;
        public System.Windows.Forms.TextBox TBPassword;
        public System.Windows.Forms.Button BSignUp;
        public System.Windows.Forms.Button BSingIn;
        public System.Windows.Forms.RadioButton RadStudent;
        public System.Windows.Forms.RadioButton RadProfesor;
        public System.Windows.Forms.RadioButton RadSecretariat;
    }
}

