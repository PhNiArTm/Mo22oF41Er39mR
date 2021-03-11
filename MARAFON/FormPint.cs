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
    public partial class FormPint : Form
    {
        public FormPint()
        {
            InitializeComponent();
            this.Location = new Point(FormRegistrationRunner.locX, FormRegistrationRunner.locY);
        }
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
