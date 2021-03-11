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
        public string connect = "server=" + "141.8.192.26;" + "user=a0521760_users;" + "database=a0521760_practicke;" + "password=PR02022002";
        public SD.DataSet ds;

        public FormVolunteers()
        {
            InitializeComponent();
            try
            {
                string script = "Select COUNT(*) from Volunteer";
                mycon = new MySqlConnection(connect);
                mycon.Open();
                MySqlDataAdapter ms_data = new MySqlDataAdapter(script, connect);
                SD.DataTable table = new SD.DataTable();
                ms_data.Fill(table);
                labelNumberOfVolunteers.Text += table.Rows[0]["COUNT(*)"];
                mycon.Close();
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
            if (comboBoxSort.SelectedItem == null)
            {
                MessageBox.Show("Не выбран вариант сортировки", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBoxSort.SelectedIndex == 0)
            {
                string sql = "SELECT FirstName, LastName, CountryCode, Gender FROM Volunteer";
            }
            else if (comboBoxSort.SelectedIndex == 1)
            {
                
            }
            else if (comboBoxSort.SelectedIndex == 2)
            {
                
            }
            else if (comboBoxSort.SelectedIndex == 3)
            {
                
            }
        }
        
    }
}
