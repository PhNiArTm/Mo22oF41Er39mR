using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MARAFON
{
    public partial class FormInventory : Form
    {
        MySqlDataAdapter da;
        DataTable dt;
        public FormInventory()
        {
            InitializeComponent();
            InfoInventory();
        }
        protected void InfoInventory()
        {
            string sql = "SELECT (SELECT COUNT(*) as count FROM Registration WHERE `RaceKitOptionId`='A') UNION (SELECT COUNT(*) as count FROM Registration WHERE `RaceKitOptionId`= 'B') UNION (SELECT COUNT(*) as count FROM Registration WHERE `RaceKitOptionId`= 'C')";
            for (int i = 0; i < 6; i++)
            {
                if (i == 0)
                {
                    ListViewItem listitem = new ListViewItem("Выбрало данный вариант");
                    int countType = 0;
                    Program.connection.Open();
                    MySqlCommand command = new MySqlCommand(sql, Program.connection);
                    da = new MySqlDataAdapter();
                    da.SelectCommand = command;
                    dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow data in dt.Rows)
                    {
                        countType += Convert.ToInt32(data["(SELECT COUNT(*) as count FROM Registration WHERE `RaceKitOptionId`='A')"]);
                        listitem.SubItems.Add(data["(SELECT COUNT(*) as count FROM Registration WHERE `RaceKitOptionId`='A')"].ToString());
                    }
                    listitem.SubItems.Add(countType.ToString());
                    //listViewInfo.Items.Add(listitem);
                }
                else
                {

                }
            }
        }
    }
}
