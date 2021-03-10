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

namespace MARAFON
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //if (textBoxEmail.Text != "" && textBoxPassword.Text != "")
            //{
                try
                {
                    Program.connection.Open();
                    //string sql = String.Format("SELECT Email, Password FROM User WHERE Email=\"{0}\" AND Password=\"{1}\"", textBoxEmail.Text, textBoxPassword.Text);
                //Строка для тестирования авторизации
                string sql = "SELECT Email, Password FROM User WHERE Email=\"a.adkin@dayrep.net\" AND Password=\"jwZh2x@p\"";
                MySqlCommand sqlCommand = new MySqlCommand(sql, Program.connection);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = sqlCommand;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Program.userInfo = new User(dt.Rows[0]["Email"].ToString(), dt.Rows[0]["Password"].ToString());
                    Program.connection.Close();
                    MessageBox.Show("Вы авторизовались!!!", "Закрыть", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Не верные Email или пароль","Закрыть",MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                
            //}
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMainCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.formMain.Show();
        }
    }
}
