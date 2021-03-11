
namespace MARAFON
{
    partial class FormRegisterAsARunner
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
            this.labelEventTime = new System.Windows.Forms.Label();
            this.tableLayoutPanelUp = new System.Windows.Forms.TableLayoutPanel();
            this.labelNameTag = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.tableLayoutPanelAll = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelCenter = new System.Windows.Forms.TableLayoutPanel();
            this.buttonNewUser = new System.Windows.Forms.Button();
            this.buttonOldUser = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanelUp.SuspendLayout();
            this.tableLayoutPanelAll.SuspendLayout();
            this.tableLayoutPanelCenter.SuspendLayout();
            this.SuspendLayout();
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
            // tableLayoutPanelUp
            // 
            this.tableLayoutPanelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanelUp.ColumnCount = 2;
            this.tableLayoutPanelUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanelUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tableLayoutPanelUp.Controls.Add(this.labelNameTag, 0, 0);
            this.tableLayoutPanelUp.Controls.Add(this.buttonBack, 0, 0);
            this.tableLayoutPanelUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelUp.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelUp.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelUp.Name = "tableLayoutPanelUp";
            this.tableLayoutPanelUp.RowCount = 1;
            this.tableLayoutPanelUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelUp.Size = new System.Drawing.Size(678, 67);
            this.tableLayoutPanelUp.TabIndex = 0;
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
            this.labelNameTag.TabIndex = 2;
            this.labelNameTag.Text = "MARATHON SKILLS 2021";
            this.labelNameTag.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.buttonBack.TabIndex = 1;
            this.buttonBack.TabStop = false;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // tableLayoutPanelAll
            // 
            this.tableLayoutPanelAll.ColumnCount = 1;
            this.tableLayoutPanelAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAll.Controls.Add(this.tableLayoutPanelUp, 0, 0);
            this.tableLayoutPanelAll.Controls.Add(this.labelEventTime, 0, 2);
            this.tableLayoutPanelAll.Controls.Add(this.tableLayoutPanelCenter, 0, 1);
            this.tableLayoutPanelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAll.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelAll.Name = "tableLayoutPanelAll";
            this.tableLayoutPanelAll.RowCount = 3;
            this.tableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelAll.Size = new System.Drawing.Size(678, 450);
            this.tableLayoutPanelAll.TabIndex = 0;
            // 
            // tableLayoutPanelCenter
            // 
            this.tableLayoutPanelCenter.ColumnCount = 1;
            this.tableLayoutPanelCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCenter.Controls.Add(this.buttonNewUser, 0, 1);
            this.tableLayoutPanelCenter.Controls.Add(this.buttonOldUser, 0, 0);
            this.tableLayoutPanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCenter.Location = new System.Drawing.Point(0, 67);
            this.tableLayoutPanelCenter.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelCenter.Name = "tableLayoutPanelCenter";
            this.tableLayoutPanelCenter.RowCount = 2;
            this.tableLayoutPanelCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCenter.Size = new System.Drawing.Size(678, 337);
            this.tableLayoutPanelCenter.TabIndex = 2;
            // 
            // buttonNewUser
            // 
            this.buttonNewUser.BackColor = System.Drawing.Color.Silver;
            this.buttonNewUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNewUser.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewUser.Font = new System.Drawing.Font("Consolas", 16.75F);
            this.buttonNewUser.Location = new System.Drawing.Point(175, 178);
            this.buttonNewUser.Margin = new System.Windows.Forms.Padding(175, 10, 175, 10);
            this.buttonNewUser.Name = "buttonNewUser";
            this.buttonNewUser.Size = new System.Drawing.Size(328, 65);
            this.buttonNewUser.TabIndex = 2;
            this.buttonNewUser.TabStop = false;
            this.buttonNewUser.Text = "Я новый участник";
            this.buttonNewUser.UseVisualStyleBackColor = false;
            this.buttonNewUser.Click += new System.EventHandler(this.buttonNewUser_Click);
            // 
            // buttonOldUser
            // 
            this.buttonOldUser.BackColor = System.Drawing.Color.Silver;
            this.buttonOldUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonOldUser.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonOldUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOldUser.Font = new System.Drawing.Font("Consolas", 16.75F);
            this.buttonOldUser.Location = new System.Drawing.Point(175, 93);
            this.buttonOldUser.Margin = new System.Windows.Forms.Padding(175, 10, 175, 10);
            this.buttonOldUser.Name = "buttonOldUser";
            this.buttonOldUser.Size = new System.Drawing.Size(328, 65);
            this.buttonOldUser.TabIndex = 1;
            this.buttonOldUser.TabStop = false;
            this.buttonOldUser.Text = "Я участвовал ранее";
            this.buttonOldUser.UseVisualStyleBackColor = false;
            this.buttonOldUser.Click += new System.EventHandler(this.buttonOldUser_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormRegisterAsARunner
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.tableLayoutPanelAll);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegisterAsARunner";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegisterAsARunner";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRegisterAsARunner_FormClosed);
            this.tableLayoutPanelUp.ResumeLayout(false);
            this.tableLayoutPanelUp.PerformLayout();
            this.tableLayoutPanelAll.ResumeLayout(false);
            this.tableLayoutPanelCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelEventTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUp;
        private System.Windows.Forms.Label labelNameTag;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCenter;
        private System.Windows.Forms.Button buttonNewUser;
        private System.Windows.Forms.Button buttonOldUser;
        private System.Windows.Forms.Timer timer;
    }
}