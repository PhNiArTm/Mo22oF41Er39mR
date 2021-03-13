
namespace MARAFON
{
    partial class FormMySponsors
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
            this.buttonWatchInfo = new System.Windows.Forms.Button();
            this.tableLayoutPanelAll = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelNameTag = new System.Windows.Forms.Label();
            this.labelEventTime = new System.Windows.Forms.Label();
            this.tableLayoutPanelCenter = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoCompany)).BeginInit();
            this.tableLayoutPanelAll.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanelCenter.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewSponsorsInfo
            // 
            this.listViewSponsorsInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSponsore,
            this.columnHeaderAmount});
            this.listViewSponsorsInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSponsorsInfo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewSponsorsInfo.HideSelection = false;
            this.listViewSponsorsInfo.Location = new System.Drawing.Point(224, 2);
            this.listViewSponsorsInfo.Margin = new System.Windows.Forms.Padding(2);
            this.listViewSponsorsInfo.Name = "listViewSponsorsInfo";
            this.tableLayoutPanel1.SetRowSpan(this.listViewSponsorsInfo, 2);
            this.listViewSponsorsInfo.Size = new System.Drawing.Size(452, 177);
            this.listViewSponsorsInfo.TabIndex = 0;
            this.listViewSponsorsInfo.UseCompatibleStateImageBehavior = false;
            this.listViewSponsorsInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderSponsore
            // 
            this.columnHeaderSponsore.Text = "Спонсор";
            this.columnHeaderSponsore.Width = 227;
            // 
            // columnHeaderAmount
            // 
            this.columnHeaderAmount.Text = "Взнос";
            this.columnHeaderAmount.Width = 110;
            // 
            // labelSponsoreTitle
            // 
            this.labelSponsoreTitle.AutoSize = true;
            this.tableLayoutPanelCenter.SetColumnSpan(this.labelSponsoreTitle, 2);
            this.labelSponsoreTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSponsoreTitle.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSponsoreTitle.Location = new System.Drawing.Point(2, 2);
            this.labelSponsoreTitle.Margin = new System.Windows.Forms.Padding(2);
            this.labelSponsoreTitle.Name = "labelSponsoreTitle";
            this.labelSponsoreTitle.Size = new System.Drawing.Size(674, 46);
            this.labelSponsoreTitle.TabIndex = 7;
            this.labelSponsoreTitle.Text = "Мои спонсоры";
            this.labelSponsoreTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSponsoreInfo
            // 
            this.labelSponsoreInfo.AutoSize = true;
            this.tableLayoutPanelCenter.SetColumnSpan(this.labelSponsoreInfo, 2);
            this.labelSponsoreInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSponsoreInfo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSponsoreInfo.Location = new System.Drawing.Point(2, 52);
            this.labelSponsoreInfo.Margin = new System.Windows.Forms.Padding(2);
            this.labelSponsoreInfo.Name = "labelSponsoreInfo";
            this.labelSponsoreInfo.Size = new System.Drawing.Size(674, 28);
            this.labelSponsoreInfo.TabIndex = 8;
            this.labelSponsoreInfo.Text = "Здесь показаны все ваши спонсоры в Marathon Skills 2016";
            this.labelSponsoreInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNameCompany
            // 
            this.labelNameCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNameCompany.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameCompany.Location = new System.Drawing.Point(2, 2);
            this.labelNameCompany.Margin = new System.Windows.Forms.Padding(2);
            this.labelNameCompany.Name = "labelNameCompany";
            this.labelNameCompany.Size = new System.Drawing.Size(218, 23);
            this.labelNameCompany.TabIndex = 9;
            this.labelNameCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogoCompany
            // 
            this.pictureBoxLogoCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogoCompany.Location = new System.Drawing.Point(2, 42);
            this.pictureBoxLogoCompany.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLogoCompany.Name = "pictureBoxLogoCompany";
            this.pictureBoxLogoCompany.Size = new System.Drawing.Size(218, 137);
            this.pictureBoxLogoCompany.TabIndex = 10;
            this.pictureBoxLogoCompany.TabStop = false;
            // 
            // labelFullDonate
            // 
            this.labelFullDonate.AutoSize = true;
            this.labelFullDonate.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFullDonate.Location = new System.Drawing.Point(232, 191);
            this.labelFullDonate.Margin = new System.Windows.Forms.Padding(10);
            this.labelFullDonate.Name = "labelFullDonate";
            this.labelFullDonate.Size = new System.Drawing.Size(70, 22);
            this.labelFullDonate.TabIndex = 12;
            this.labelFullDonate.Text = "Всего:";
            // 
            // buttonWatchInfo
            // 
            this.buttonWatchInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonWatchInfo.Location = new System.Drawing.Point(20, 201);
            this.buttonWatchInfo.Margin = new System.Windows.Forms.Padding(20);
            this.buttonWatchInfo.Name = "buttonWatchInfo";
            this.buttonWatchInfo.Size = new System.Drawing.Size(182, 34);
            this.buttonWatchInfo.TabIndex = 14;
            this.buttonWatchInfo.Text = "Описание компании";
            this.buttonWatchInfo.UseVisualStyleBackColor = true;
            this.buttonWatchInfo.Click += new System.EventHandler(this.buttonWatchInfo_Click);
            // 
            // tableLayoutPanelAll
            // 
            this.tableLayoutPanelAll.ColumnCount = 1;
            this.tableLayoutPanelAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAll.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanelAll.Controls.Add(this.labelEventTime, 0, 2);
            this.tableLayoutPanelAll.Controls.Add(this.tableLayoutPanelCenter, 0, 1);
            this.tableLayoutPanelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAll.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelAll.Name = "tableLayoutPanelAll";
            this.tableLayoutPanelAll.RowCount = 3;
            this.tableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelAll.Size = new System.Drawing.Size(678, 450);
            this.tableLayoutPanelAll.TabIndex = 16;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.buttonBack, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonLogout, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelNameTag, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(678, 67);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Silver;
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(10, 5);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(61, 34);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.TabStop = false;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Silver;
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLogout.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Location = new System.Drawing.Point(552, 5);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(116, 34);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.TabStop = false;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelNameTag
            // 
            this.labelNameTag.AutoSize = true;
            this.labelNameTag.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelNameTag.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelNameTag.Location = new System.Drawing.Point(83, 10);
            this.labelNameTag.Margin = new System.Windows.Forms.Padding(2, 10, 10, 0);
            this.labelNameTag.Name = "labelNameTag";
            this.labelNameTag.Size = new System.Drawing.Size(250, 57);
            this.labelNameTag.TabIndex = 1;
            this.labelNameTag.Text = "MARATHON SKILLS 2021";
            this.labelNameTag.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelEventTime
            // 
            this.labelEventTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelEventTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEventTime.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEventTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelEventTime.Location = new System.Drawing.Point(0, 404);
            this.labelEventTime.Margin = new System.Windows.Forms.Padding(0);
            this.labelEventTime.Name = "labelEventTime";
            this.labelEventTime.Size = new System.Drawing.Size(678, 46);
            this.labelEventTime.TabIndex = 1;
            this.labelEventTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelCenter
            // 
            this.tableLayoutPanelCenter.ColumnCount = 2;
            this.tableLayoutPanelCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.51033F));
            this.tableLayoutPanelCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.48967F));
            this.tableLayoutPanelCenter.Controls.Add(this.labelSponsoreTitle, 0, 0);
            this.tableLayoutPanelCenter.Controls.Add(this.labelSponsoreInfo, 0, 1);
            this.tableLayoutPanelCenter.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCenter.Location = new System.Drawing.Point(0, 67);
            this.tableLayoutPanelCenter.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelCenter.Name = "tableLayoutPanelCenter";
            this.tableLayoutPanelCenter.RowCount = 3;
            this.tableLayoutPanelCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.13353F));
            this.tableLayoutPanelCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.495549F));
            this.tableLayoutPanelCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.37092F));
            this.tableLayoutPanelCenter.Size = new System.Drawing.Size(678, 337);
            this.tableLayoutPanelCenter.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanelCenter.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 456F));
            this.tableLayoutPanel1.Controls.Add(this.labelNameCompany, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonWatchInfo, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelFullDonate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxLogoCompany, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listViewSponsorsInfo, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 82);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.3176F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.6824F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(678, 255);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // FormMySponsors
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.tableLayoutPanelAll);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMySponsors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMySponsore";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMySponsors_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoCompany)).EndInit();
            this.tableLayoutPanelAll.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanelCenter.ResumeLayout(false);
            this.tableLayoutPanelCenter.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button buttonWatchInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCenter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAll;
        private System.Windows.Forms.Label labelEventTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelNameTag;
    }
}