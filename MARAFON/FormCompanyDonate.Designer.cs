
namespace MARAFON
{
    partial class FormCompanyDonate
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
            this.listViewInfoCompany = new System.Windows.Forms.ListView();
            this.columnHeaderLogo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelInfoCompany = new System.Windows.Forms.Label();
            this.labelTitleForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewInfoCompany
            // 
            this.listViewInfoCompany.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listViewInfoCompany.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewInfoCompany.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderLogo,
            this.columnHeaderName,
            this.columnHeaderDescription});
            this.listViewInfoCompany.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewInfoCompany.HideSelection = false;
            this.listViewInfoCompany.Location = new System.Drawing.Point(13, 87);
            this.listViewInfoCompany.Margin = new System.Windows.Forms.Padding(4);
            this.listViewInfoCompany.Name = "listViewInfoCompany";
            this.listViewInfoCompany.Scrollable = false;
            this.listViewInfoCompany.Size = new System.Drawing.Size(679, 319);
            this.listViewInfoCompany.TabIndex = 18;
            this.listViewInfoCompany.UseCompatibleStateImageBehavior = false;
            this.listViewInfoCompany.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderLogo
            // 
            this.columnHeaderLogo.Text = "Логотип";
            this.columnHeaderLogo.Width = 186;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Наименование";
            this.columnHeaderName.Width = 135;
            // 
            // columnHeaderDescription
            // 
            this.columnHeaderDescription.Text = "Описание";
            this.columnHeaderDescription.Width = 223;
            // 
            // labelInfoCompany
            // 
            this.labelInfoCompany.AutoSize = true;
            this.labelInfoCompany.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfoCompany.Location = new System.Drawing.Point(69, 47);
            this.labelInfoCompany.Name = "labelInfoCompany";
            this.labelInfoCompany.Size = new System.Drawing.Size(553, 30);
            this.labelInfoCompany.TabIndex = 17;
            this.labelInfoCompany.Text = "Это - список всех благотворительных учреждений, которые поддерживаются в\r\nMaratho" +
    "n Skills 2016. Спасибо за помощь вы поддерживаете их, спонсируя бегунов";
            this.labelInfoCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitleForm
            // 
            this.labelTitleForm.AutoSize = true;
            this.labelTitleForm.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleForm.Location = new System.Drawing.Point(145, 5);
            this.labelTitleForm.Name = "labelTitleForm";
            this.labelTitleForm.Size = new System.Drawing.Size(442, 24);
            this.labelTitleForm.TabIndex = 16;
            this.labelTitleForm.Text = "Список благотворительных организаций";
            this.labelTitleForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCompanyDonate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 413);
            this.Controls.Add(this.listViewInfoCompany);
            this.Controls.Add(this.labelInfoCompany);
            this.Controls.Add(this.labelTitleForm);
            this.Name = "FormCompanyDonate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Благотворительные организации";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewInfoCompany;
        private System.Windows.Forms.ColumnHeader columnHeaderLogo;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderDescription;
        private System.Windows.Forms.Label labelInfoCompany;
        private System.Windows.Forms.Label labelTitleForm;
    }
}