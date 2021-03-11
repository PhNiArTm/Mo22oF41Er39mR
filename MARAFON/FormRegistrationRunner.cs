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
using System.Windows.Forms;

namespace MARAFON
{
    public partial class FormRegistrationRunner : Form
    {
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
                for (int i = 0; i < dataTable.Rows.Count; i++) comboBoxCountry.Items.Add(string.Join(" ", $"{dataTable.Rows[i]["CountryName"]}-{dataTable.Rows[i]["CountryCode"]}"));
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
            FormRegisterAsARunner formRegisterAsARunner = new FormRegisterAsARunner();
            this.Hide();
            formRegisterAsARunner.Show();
        }
        private void FormRegistrationRunner_FormClosed(object sender, FormClosedEventArgs e)
        {
            formMain.Show();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            formMain.Show();
            this.Close();
        }
        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            //if (CheckForNullOrEmpty()) MessageBox.Show("Заполните все поля!", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //if (!CheckForCorrectData()) MessageBox.Show("Корректно введите Email!", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //if (!CheckForPassword()) MessageBox.Show("Введенные пароли не совпадают!", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //if (!CheckForDifficultPassword()) MessageBox.Show("Пароль твой - говно", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Program.connection.Open();
            string countryCode = comboBoxCountry.SelectedItem.ToString();
            int countryCodeLength = countryCode.Length-3;
            string InsertUser = $"INSERT INTO `User` (`Email`,`Password`,`FirstName`,`LastName`,`RoleId`) VALUES ('{textBoxEmail.Text}','{textBoxPassword.Text}','{textBoxName.Text.ToUpper()}','{textBoxSurname.Text.ToUpper()}','R')";
            string InsertRunner = $"INSERT INTO `Runner` (`Email`,`Gender`,`DateOfBirth`,`CountryCode`) VALUES ('{textBoxEmail.Text}','{comboBoxGender.SelectedItem}','{dateTimePickerBirthday.Value}','{countryCode.Remove(0, countryCodeLength)}')";
            Program.userInfo.
            MySqlCommand sqlCommand = new MySqlCommand(InsertUser, Program.connection);
            MessageBox.Show(sqlCommand.ExecuteNonQuery().ToString());
            sqlCommand = new MySqlCommand(InsertRunner, Program.connection);
            MessageBox.Show(sqlCommand.ExecuteNonQuery().ToString());
            Program.connection.Close();
        }
        private bool CheckForCorrectData()
        {
            //мне конкретно поебать на эту константу взятую из инета. мой регекс нихуя не работает!
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$"; ;
            return (Regex.IsMatch(textBoxEmail.Text, pattern));
        }
        private bool CheckForDifficultPassword()
        {
            string pattern = @"([A-Z]{6})(\d+)"; ;
            return (Regex.IsMatch(textBoxPassword.Text, pattern));
        }
        private bool CheckForPassword()
        {
            return textBoxPassword.Text == textBoxRepeatPassword.Text;
        }
        private bool CheckForNullOrEmpty()
        {
            return (String.IsNullOrEmpty(textBoxEmail.Text) || String.IsNullOrEmpty(textBoxName.Text) || String.IsNullOrEmpty(textBoxRepeatPassword.Text) || String.IsNullOrEmpty(textBoxPassword.Text) || String.IsNullOrEmpty(textBoxSurname.Text) || comboBoxCountry.SelectedIndex != 0);
        }
    }
}