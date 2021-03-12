
namespace MARAFON
{
    partial class FormMySponsore
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
            this.listViewSponsorsInfo = new System.Windows.Forms.ListView();
            this.columnHeaderSponsore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelSponsoreTitle = new System.Windows.Forms.Label();
            this.labelSponsoreInfo = new System.Windows.Forms.Label();
            this.labelNameCompany = new System.Windows.Forms.Label();
            this.pictureBoxLogoCompany = new System.Windows.Forms.PictureBox();
            this.labelFullDonate = new System.Windows.Forms.Label();
            this.labelFullMoney = new System.Windows.Forms.Label();
            this.buttonWatchInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewSponsorsInfo
            // 
            this.listViewSponsorsInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSponsore,
            this.columnHeaderAmount});
            this.listViewSponsorsInfo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewSponsorsInfo.HideSelection = false;
            this.listViewSponsorsInfo.Location = new System.Drawing.Point(427, 154);
            this.listViewSponsorsInfo.Name = "listViewSponsorsInfo";
            this.listViewSponsorsInfo.Size = new System.Drawing.Size(345, 162);
            this.listViewSponsorsInfo.TabIndex = 0;
            this.listViewSponsorsInfo.UseCompatibleStateImageBehavior = false;
            this.listViewSponsorsInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderSponsore
            // 
            this.columnHeaderSponsore.Text = "Спонсор";
            this.columnHeaderSponsore.Width = 133;
            // 
            // columnHeaderAmount
            // 
            this.columnHeaderAmount.Text = "Взнос";
            this.columnHeaderAmount.Width = 110;
            // 
            // labelSponsoreTitle
            // 
            this.labelSponsoreTitle.AutoSize = true;
            this.labelSponsoreTitle.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSponsoreTitle.Location = new System.Drawing.Point(287, 11);
            this.labelSponsoreTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSponsoreTitle.Name = "labelSponsoreTitle";
            this.labelSponsoreTitle.Size = new System.Drawing.Size(233, 38);
            this.labelSponsoreTitle.TabIndex = 7;
            this.labelSponsoreTitle.Text = "Мои спонсоры";
            // 
            // labelSponsoreInfo
            // 
            this.labelSponsoreInfo.AutoSize = true;
            this.labelSponsoreInfo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSponsoreInfo.Location = new System.Drawing.Point(134, 59);
            this.labelSponsoreInfo.Name = "labelSponsoreInfo";
            this.labelSponsoreInfo.Size = new System.Drawing.Size(504, 20);
            this.labelSponsoreInfo.TabIndex = 8;
            this.labelSponsoreInfo.Text = "Здесь показаны все ваши спонсоры в Marathon Skills 2016";
            this.labelSponsoreInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNameCompany
            // 
            this.labelNameCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNameCompany.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameCompany.Location = new System.Drawing.Point(27, 135);
            this.labelNameCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameCompany.Name = "labelNameCompany";
            this.labelNameCompany.Size = new System.Drawing.Size(303, 28);
            this.labelNameCompany.TabIndex = 9;
            this.labelNameCompany.Text = "Clara";
            this.labelNameCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogoCompany
            // 
            this.pictureBoxLogoCompany.Location = new System.Drawing.Point(83, 173);
            this.pictureBoxLogoCompany.Name = "pictureBoxLogoCompany";
            this.pictureBoxLogoCompany.Size = new System.Drawing.Size(175, 119);
            this.pictureBoxLogoCompany.TabIndex = 10;
            this.pictureBoxLogoCompany.TabStop = false;
            // 
            // labelFullDonate
            // 
            this.labelFullDonate.AutoSize = true;
            this.labelFullDonate.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFullDonate.Location = new System.Drawing.Point(552, 321);
            this.labelFullDonate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFullDonate.Name = "labelFullDonate";
            this.labelFullDonate.Size = new System.Drawing.Size(90, 28);
            this.labelFullDonate.TabIndex = 12;
            this.labelFullDonate.Text = "Всего:";
            // 
            // labelFullMoney
            // 
            this.labelFullMoney.AutoSize = true;
            this.labelFullMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFullMoney.Location = new System.Drawing.Point(642, 324);
            this.labelFullMoney.Name = "labelFullMoney";
            this.labelFullMoney.Size = new System.Drawing.Size(50, 24);
            this.labelFullMoney.TabIndex = 13;
            this.labelFullMoney.Text = "$680";
            // 
            // buttonWatchInfo
            // 
            this.buttonWatchInfo.Location = new System.Drawing.Point(80, 312);
            this.buttonWatchInfo.Name = "buttonWatchInfo";
            this.buttonWatchInfo.Size = new System.Drawing.Size(184, 45);
            this.buttonWatchInfo.TabIndex = 14;
            this.buttonWatchInfo.Text = "Описание компании";
            this.buttonWatchInfo.UseVisualStyleBackColor = true;
            this.buttonWatchInfo.Click += new System.EventHandler(this.buttonWatchInfo_Click);
            // 
            // FormMySponsore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 455);
            this.Controls.Add(this.buttonWatchInfo);
            this.Controls.Add(this.labelFullMoney);
            this.Controls.Add(this.labelFullDonate);
            this.Controls.Add(this.pictureBoxLogoCompany);
            this.Controls.Add(this.labelNameCompany);
            this.Controls.Add(this.labelSponsoreInfo);
            this.Controls.Add(this.labelSponsoreTitle);
            this.Controls.Add(this.listViewSponsorsInfo);
            this.Name = "FormMySponsore";
            this.Text = "FormMySponsore";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoCompany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewSponsorsInfo;
        private System.Windows.Forms.ColumnHeader columnHeaderSponsore;
        private System.Windows.Forms.ColumnHeader columnHeaderAmount;
        private System.Windows.Forms.Label labelSponsoreTitle;
        private System.Windows.Forms.Label labelSponsoreInfo;
        private System.Windows.Forms.Label labelNameCompany;
        private System.Windows.Forms.PictureBox pictureBoxLogoCompany;
        private System.Windows.Forms.Label labelFullDonate;
        private System.Windows.Forms.Label labelFullMoney;
        private System.Windows.Forms.Button buttonWatchInfo;
    }
}