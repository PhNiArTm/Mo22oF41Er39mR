
namespace MARAFON
{
    partial class FormVolunteers
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.LabelMarathon = new System.Windows.Forms.Label();
            this.labelDowload = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewVolonters = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            this.labelManagingМolunteers = new System.Windows.Forms.Label();
            this.labelKolvoVolonterov = new System.Windows.Forms.Label();
            this.labelSearchPo = new System.Windows.Forms.Label();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.labelNumberOfVolunteers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(456, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(105, 117);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // LabelMarathon
            // 
            this.LabelMarathon.AutoSize = true;
            this.LabelMarathon.Location = new System.Drawing.Point(93, 17);
            this.LabelMarathon.Name = "LabelMarathon";
            this.LabelMarathon.Size = new System.Drawing.Size(106, 13);
            this.LabelMarathon.TabIndex = 3;
            this.LabelMarathon.Text = "Marathon Skills 2016";
            // 
            // labelDowload
            // 
            this.labelDowload.AutoSize = true;
            this.labelDowload.Location = new System.Drawing.Point(439, 74);
            this.labelDowload.Name = "labelDowload";
            this.labelDowload.Size = new System.Drawing.Size(54, 13);
            this.labelDowload.TabIndex = 4;
            this.labelDowload.Text = "Загрузка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Сортировка и фильтрация";
            // 
            // listViewVolonters
            // 
            this.listViewVolonters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewVolonters.FullRowSelect = true;
            this.listViewVolonters.GridLines = true;
            this.listViewVolonters.HideSelection = false;
            this.listViewVolonters.Location = new System.Drawing.Point(12, 166);
            this.listViewVolonters.Name = "listViewVolonters";
            this.listViewVolonters.Size = new System.Drawing.Size(519, 230);
            this.listViewVolonters.TabIndex = 6;
            this.listViewVolonters.UseCompatibleStateImageBehavior = false;
            this.listViewVolonters.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имя";
            this.columnHeader1.Width = 124;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Фамилия";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Страна";
            this.columnHeader3.Width = 106;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Пол";
            this.columnHeader4.Width = 115;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(398, 90);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Загрузка волонтеров";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // labelManagingМolunteers
            // 
            this.labelManagingМolunteers.AutoSize = true;
            this.labelManagingМolunteers.Location = new System.Drawing.Point(203, 40);
            this.labelManagingМolunteers.Name = "labelManagingМolunteers";
            this.labelManagingМolunteers.Size = new System.Drawing.Size(139, 13);
            this.labelManagingМolunteers.TabIndex = 3;
            this.labelManagingМolunteers.Text = "Управление волонтерами";
            // 
            // labelKolvoVolonterov
            // 
            this.labelKolvoVolonterov.AutoSize = true;
            this.labelKolvoVolonterov.Location = new System.Drawing.Point(166, 150);
            this.labelKolvoVolonterov.Name = "labelKolvoVolonterov";
            this.labelKolvoVolonterov.Size = new System.Drawing.Size(102, 13);
            this.labelKolvoVolonterov.TabIndex = 4;
            this.labelKolvoVolonterov.Text = "Всего волонтеров:";
            // 
            // labelSearchPo
            // 
            this.labelSearchPo.AutoSize = true;
            this.labelSearchPo.Location = new System.Drawing.Point(9, 90);
            this.labelSearchPo.Name = "labelSearchPo";
            this.labelSearchPo.Size = new System.Drawing.Size(90, 13);
            this.labelSearchPo.TabIndex = 5;
            this.labelSearchPo.Text = "Сортировать по:";
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "Имя",
            "Фамилия",
            "Страна",
            "Пол"});
            this.comboBoxSort.Location = new System.Drawing.Point(105, 90);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(137, 21);
            this.comboBoxSort.TabIndex = 7;
            // 
            // labelNumberOfVolunteers
            // 
            this.labelNumberOfVolunteers.AutoSize = true;
            this.labelNumberOfVolunteers.Location = new System.Drawing.Point(274, 150);
            this.labelNumberOfVolunteers.Name = "labelNumberOfVolunteers";
            this.labelNumberOfVolunteers.Size = new System.Drawing.Size(0, 13);
            this.labelNumberOfVolunteers.TabIndex = 4;
            // 
            // FormVolunteers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 404);
            this.Controls.Add(this.comboBoxSort);
            this.Controls.Add(this.listViewVolonters);
            this.Controls.Add(this.labelSearchPo);
            this.Controls.Add(this.labelNumberOfVolunteers);
            this.Controls.Add(this.labelKolvoVolonterov);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelManagingМolunteers);
            this.Controls.Add(this.labelDowload);
            this.Controls.Add(this.LabelMarathon);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormVolunteers";
            this.Text = "FormVolunteers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label LabelMarathon;
        private System.Windows.Forms.Label labelDowload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewVolonters;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labelManagingМolunteers;
        private System.Windows.Forms.Label labelKolvoVolonterov;
        private System.Windows.Forms.Label labelSearchPo;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label labelNumberOfVolunteers;
    }
}