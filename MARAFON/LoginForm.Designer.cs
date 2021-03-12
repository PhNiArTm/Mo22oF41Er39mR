
namespace MARAFON
{
    partial class FormLogin
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
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonMainCancel = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelFormAuth = new System.Windows.Forms.Label();
            this.labelAuthInfo = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelMarathonSkills2016 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(210, 143);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(169, 20);
            this.textBoxEmail.TabIndex = 0;
            this.textBoxEmail.Text = "aaron.whalen@hr.gov";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(210, 185);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(169, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Text = "Aj4fC2477";
            // 
            // buttonMainCancel
            // 
            this.buttonMainCancel.Location = new System.Drawing.Point(9, 10);
            this.buttonMainCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMainCancel.Name = "buttonMainCancel";
            this.buttonMainCancel.Size = new System.Drawing.Size(56, 19);
            this.buttonMainCancel.TabIndex = 2;
            this.buttonMainCancel.Text = "Назад";
            this.buttonMainCancel.UseVisualStyleBackColor = true;
            this.buttonMainCancel.Click += new System.EventHandler(this.buttonMainCancel_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(193, 238);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(56, 19);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Логин";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(322, 238);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(56, 19);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelFormAuth
            // 
            this.labelFormAuth.AutoSize = true;
            this.labelFormAuth.Location = new System.Drawing.Point(236, 62);
            this.labelFormAuth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFormAuth.Name = "labelFormAuth";
            this.labelFormAuth.Size = new System.Drawing.Size(112, 13);
            this.labelFormAuth.TabIndex = 5;
            this.labelFormAuth.Text = "Форма авторизации";
            // 
            // labelAuthInfo
            // 
            this.labelAuthInfo.AutoSize = true;
            this.labelAuthInfo.Location = new System.Drawing.Point(64, 96);
            this.labelAuthInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAuthInfo.Name = "labelAuthInfo";
            this.labelAuthInfo.Size = new System.Drawing.Size(472, 13);
            this.labelAuthInfo.TabIndex = 6;
            this.labelAuthInfo.Text = "Пожалуйста, авторизуйтесь в системе, используя ваш адрес электронной почты и паро" +
    "ль.";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(150, 147);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "Email:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(150, 188);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "Password:";
            // 
            // labelMarathonSkills2016
            // 
            this.labelMarathonSkills2016.AutoSize = true;
            this.labelMarathonSkills2016.Location = new System.Drawing.Point(112, 15);
            this.labelMarathonSkills2016.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMarathonSkills2016.Name = "labelMarathonSkills2016";
            this.labelMarathonSkills2016.Size = new System.Drawing.Size(135, 13);
            this.labelMarathonSkills2016.TabIndex = 9;
            this.labelMarathonSkills2016.Text = "MARATHON SKILLS 2016";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 324);
            this.Controls.Add(this.labelMarathonSkills2016);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelAuthInfo);
            this.Controls.Add(this.labelFormAuth);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonMainCancel);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аворизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonMainCancel;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelFormAuth;
        private System.Windows.Forms.Label labelAuthInfo;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelMarathonSkills2016;
    }
}