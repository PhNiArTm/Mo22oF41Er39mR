
namespace MARAFON
{
    partial class FormInfoMarathon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfoMarathon));
            this.labelSponsoreTitle = new System.Windows.Forms.Label();
            this.labelSponsoreInfo = new System.Windows.Forms.Label();
            this.pictureBoxInfoImageFour = new System.Windows.Forms.PictureBox();
            this.pictureBoxInfoImageFree = new System.Windows.Forms.PictureBox();
            this.pictureBoxInfoImageTwo = new System.Windows.Forms.PictureBox();
            this.pictureBoxInfoImageOne = new System.Windows.Forms.PictureBox();
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoImageFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoImageFree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoImageTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoImageOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSponsoreTitle
            // 
            this.labelSponsoreTitle.AutoSize = true;
            this.labelSponsoreTitle.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSponsoreTitle.Location = new System.Drawing.Point(169, 9);
            this.labelSponsoreTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSponsoreTitle.Name = "labelSponsoreTitle";
            this.labelSponsoreTitle.Size = new System.Drawing.Size(510, 32);
            this.labelSponsoreTitle.TabIndex = 1;
            this.labelSponsoreTitle.Text = "Информация о Marathon Skills 2016";
            // 
            // labelSponsoreInfo
            // 
            this.labelSponsoreInfo.AutoSize = true;
            this.labelSponsoreInfo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSponsoreInfo.Location = new System.Drawing.Point(224, 41);
            this.labelSponsoreInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSponsoreInfo.Name = "labelSponsoreInfo";
            this.labelSponsoreInfo.Size = new System.Drawing.Size(637, 390);
            this.labelSponsoreInfo.TabIndex = 2;
            this.labelSponsoreInfo.Text = resources.GetString("labelSponsoreInfo.Text");
            this.labelSponsoreInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxInfoImageFour
            // 
            this.pictureBoxInfoImageFour.Image = global::MARAFON.Properties.Resources.banco_banespa;
            this.pictureBoxInfoImageFour.Location = new System.Drawing.Point(105, 246);
            this.pictureBoxInfoImageFour.Name = "pictureBoxInfoImageFour";
            this.pictureBoxInfoImageFour.Size = new System.Drawing.Size(107, 196);
            this.pictureBoxInfoImageFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInfoImageFour.TabIndex = 7;
            this.pictureBoxInfoImageFour.TabStop = false;
            // 
            // pictureBoxInfoImageFree
            // 
            this.pictureBoxInfoImageFree.Image = global::MARAFON.Properties.Resources.marathon_image;
            this.pictureBoxInfoImageFree.Location = new System.Drawing.Point(12, 378);
            this.pictureBoxInfoImageFree.Name = "pictureBoxInfoImageFree";
            this.pictureBoxInfoImageFree.Size = new System.Drawing.Size(85, 60);
            this.pictureBoxInfoImageFree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInfoImageFree.TabIndex = 6;
            this.pictureBoxInfoImageFree.TabStop = false;
            // 
            // pictureBoxInfoImageTwo
            // 
            this.pictureBoxInfoImageTwo.Image = global::MARAFON.Properties.Resources.ibirapuera_park_lake;
            this.pictureBoxInfoImageTwo.Location = new System.Drawing.Point(12, 312);
            this.pictureBoxInfoImageTwo.Name = "pictureBoxInfoImageTwo";
            this.pictureBoxInfoImageTwo.Size = new System.Drawing.Size(85, 60);
            this.pictureBoxInfoImageTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInfoImageTwo.TabIndex = 5;
            this.pictureBoxInfoImageTwo.TabStop = false;
            // 
            // pictureBoxInfoImageOne
            // 
            this.pictureBoxInfoImageOne.Image = global::MARAFON.Properties.Resources.teatro_municipal;
            this.pictureBoxInfoImageOne.Location = new System.Drawing.Point(12, 246);
            this.pictureBoxInfoImageOne.Name = "pictureBoxInfoImageOne";
            this.pictureBoxInfoImageOne.Size = new System.Drawing.Size(85, 60);
            this.pictureBoxInfoImageOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInfoImageOne.TabIndex = 4;
            this.pictureBoxInfoImageOne.TabStop = false;
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.Image = global::MARAFON.Properties.Resources.marathon_skills_2016_marathon_map;
            this.pictureBoxMap.Location = new System.Drawing.Point(4, 48);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(213, 183);
            this.pictureBoxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMap.TabIndex = 3;
            this.pictureBoxMap.TabStop = false;
            this.pictureBoxMap.Click += new System.EventHandler(this.pictureBoxMap_Click);
            // 
            // FormInfoMarathon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 446);
            this.Controls.Add(this.pictureBoxInfoImageFour);
            this.Controls.Add(this.pictureBoxInfoImageFree);
            this.Controls.Add(this.pictureBoxInfoImageTwo);
            this.Controls.Add(this.pictureBoxInfoImageOne);
            this.Controls.Add(this.pictureBoxMap);
            this.Controls.Add(this.labelSponsoreInfo);
            this.Controls.Add(this.labelSponsoreTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormInfoMarathon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о Marathon Skills 2016";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoImageFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoImageFree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoImageTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoImageOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSponsoreTitle;
        private System.Windows.Forms.Label labelSponsoreInfo;
        private System.Windows.Forms.PictureBox pictureBoxMap;
        private System.Windows.Forms.PictureBox pictureBoxInfoImageOne;
        private System.Windows.Forms.PictureBox pictureBoxInfoImageTwo;
        private System.Windows.Forms.PictureBox pictureBoxInfoImageFree;
        private System.Windows.Forms.PictureBox pictureBoxInfoImageFour;
    }
}