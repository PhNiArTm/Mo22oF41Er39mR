
namespace MARAFON
{
    partial class FormMenageCharity
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
            this.labelMARATHON = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listViewCompany = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMARATHON
            // 
            this.labelMARATHON.AutoSize = true;
            this.labelMARATHON.Location = new System.Drawing.Point(124, 21);
            this.labelMARATHON.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMARATHON.Name = "labelMARATHON";
            this.labelMARATHON.Size = new System.Drawing.Size(173, 17);
            this.labelMARATHON.TabIndex = 0;
            this.labelMARATHON.Text = "MARATHON SKILLS 2016";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(252, 55);
            this.labelText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(337, 17);
            this.labelText.TabIndex = 1;
            this.labelText.Text = "Управление благотворительными организациями";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(16, 15);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 28);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(16, 89);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(168, 36);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "+ Добавить нового";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listViewCompany
            // 
            this.listViewCompany.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewCompany.FullRowSelect = true;
            this.listViewCompany.GridLines = true;
            this.listViewCompany.HideSelection = false;
            this.listViewCompany.Location = new System.Drawing.Point(16, 132);
            this.listViewCompany.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewCompany.Name = "listViewCompany";
            this.listViewCompany.Size = new System.Drawing.Size(907, 516);
            this.listViewCompany.TabIndex = 4;
            this.listViewCompany.UseCompatibleStateImageBehavior = false;
            this.listViewCompany.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Лого";
            this.columnHeader1.Width = 149;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Наименование";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Описание";
            this.columnHeader3.Width = 204;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(797, 89);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(127, 36);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // FormMenageCharity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 655);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.listViewCompany);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labelMARATHON);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMenageCharity";
            this.Text = "Marathon Skills 2016 – Manage charities";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMARATHON;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listViewCompany;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonEdit;
    }
}