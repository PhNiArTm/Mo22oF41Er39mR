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
    public partial class FormRunner : Form
    {
        public FormRunner()
        {
            InitializeComponent();
        }

        private void buttonContact_Click(object sender, EventArgs e)
        {
            Form frm = new FormContactCoordinator();
            frm.Show();
        }
    }
}
