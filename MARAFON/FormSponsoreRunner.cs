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
        MySqlConnection connection = new MySqlConnection("server=" +
            "141.8.192.26;" +
            "user=a0521760_users;" +
            "database=a0521760_practicke;" +
            "password=PR02022002");
        MySqlDataAdapter da;
        DataTable dt;
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
        private void addDonate()
        {
            string name = textBoxNameData.Text;
            string cardNumber = textBoxNumberCardData.Text;
            string cardCVC = textBoxCVCData.Text;
            string money = textBoxSummDonate.Text;
            string authorCard = textBoxAuthorCardData.Text;
            int cardMonth = Convert.ToInt32(textBoxMonthCardData.Text);
            int cardYear = Convert.ToInt32(textBoxDayCardData.Text);
            checkField(name, authorCard, cardNumber, cardMonth, cardYear, cardCVC);
            if (String.IsNullOrEmpty(this.messageError))
            {
                MessageBox.Show("Ошибка!", this.messageError, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT Registration.RegistrationId, User.LastName, User.FirstName FROM Registration, User WHERE Registration.RunnerId = (SELECT Runner.RunnerId FROM Runner WHERE Runner.Email = User.Email)", connection);
                da = new MySqlDataAdapter();
                da.SelectCommand = command;
                dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string[] items = new string[] { dt.Rows[i]["RegistrationId"].ToString() + ". " + dt.Rows[i]["FirstName"].ToString() + " " + dt.Rows[i]["LastName"].ToString() };
                    comboBoxRunnerData.Items.Add(string.Join(" ", items));
                }
            }
            catch { }
            finally { connection.Close(); }
        }
        private void checkField(string name, string authorCard, string numberCard, int cardMonth, int cardYear, string cvc)
        {
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
        }
    }
}
