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
    public partial class FormInfoForCharity : Form
    {
        public FormInfoForCharity()
        {
            InitializeComponent();
            if (String.Empty == (FormRegistrationOnMarafon.nameOfCharity))
            {
                label1.Text = FormRegistrationOnMarafon.nameOfCharity;
                label2.Text = FormRegistrationOnMarafon.discOfCharity;
            }
            else
            {
                label1.Text = FormMySponsors.nameOfCharitySponsor;
                label2.Text = FormMySponsors.discOfCharitySponsor;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormInfoForCharity_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == (char)Keys.Escape) button1.PerformClick();
        }
    }
}
