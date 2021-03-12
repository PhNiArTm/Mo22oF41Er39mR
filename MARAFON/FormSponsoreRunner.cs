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
    public partial class FormSponsoreRunner : Form
    {
        string messageError;
        public FormSponsoreRunner()
        {
            InitializeComponent();
            showRunner();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonPlusSumm_Click(object sender, EventArgs e)
        {
            int nowSumm = Convert.ToInt32(textBoxSummDonate.Text);
            textBoxSummDonate.Text = (nowSumm + 10).ToString();
            labelResultSumm.Text = "$" + (nowSumm + 10).ToString();
        }

        private void buttonMinusSumm_Click(object sender, EventArgs e)
        {
            int nowSumm = Convert.ToInt32(textBoxSummDonate.Text);
            if (nowSumm != 0)
            {
                textBoxSummDonate.Text = (nowSumm - 10).ToString();
                labelResultSumm.Text = "$" + (nowSumm - 10).ToString();
            }
        }

        private void buttonCancelDonate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void showRunner()
        {
            try
            {
                comboBoxRunnerData.Items.Clear();
                Program.connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT Registration.RegistrationId, User.LastName, User.FirstName FROM Registration, User WHERE Registration.RunnerId = (SELECT Runner.RunnerId FROM Runner WHERE Runner.Email = User.Email)", Program.connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxRunnerData.Items.Add($"{reader.GetString("RegistrationId")}. {reader.GetString("FirstName")}  {reader.GetString("LastName")}");
                }
                comboBoxRunnerData.SelectedIndex = 0;
            }
            catch { }
            finally { Program.connection.Close(); }
        }
        private void checkField(string name, string authorCard, string numberCard, int cardMonth, int cardYear, string cvc, int money)
        {
            this.messageError = "";
            if (String.IsNullOrEmpty(name))
            {
                this.messageError = "Заполните обязательное поле Имя!";
            }
            else if (numberCard.Length != 16)
            {
                this.messageError = "Код карты должен состоять из 16 цифр";
            }
            else if (cvc.Length != 3)
            {
                this.messageError = "CVC код должен содержать 3 цифры";
            }
            else if (money <= 0)
            {
                this.messageError = "Невозможно пожертвовать 0$";
            }
        }

        private void buttonAddDonate_Click(object sender, EventArgs e)
        {
            string name = textBoxNameData.Text;
            string cardNumber = textBoxNumberCardData.Text;
            string cardCVC = textBoxCVCData.Text;
            int money = Convert.ToInt32(textBoxSummDonate.Text);
            string authorCard = textBoxAuthorCardData.Text;
            int cardMonth = Convert.ToInt32(textBoxMonthCardData.Text);
            int cardYear = Convert.ToInt32(textBoxYearCardData.Text);
            checkField(name, authorCard, cardNumber, cardMonth, cardYear, cardCVC, money);
            if (!String.IsNullOrEmpty(this.messageError))
            {
                MessageBox.Show(this.messageError,"Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int idRunner = Convert.ToInt32(comboBoxRunnerData.SelectedItem.ToString().Split('.')[0]);
                string sql = String.Format("INSERT INTO Sponsorship (SponsorName, RegistrationId, Amount) VALUES ('{0}', '{1}', '{2}')", name, idRunner, money);
                Program.connection.Open();
                MySqlCommand command = new MySqlCommand(sql, Program.connection);
                command.ExecuteNonQuery();
                Program.connection.Close();
            }
        }

        private void FormSponsoreRunner_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void textBoxNumberCardData_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num) && num != 8 || num == 127)
            {
                e.Handled = true;
            }
        }
    }
}
