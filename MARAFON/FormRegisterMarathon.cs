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
    public partial class FormRegisterMarathon : Form
    {
        string type = "A";
        public FormRegisterMarathon()
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

        //private void buttonRegister_Click(object sender, EventArgs e)
        //{
        //    type = (radioButtonDesicionB.Checked) ? "B" : type;
        //    type = (radioButtonDesicionC.Checked) ? "C" : type;
        //    Program.connection.Open();
        //    MySqlCommand command = new MySqlCommand("INSERT INTO Registration (RunnerId, RegistrationDateTime, RaceKitOptionId, RegistrationStatusId, Cost, CharityId, SponsorshipTarget) VALUES (@RunnerId, @RegistrationDateTime, @RaceKitOptionId, @RegistrationStatusId, @Cost, @CharityId, @SponsorshipTarget)", connection);
        //    command.Parameters.AddWithValue("@RunnerId", login);
        //    command.Parameters.AddWithValue("@RegistrationDateTime", DateTime.Now);
        //    command.Parameters.AddWithValue("@RaceKitOptionId", brace);
        //    command.Parameters.AddWithValue("@RegistrationStatusId", "1");
        //    command.Parameters.AddWithValue("@Cost", itog);
        //    command.Parameters.AddWithValue("@CharityId", metroComboBox1.SelectedIndex + 1);
        //    command.Parameters.AddWithValue("@SponsorshipTarget", metroTextBox2.Text);
        //    command.Prepare();
        //    command.ExecuteNonQuery();
        //    connection.Close();
        //    MetroMessageBox.Show(this, "Вы успешно зарегистрированы на забег! С вами свяжутся для уточнения деталей оплаты");
        //}
    }
}
