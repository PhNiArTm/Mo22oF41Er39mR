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
    public partial class FormDetailInfo : Form
    {
        public FormDetailInfo()
        {
            InitializeComponent();
        }

        private void buttonDonateCompany_Click(object sender, EventArgs e)
        {
            FormCompanyDonate frm = new FormCompanyDonate();
            frm.Show();
            this.Hide();
        }

        private void buttonDurationMarathon_Click(object sender, EventArgs e)
        {
            FormHowLong frm = new FormHowLong();
            frm.Show();
            this.Hide();
        }

        private void buttonSkills2016_Click(object sender, EventArgs e)
        {
            FormInformAboutMarafon frm = new FormInformAboutMarafon();
            frm.Show();
            this.Hide();
        }
    }
}
