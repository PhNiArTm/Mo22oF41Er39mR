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
        bool checkCancelButton = false;
        int fullDonate = 0;
        string infocompany;
        public static string nameOfCharitySponsor = null;
        public static string discOfCharitySponsor = null;
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
            string sql = $"SELECT `SponsorName`, `Amount` FROM `Sponsorship` WHERE `RegistrationId`=(SELECT `RegistrationId` FROM `Registration` WHERE `RunnerId`='{Program.userInfo.RunnerId}')";
            MySqlCommand sqlCommand = new MySqlCommand(sql, Program.connection);
            ListViewItem item = new ListViewItem();
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                item = new ListViewItem(new string[]{ Convert.ToString(reader["SponsorName"]), Convert.ToString(reader["Amount"]) + "$", });
                fullDonate += Convert.ToInt32(reader["Amount"]);
                listViewSponsorsInfo.Items.Add(item);
            }
            reader.Close();
            Program.connection.Close();
            labelFullDonate.Text = $"Всего: {fullDonate}$";
        }
        public void getCompanyInfo()
        {
            Program.connection.Open();
            string sql = $"SELECT Charity.CharityName, Charity.CharityDescription, Charity.CharityLogo FROM Charity WHERE Charity.CharityId=(SELECT Registration.CharityId FROM Registration WHERE RunnerId = {Program.userInfo.RunnerId})";
            MySqlCommand sqlCommand = new MySqlCommand(sql, Program.connection);
            ListViewItem item = new ListViewItem();
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            reader.Read();
            infocompany = reader["CharityDescription"].ToString();
            labelNameCompany.Text = reader["CharityName"].ToString();
            reader.Close();
            Program.connection.Close();
        }
        private void buttonWatchInfo_Click(object sender, EventArgs e)
        {
            nameOfCharitySponsor = labelNameCompany.Text;
            Program.connection.Open();
            String SelectCharity = $"SELECT CharityDescription FROM Charity WHERE CharityName = '{nameOfCharitySponsor}'";
            MySqlCommand sqlCommand = new MySqlCommand(SelectCharity, Program.connection);
            Program.sqlDataReader = sqlCommand.ExecuteReader();
            Program.sqlDataReader.Read();
            discOfCharitySponsor = Program.sqlDataReader.GetString("CharityDescription");
            Program.connection.Close();
            FormInfoForCharity formInfoForCharity = new FormInfoForCharity();
            formInfoForCharity.Show();
        }
        private void FormMySponsors_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!checkCancelButton)
            {
                Application.Exit();
            }
        }
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Program.UserInfoClear();
            checkCancelButton = true;
            Program.formMain.Show();
            this.Close();
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            checkCancelButton = true;
            FormMenuRunner formMenuRunner = new FormMenuRunner();
            formMenuRunner.Show();
            this.Close();
        }
    }
}