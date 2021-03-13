﻿using System;
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
        bool checkCancelButton = false;
        string messageError;
        int idRunner;
        public static string[] fullName;
        public static string sponsorName;
        public static int num;
        public FormSponsoreRunner()
        {
            InitializeComponent();
            showRunner();
            comboBoxRunnerData.SelectedIndex = 0;
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
                reader.Close();
                comboBoxRunnerData.SelectedIndex = 1;
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
                fullName = comboBoxRunnerData.SelectedItem.ToString().Split(new char[] { ' ', '.' });
                num = money;
                int idRunner = Convert.ToInt32(comboBoxRunnerData.SelectedItem.ToString().Split('.')[0]);
                string sql = String.Format("INSERT INTO Sponsorship (SponsorName, RegistrationId, Amount) VALUES ('{0}', '{1}', '{2}')", name, idRunner, money);
                Program.connection.Open();
                MySqlCommand command = new MySqlCommand(sql, Program.connection);
                command.ExecuteNonQuery();
                Program.connection.Close();
                FormConfirmDonate formConfirmDonate = new FormConfirmDonate();
                checkCancelButton = true;
                formConfirmDonate.Show();
                this.Close();
            }
        }
        private void FormSponsoreRunner_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!checkCancelButton)
            {
                Application.Exit();
            }
        }
        private void textBoxNumberCardData_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num) && num != 8 || num == 127)
            {
                e.Handled = true;
            }
        }
        private void comboBoxRunnerData_SelectedIndexChanged(object sender, EventArgs e)
        {
            idRunner = Convert.ToInt32(comboBoxRunnerData.SelectedItem.ToString().Split('.')[0]);
            Program.connection.Open();
            MySqlCommand SelectCharity = new MySqlCommand($"SELECT `CharityName` FROM `Charity` WHERE `CharityId` =(SELECT `CharityId` FROM `Registration` WHERE `RegistrationId` = '{idRunner}')", Program.connection);
            Program.sqlDataReader = SelectCharity.ExecuteReader();
            Program.sqlDataReader.Read();
            labelFondInfo.Text = Program.sqlDataReader.GetString("CharityName");
            sponsorName = Program.sqlDataReader.GetString("CharityName");
            Program.connection.Close();
        }
    }
}