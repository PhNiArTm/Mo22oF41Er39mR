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
    public partial class FormConfirmDonate : Form
    {
        MySqlConnection connection = new MySqlConnection("server=" +
        "141.8.192.26;" +
        "user=a0521760_users;" +
        "database=a0521760_practicke;" +
        "password=PR02022002");
        MySqlDataAdapter da;
        DataTable dt;
        public FormConfirmDonate()
        {
            InitializeComponent();
            showInfoDonate();
        }
        public void showInfoDonate()
        {
            try
            {
                connection.Open();
                string sql = "SELECT User.LastName, User.FirstName, RegistrationEvent.BibNumber, Country.CountryName, Sponsorship.Amount FROM RegistrationEvent, Sponsorship JOIN Registration ON Registration.RegistrationId=Sponsorship.RegistrationId JOIN Runner ON Registration.RunnerId=Runner.RunnerId JOIN User ON User.Email=Runner.Email JOIN Country ON Country.CountryCode=Runner.CountryCode WHERE SponsorshipId=(SELECT SponsorshipId FROM Sponsorship ORDER BY SponsorshipId DESC LIMIT 1) AND RegistrationEvent.RegistrationId=Registration.RegistrationId LIMIT 1";
                MySqlCommand sqlCommand = new MySqlCommand(sql, connection);
                da = new MySqlDataAdapter();
                da.SelectCommand = sqlCommand;
                dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    MessageBox.Show(dt.Rows[i]["FirstName"].ToString());
                    labelNameRunner.Text = dt.Rows[i]["FirstName"].ToString() + " " + dt.Rows[i]["LastName"].ToString() + "(" + dt.Rows[i]["BibNumber"].ToString() + ") из " + dt.Rows[i]["CountryName"].ToString();
                    labelCountDonate.Text = "$" + dt.Rows[i]["Amount"].ToString();
                }
            }
            catch { }
            finally { connection.Close(); }
        }
    }
}
