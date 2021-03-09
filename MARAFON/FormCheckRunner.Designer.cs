
namespace MARAFON
{
    partial class FormCheckRunner
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
            this.buttonLastRunner = new System.Windows.Forms.Button();
            this.buttonNewRunner = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLastRunner
            // 
            this.buttonLastRunner.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLastRunner.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonLastRunner.FlatAppearance.BorderSize = 2;
            this.buttonLastRunner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLastRunner.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLastRunner.Location = new System.Drawing.Point(95, 31);
            this.buttonLastRunner.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLastRunner.Name = "buttonLastRunner";
            this.buttonLastRunner.Size = new System.Drawing.Size(296, 67);
            this.buttonLastRunner.TabIndex = 11;
            this.buttonLastRunner.Text = "Я участвовал ранее";
            this.buttonLastRunner.UseVisualStyleBackColor = false;
            // 
            // buttonNewRunner
            // 
            this.buttonNewRunner.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNewRunner.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonNewRunner.FlatAppearance.BorderSize = 2;
            this.buttonNewRunner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewRunner.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNewRunner.Location = new System.Drawing.Point(95, 116);
            this.buttonNewRunner.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNewRunner.Name = "buttonNewRunner";
            this.buttonNewRunner.Size = new System.Drawing.Size(296, 67);
            this.buttonNewRunner.TabIndex = 12;
            this.buttonNewRunner.Text = "Я новый участник";
            this.buttonNewRunner.UseVisualStyleBackColor = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonLogin.FlatAppearance.BorderSize = 2;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.Location = new System.Drawing.Point(346, 204);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(128, 39);
            this.buttonLogin.TabIndex = 13;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            // 
            // FormCheckRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(485, 292);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonNewRunner);
            this.Controls.Add(this.buttonLastRunner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormCheckRunner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проверка бегуна";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLastRunner;
        private System.Windows.Forms.Button buttonNewRunner;
        private System.Windows.Forms.Button buttonLogin;
    }
}