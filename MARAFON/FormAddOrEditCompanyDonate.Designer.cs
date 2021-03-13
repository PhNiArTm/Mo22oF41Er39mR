
namespace MARAFON
{
    partial class FormAddOrEditCompanyDonate
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
            this.labelNameCompany = new System.Windows.Forms.Label();
            this.labelDescriptionCompany = new System.Windows.Forms.Label();
            this.textBoxNameCompany = new System.Windows.Forms.TextBox();
            this.textBoxDescriptionCompany = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelSponsoreTitle = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNameCompany
            // 
            this.labelNameCompany.AutoSize = true;
            this.labelNameCompany.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameCompany.Location = new System.Drawing.Point(12, 100);
            this.labelNameCompany.Name = "labelNameCompany";
            this.labelNameCompany.Size = new System.Drawing.Size(142, 23);
            this.labelNameCompany.TabIndex = 0;
            this.labelNameCompany.Text = "Наименование";
            // 
            // labelDescriptionCompany
            // 
            this.labelDescriptionCompany.AutoSize = true;
            this.labelDescriptionCompany.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescriptionCompany.Location = new System.Drawing.Point(12, 174);
            this.labelDescriptionCompany.Name = "labelDescriptionCompany";
            this.labelDescriptionCompany.Size = new System.Drawing.Size(98, 23);
            this.labelDescriptionCompany.TabIndex = 1;
            this.labelDescriptionCompany.Text = "Описание";
            // 
            // textBoxNameCompany
            // 
            this.textBoxNameCompany.Location = new System.Drawing.Point(16, 126);
            this.textBoxNameCompany.Multiline = true;
            this.textBoxNameCompany.Name = "textBoxNameCompany";
            this.textBoxNameCompany.Size = new System.Drawing.Size(241, 34);
            this.textBoxNameCompany.TabIndex = 2;
            // 
            // textBoxDescriptionCompany
            // 
            this.textBoxDescriptionCompany.Location = new System.Drawing.Point(16, 200);
            this.textBoxDescriptionCompany.Multiline = true;
            this.textBoxDescriptionCompany.Name = "textBoxDescriptionCompany";
            this.textBoxDescriptionCompany.Size = new System.Drawing.Size(421, 178);
            this.textBoxDescriptionCompany.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(282, 399);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(139, 44);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelSponsoreTitle
            // 
            this.labelSponsoreTitle.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSponsoreTitle.Location = new System.Drawing.Point(178, 9);
            this.labelSponsoreTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSponsoreTitle.Name = "labelSponsoreTitle";
            this.labelSponsoreTitle.Size = new System.Drawing.Size(475, 81);
            this.labelSponsoreTitle.TabIndex = 7;
            this.labelSponsoreTitle.Text = "Добавление/Редактирование благотворительных организаций";
            this.labelSponsoreTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(445, 399);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(139, 44);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(504, 189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 189);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FormAddOrEditCompanyDonate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelSponsoreTitle);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxDescriptionCompany);
            this.Controls.Add(this.textBoxNameCompany);
            this.Controls.Add(this.labelDescriptionCompany);
            this.Controls.Add(this.labelNameCompany);
            this.Name = "FormAddOrEditCompanyDonate";
            this.Text = "FormAddOrEditCompanyDonate";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameCompany;
        private System.Windows.Forms.Label labelDescriptionCompany;
        private System.Windows.Forms.TextBox textBoxNameCompany;
        private System.Windows.Forms.TextBox textBoxDescriptionCompany;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelSponsoreTitle;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}