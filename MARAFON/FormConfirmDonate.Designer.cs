
namespace MARAFON
{
    partial class FormConfirmDonate
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
            this.labelSponsoreTitle = new System.Windows.Forms.Label();
            this.labelSponsoreInfo = new System.Windows.Forms.Label();
            this.labelNameRunner = new System.Windows.Forms.Label();
            this.labelFund = new System.Windows.Forms.Label();
            this.labelCountDonate = new System.Windows.Forms.Label();
            this.buttonBMR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSponsoreTitle
            // 
            this.labelSponsoreTitle.AutoSize = true;
            this.labelSponsoreTitle.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSponsoreTitle.Location = new System.Drawing.Point(28, 19);
            this.labelSponsoreTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSponsoreTitle.Name = "labelSponsoreTitle";
            this.labelSponsoreTitle.Size = new System.Drawing.Size(493, 28);
            this.labelSponsoreTitle.TabIndex = 1;
            this.labelSponsoreTitle.Text = "Спасибо за вашу спонсорскую поддержку";
            // 
            // labelSponsoreInfo
            // 
            this.labelSponsoreInfo.AutoSize = true;
            this.labelSponsoreInfo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSponsoreInfo.Location = new System.Drawing.Point(58, 60);
            this.labelSponsoreInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSponsoreInfo.Name = "labelSponsoreInfo";
            this.labelSponsoreInfo.Size = new System.Drawing.Size(434, 30);
            this.labelSponsoreInfo.TabIndex = 2;
            this.labelSponsoreInfo.Text = "Спасибо за вашу поддержку бегуна в Marathon Skills 2016\r\nВаше пожертвование пойде" +
    "т в его благотворительную организацию\r\n";
            this.labelSponsoreInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNameRunner
            // 
            this.labelNameRunner.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameRunner.Location = new System.Drawing.Point(11, 113);
            this.labelNameRunner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNameRunner.Name = "labelNameRunner";
            this.labelNameRunner.Size = new System.Drawing.Size(542, 37);
            this.labelNameRunner.TabIndex = 3;
            this.labelNameRunner.Text = "Иван Прудов(204) из Russia";
            this.labelNameRunner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFund
            // 
            this.labelFund.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFund.Location = new System.Drawing.Point(11, 161);
            this.labelFund.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFund.Name = "labelFund";
            this.labelFund.Size = new System.Drawing.Size(542, 37);
            this.labelFund.TabIndex = 4;
            this.labelFund.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCountDonate
            // 
            this.labelCountDonate.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountDonate.Location = new System.Drawing.Point(11, 207);
            this.labelCountDonate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCountDonate.Name = "labelCountDonate";
            this.labelCountDonate.Size = new System.Drawing.Size(542, 75);
            this.labelCountDonate.TabIndex = 5;
            this.labelCountDonate.Text = "$0.00";
            this.labelCountDonate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBMR
            // 
            this.buttonBMR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBMR.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonBMR.FlatAppearance.BorderSize = 2;
            this.buttonBMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBMR.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBMR.Location = new System.Drawing.Point(173, 284);
            this.buttonBMR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBMR.Name = "buttonBMR";
            this.buttonBMR.Size = new System.Drawing.Size(226, 56);
            this.buttonBMR.TabIndex = 7;
            this.buttonBMR.Text = "Назад";
            this.buttonBMR.UseVisualStyleBackColor = false;
            // 
            // FormConfirmDonate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(564, 372);
            this.Controls.Add(this.buttonBMR);
            this.Controls.Add(this.labelCountDonate);
            this.Controls.Add(this.labelFund);
            this.Controls.Add(this.labelNameRunner);
            this.Controls.Add(this.labelSponsoreInfo);
            this.Controls.Add(this.labelSponsoreTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormConfirmDonate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подтверждение спонсорства";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSponsoreTitle;
        private System.Windows.Forms.Label labelSponsoreInfo;
        private System.Windows.Forms.Label labelNameRunner;
        private System.Windows.Forms.Label labelFund;
        private System.Windows.Forms.Label labelCountDonate;
        private System.Windows.Forms.Button buttonBMR;
    }
}