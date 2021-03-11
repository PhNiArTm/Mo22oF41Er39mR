
namespace MARAFON
{
    partial class FormCoordinator
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
            this.buttonSupport = new System.Windows.Forms.Button();
            this.buttonRunner = new System.Windows.Forms.Button();
            this.labelTitleForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSupport
            // 
            this.buttonSupport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSupport.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSupport.FlatAppearance.BorderSize = 2;
            this.buttonSupport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupport.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSupport.Location = new System.Drawing.Point(332, 71);
            this.buttonSupport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSupport.Name = "buttonSupport";
            this.buttonSupport.Size = new System.Drawing.Size(293, 82);
            this.buttonSupport.TabIndex = 14;
            this.buttonSupport.Text = "Спонсоры";
            this.buttonSupport.UseVisualStyleBackColor = false;
            // 
            // buttonRunner
            // 
            this.buttonRunner.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRunner.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonRunner.FlatAppearance.BorderSize = 2;
            this.buttonRunner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRunner.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRunner.Location = new System.Drawing.Point(14, 71);
            this.buttonRunner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRunner.Name = "buttonRunner";
            this.buttonRunner.Size = new System.Drawing.Size(305, 82);
            this.buttonRunner.TabIndex = 13;
            this.buttonRunner.Text = "Бегуны";
            this.buttonRunner.UseVisualStyleBackColor = false;
            // 
            // labelTitleForm
            // 
            this.labelTitleForm.AutoSize = true;
            this.labelTitleForm.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleForm.Location = new System.Drawing.Point(139, 9);
            this.labelTitleForm.Name = "labelTitleForm";
            this.labelTitleForm.Size = new System.Drawing.Size(394, 47);
            this.labelTitleForm.TabIndex = 12;
            this.labelTitleForm.Text = "Меню координатора";
            this.labelTitleForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCoordinator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(646, 235);
            this.Controls.Add(this.buttonSupport);
            this.Controls.Add(this.buttonRunner);
            this.Controls.Add(this.labelTitleForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormCoordinator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Меню координатора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSupport;
        private System.Windows.Forms.Button buttonRunner;
        private System.Windows.Forms.Label labelTitleForm;
    }
}