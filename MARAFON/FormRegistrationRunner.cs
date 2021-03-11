using MySql.Data.MySqlClient;
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
    public partial class FormRegistrationRunner : Form
    {
        MySqlDataAdapter mySqlDataAdapter;
        DataTable dataTable;
        FormMain formMain = new FormMain();
        public FormRegistrationRunner()
        {
            InitializeComponent();
            ShowGenders();
            ShowCountry();

        }
        private void ShowGenders()
        {
            try
            {
                comboBoxGender.Items.Clear();
                Program.connection.Open();
                MySqlCommand selectGender = new MySqlCommand("SELECT Gender FROM Gender", Program.connection);
                mySqlDataAdapter = new MySqlDataAdapter();
                mySqlDataAdapter.SelectCommand = selectGender;
                dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    string[] items = new string[] { dataTable.Rows[i]["Gender"].ToString()};
                    comboBoxGender.Items.Add(string.Join(" ", items));
                }
            }
            catch 
            {
                
            }
            finally 
            { 
                Program.connection.Close(); 
            }
        }
        private void ShowCountry()
        {
            try
            {
                comboBoxCountry.Items.Clear();
                Program.connection.Open();
                MySqlCommand selectCountry = new MySqlCommand("SELECT CountryCode, CountryName FROM Country", Program.connection);
                mySqlDataAdapter = new MySqlDataAdapter();
                mySqlDataAdapter.SelectCommand = selectCountry;
                dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                for (int i = 0; i < dataTable.Rows.Count; i++) comboBoxCountry.Items.Add(string.Join(" ", dataTable.Rows[i]["CountryName"]));
            }
            catch
            {

            }
            finally
            {
                Program.connection.Close();
            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormRegisterAsARunner formRegisterAsARunner = new FormRegisterAsARunner();
            this.Hide();
            formRegisterAsARunner.Show();
        }

        private void FormRegistrationRunner_FormClosed(object sender, FormClosedEventArgs e)
        {
            formMain.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            formMain.Show();
            this.Close();
        }
        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            
        }
    }
}