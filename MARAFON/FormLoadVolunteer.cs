using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using MySql.Data.MySqlClient;

namespace MARAFON
{
    public partial class FormLoadVolunteer : Form
    {
        public OpenFileDialog fileInfo;
        bool checkImport = false;
        public FormLoadVolunteer()
        {
            InitializeComponent();
        }

        private void buttonImportData_Click(object sender, EventArgs e)
        {
            fileInfo = new OpenFileDialog();
            fileInfo.Filter = "Файлы CSV|*.csv";
            fileInfo.Multiselect = false;
            if (fileInfo.ShowDialog() != DialogResult.OK) return;
            textBoxNamFile.Text = fileInfo.FileName.ToString();
            checkImport = true;
        }

        private void buttonLoadDB_Click(object sender, EventArgs e)
        {
            if (checkImport == true)
            {
                int count = 0;
                try
                {
                    using (TextFieldParser parser = new TextFieldParser(fileInfo.FileName))
                    {
                        parser.TextFieldType = FieldType.Delimited;
                        parser.SetDelimiters(",");
                        Program.connection.Open();
                        while (!parser.EndOfData)
                        {
                            string[] fields = parser.ReadFields();
                            if (count != 0)
                            {
                                switch (fields[4])
                                {
                                    case "F":
                                        fields[4] = "Female";
                                        break;
                                    case "M":
                                        fields[4] = "Male";
                                        break;
                                }
                                string sql = $"INSERT INTO Volunteer (VolunteerId, FirstName, LastName, CountryCode, Gender) VALUES ('{fields[0]}', '{fields[1]}', '{fields[2]}', '{fields[3]}', '{fields[4]}')";
                                MySqlCommand sqlCommand = new MySqlCommand(sql, Program.connection);
                                sqlCommand.ExecuteNonQuery();
                                count++;
                            }
                            else { count++; }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Произошла ошибка, обратитесь к администратору", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    labelResultAdd.Visible = true;
                    labelResultAdd.Text = "Успешно добавлено: " + count;
                    Program.connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Для начало загрузите файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Form frm = new FormVolunteers();
            frm.Show();
            this.Hide();
        }
    }
}
