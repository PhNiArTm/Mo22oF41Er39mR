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
        private Dictionary<string, string> dict = new Dictionary<string, string>{
            {"Комплект","" },
            {"Тип А","" },
            {"Тип B","" },
            {"Тип C","" },
            {"Необходимо","" },
            {"Остаток","" },
            {"Выбрало данный вариант","" },
            {"Номер","" },
            {"RFID бр-т","" },
            {"Бейсболка","" },
            {"Бут. Воды","" },
            {"Футболка","" },
            {"Сув. букл.","" },
            };
        public FormInventory()
        {
            InitializeComponent();
            Program.formMain.label = labelTimer;
            Program.formMain.timerEvent_Tick(Program.formMain.sender, Program.formMain.e);
            int count_reg_runners = getCountRunners();
            labelCountRunners.Text = count_reg_runners.ToString();
            fillPanel();
            //tableLayoutPanel.Controls.;
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
                string test = sqlDataReader.GetString("count");
                count = Convert.ToInt32(sqlDataReader.GetString("count"));
            }
            catch { }

            Program.connection.Close();
            sqlDataReader.Close();
            return count;
        }

        private void fillPanel()
        {
            int t = tableLayoutPanel.Controls.Count;
            foreach (Label label in tableLayoutPanel.Controls)
            {

                //tableLayout;
                int i = 0;
            }
        }
    }
}
