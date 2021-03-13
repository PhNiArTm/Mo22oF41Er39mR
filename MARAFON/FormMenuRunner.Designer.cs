
namespace MARAFON
{
    partial class FormMenuRunner
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelEventTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button6 = new System.Windows.Forms.Button();
            this.labelNameTag = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEditProfile = new System.Windows.Forms.Button();
            this.buttonMyResult = new System.Windows.Forms.Button();
            this.buttonMySponsore = new System.Windows.Forms.Button();
            this.buttonContactInfo = new System.Windows.Forms.Button();
            this.buttonRegisterMarathon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelEventTime, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(678, 450);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.labelEventTime.TabIndex = 3;
            this.labelEventTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.button6, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelNameTag, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(678, 67);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Silver;
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(552, 5);
            this.button6.Margin = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(116, 34);
            this.button6.TabIndex = 2;
            this.button6.TabStop = false;
            this.button6.Text = "Logout";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
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
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.buttonEditProfile, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.buttonMyResult, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.buttonMySponsore, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.buttonContactInfo, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.buttonRegisterMarathon, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 67);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(678, 337);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // buttonEditProfile
            // 
            this.buttonEditProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEditProfile.Font = new System.Drawing.Font("Consolas", 15F);
            this.buttonEditProfile.Location = new System.Drawing.Point(50, 178);
            this.buttonEditProfile.Margin = new System.Windows.Forms.Padding(50, 10, 10, 10);
            this.buttonEditProfile.Name = "buttonEditProfile";
            this.buttonEditProfile.Size = new System.Drawing.Size(279, 64);
            this.buttonEditProfile.TabIndex = 4;
            this.buttonEditProfile.Text = "Редактирование профиля";
            this.buttonEditProfile.UseVisualStyleBackColor = true;
            this.buttonEditProfile.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonMyResult
            // 
            this.buttonMyResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMyResult.Font = new System.Drawing.Font("Consolas", 15F);
            this.buttonMyResult.Location = new System.Drawing.Point(349, 94);
            this.buttonMyResult.Margin = new System.Windows.Forms.Padding(10, 10, 50, 10);
            this.buttonMyResult.Name = "buttonMyResult";
            this.buttonMyResult.Size = new System.Drawing.Size(279, 64);
            this.buttonMyResult.TabIndex = 3;
            this.buttonMyResult.Text = "Мои результаты";
            this.buttonMyResult.UseVisualStyleBackColor = true;
            // 
            // buttonMySponsore
            // 
            this.buttonMySponsore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMySponsore.Font = new System.Drawing.Font("Consolas", 15F);
            this.buttonMySponsore.Location = new System.Drawing.Point(349, 178);
            this.buttonMySponsore.Margin = new System.Windows.Forms.Padding(10, 10, 50, 10);
            this.buttonMySponsore.Name = "buttonMySponsore";
            this.buttonMySponsore.Size = new System.Drawing.Size(279, 64);
            this.buttonMySponsore.TabIndex = 2;
            this.buttonMySponsore.Text = "Мой спонсор";
            this.buttonMySponsore.UseVisualStyleBackColor = true;
            this.buttonMySponsore.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonContactInfo
            // 
            this.buttonContactInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonContactInfo.Font = new System.Drawing.Font("Consolas", 15F);
            this.buttonContactInfo.Location = new System.Drawing.Point(50, 262);
            this.buttonContactInfo.Margin = new System.Windows.Forms.Padding(50, 10, 10, 10);
            this.buttonContactInfo.Name = "buttonContactInfo";
            this.buttonContactInfo.Size = new System.Drawing.Size(279, 65);
            this.buttonContactInfo.TabIndex = 1;
            this.buttonContactInfo.Text = "Контакты";
            this.buttonContactInfo.UseVisualStyleBackColor = true;
            this.buttonContactInfo.Click += new System.EventHandler(this.buttonContactInfo_Click);
            // 
            // buttonRegisterMarathon
            // 
            this.buttonRegisterMarathon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRegisterMarathon.Font = new System.Drawing.Font("Consolas", 15F);
            this.buttonRegisterMarathon.Location = new System.Drawing.Point(50, 94);
            this.buttonRegisterMarathon.Margin = new System.Windows.Forms.Padding(50, 10, 10, 10);
            this.buttonRegisterMarathon.Name = "buttonRegisterMarathon";
            this.buttonRegisterMarathon.Size = new System.Drawing.Size(279, 64);
            this.buttonRegisterMarathon.TabIndex = 0;
            this.buttonRegisterMarathon.Text = "Регистрация на марафон";
            this.buttonRegisterMarathon.UseVisualStyleBackColor = true;
            this.buttonRegisterMarathon.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Consolas", 19.75F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(672, 84);
            this.label1.TabIndex = 5;
            this.label1.Text = "Меню бегуна";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormMenuRunner
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenuRunner";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuRunner";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenuRunner_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelNameTag;
        private System.Windows.Forms.Label labelEventTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonEditProfile;
        private System.Windows.Forms.Button buttonMyResult;
        private System.Windows.Forms.Button buttonMySponsore;
        private System.Windows.Forms.Button buttonContactInfo;
        private System.Windows.Forms.Button buttonRegisterMarathon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button6;
    }
}