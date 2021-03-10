using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MARAFON
{
    public partial class FormContactCoordinator : Form
    {
        MySqlDataAdapter da;
        DataTable dt;
        public FormContactCoordinator()
        {
            InitializeComponent();
            labelContactCoordinators.Text = "";
            showContact();
        }
        protected void showContact()
        {
            Program.connection.Open();
            MySqlCommand command = new MySqlCommand("SELECT User.Email, User.FirstName, User.LastName FROM User WHERE User.RoleId='C' LIMIT 3", Program.connection);
            da = new MySqlDataAdapter();
            da.SelectCommand = command;
            dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                labelContactCoordinators.Text += dt.Rows[i]["FirstName"].ToString() + " " + dt.Rows[i]["LastName"].ToString() + ", " + dt.Rows[i]["Email"].ToString() + "\r\n";
            }
        }
    }
}
