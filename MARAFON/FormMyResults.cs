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
    public partial class FormMyResults : Form
    {
        DateTime voteTime = new DateTime(2021, 04, 24, 6, 0, 0);
        public FormMyResults()
        {
            InitializeComponent();
            FillData();
            FillListView();
        }
        void FillData()
        {
            int ageUser = Program.userInfo.DateOfBirth.Year;
            labelGender.Text += Program.userInfo.Gender == "Male" ? "мужской" : "женский";
            labelAge.Text += ageUser > 2003 ? "до 18" : ageUser > 1991 ? "18-29" : ageUser > 1981 ? "30-39" : ageUser > 1964 ? "40-55" : ageUser > 1950 ? "56-70" : "от 70";
        }
        void FillListView()
        {
            List<string> eventId = new List<string>();
            List<string> raceTime = new List<string>();
            listViewResults.Items.Clear();
            Program.connection.Open();
            MySqlCommand sqlCommand = new MySqlCommand($"SELECT EventId, RaceTime FROM `RegistrationEvent` WHERE `RegistrationId` = (SELECT `RegistrationId` FROM `Registration` WHERE `RunnerId` = '150')", Program.connection);
            ListViewItem item;
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                eventId.Add(reader.GetString("EventId"));
                raceTime.Add(reader.GetString("RaceTime"));
            }
            reader.Close();
            for(int i = 0; i < eventId.Count; i++)
            {
                sqlCommand = new MySqlCommand($"SELECT YearHeld, CountryCode FROM Marathon WHERE MarathonId = (SELECT MarathonId FROM Event WHERE EventId = '{eventId[i]}')", Program.connection);
                MySqlDataReader newReader = sqlCommand.ExecuteReader();
                newReader.Read();
                string lengthRun = eventId[i].ToString().Contains("FM") ? "42 км. Полный марафон" : eventId[i].ToString().Contains("FR") ? "5 км. Мини-марафон" : "21 км. Полу-марафон"; 
                item = new ListViewItem(new string[] { $"{newReader.GetString("YearHeld")} {newReader.GetString("CountryCode")}", lengthRun, $"{raceTime[i]} секунд" });
                listViewResults.Items.Add(item);
                newReader.Close();
            }
            Program.connection.Close();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan TimeRemaining = voteTime - DateTime.Now;
            labelEventTime.Text = TimeRemaining.Days + " дней " + TimeRemaining.Hours + " часов " + TimeRemaining.Minutes + " минут " + TimeRemaining.Seconds + " секунд.";
        }

        private void listViewSponsorsInfo_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.DarkGray, e.Bounds);
            e.DrawText();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMenuRunner frm = new FormMenuRunner();
            frm.Show();
            this.Close();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Program.UserInfoClear();
            Program.formMain.Show();
            this.Close();
        }
    }
}
