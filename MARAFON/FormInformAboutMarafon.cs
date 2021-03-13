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
        public FormInformAboutMarafon()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormInteractionMap formMap = new FormInteractionMap();
            formMap.Show();
            this.Hide();
        }
    }
}
