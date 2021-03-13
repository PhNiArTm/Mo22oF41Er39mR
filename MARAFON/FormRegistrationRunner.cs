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
    public partial class FormRegistrationRunner : Form
    {
        DateTime voteTime = new DateTime(2021, 04, 24, 6, 0, 0);
        private bool checkCancelButton = false;
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
                MySqlDataReader reader = selectGender.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxGender.Items.Add(reader.GetString("Gender"));
                }
                comboBoxGender.SelectedIndex = 0;
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
                MySqlCommand selectCountry = new MySqlCommand("SELECT CountryName, CountryCode FROM Country", Program.connection);
                MySqlDataReader reader = selectCountry.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxCountry.Items.Add($"{reader.GetString("CountryName")} {reader.GetString("CountryCode")}");
                }
                comboBoxCountry.SelectedIndex = 0;
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
            checkCancelButton = true;
            FormRegisterAsARunner formRegisterAsARunner = new FormRegisterAsARunner();
            this.Close();
            formRegisterAsARunner.Show();
        }
        private void FormRegistrationRunner_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!checkCancelButton)
            {
                Application.Exit();
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            checkCancelButton = true;
            Program.formMain.Show();
            this.Close();
        }
        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            string countryCode = comboBoxCountry.SelectedItem.ToString();
            int countryCodeLength = countryCode.Length - 3;
            if (!CheckData()) MessageBox.Show("Исправьте ошибки!");
            else if (CheckForNullOrEmpty()) MessageBox.Show("Заполните все поля!");
            else if (!CheckForCorrectData()) MessageBox.Show("Корректно введите Email!");
            else
            {
                Program.connection.Open();
                string InsertUser = $"INSERT INTO `User` (`Email`,`Password`,`FirstName`,`LastName`,`RoleId`) VALUES ('{textBoxEmail.Text}','{textBoxPassword.Text}','{textBoxName.Text.ToUpper()}','{textBoxSurname.Text.ToUpper()}','R')";
                MySqlCommand sqlCommand = new MySqlCommand(InsertUser, Program.connection);
                sqlCommand.ExecuteNonQuery();
                string InsertRunner = $"INSERT INTO `Runner` (`Email`,`Gender`,`DateOfBirth`,`CountryCode`, `IsCheckROM`) VALUES ('{textBoxEmail.Text}','{comboBoxGender.SelectedItem}','{dateTimePickerBirthday.Value}','{countryCode.Remove(0, countryCodeLength)}','false')";
                sqlCommand = new MySqlCommand(InsertRunner, Program.connection);
                sqlCommand.ExecuteNonQuery();
                string SelectUser = $"SELECT Email, Password, FirstName, LastName, RoleId FROM User WHERE Email='{textBoxEmail.Text}'";
                sqlCommand = new MySqlCommand(SelectUser, Program.connection);
                Program.sqlDataReader = sqlCommand.ExecuteReader();
                Program.sqlDataReader.Read();
                Program.userInfo.Email = Program.sqlDataReader.GetString("Email");
                Program.userInfo.Password = Program.sqlDataReader.GetString("Password");
                Program.userInfo.FirstName = Program.sqlDataReader.GetString("FirstName");
                Program.userInfo.LastName = Program.sqlDataReader.GetString("LastName");
                Program.userInfo.RoleId = Program.sqlDataReader.GetString("RoleId");
                Program.sqlDataReader.Close();
                string SelectRunner = $"SELECT RunnerId, CountryCode, Gender, IsCheckROM FROM Runner WHERE Email='{textBoxEmail.Text}'";
                sqlCommand = new MySqlCommand(SelectRunner, Program.connection);
                Program.sqlDataReader = sqlCommand.ExecuteReader();
                Program.sqlDataReader.Read();
                Program.userInfo.Gender = Program.sqlDataReader.GetString("Gender");
                Program.userInfo.CountryCode = Program.sqlDataReader.GetString("CountryCode");
                Program.userInfo.RunnerId = Program.sqlDataReader.GetInt32("RunnerId");
                Program.userInfo.checkIsRegisterOnMarafon = Program.sqlDataReader.GetBoolean("IsCheckROM");
                Program.sqlDataReader.Close();
                sqlCommand = new MySqlCommand($"SELECT CountryName FROM Country WHERE CountryCode='{Program.userInfo.CountryCode}'", Program.connection);
                Program.sqlDataReader = sqlCommand.ExecuteReader();
                Program.sqlDataReader.Read();
                Program.userInfo.CountryName = Program.sqlDataReader.GetString("CountryName");
                Program.connection.Close();
                checkCancelButton = true;
                FormMenuRunner formMenuRunner = new FormMenuRunner();
                formMenuRunner.Show();
                this.Close();
            }
        }
        private bool CheckData()
        {
            bool checkEmail = String.IsNullOrEmpty(label1.Text);
            bool checkPassword = String.IsNullOrEmpty(label2.Text);
            bool checkRepeatPassword = String.IsNullOrEmpty(label10.Text);
            return checkEmail && checkPassword && checkRepeatPassword;
        }
        private bool CheckForCorrectData()
        {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,17})+)$"; ;
            return Regex.IsMatch(textBoxEmail.Text, pattern);
        }
        private bool CheckForNullOrEmpty()
        {
            return (String.IsNullOrEmpty(textBoxEmail.Text) || String.IsNullOrEmpty(textBoxName.Text) || String.IsNullOrEmpty(textBoxRepeatPassword.Text) || String.IsNullOrEmpty(textBoxPassword.Text) || String.IsNullOrEmpty(textBoxSurname.Text) || comboBoxCountry.SelectedItem.ToString() == "");
        }
        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            label2.Text = Regex.IsMatch(textBoxPassword.Text, @"([A-Z])") && Regex.IsMatch(textBoxPassword.Text, @"(\d+)") && (textBoxPassword.Text.Length >= 6 && textBoxPassword.Text.Length <= 100) && Regex.IsMatch(textBoxPassword.Text, @"[!@#$%^]+") ? "" : "Пароль простой";
        }
        private void textBoxRepeatPassword_Leave(object sender, EventArgs e)
        {
            label10.Text = textBoxPassword.Text == textBoxRepeatPassword.Text ? "" : "Пароли не совпадают";
        }
        public static int locX = 0;
        public static int locY = 0;
        private void label2_MouseHover(object sender, EventArgs e)
        {
            locX = Cursor.Position.X - 40;
            locY = Cursor.Position.Y - 40;
            if (!String.IsNullOrEmpty(label2.Text))
            {
                FormPint formPint = new FormPint();
                formPint.Show();
            }
        }
        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            label2.Text = null;
        }
        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            Program.connection.Open();
            string checkSelectEmail = $@"SELECT Email FROM User WHERE Email='{textBoxEmail.Text}'";
            MySqlCommand sqlCommand = new MySqlCommand(checkSelectEmail, Program.connection);
            Program.sqlDataReader = sqlCommand.ExecuteReader();
            label1.Text = Program.sqlDataReader.HasRows == true ? "Email занят!" : "";
            Program.connection.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan TimeRemaining = voteTime - DateTime.Now;
            labelEventTime.Text = TimeRemaining.Days + " дней " + TimeRemaining.Hours + " часов " + TimeRemaining.Minutes + " минут " + TimeRemaining.Seconds + " секунд.";
        }

        private void textBoxRepeatPassword_TextChanged(object sender, EventArgs e)
        {
            label10.Text = textBoxPassword.Text == textBoxRepeatPassword.Text ? "" : "Пароли не совпадают";
        }

        private void FormRegistrationRunner_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter) buttonRegistration.PerformClick();
        }
    }
}