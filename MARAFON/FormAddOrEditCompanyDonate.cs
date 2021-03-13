using System;
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
    public partial class FormAddOrEditCompanyDonate : Form
    {
        bool companyAdd = true;
        int companyTransform = 0;
        public FormAddOrEditCompanyDonate()
        {
            InitializeComponent();
            if (!String.IsNullOrEmpty(Program.companyName))
            {
                getInfoCompany();
                companyAdd = false;
            }
        }
        void getInfoCompany()
        {
            Program.connection.Open();
            string sql = "SELECT CharityId, CharityName, CharityDescription, CharityLogo FROM Charity WHERE Charity.CharityName='" + Program.companyName + "'";
            MySqlCommand selectGender = new MySqlCommand(sql, Program.connection);
            MySqlDataReader reader = selectGender.ExecuteReader();
            while (reader.Read())
            {
                companyTransform = reader.GetInt32("CharityId");
                textBoxNameCompany.Text = reader.GetString("CharityName");
                textBoxDescriptionCompany.Text = reader.GetString("CharityDescription");
            }
            Program.connection.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxNameCompany.Text) && !String.IsNullOrEmpty(textBoxNameCompany.Text))
            {
                try
                {
                    string sql = "";
                    if (companyAdd == true)
                    {
                        sql = String.Format("INSERT INTO Charity (CharityName, CharityDescription, CharityLogo) " +
                            "VALUES ('{0}', {1}, {2})", textBoxNameCompany.Text, textBoxDescriptionCompany.Text, "test.png");
                    }
                    else
                    {
                        sql = String.Format("UPDATE Charity SET CharityName = '{0}', CharityDescription = '{1}', CharityLogo " +
                            "= {2} WHERE Charity.CharityId = {3}", textBoxNameCompany.Text, textBoxDescriptionCompany.Text,
                            "'test,png'", companyTransform);
                    }
                    Program.connection.Open();
                    MySqlCommand sqlCommand = new MySqlCommand(sql, Program.connection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Информация", "Ваше действие успешно выполнено!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Ошибка", "Произошла ошибка, обратитесь к администратору", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { Program.connection.Close(); }
            }
            else
            {
                MessageBox.Show("Ошибка", "Заполните обязательное поле название компании", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
