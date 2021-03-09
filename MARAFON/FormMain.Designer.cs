
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
            this.button1 = new System.Windows.Forms.Button();
            this.timerEvent = new System.Windows.Forms.Timer(this.components);
            this.labelEventTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRunner
            // 
            this.buttonRunner.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRunner.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonRunner.FlatAppearance.BorderSize = 2;
            this.buttonRunner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRunner.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRunner.Location = new System.Drawing.Point(28, 60);
            this.buttonRunner.Name = "buttonRunner";
            this.buttonRunner.Size = new System.Drawing.Size(498, 70);
            this.buttonRunner.TabIndex = 0;
            this.buttonRunner.Text = "Я хочу стать бегуном";
            this.buttonRunner.UseVisualStyleBackColor = false;
            // 
            // buttonSponsore
            // 
            this.buttonSponsore.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSponsore.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSponsore.FlatAppearance.BorderSize = 2;
            this.buttonSponsore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSponsore.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSponsore.Location = new System.Drawing.Point(28, 161);
            this.buttonSponsore.Name = "buttonSponsore";
            this.buttonSponsore.Size = new System.Drawing.Size(498, 70);
            this.buttonSponsore.TabIndex = 1;
            this.buttonSponsore.Text = "Я хочу стать спонсором бегуна";
            this.buttonSponsore.UseVisualStyleBackColor = false;
            this.buttonSponsore.Click += new System.EventHandler(this.buttonSponsore_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(28, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(498, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "Я хочу узнать о событии";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // timerEvent
            // 
            this.timerEvent.Tick += new System.EventHandler(this.timerEvent_Tick);
            // 
            // labelEventTime
            // 
            this.labelEventTime.AutoSize = true;
            this.labelEventTime.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEventTime.Location = new System.Drawing.Point(33, 371);
            this.labelEventTime.Name = "labelEventTime";
            this.labelEventTime.Size = new System.Drawing.Size(0, 28);
            this.labelEventTime.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(156, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "До события осталось:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(570, 466);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelEventTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSponsore);
            this.Controls.Add(this.buttonRunner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRunner;
        private System.Windows.Forms.Button buttonSponsore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerEvent;
        private System.Windows.Forms.Label labelEventTime;
        private System.Windows.Forms.Label label1;
    }
}

