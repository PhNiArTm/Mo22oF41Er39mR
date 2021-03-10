
namespace MARAFON
{
    partial class FormContactCoordinator
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
            this.labelTitleForm = new System.Windows.Forms.Label();
            this.labelInfoForm = new System.Windows.Forms.Label();
            this.labelTitleEmail = new System.Windows.Forms.Label();
            this.labelContactCoordinators = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitleForm
            // 
            this.labelTitleForm.AutoSize = true;
            this.labelTitleForm.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleForm.Location = new System.Drawing.Point(134, 15);
            this.labelTitleForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitleForm.Name = "labelTitleForm";
            this.labelTitleForm.Size = new System.Drawing.Size(161, 37);
            this.labelTitleForm.TabIndex = 16;
            this.labelTitleForm.Text = "Контакты";
            // 
            // labelInfoForm
            // 
            this.labelInfoForm.AutoSize = true;
            this.labelInfoForm.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfoForm.Location = new System.Drawing.Point(9, 65);
            this.labelInfoForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfoForm.Name = "labelInfoForm";
            this.labelInfoForm.Size = new System.Drawing.Size(406, 30);
            this.labelInfoForm.TabIndex = 17;
            this.labelInfoForm.Text = "Для получения дополнительной информации свяжитесь с одним\r\nиз указаных ниже коорд" +
    "инаторов\r\n";
            this.labelInfoForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTitleEmail
            // 
            this.labelTitleEmail.AutoSize = true;
            this.labelTitleEmail.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleEmail.Location = new System.Drawing.Point(9, 110);
            this.labelTitleEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitleEmail.Name = "labelTitleEmail";
            this.labelTitleEmail.Size = new System.Drawing.Size(252, 26);
            this.labelTitleEmail.TabIndex = 18;
            this.labelTitleEmail.Text = "Почта координаторов:";
            // 
            // labelContactCoordinators
            // 
            this.labelContactCoordinators.AutoSize = true;
            this.labelContactCoordinators.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelContactCoordinators.Location = new System.Drawing.Point(10, 146);
            this.labelContactCoordinators.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContactCoordinators.Name = "labelContactCoordinators";
            this.labelContactCoordinators.Size = new System.Drawing.Size(168, 15);
            this.labelContactCoordinators.TabIndex = 19;
            this.labelContactCoordinators.Text = "artis.butorin@yandex.ru\r\n";
            this.labelContactCoordinators.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormContactCoordinator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(429, 309);
            this.Controls.Add(this.labelContactCoordinators);
            this.Controls.Add(this.labelTitleEmail);
            this.Controls.Add(this.labelInfoForm);
            this.Controls.Add(this.labelTitleForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormContactCoordinator";
            this.Text = "FormContactCoordinator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitleForm;
        private System.Windows.Forms.Label labelInfoForm;
        private System.Windows.Forms.Label labelTitleEmail;
        private System.Windows.Forms.Label labelContactCoordinators;
    }
}