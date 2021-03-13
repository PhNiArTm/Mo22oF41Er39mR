
namespace MARAFON
{
    partial class FormLoadVolunteer
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
            this.buttonImportData = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBoxNamFile = new System.Windows.Forms.TextBox();
            this.labelCSVName = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonLoadDB = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelResultAdd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonImportData
            // 
            this.buttonImportData.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonImportData.Location = new System.Drawing.Point(323, 114);
            this.buttonImportData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonImportData.Name = "buttonImportData";
            this.buttonImportData.Size = new System.Drawing.Size(161, 33);
            this.buttonImportData.TabIndex = 0;
            this.buttonImportData.Text = "Импортировать";
            this.buttonImportData.UseVisualStyleBackColor = true;
            this.buttonImportData.Click += new System.EventHandler(this.buttonImportData_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // textBoxNamFile
            // 
            this.textBoxNamFile.Enabled = false;
            this.textBoxNamFile.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNamFile.Location = new System.Drawing.Point(24, 114);
            this.textBoxNamFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNamFile.Multiline = true;
            this.textBoxNamFile.Name = "textBoxNamFile";
            this.textBoxNamFile.Size = new System.Drawing.Size(277, 32);
            this.textBoxNamFile.TabIndex = 1;
            // 
            // labelCSVName
            // 
            this.labelCSVName.AutoSize = true;
            this.labelCSVName.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCSVName.Location = new System.Drawing.Point(20, 89);
            this.labelCSVName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCSVName.Name = "labelCSVName";
            this.labelCSVName.Size = new System.Drawing.Size(200, 22);
            this.labelCSVName.TabIndex = 2;
            this.labelCSVName.Text = "CSV файл волонтеров";
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(59, 11);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(419, 59);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Загрузка волонтеров";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLoadDB
            // 
            this.buttonLoadDB.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoadDB.Location = new System.Drawing.Point(24, 159);
            this.buttonLoadDB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLoadDB.Name = "buttonLoadDB";
            this.buttonLoadDB.Size = new System.Drawing.Size(137, 37);
            this.buttonLoadDB.TabIndex = 9;
            this.buttonLoadDB.Text = "Загрузить";
            this.buttonLoadDB.UseVisualStyleBackColor = true;
            this.buttonLoadDB.Click += new System.EventHandler(this.buttonLoadDB_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(169, 159);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(133, 37);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelResultAdd
            // 
            this.labelResultAdd.AutoSize = true;
            this.labelResultAdd.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResultAdd.Location = new System.Drawing.Point(20, 210);
            this.labelResultAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResultAdd.Name = "labelResultAdd";
            this.labelResultAdd.Size = new System.Drawing.Size(160, 18);
            this.labelResultAdd.TabIndex = 11;
            this.labelResultAdd.Text = "Успешно добавлено: ";
            this.labelResultAdd.Visible = false;
            // 
            // FormLoadVolunteer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 288);
            this.Controls.Add(this.labelResultAdd);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonLoadDB);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelCSVName);
            this.Controls.Add(this.textBoxNamFile);
            this.Controls.Add(this.buttonImportData);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormLoadVolunteer";
            this.Text = "FormLoadVolunteer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLoadVolunteer_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonImportData;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox textBoxNamFile;
        private System.Windows.Forms.Label labelCSVName;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonLoadDB;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelResultAdd;
    }
}