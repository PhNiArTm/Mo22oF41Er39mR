using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace MARAFON
{
    public partial class FormRegistrationOnMarafon : Form
    {
        DateTime voteTime = new DateTime(2021, 04, 24, 6, 0, 0);
        public static string nameOfCharity = null;
        public static string discOfCharity = null;
        private bool checkCancelButton = false;
        int sum = 0;
        string raceKitOption = "A";
        public FormRegistrationOnMarafon()
        {
            InitializeComponent();
            showDeposit();
        }
        protected void showDeposit()
        {
            Program.connection.Open();
            MySqlCommand newcommand = new MySqlCommand("SELECT CharityId, CharityName FROM Charity", Program.connection);
            MySqlDataReader reader = newcommand.ExecuteReader();
            while (reader.Read())comboBoxDeposit.Items.Add($"{reader.GetString("CharityId")}. {reader.GetString("CharityName")}");
            comboBoxDeposit.SelectedIndex = 0;
            Program.connection.Close();
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            checkCancelButton = true;
            FormMenuRunner formMenu = new FormMenuRunner();
            this.Close();
            formMenu.Show();
        }
        private void FormRegistrationOnMarafon_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!checkCancelButton)
            {
                Application.Exit();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan TimeRemaining = voteTime - DateTime.Now;
            labelEventTime.Text = TimeRemaining.Days + " дней " + TimeRemaining.Hours + " часов " + TimeRemaining.Minutes + " минут " + TimeRemaining.Seconds + " секунд.";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            sum = checkBox42km.Checked ? sum += 145 : sum -= 145;
            labelAmountFullRegister.Text = $"{sum}$";
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            sum = checkBox21km.Checked ? sum += 75 : sum -= 75;
            labelAmountFullRegister.Text = $"{sum}$";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            sum = checkBox5km.Checked ? sum += 20 : sum -= 20;
            labelAmountFullRegister.Text = $"{sum}$";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sum = radioButtonTypeA.Checked ? sum += 0 : sum -= 0;
            labelAmountFullRegister.Text = $"{sum}$";
            raceKitOption = "A";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sum = radioButtonTypeB.Checked ? sum += 20 : sum -= 20;
            labelAmountFullRegister.Text = $"{sum}$";
            raceKitOption = "B";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            sum = radioButtonTypeC.Checked ? sum += 45 : sum -= 45;
            labelAmountFullRegister.Text = $"{sum}$";
            raceKitOption = "C";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(!checkBox42km.Checked && !checkBox21km.Checked && !checkBox5km.Checked)
            {
                MessageBox.Show("Выберите один из марафонов!");
            }
            else if(textBoxAmountSponsore.Text == "0")
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите пожертвовать 0$?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    GoToMenu();
                }
                else
                {
                    return;
                }
            }
            else
            {
                GoToMenu();
            }
        }
        void GoToMenu()
        {
            Program.connection.Open();
            MySqlCommand command = new MySqlCommand($"INSERT INTO Registration (RunnerId, RegistrationDateTime, RaceKitOptionId, RegistrationStatusId, Cost, CharityId, SponsorshipTarget) VALUES ({Program.userInfo.RunnerId}, @Time, '{raceKitOption}', \"1\", {sum}, {comboBoxDeposit.SelectedIndex + 1}, {textBoxAmountSponsore.Text})", Program.connection);
            command.Parameters.AddWithValue("@Time", DateTime.UtcNow);
            command.ExecuteNonQuery();
            MySqlCommand Newcommand = new MySqlCommand($"UPDATE Runner SET `IsCheckROM`= '1' WHERE RunnerId = {Program.userInfo.RunnerId}", Program.connection);
            Newcommand.ExecuteNonQuery();
            Program.connection.Close();
            FormMenuRunner formMenuRunner = new FormMenuRunner();
            Program.userInfo.checkIsRegisterOnMarafon = true;
            checkCancelButton = true;
            formMenuRunner.Show();
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string[] charityId = comboBoxDeposit.SelectedItem.ToString().Split('.');
            nameOfCharity = charityId[1].Trim();
            Program.connection.Open();
            String SelectCharity = $"SELECT CharityDescription FROM Charity WHERE CharityName = '{nameOfCharity}'";
            MySqlCommand sqlCommand = new MySqlCommand(SelectCharity, Program.connection);
            Program.sqlDataReader = sqlCommand.ExecuteReader();
            while (Program.sqlDataReader.Read())
            {
                discOfCharity = Program.sqlDataReader.GetString("CharityDescription");
            }
            Program.connection.Close();
            FormInfoForCharity formInfoForCharity = new FormInfoForCharity();
            formInfoForCharity.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkCancelButton = true;
            FormMenuRunner formMenu = new FormMenuRunner();
            this.Close();
            formMenu.Show();
        }
    }
}