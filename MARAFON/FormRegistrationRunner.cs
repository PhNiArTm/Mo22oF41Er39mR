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
                MySqlCommand selectCountry = new MySqlCommand("SELECT CountryCode, CountryName FROM Country", Program.connection);
                mySqlDataAdapter = new MySqlDataAdapter();
                mySqlDataAdapter.SelectCommand = selectCountry;
                dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
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
            this.Hide();
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
            formMain.Show();
            this.Close();
        }
        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            string countryCode = comboBoxCountry.SelectedItem.ToString();
            int countryCodeLength = countryCode.Length-3;
            if (CheckForNullOrEmpty()) MessageBox.Show("Заполните все поля!", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (!CheckForCorrectData()) MessageBox.Show("Корректно введите Email!", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (!CheckForPassword()) MessageBox.Show("Введенные пароли не совпадают!", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (!CheckForDifficultPassword(textBoxPassword.Text)) MessageBox.Show("Пароль твой - говно", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(!CheckForNullOrEmpty() && CheckForCorrectData() && CheckForDifficultPassword(textBoxPassword.Text) && CheckForPassword())
            {
                Program.connection.Open();
                string InsertUser = $"INSERT INTO `User` (`Email`,`Password`,`FirstName`,`LastName`,`RoleId`) VALUES ('{textBoxEmail.Text}','{textBoxPassword.Text}','{textBoxName.Text.ToUpper()}','{textBoxSurname.Text.ToUpper()}','R')";
                string InsertRunner = $"INSERT INTO `Runner` (`Email`,`Gender`,`DateOfBirth`,`CountryCode`) VALUES ('{textBoxEmail.Text}','{comboBoxGender.SelectedItem}','{dateTimePickerBirthday.Value}','{countryCode.Remove(0, countryCodeLength)}')";
                MySqlCommand sqlCommand = new MySqlCommand(InsertUser, Program.connection);
                sqlCommand.ExecuteNonQuery().ToString();
                sqlCommand = new MySqlCommand(InsertRunner, Program.connection);
                sqlCommand.ExecuteNonQuery().ToString();
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
                Program.connection.Close();

            }
        }
        private bool CheckForCorrectData()
        {
            string pattern = @"(@)(.+)$"; ;
            return Regex.IsMatch(textBoxEmail.Text, pattern);
        }
        private bool CheckForDifficultPassword(string password)
        {
            return Regex.IsMatch(password, @"([A-Z])") && Regex.IsMatch(password, @"(\d+)") && (password.Length >= 6 && password.Length <= 100) && Regex.IsMatch(password, @"[!@#$%^]+");
        }
        private bool CheckForPassword()
        {
            return textBoxPassword.Text == textBoxRepeatPassword.Text;
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
    }
}