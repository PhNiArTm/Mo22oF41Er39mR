using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MARAFON
{ 
    public partial class FormInformAboutMarafon : Form
    {
        private bool checkCancelButton = false;
        public FormInformAboutMarafon()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            checkCancelButton = true;
            FormInteractionMap formMap = new FormInteractionMap();
            formMap.Show();
            this.Close();
        }

        private void FormInformAboutMarafon_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!this.checkCancelButton)
            {
                Application.Exit();
            }
        }
    }
}
