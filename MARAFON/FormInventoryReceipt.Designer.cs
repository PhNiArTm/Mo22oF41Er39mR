
namespace MARAFON
{
    partial class FormInventoryReceipt
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelInventory = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelInfo1 = new System.Windows.Forms.Label();
            this.labelInfo2 = new System.Windows.Forms.Label();
            this.labelInfo3 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.labeName = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labeLentrance = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelCount3 = new System.Windows.Forms.Label();
            this.labelCount2 = new System.Windows.Forms.Label();
            this.labelCount1 = new System.Windows.Forms.Label();
            this.labelCounts = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(17, 17);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 35);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Назад";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(775, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 35);
            this.buttonLogout.TabIndex = 7;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Location = new System.Drawing.Point(284, 35);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(169, 17);
            this.labelInventory.TabIndex = 6;
            this.labelInventory.Text = "Поступление инвентаря";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(345, 354);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(99, 35);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(187, 424);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(44, 17);
            this.labelTimer.TabIndex = 11;
            this.labelTimer.Text = "Timer";
            // 
            // labelInfo1
            // 
            this.labelInfo1.AutoSize = true;
            this.labelInfo1.Location = new System.Drawing.Point(621, 135);
            this.labelInfo1.Name = "labelInfo1";
            this.labelInfo1.Size = new System.Drawing.Size(0, 17);
            this.labelInfo1.TabIndex = 12;
            // 
            // labelInfo2
            // 
            this.labelInfo2.AutoSize = true;
            this.labelInfo2.Location = new System.Drawing.Point(621, 200);
            this.labelInfo2.Name = "labelInfo2";
            this.labelInfo2.Size = new System.Drawing.Size(0, 17);
            this.labelInfo2.TabIndex = 13;
            // 
            // labelInfo3
            // 
            this.labelInfo3.AutoSize = true;
            this.labelInfo3.Location = new System.Drawing.Point(621, 265);
            this.labelInfo3.Name = "labelInfo3";
            this.labelInfo3.Size = new System.Drawing.Size(0, 17);
            this.labelInfo3.TabIndex = 14;
            // 
            // textBoxA
            // 
            this.textBoxA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxA.Location = new System.Drawing.Point(169, 49);
            this.textBoxA.Multiline = true;
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(160, 59);
            this.textBoxA.TabIndex = 15;
            // 
            // labeName
            // 
            this.labeName.AutoSize = true;
            this.labeName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labeName.Location = new System.Drawing.Point(0, 3);
            this.labeName.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.labeName.Name = "labeName";
            this.labeName.Size = new System.Drawing.Size(166, 40);
            this.labeName.TabIndex = 13;
            this.labeName.Text = "Наименование";
            this.labeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB.Location = new System.Drawing.Point(3, 114);
            this.labelB.Margin = new System.Windows.Forms.Padding(3);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(160, 59);
            this.labelB.TabIndex = 11;
            this.labelB.Text = "Количество комплектов B";
            this.labelB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.Location = new System.Drawing.Point(3, 49);
            this.labelA.Margin = new System.Windows.Forms.Padding(3);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(160, 59);
            this.labelA.TabIndex = 10;
            this.labelA.Text = "Количество комплектов A";
            this.labelA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelC.Location = new System.Drawing.Point(3, 179);
            this.labelC.Margin = new System.Windows.Forms.Padding(3);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(160, 61);
            this.labelC.TabIndex = 12;
            this.labelC.Text = "Количество комплектов C";
            this.labelC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labeLentrance
            // 
            this.labeLentrance.AutoSize = true;
            this.labeLentrance.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labeLentrance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labeLentrance.Location = new System.Drawing.Point(166, 3);
            this.labeLentrance.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.labeLentrance.Name = "labeLentrance";
            this.labeLentrance.Size = new System.Drawing.Size(166, 40);
            this.labeLentrance.TabIndex = 14;
            this.labeLentrance.Text = "Поступление";
            this.labeLentrance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxB
            // 
            this.textBoxB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxB.Location = new System.Drawing.Point(169, 114);
            this.textBoxB.Multiline = true;
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(160, 59);
            this.textBoxB.TabIndex = 16;
            // 
            // textBoxC
            // 
            this.textBoxC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxC.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxC.Location = new System.Drawing.Point(169, 179);
            this.textBoxC.Multiline = true;
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(160, 61);
            this.textBoxC.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.labelCount3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelCount2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelCount1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxC, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labeLentrance, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelC, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelA, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelB, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labeName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxA, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelCounts, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(159, 86);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.2432F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.91894F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.91894F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.91894F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 243);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // labelCount3
            // 
            this.labelCount3.AutoSize = true;
            this.labelCount3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCount3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount3.Location = new System.Drawing.Point(335, 179);
            this.labelCount3.Margin = new System.Windows.Forms.Padding(3);
            this.labelCount3.Name = "labelCount3";
            this.labelCount3.Size = new System.Drawing.Size(162, 61);
            this.labelCount3.TabIndex = 21;
            this.labelCount3.Text = "0";
            this.labelCount3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCount2
            // 
            this.labelCount2.AutoSize = true;
            this.labelCount2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount2.Location = new System.Drawing.Point(335, 114);
            this.labelCount2.Margin = new System.Windows.Forms.Padding(3);
            this.labelCount2.Name = "labelCount2";
            this.labelCount2.Size = new System.Drawing.Size(162, 59);
            this.labelCount2.TabIndex = 20;
            this.labelCount2.Text = "0";
            this.labelCount2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCount1
            // 
            this.labelCount1.AutoSize = true;
            this.labelCount1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount1.Location = new System.Drawing.Point(335, 49);
            this.labelCount1.Margin = new System.Windows.Forms.Padding(3);
            this.labelCount1.Name = "labelCount1";
            this.labelCount1.Size = new System.Drawing.Size(162, 59);
            this.labelCount1.TabIndex = 19;
            this.labelCount1.Text = "0";
            this.labelCount1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCounts
            // 
            this.labelCounts.AutoSize = true;
            this.labelCounts.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelCounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCounts.Location = new System.Drawing.Point(332, 3);
            this.labelCounts.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.labelCounts.Name = "labelCounts";
            this.labelCounts.Size = new System.Drawing.Size(168, 40);
            this.labelCounts.TabIndex = 18;
            this.labelCounts.Text = "Количество на складе";
            this.labelCounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormInventoryReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.labelInfo3);
            this.Controls.Add(this.labelInfo2);
            this.Controls.Add(this.labelInfo1);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.labelInventory);
            this.Name = "FormInventoryReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поступление инвентаря";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelInventory;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labelInfo1;
        private System.Windows.Forms.Label labelInfo2;
        private System.Windows.Forms.Label labelInfo3;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label labeName;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labeLentrance;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelCount3;
        private System.Windows.Forms.Label labelCount2;
        private System.Windows.Forms.Label labelCount1;
        private System.Windows.Forms.Label labelCounts;
    }
}