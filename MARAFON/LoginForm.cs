using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MARAFON
{
    public partial class FormLogin : Form
    {
        private bool checkCancelButton = false;
        DateTime voteTime = new DateTime(2021, 04, 24, 6, 0, 0);

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text != "" && textBoxPassword.Text != "")
            {
                try
                {
                    if (Regex.IsMatch(textBoxEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                    {
                        Program.connection.Open();
                        string sql = String.Format("SELECT * FROM User WHERE Email='{0}' AND Password='{1}'", textBoxEmail.Text, textBoxPassword.Text);
                        MySqlCommand sqlCommand = new MySqlCommand(sql, Program.connection);
                        Program.sqlDataReader = sqlCommand.ExecuteReader();
                        Program.sqlDataReader.Read();
                        Program.userInfo.Email = Program.sqlDataReader.GetString("Email");
                        Program.userInfo.Password = Program.sqlDataReader.GetString("Password");
                        Program.userInfo.FirstName = Program.sqlDataReader.GetString("FirstName");
                        Program.userInfo.LastName = Program.sqlDataReader.GetString("LastName");
                        Program.userInfo.RoleId = Program.sqlDataReader.GetString("RoleId");
                        Program.sqlDataReader.Close();
                        sqlCommand = new MySqlCommand($"SELECT RunnerId, Gender, CountryCode, DateOfBirth, IsCheckROM FROM Runner WHERE Email='{textBoxEmail.Text}'", Program.connection);
                        Program.sqlDataReader = sqlCommand.ExecuteReader();
                        Program.sqlDataReader.Read();
                        Program.userInfo.Gender = Program.sqlDataReader.GetString("Gender");
                        Program.userInfo.CountryCode = Program.sqlDataReader.GetString("CountryCode");
                        Program.userInfo.DateOfBirth = Program.sqlDataReader.GetDateTime("DateOfBirth");
                        Program.userInfo.RunnerId = Program.sqlDataReader.GetInt32("RunnerId");
                        Program.userInfo.checkIsRegisterOnMarafon = Program.sqlDataReader.GetBoolean("IsCheckROM");
                        Program.sqlDataReader.Close();
                        DateTime Age = Program.userInfo.DateOfBirth;
                        Program.userInfo.AgeGroup = Age.Year > 2003 ? 1 : Age.Year > 1991 ? 2 : Age.Year > 1981 ? 3 : Age.Year > 1964 ? 4 : Age.Year > 1950 ? 5 : 6;
                        sqlCommand = new MySqlCommand($"SELECT CountryName FROM Country WHERE CountryCode='{Program.userInfo.CountryCode}'", Program.connection);
                        Program.sqlDataReader = sqlCommand.ExecuteReader();
                        Program.sqlDataReader.Read();
                        Program.userInfo.CountryName = Program.sqlDataReader.GetString("CountryName");
                        Program.connection.Close();
                        MessageBox.Show("Вы авторизовались!", "Закрыть", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        switch (Program.userInfo.RoleId)
                        {
                            case "R":
                                FormMenuRunner formMenuRunner = new FormMenuRunner();
                                formMenuRunner.Show();
                                checkCancelButton = true;
                                break;
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Не валидна введена почта!", "Закрыть", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Не верные Email или пароль", "Закрыть", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    Program.connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Закрыть", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.checkCancelButton = true;
            Program.formMain.Show();
            this.Close();
        }

        private void buttonMainCancel_Click(object sender, EventArgs e)
        {
            this.checkCancelButton = true;
            Program.formMain.Show();
            this.Close();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!this.checkCancelButton)
            {
                Application.Exit();
            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            checkCancelButton = true;
            Program.formMain.Show();
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan TimeRemaining = voteTime - DateTime.Now;
            labelEventTime.Text = TimeRemaining.Days + " дней " + TimeRemaining.Hours + " часов " + TimeRemaining.Minutes + " минут " + TimeRemaining.Seconds + " секунд.";

        }
    }
}
