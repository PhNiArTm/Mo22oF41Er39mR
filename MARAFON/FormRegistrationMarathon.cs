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
    public partial class FormRegistrationMarathon : Form
    {
        public FormRegistrationMarathon()
        {
            InitializeComponent();
            showDeposit();
        }
        protected void showDeposit()
        {
            Program.connection.Open();
            MySqlCommand newcommand = new MySqlCommand("SELECT CharityId, CharityName FROM Charity", Program.connection);
            MySqlDataReader reader = newcommand.ExecuteReader();
            while (reader.Read())
            {
                string[] items = new string[] { reader.GetString("CharityId") + ". " + reader.GetString("CharityName") };
                comboBoxDeposit.Items.Add(string.Join(" ", items));
            }
            Program.connection.Close();
        }
    }
}
