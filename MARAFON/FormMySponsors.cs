using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MARAFON
{
    public partial class FormMySponsors : Form
    {
        int fullDonate = 0;
        string infocompany;
        public FormMySponsors()
        {
            InitializeComponent();
            infoSponsors();
            getCompanyInfo();
        }
        public void infoSponsors()
        {
            listViewSponsorsInfo.Items.Clear();
            Program.connection.Open();
            string sql = "SELECT Sponsorship.SponsorName, Sponsorship.Amount FROM Sponsorship JOIN Runner ON Runner.Email='" + Program.userInfo.Email + "'";
            MySqlCommand sqlCommand = new MySqlCommand(sql, Program.connection);
            ListViewItem item = new ListViewItem();
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                item = new ListViewItem(new string[]
                {
                    Convert.ToString(reader["SponsorName"]),
                    Convert.ToString(reader["Amount"]) + "$",
                });
                fullDonate += Convert.ToInt32(reader["Amount"]);
                listViewSponsorsInfo.Items.Add(item);
            }
            Program.connection.Close();
            labelFullMoney.Text = fullDonate.ToString();
        }
        public void getCompanyInfo()
        {
            Program.connection.Open();
            string sql = "SELECT Charity.CharityName, Charity.CharityDescription, Charity.CharityLogo FROM Charity WHERE Charity.CharityId=(SELECT Registration.CharityId FROM Registration JOIN Runner ON Runner.Email='" + Program.userInfo.Email + "')";
            MySqlCommand sqlCommand = new MySqlCommand(sql, Program.connection);
            ListViewItem item = new ListViewItem();
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                infocompany = reader["CharityDescription"].ToString();
                labelNameCompany.Text = reader["CharityName"].ToString();
                //pictureBoxLogoCompany.Image = Image.FromFile("image/" + reader["CharityLogo"].ToString());
            }
            Program.connection.Close();
        }

        private void buttonWatchInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(infocompany);
        }
    }
}
