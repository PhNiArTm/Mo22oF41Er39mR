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
            if (FormRegistrationRunner.locX == 0) this.Location = new Point(FormEditRunnerProfile.locXE, FormEditRunnerProfile.locYE);
            else this.Location = new Point(FormRegistrationRunner.locX, FormRegistrationRunner.locY);
        }
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
