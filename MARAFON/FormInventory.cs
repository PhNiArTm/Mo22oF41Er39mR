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
    public partial class FormInventory : Form
    {
        public int[] counts = new int[3];
        public char[] Ids = new char[3] { 'A', 'B', 'C' };
        public FormInventory()
        {
            InitializeComponent();
            //Program.formMain.label = labelTimer;
            //Program.formMain.timerEvent_Tick(Program.formMain.sender, Program.formMain.e);
            int count_reg_runners = getCountRunners();
            labelCountRunners.Text = count_reg_runners.ToString();
            fillPanel();
        }

        private int getCountRunners()
        {
            Program.connection.Open();
            MySqlDataReader sqlDataReader = null;
            int count = 0;
            try
            {
                string sql = "SELECT COUNT(*) as count FROM Registration";
                MySqlCommand sqlCommand = new MySqlCommand(sql, Program.connection);
                sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Read();
                count = Convert.ToInt32(sqlDataReader.GetString("count"));
            }
            catch { }

            Program.connection.Close();
            sqlDataReader.Close();
            return count;
        }

        public void updateCounts()
        {
            Program.connection.Open();
            for (int i = 0; i < Ids.Length; i++)
            {
                string sql = $"SELECT Count FROM RaceKitOption WHERE RaceKitOptionId='{Ids[i]}'";
                MySqlCommand sqlCommand = new MySqlCommand(sql, Program.connection);
                Program.sqlDataReader = sqlCommand.ExecuteReader();
                Program.sqlDataReader.Read();
                counts[i] = Convert.ToInt32(Program.sqlDataReader.GetString("Count"));
                Program.sqlDataReader.Close();
            }
            Program.connection.Close();
        }

        private void fillPanel()
        {
            Program.connection.Open();
            MySqlDataReader sqlDataReader = null;
            try
            {
                string sql = "SELECT COUNT(*) as count FROM Registration WHERE RaceKitOptionId = 'A'";
                int sum = 0;
                MySqlCommand sqlCommand = new MySqlCommand(sql, Program.connection);
                sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Read();
                labelA1.Text = sqlDataReader.GetString("count");
                sum += Convert.ToInt32(sqlDataReader.GetString("count"));
                sqlDataReader.Close();

                sql = "SELECT COUNT(*) as count FROM Registration WHERE RaceKitOptionId = 'B'";
                sqlCommand = new MySqlCommand(sql, Program.connection);
                sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Read();
                labelB1.Text = sqlDataReader.GetString("count");
                sum += Convert.ToInt32(sqlDataReader.GetString("count"));
                sqlDataReader.Close();

                sql = "SELECT COUNT(*) as count FROM Registration WHERE RaceKitOptionId = 'C'";
                sqlCommand = new MySqlCommand(sql, Program.connection);
                sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Read();
                labelC1.Text = sqlDataReader.GetString("count");
                sum += Convert.ToInt32(sqlDataReader.GetString("count"));
                labelSum1.Text = sum.ToString();
                sqlDataReader.Close();

                sql = "SELECT (SELECT Count FROM RaceKitOption WHERE RaceKitOptionId='A')+(SELECT Count FROM RaceKitOption WHERE RaceKitOptionId='B')+(SELECT Count FROM RaceKitOption WHERE RaceKitOptionId='C') as Remains";
                sqlCommand = new MySqlCommand(sql, Program.connection);
                sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Read();
                labelRemains1.Text = Convert.ToString(Convert.ToInt32(sqlDataReader.GetString("Remains")) - sum);
                sqlDataReader.Close();

                labelA2.Text = labelA1.Text;
                labelA3.Text = labelA1.Text;

                labelB2.Text = labelB1.Text;
                labelB3.Text = labelB1.Text;
                labelB4.Text = labelB1.Text;
                labelB5.Text = labelB1.Text;

                labelC2.Text = labelC1.Text;
                labelC3.Text = labelC1.Text;
                labelC4.Text = labelC1.Text;
                labelC5.Text = labelC1.Text;
                labelC6.Text = labelC1.Text;
                labelC7.Text = labelC1.Text;

                labelSum2.Text = labelSum1.Text;
                labelSum3.Text = labelSum1.Text;
                labelSum4.Text = (Convert.ToInt32(labelSum1.Text) - Convert.ToInt32(labelA3.Text)).ToString();
                labelSum5.Text = (Convert.ToInt32(labelSum1.Text) - Convert.ToInt32(labelA3.Text)).ToString();
                labelSum6.Text = (Convert.ToInt32(labelSum1.Text) - Convert.ToInt32(labelA3.Text) - Convert.ToInt32(labelB3.Text)).ToString();
                labelSum7.Text = (Convert.ToInt32(labelSum1.Text) - Convert.ToInt32(labelA3.Text) - Convert.ToInt32(labelB3.Text)).ToString();

                labelRemains2.Text = labelRemains1.Text;
                labelRemains3.Text = labelRemains1.Text;
                labelRemains4.Text = (counts[1] + counts[2] - Convert.ToInt32(labelSum4.Text)).ToString();
                labelRemains5.Text = (counts[1] + counts[2] - Convert.ToInt32(labelSum4.Text)).ToString();
                labelRemains6.Text = (counts[2] - Convert.ToInt32(labelSum6.Text)).ToString();
                labelRemains7.Text = (counts[2] - Convert.ToInt32(labelSum6.Text)).ToString();
            }
            catch { }

            Program.connection.Close();
            sqlDataReader.Close();

            updateCounts();
        }

        private void buttonEntrance_Click(object sender, EventArgs e)
        {
            FormInventoryReceipt form = new FormInventoryReceipt();
            form.Show();
        }
    }
}
