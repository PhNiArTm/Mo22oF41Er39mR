
namespace MARAFON
{
    partial class FormRegistrationConfirmation
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label_MARATHON_SKILLS_2016 = new System.Windows.Forms.Label();
            this.label_GRATITUDE = new System.Windows.Forms.Label();
            this.label_GRATITUDE2 = new System.Windows.Forms.Label();
            this.label_payment = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerEvent = new System.Windows.Forms.Timer(this.components);
            this.labelEventTime = new System.Windows.Forms.Label();
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
            this.buttonLogout.Location = new System.Drawing.Point(483, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(248, 197);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // label_MARATHON_SKILLS_2016
            // 
            this.label_MARATHON_SKILLS_2016.AutoSize = true;
            this.label_MARATHON_SKILLS_2016.Location = new System.Drawing.Point(105, 22);
            this.label_MARATHON_SKILLS_2016.Name = "label_MARATHON_SKILLS_2016";
            this.label_MARATHON_SKILLS_2016.Size = new System.Drawing.Size(135, 13);
            this.label_MARATHON_SKILLS_2016.TabIndex = 3;
            this.label_MARATHON_SKILLS_2016.Text = "MARATHON SKILLS 2016";
            // 
            // label_GRATITUDE
            // 
            this.label_GRATITUDE.AutoSize = true;
            this.label_GRATITUDE.Location = new System.Drawing.Point(164, 93);
            this.label_GRATITUDE.Name = "label_GRATITUDE";
            this.label_GRATITUDE.Size = new System.Drawing.Size(223, 26);
            this.label_GRATITUDE.TabIndex = 4;
            this.label_GRATITUDE.Text = "Спасибо за вашу регистрацию в качестве \r\nбегуна!";
            this.label_GRATITUDE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_GRATITUDE2
            // 
            this.label_GRATITUDE2.AutoSize = true;
            this.label_GRATITUDE2.Location = new System.Drawing.Point(105, 119);
            this.label_GRATITUDE2.Name = "label_GRATITUDE2";
            this.label_GRATITUDE2.Size = new System.Drawing.Size(371, 13);
            this.label_GRATITUDE2.TabIndex = 5;
            this.label_GRATITUDE2.Text = "Спасибо за вашу регистрацию в качестве бегуна в Marathon Skills 2016!\r\n";
            // 
            // label_payment
            // 
            this.label_payment.AutoSize = true;
            this.label_payment.Location = new System.Drawing.Point(177, 142);
            this.label_payment.Name = "label_payment";
            this.label_payment.Size = new System.Drawing.Size(190, 13);
            this.label_payment.TabIndex = 6;
            this.label_payment.Text = "С вами свяжутся по поводу оплаты.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 44);
            this.label1.TabIndex = 8;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(587, 38);
            this.label2.TabIndex = 9;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timerEvent
            // 
            this.timerEvent.Tick += new System.EventHandler(this.timerEvent_Tick);
            // 
            // labelEventTime
            // 
            this.labelEventTime.AutoSize = true;
            this.labelEventTime.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEventTime.Location = new System.Drawing.Point(176, 294);
            this.labelEventTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEventTime.Name = "labelEventTime";
            this.labelEventTime.Size = new System.Drawing.Size(0, 22);
            this.labelEventTime.TabIndex = 11;
            // 
            // FormRegistrationConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 325);
            this.Controls.Add(this.labelEventTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_payment);
            this.Controls.Add(this.label_GRATITUDE2);
            this.Controls.Add(this.label_GRATITUDE);
            this.Controls.Add(this.label_MARATHON_SKILLS_2016);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FormRegistrationConfirmation";
            this.Text = "Marathon Skills 2016 - Registration confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label_MARATHON_SKILLS_2016;
        private System.Windows.Forms.Label label_GRATITUDE;
        private System.Windows.Forms.Label label_GRATITUDE2;
        private System.Windows.Forms.Label label_payment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerEvent;
        private System.Windows.Forms.Label labelEventTime;
    }
}