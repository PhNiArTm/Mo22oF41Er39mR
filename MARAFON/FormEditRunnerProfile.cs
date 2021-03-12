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
    public partial class FormEditRunnerProfile : Form
    {
        bool checkCancelButton = false;
        DateTime voteTime = new DateTime(2021, 04, 24, 6, 0, 0);
        public FormEditRunnerProfile()
        {
            InitializeComponent();
            ShowGenders();
            ShowCountry();
            ShowInfoRunner();
        }
        void ShowInfoRunner()
        {
            labelEmail.Text = Program.userInfo.Email;
            textBoxName.Text = Program.userInfo.FirstName;
            textBoxSurname.Text = Program.userInfo.LastName;
            textBoxPassword.Text = Program.userInfo.Password;
            textBoxRepeatPassword.Text = Program.userInfo.Password;
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
                comboBoxGender.SelectedItem = Program.userInfo.Gender;
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
                comboBoxCountry.SelectedItem = $"{Program.userInfo.CountryName} {Program.userInfo.CountryCode}";
            }
            catch
            {

            }
            finally
            {
                Program.connection.Close();
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan TimeRemaining = voteTime - DateTime.Now;
            labelEventTime.Text = TimeRemaining.Days + " дней " + TimeRemaining.Hours + " часов " + TimeRemaining.Minutes + " минут " + TimeRemaining.Seconds + " секунд.";
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (CheckEdit()) MessageBox.Show("Данные не изменены");
            else
            {
                string countryCode = comboBoxCountry.Text.Remove(0, comboBoxCountry.Text.Length - 3);
                string countryName = comboBoxCountry.Text.Remove(comboBoxCountry.Text.Length - 4);
                Program.connection.Open();
                string Date = String.Format($"{dateTimePickerBirthday.Value.Year}.{dateTimePickerBirthday.Value.Month}.{dateTimePickerBirthday.Value.Day}");
                MySqlCommand sqlCommand = new MySqlCommand($"UPDATE User SET Password= '{textBoxPassword.Text}', FirstName= '{textBoxName.Text}', LastName= '{textBoxSurname.Text}' WHERE `Email` = \"{Program.userInfo.Email}\"", Program.connection);
                sqlCommand.ExecuteNonQuery();
                sqlCommand = new MySqlCommand($"UPDATE Runner SET Gender= '{comboBoxGender.SelectedItem}', CountryCode= '{comboBoxCountry.Text.Remove(0,comboBoxCountry.Text.Length-3)}', DateOfBirth= '{Date}' WHERE `Email` = \"{Program.userInfo.Email}\"", Program.connection);
                sqlCommand.ExecuteNonQuery();
                Program.userInfo.FirstName = textBoxName.Text;
                Program.userInfo.LastName = textBoxSurname.Text;
                Program.userInfo.CountryCode = countryCode;
                Program.userInfo.CountryName = countryName;
                Program.userInfo.Password = textBoxPassword.Text;
                Program.userInfo.Gender = comboBoxGender.Text;
                Program.connection.Close();
                ExitForm();
            }
        }
        bool CheckEdit()
        {
            return textBoxName.Text == Program.userInfo.FirstName
                && textBoxPassword.Text == Program.userInfo.Password
                && textBoxSurname.Text == Program.userInfo.LastName
                && comboBoxCountry.Text == $"{Program.userInfo.CountryName} {Program.userInfo.CountryCode}"
                && comboBoxGender.Text == Program.userInfo.Gender;
        }
        private void textBoxRepeatPassword_TextChanged(object sender, EventArgs e)
        {
            labelCheckPassword.Text = textBoxPassword.Text == textBoxRepeatPassword.Text ? "" : "Пароли не совпадают";
        }
        private void FormEditRunnerProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!checkCancelButton)
            {
                Application.Exit();
            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            ExitForm2();
        }
        private void ExitForm2()
        {
            if (!CheckEdit())
            {
                if (MessageBox.Show("Выйти не сохранив изменения?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ExitForm();
                }
            }
            else
            {
                ExitForm();
            }
        }
        private void ExitForm()
        {
            checkCancelButton = true;
            FormMenuRunner formMenu = new FormMenuRunner();
            this.Close();
            formMenu.Show();
        }
        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            labelCheckDifficult.Text = Regex.IsMatch(textBoxPassword.Text, @"([A-Z])") && Regex.IsMatch(textBoxPassword.Text, @"(\d+)") && (textBoxPassword.Text.Length >= 6 && textBoxPassword.Text.Length <= 100) && Regex.IsMatch(textBoxPassword.Text, @"[!@#$%^]+") ? "" : "Пароль простой";
        }
        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            labelCheckDifficult.Text = null;
        }
        public static int locXE = 0;
        public static int locYE = 0;
        private void labelCheckDifficult_MouseHover(object sender, EventArgs e)
        {
            locXE = Cursor.Position.X - 40;
            locYE = Cursor.Position.Y - 40;
            if (!String.IsNullOrEmpty(labelCheckDifficult.Text))
            {
                FormPint formPint = new FormPint();
                formPint.Show();
            }
        }
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Program.UserInfoClear();
            checkCancelButton = true;
            Program.formMain.Show();
            this.Close();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ExitForm2();
        }
    }
}
