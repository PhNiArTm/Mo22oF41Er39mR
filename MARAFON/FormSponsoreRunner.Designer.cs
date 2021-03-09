
namespace MARAFON
{
    partial class FormSponsoreRunner
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
            this.labelSponsoreTitle = new System.Windows.Forms.Label();
            this.labelSponsoreInfo = new System.Windows.Forms.Label();
            this.textBoxNameData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxRunnerData = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAuthorCardData = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNumberCardData = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDayCardData = new System.Windows.Forms.TextBox();
            this.textBoxMonthCardData = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCVCData = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelFondInfo = new System.Windows.Forms.Label();
            this.labelSummDonate = new System.Windows.Forms.Label();
            this.labelResultSumm = new System.Windows.Forms.Label();
            this.buttonMinusSumm = new System.Windows.Forms.Button();
            this.buttonPlusSumm = new System.Windows.Forms.Button();
            this.textBoxSummDonate = new System.Windows.Forms.TextBox();
            this.buttonAddDonate = new System.Windows.Forms.Button();
            this.buttonCancelDonate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSponsoreTitle
            // 
            this.labelSponsoreTitle.AutoSize = true;
            this.labelSponsoreTitle.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSponsoreTitle.Location = new System.Drawing.Point(176, 22);
            this.labelSponsoreTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSponsoreTitle.Name = "labelSponsoreTitle";
            this.labelSponsoreTitle.Size = new System.Drawing.Size(225, 32);
            this.labelSponsoreTitle.TabIndex = 0;
            this.labelSponsoreTitle.Text = "Спонсор бегуна";
            // 
            // labelSponsoreInfo
            // 
            this.labelSponsoreInfo.AutoSize = true;
            this.labelSponsoreInfo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSponsoreInfo.Location = new System.Drawing.Point(34, 54);
            this.labelSponsoreInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSponsoreInfo.Name = "labelSponsoreInfo";
            this.labelSponsoreInfo.Size = new System.Drawing.Size(525, 45);
            this.labelSponsoreInfo.TabIndex = 1;
            this.labelSponsoreInfo.Text = "Пожалуйста выберите бегуна, которого вы хотели бы спонсировать и сумму, \r\nкоторую" +
    " вы хотели бы спонсировать. Спасибо за вашу поддержку бегунов и их \r\nблаготворит" +
    "ельных учреждений\r\n";
            this.labelSponsoreInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNameData
            // 
            this.textBoxNameData.Location = new System.Drawing.Point(125, 171);
            this.textBoxNameData.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNameData.Multiline = true;
            this.textBoxNameData.Name = "textBoxNameData";
            this.textBoxNameData.Size = new System.Drawing.Size(139, 19);
            this.textBoxNameData.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ваше имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(62, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Бегун:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBoxRunnerData
            // 
            this.comboBoxRunnerData.FormattingEnabled = true;
            this.comboBoxRunnerData.Location = new System.Drawing.Point(125, 201);
            this.comboBoxRunnerData.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxRunnerData.Name = "comboBoxRunnerData";
            this.comboBoxRunnerData.Size = new System.Drawing.Size(139, 21);
            this.comboBoxRunnerData.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(62, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Карта:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxAuthorCardData
            // 
            this.textBoxAuthorCardData.Location = new System.Drawing.Point(125, 235);
            this.textBoxAuthorCardData.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAuthorCardData.Multiline = true;
            this.textBoxAuthorCardData.Name = "textBoxAuthorCardData";
            this.textBoxAuthorCardData.Size = new System.Drawing.Size(139, 19);
            this.textBoxAuthorCardData.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(21, 267);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Номер карты:";
            // 
            // textBoxNumberCardData
            // 
            this.textBoxNumberCardData.Location = new System.Drawing.Point(125, 266);
            this.textBoxNumberCardData.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumberCardData.Multiline = true;
            this.textBoxNumberCardData.Name = "textBoxNumberCardData";
            this.textBoxNumberCardData.Size = new System.Drawing.Size(139, 19);
            this.textBoxNumberCardData.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(5, 299);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Срок действия:";
            // 
            // textBoxDayCardData
            // 
            this.textBoxDayCardData.Location = new System.Drawing.Point(125, 298);
            this.textBoxDayCardData.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDayCardData.Multiline = true;
            this.textBoxDayCardData.Name = "textBoxDayCardData";
            this.textBoxDayCardData.Size = new System.Drawing.Size(33, 19);
            this.textBoxDayCardData.TabIndex = 11;
            // 
            // textBoxMonthCardData
            // 
            this.textBoxMonthCardData.Location = new System.Drawing.Point(162, 298);
            this.textBoxMonthCardData.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMonthCardData.Multiline = true;
            this.textBoxMonthCardData.Name = "textBoxMonthCardData";
            this.textBoxMonthCardData.Size = new System.Drawing.Size(43, 19);
            this.textBoxMonthCardData.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(75, 327);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "CVC:";
            // 
            // textBoxCVCData
            // 
            this.textBoxCVCData.Location = new System.Drawing.Point(125, 326);
            this.textBoxCVCData.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCVCData.Multiline = true;
            this.textBoxCVCData.Name = "textBoxCVCData";
            this.textBoxCVCData.Size = new System.Drawing.Size(57, 19);
            this.textBoxCVCData.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(38, 128);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Информация о спонсоре";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(359, 128);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "Благотворительность";
            // 
            // labelFondInfo
            // 
            this.labelFondInfo.AutoSize = true;
            this.labelFondInfo.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFondInfo.Location = new System.Drawing.Point(388, 158);
            this.labelFondInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFondInfo.Name = "labelFondInfo";
            this.labelFondInfo.Size = new System.Drawing.Size(130, 22);
            this.labelFondInfo.TabIndex = 17;
            this.labelFondInfo.Text = "Фонд кошелёк";
            this.labelFondInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSummDonate
            // 
            this.labelSummDonate.AutoSize = true;
            this.labelSummDonate.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSummDonate.Location = new System.Drawing.Point(359, 202);
            this.labelSummDonate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSummDonate.Name = "labelSummDonate";
            this.labelSummDonate.Size = new System.Drawing.Size(200, 22);
            this.labelSummDonate.TabIndex = 18;
            this.labelSummDonate.Text = "Сумма пожертвования";
            // 
            // labelResultSumm
            // 
            this.labelResultSumm.AutoSize = true;
            this.labelResultSumm.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResultSumm.Location = new System.Drawing.Point(426, 231);
            this.labelResultSumm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResultSumm.Name = "labelResultSumm";
            this.labelResultSumm.Size = new System.Drawing.Size(71, 37);
            this.labelResultSumm.TabIndex = 19;
            this.labelResultSumm.Text = "$50";
            // 
            // buttonMinusSumm
            // 
            this.buttonMinusSumm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMinusSumm.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonMinusSumm.FlatAppearance.BorderSize = 2;
            this.buttonMinusSumm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinusSumm.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinusSumm.Location = new System.Drawing.Point(363, 284);
            this.buttonMinusSumm.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMinusSumm.Name = "buttonMinusSumm";
            this.buttonMinusSumm.Size = new System.Drawing.Size(53, 30);
            this.buttonMinusSumm.TabIndex = 20;
            this.buttonMinusSumm.Text = "-";
            this.buttonMinusSumm.UseVisualStyleBackColor = false;
            this.buttonMinusSumm.Click += new System.EventHandler(this.buttonMinusSumm_Click);
            // 
            // buttonPlusSumm
            // 
            this.buttonPlusSumm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPlusSumm.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonPlusSumm.FlatAppearance.BorderSize = 2;
            this.buttonPlusSumm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlusSumm.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlusSumm.Location = new System.Drawing.Point(500, 284);
            this.buttonPlusSumm.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPlusSumm.Name = "buttonPlusSumm";
            this.buttonPlusSumm.Size = new System.Drawing.Size(53, 30);
            this.buttonPlusSumm.TabIndex = 21;
            this.buttonPlusSumm.Text = "+";
            this.buttonPlusSumm.UseVisualStyleBackColor = false;
            this.buttonPlusSumm.Click += new System.EventHandler(this.buttonPlusSumm_Click);
            // 
            // textBoxSummDonate
            // 
            this.textBoxSummDonate.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSummDonate.Location = new System.Drawing.Point(421, 284);
            this.textBoxSummDonate.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSummDonate.Multiline = true;
            this.textBoxSummDonate.Name = "textBoxSummDonate";
            this.textBoxSummDonate.Size = new System.Drawing.Size(76, 31);
            this.textBoxSummDonate.TabIndex = 22;
            this.textBoxSummDonate.Text = "50";
            this.textBoxSummDonate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonAddDonate
            // 
            this.buttonAddDonate.Location = new System.Drawing.Point(353, 372);
            this.buttonAddDonate.Name = "buttonAddDonate";
            this.buttonAddDonate.Size = new System.Drawing.Size(112, 38);
            this.buttonAddDonate.TabIndex = 23;
            this.buttonAddDonate.Text = "Заплатить";
            this.buttonAddDonate.UseVisualStyleBackColor = true;
            // 
            // buttonCancelDonate
            // 
            this.buttonCancelDonate.Location = new System.Drawing.Point(471, 372);
            this.buttonCancelDonate.Name = "buttonCancelDonate";
            this.buttonCancelDonate.Size = new System.Drawing.Size(112, 38);
            this.buttonCancelDonate.TabIndex = 24;
            this.buttonCancelDonate.Text = "Отменить";
            this.buttonCancelDonate.UseVisualStyleBackColor = true;
            this.buttonCancelDonate.Click += new System.EventHandler(this.buttonCancelDonate_Click);
            // 
            // FormSponsoreRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(600, 422);
            this.Controls.Add(this.buttonCancelDonate);
            this.Controls.Add(this.buttonAddDonate);
            this.Controls.Add(this.textBoxSummDonate);
            this.Controls.Add(this.buttonPlusSumm);
            this.Controls.Add(this.buttonMinusSumm);
            this.Controls.Add(this.labelResultSumm);
            this.Controls.Add(this.labelSummDonate);
            this.Controls.Add(this.labelFondInfo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCVCData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxMonthCardData);
            this.Controls.Add(this.textBoxDayCardData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNumberCardData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAuthorCardData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxRunnerData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNameData);
            this.Controls.Add(this.labelSponsoreInfo);
            this.Controls.Add(this.labelSponsoreTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSponsoreRunner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спонсор бегуна";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSponsoreRunner_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSponsoreTitle;
        private System.Windows.Forms.Label labelSponsoreInfo;
        private System.Windows.Forms.TextBox textBoxNameData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxRunnerData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAuthorCardData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNumberCardData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDayCardData;
        private System.Windows.Forms.TextBox textBoxMonthCardData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCVCData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelFondInfo;
        private System.Windows.Forms.Label labelSummDonate;
        private System.Windows.Forms.Label labelResultSumm;
        private System.Windows.Forms.Button buttonMinusSumm;
        private System.Windows.Forms.Button buttonPlusSumm;
        private System.Windows.Forms.TextBox textBoxSummDonate;
        private System.Windows.Forms.Button buttonAddDonate;
        private System.Windows.Forms.Button buttonCancelDonate;
    }
}