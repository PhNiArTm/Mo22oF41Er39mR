
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
            this.buttonBack.Location = new System.Drawing.Point(16, 15);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 28);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(608, 15);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(100, 28);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(140, 144);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 28);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // LabelMarathon
            // 
            this.LabelMarathon.AutoSize = true;
            this.LabelMarathon.Location = new System.Drawing.Point(124, 21);
            this.LabelMarathon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelMarathon.Name = "LabelMarathon";
            this.LabelMarathon.Size = new System.Drawing.Size(140, 17);
            this.LabelMarathon.TabIndex = 3;
            this.LabelMarathon.Text = "Marathon Skills 2016";
            // 
            // labelDowload
            // 
            this.labelDowload.AutoSize = true;
            this.labelDowload.Location = new System.Drawing.Point(585, 91);
            this.labelDowload.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDowload.Name = "labelDowload";
            this.labelDowload.Size = new System.Drawing.Size(67, 17);
            this.labelDowload.TabIndex = 4;
            this.labelDowload.Text = "Загрузка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 17);
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
            this.listViewVolonters.Location = new System.Drawing.Point(16, 204);
            this.listViewVolonters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewVolonters.Name = "listViewVolonters";
            this.listViewVolonters.Size = new System.Drawing.Size(691, 282);
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
            this.button4.Location = new System.Drawing.Point(531, 111);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 28);
            this.button4.TabIndex = 2;
            this.button4.Text = "Загрузка волонтеров";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // labelManagingМolunteers
            // 
            this.labelManagingМolunteers.AutoSize = true;
            this.labelManagingМolunteers.Location = new System.Drawing.Point(271, 49);
            this.labelManagingМolunteers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelManagingМolunteers.Name = "labelManagingМolunteers";
            this.labelManagingМolunteers.Size = new System.Drawing.Size(179, 17);
            this.labelManagingМolunteers.TabIndex = 3;
            this.labelManagingМolunteers.Text = "Управление волонтерами";
            // 
            // labelKolvoVolonterov
            // 
            this.labelKolvoVolonterov.AutoSize = true;
            this.labelKolvoVolonterov.Location = new System.Drawing.Point(221, 185);
            this.labelKolvoVolonterov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKolvoVolonterov.Name = "labelKolvoVolonterov";
            this.labelKolvoVolonterov.Size = new System.Drawing.Size(130, 17);
            this.labelKolvoVolonterov.TabIndex = 4;
            this.labelKolvoVolonterov.Text = "Всего волонтеров:";
            // 
            // labelSearchPo
            // 
            this.labelSearchPo.AutoSize = true;
            this.labelSearchPo.Location = new System.Drawing.Point(12, 111);
            this.labelSearchPo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearchPo.Name = "labelSearchPo";
            this.labelSearchPo.Size = new System.Drawing.Size(117, 17);
            this.labelSearchPo.TabIndex = 5;
            this.labelSearchPo.Text = "Сортировать по:";
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "Фамилия",
            "Имя",
            "Страна",
            "Пол"});
            this.comboBoxSort.Location = new System.Drawing.Point(140, 111);
            this.comboBoxSort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(181, 24);
            this.comboBoxSort.TabIndex = 7;
            // 
            // labelNumberOfVolunteers
            // 
            this.labelNumberOfVolunteers.AutoSize = true;
            this.labelNumberOfVolunteers.Location = new System.Drawing.Point(365, 185);
            this.labelNumberOfVolunteers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumberOfVolunteers.Name = "labelNumberOfVolunteers";
            this.labelNumberOfVolunteers.Size = new System.Drawing.Size(0, 17);
            this.labelNumberOfVolunteers.TabIndex = 4;
            // 
            // FormVolunteers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 497);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormVolunteers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVolunteers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormVolunteers_FormClosed);
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