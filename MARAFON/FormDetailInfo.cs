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
        private bool checkCancelButton = false;
        public FormDetailInfo()
        {
            InitializeComponent();
        }

        private void buttonDonateCompany_Click(object sender, EventArgs e)
        {
            FormCompanyDonate frm = new FormCompanyDonate();
            frm.Show();
            this.Close();
        }

        private void buttonDurationMarathon_Click(object sender, EventArgs e)
        {
            this.checkCancelButton = true;
            FormHowLong frm = new FormHowLong();
            frm.Show();
            this.Close();
        }

        private void buttonSkills2016_Click(object sender, EventArgs e)
        {
            this.checkCancelButton = true;
            FormInformAboutMarafon frm = new FormInformAboutMarafon();
            frm.Show();
            this.Close();
        }

        private void FormDetailInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!this.checkCancelButton)
            {
                Application.Exit();
            }
        }
    }
}
