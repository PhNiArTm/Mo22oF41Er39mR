
namespace MARAFON
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonRunner = new System.Windows.Forms.Button();
            this.buttonSponsore = new System.Windows.Forms.Button();
            this.buttonEventInfo = new System.Windows.Forms.Button();
            this.timerEvent = new System.Windows.Forms.Timer(this.components);
            this.buttonLogin = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelEventTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelNameTag = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRunner
            // 
            this.buttonRunner.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel3.SetColumnSpan(this.buttonRunner, 2);
            this.buttonRunner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRunner.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonRunner.FlatAppearance.BorderSize = 2;
            this.buttonRunner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRunner.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRunner.Location = new System.Drawing.Point(150, 20);
            this.buttonRunner.Margin = new System.Windows.Forms.Padding(150, 20, 150, 0);
            this.buttonRunner.Name = "buttonRunner";
            this.buttonRunner.Size = new System.Drawing.Size(378, 58);
            this.buttonRunner.TabIndex = 0;
            this.buttonRunner.TabStop = false;
            this.buttonRunner.Text = "Я хочу стать бегуном";
            this.buttonRunner.UseVisualStyleBackColor = false;
            this.buttonRunner.Click += new System.EventHandler(this.buttonRunner_Click);
            // 
            // buttonSponsore
            // 
            this.buttonSponsore.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel3.SetColumnSpan(this.buttonSponsore, 2);
            this.buttonSponsore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSponsore.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSponsore.FlatAppearance.BorderSize = 2;
            this.buttonSponsore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSponsore.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSponsore.Location = new System.Drawing.Point(150, 98);
            this.buttonSponsore.Margin = new System.Windows.Forms.Padding(150, 20, 150, 0);
            this.buttonSponsore.Name = "buttonSponsore";
            this.buttonSponsore.Size = new System.Drawing.Size(378, 58);
            this.buttonSponsore.TabIndex = 1;
            this.buttonSponsore.TabStop = false;
            this.buttonSponsore.Text = "Я хочу стать спонсором бегуна";
            this.buttonSponsore.UseVisualStyleBackColor = false;
            this.buttonSponsore.Click += new System.EventHandler(this.buttonSponsore_Click);
            // 
            // buttonEventInfo
            // 
            this.buttonEventInfo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel3.SetColumnSpan(this.buttonEventInfo, 2);
            this.buttonEventInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEventInfo.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonEventInfo.FlatAppearance.BorderSize = 2;
            this.buttonEventInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEventInfo.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEventInfo.Location = new System.Drawing.Point(150, 176);
            this.buttonEventInfo.Margin = new System.Windows.Forms.Padding(150, 20, 150, 0);
            this.buttonEventInfo.Name = "buttonEventInfo";
            this.buttonEventInfo.Size = new System.Drawing.Size(378, 58);
            this.buttonEventInfo.TabIndex = 2;
            this.buttonEventInfo.TabStop = false;
            this.buttonEventInfo.Text = "Я хочу узнать о событии";
            this.buttonEventInfo.UseVisualStyleBackColor = false;
            this.buttonEventInfo.Click += new System.EventHandler(this.buttonEventInfo_Click);
            // 
            // timerEvent
            // 
            this.timerEvent.Enabled = true;
            this.timerEvent.Interval = 1000;
            this.timerEvent.Tick += new System.EventHandler(this.timerEvent_Tick);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Silver;
            this.buttonLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonLogin.FlatAppearance.BorderSize = 2;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Location = new System.Drawing.Point(531, 244);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 10, 20, 10);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(127, 38);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.TabStop = false;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.buttonRunner, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonLogin, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.buttonSponsore, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.buttonEventInfo, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 112);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(678, 292);
            this.tableLayoutPanel3.TabIndex = 3;
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
            this.labelEventTime.TabIndex = 2;
            this.labelEventTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.labelNameTag, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(678, 112);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // labelNameTag
            // 
            this.labelNameTag.AutoSize = true;
            this.labelNameTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNameTag.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelNameTag.Location = new System.Drawing.Point(0, 0);
            this.labelNameTag.Margin = new System.Windows.Forms.Padding(0);
            this.labelNameTag.Name = "labelNameTag";
            this.labelNameTag.Size = new System.Drawing.Size(678, 112);
            this.labelNameTag.TabIndex = 2;
            this.labelNameTag.Text = "MARATHON SKILLS 2021\r\n\r\n";
            this.labelNameTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelEventTime, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(678, 450);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRunner;
        private System.Windows.Forms.Button buttonSponsore;
        private System.Windows.Forms.Button buttonEventInfo;
        private System.Windows.Forms.Timer timerEvent;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelEventTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelNameTag;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

