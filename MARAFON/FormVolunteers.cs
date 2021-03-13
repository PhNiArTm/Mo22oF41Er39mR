using System;
using System.Collections.Generic;
using System.ComponentModel;
using SD = System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace MARAFON
{
    public partial class FormVolunteers : Form
    {
        public MySqlConnection mycon;
        public MySqlCommand mycom;

        public SD.DataSet ds;
        private bool checkCancelButton = false;

        public FormVolunteers()
        {
            InitializeComponent();
            comboBoxSort.SelectedIndex = 0;
            Program.connection.Open();
            try
            {
                string script = "Select COUNT(*) from Volunteer";
                MySqlDataAdapter ms_data = new MySqlDataAdapter(script, Program.connection);
                SD.DataTable table = new SD.DataTable();
                ms_data.Fill(table);
                labelNumberOfVolunteers.Text += table.Rows[0]["COUNT(*)"];
                Program.connection.Close();
            }
            catch
            {
                MessageBox.Show("Connection lost");
            }
            Program.connection.Open();
            string sql = "SELECT FirstName, LastName, CountryCode, Gender FROM Volunteer";
            MySqlCommand sqlCommand = new MySqlCommand(sql, Program.connection);
            MySqlDataReader sqlDataReader = null;
            sqlDataReader = sqlCommand.ExecuteReader();
            listViewVolonters.Items.Clear();
            ListViewItem item = new ListViewItem();
            while (sqlDataReader.Read())
            {
                item = new ListViewItem(new string[]
                {
                    Convert.ToString(sqlDataReader["FirstName"]),
                    Convert.ToString(sqlDataReader["LastName"]),
                    Convert.ToString(sqlDataReader["CountryCode"]),
                    Convert.ToString(sqlDataReader["Gender"])
                });
                listViewVolonters.Items.Add(item);
            }
            Program.connection.Close();
            sqlDataReader.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Program.connection.Open();
            Update(comboBoxSort.SelectedIndex);
        }
        private void Update(int i)
        {
            string[] words = { "FirstName", "LastName", "CountryCode", "Gender" };
            string sql = $"SELECT FirstName, LastName, CountryCode, Gender FROM Volunteer ORDER BY {words[i]}";
            MySqlCommand sqlCommand = new MySqlCommand(sql, Program.connection);
            MySqlDataReader sqlDataReader = null;
            sqlDataReader = sqlCommand.ExecuteReader();

            listViewVolonters.Items.Clear();
            ListViewItem item = new ListViewItem();
            while (sqlDataReader.Read())
            {
                item = new ListViewItem(new string[]
                {
                    Convert.ToString(sqlDataReader["FirstName"]),
                    Convert.ToString(sqlDataReader["LastName"]),
                    Convert.ToString(sqlDataReader["CountryCode"]),
                    Convert.ToString(sqlDataReader["Gender"])
                });
                listViewVolonters.Items.Add(item);
            }
            Program.connection.Close();
            sqlDataReader.Close();
        }
        private void FormVolunteers_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!this.checkCancelButton)
            {
                Application.Exit();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.checkCancelButton = true;
            Program.formMain.Show();
            this.Close();
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            this.checkCancelButton = true;
            Program.formMain.Show();
            Form frm = new FormLoadVolunteer();
            frm.Show();
            this.Close();
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Program.UserInfoClear();
            this.checkCancelButton = true;
            Program.formMain.Show();
            this.Close();
        }
    }
}
