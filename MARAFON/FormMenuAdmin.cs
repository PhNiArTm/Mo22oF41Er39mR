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
        private bool checkCancelButton = false;
        public FormMenuAdmin()
        {
            InitializeComponent();
        }

        private void buttonVolunteer_Click(object sender, EventArgs e)
        {
            FormVolunteers formVolunteers = new FormVolunteers();
            formVolunteers.Show();
            Program.formMain.Show();
            this.Close();
        }

        private void FormMenuAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!this.checkCancelButton)
            {
                Application.Exit();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            checkCancelButton = true;
            
            this.Close();

            Program.formMain.Show();
        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            checkCancelButton = true;
            FormInventory form = new FormInventory();
            this.Close();
            form.Show();
        }
    }
}
