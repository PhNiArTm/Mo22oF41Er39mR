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
                        sqlCommand = new MySqlCommand($"SELECT RunnerId, Gender, CountryCode FROM Runner WHERE Email='{textBoxEmail.Text}'", Program.connection);
                        Program.sqlDataReader = sqlCommand.ExecuteReader();
                        Program.sqlDataReader.Read();
                        Program.userInfo.Gender = Program.sqlDataReader.GetString("Gender");
                        Program.userInfo.CountryCode = Program.sqlDataReader.GetString("CountryCode");
                        Program.userInfo.RunnerId = Program.sqlDataReader.GetInt32("RunnerId");
                        Program.sqlDataReader.Close();
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
    }
}
