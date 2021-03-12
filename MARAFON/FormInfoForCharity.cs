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
            label1.Text = FormRegistrationOnMarafon.nameOfCharity;
            label2.Text = FormRegistrationOnMarafon.discOfCharity;
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
