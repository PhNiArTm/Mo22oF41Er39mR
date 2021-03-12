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
                        //Строка для тестирования авторизации
                        //string sql = "SELECT Email, Password FROM User WHERE Email='a.adkin@dayrep.net' AND Password='jwZh2x@p'";
                        MySqlCommand sqlCommand = new MySqlCommand(sql, Program.connection);
                        //Program.sqlDataReader;
                        Program.sqlDataReader = sqlCommand.ExecuteReader();
                        Program.sqlDataReader.Read();
                        Program.userInfo.Email = Program.sqlDataReader.GetString("Email");
                        Program.userInfo.Password = Program.sqlDataReader.GetString("Password");
                        Program.userInfo.RoleId = Program.sqlDataReader.GetString("RoleId");
                        Program.connection.Close();
                        Program.sqlDataReader.Close();
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
