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
    public partial class FormMenuAdmin : Form
    {
        public FormMenuAdmin()
        {
            InitializeComponent();
        }

        private void buttonVolunteer_Click(object sender, EventArgs e)
        {
            FormVolunteers formVolunteers = new FormVolunteers();
            formVolunteers.Show();
            this.Hide();
        }
    }
}
