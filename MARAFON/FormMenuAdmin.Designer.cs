﻿
namespace MARAFON
{
    partial class FormMenuAdmin
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
            this.labelTitleForm = new System.Windows.Forms.Label();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonVolunteer = new System.Windows.Forms.Button();
            this.buttonDonateCompany = new System.Windows.Forms.Button();
            this.buttonInventory = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitleForm
            // 
            this.labelTitleForm.AutoSize = true;
            this.labelTitleForm.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleForm.Location = new System.Drawing.Point(68, 42);
            this.labelTitleForm.Name = "labelTitleForm";
            this.labelTitleForm.Size = new System.Drawing.Size(438, 47);
            this.labelTitleForm.TabIndex = 4;
            this.labelTitleForm.Text = "Меню администратора";
            // 
            // buttonUser
            // 
            this.buttonUser.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUser.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonUser.FlatAppearance.BorderSize = 2;
            this.buttonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUser.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUser.Location = new System.Drawing.Point(15, 108);
            this.buttonUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(305, 82);
            this.buttonUser.TabIndex = 5;
            this.buttonUser.Text = "Пользователи";
            this.buttonUser.UseVisualStyleBackColor = false;
            // 
            // buttonVolunteer
            // 
            this.buttonVolunteer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonVolunteer.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonVolunteer.FlatAppearance.BorderSize = 2;
            this.buttonVolunteer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolunteer.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVolunteer.Location = new System.Drawing.Point(332, 108);
            this.buttonVolunteer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonVolunteer.Name = "buttonVolunteer";
            this.buttonVolunteer.Size = new System.Drawing.Size(293, 82);
            this.buttonVolunteer.TabIndex = 6;
            this.buttonVolunteer.Text = "Волонтёры";
            this.buttonVolunteer.UseVisualStyleBackColor = false;
            this.buttonVolunteer.Click += new System.EventHandler(this.buttonVolunteer_Click);
            // 
            // buttonDonateCompany
            // 
            this.buttonDonateCompany.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDonateCompany.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDonateCompany.FlatAppearance.BorderSize = 2;
            this.buttonDonateCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDonateCompany.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDonateCompany.Location = new System.Drawing.Point(15, 207);
            this.buttonDonateCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDonateCompany.Name = "buttonDonateCompany";
            this.buttonDonateCompany.Size = new System.Drawing.Size(305, 82);
            this.buttonDonateCompany.TabIndex = 7;
            this.buttonDonateCompany.Text = "Благотворительные организации";
            this.buttonDonateCompany.UseVisualStyleBackColor = false;
            // 
            // buttonInventory
            // 
            this.buttonInventory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonInventory.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonInventory.FlatAppearance.BorderSize = 2;
            this.buttonInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInventory.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInventory.Location = new System.Drawing.Point(332, 207);
            this.buttonInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInventory.Name = "buttonInventory";
            this.buttonInventory.Size = new System.Drawing.Size(293, 82);
            this.buttonInventory.TabIndex = 8;
            this.buttonInventory.Text = "Инвентарь";
            this.buttonInventory.UseVisualStyleBackColor = false;
            this.buttonInventory.Click += new System.EventHandler(this.buttonInventory_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 16);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(636, 384);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonInventory);
            this.Controls.Add(this.buttonDonateCompany);
            this.Controls.Add(this.buttonVolunteer);
            this.Controls.Add(this.buttonUser);
            this.Controls.Add(this.labelTitleForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenuAdmin_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitleForm;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button buttonVolunteer;
        private System.Windows.Forms.Button buttonDonateCompany;
        private System.Windows.Forms.Button buttonInventory;
        private System.Windows.Forms.Button buttonCancel;
    }
}