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
    public partial class FormMenuRunner : Form
    {
        DateTime voteTime = new DateTime(2021, 04, 24, 6, 0, 0);
        bool checkCancelButton = false;
        public FormMenuRunner()
        {
            InitializeComponent();
            label1.Text += $"\n[{Program.userInfo.FirstName} {Program.userInfo.LastName}]";
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan TimeRemaining = voteTime - DateTime.Now;
            labelEventTime.Text = TimeRemaining.Days + " дней " + TimeRemaining.Hours + " часов " + TimeRemaining.Minutes + " минут " + TimeRemaining.Seconds + " секунд.";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Program.UserInfoClear();
            checkCancelButton = true;
            Program.formMain.Show();
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            checkCancelButton = true;
            Program.formMain.Show();
            this.Close();
        }

        private void FormMenuRunner_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!checkCancelButton)
            {
                Application.Exit();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.userInfo.checkIsRegisterOnMarafon)
            {
                MessageBox.Show("Вы уже зарегестрировались на марафон!","",MessageBoxButtons.OK);
            }
            else
            {
                checkCancelButton = true;
                FormRegistrationOnMarafon formRegistrationOnMarafon = new FormRegistrationOnMarafon();
                formRegistrationOnMarafon.Show();
                this.Close();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            checkCancelButton = true;
            FormEditRunnerProfile formEditRunner = new FormEditRunnerProfile();
            formEditRunner.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Program.userInfo.checkIsRegisterOnMarafon)
            {
                MessageBox.Show("Вы еще не зарегестрировались на марафон!", "", MessageBoxButtons.OK);
            }
            else
            {
                checkCancelButton = true;
                FormMySponsors formMySponsors = new FormMySponsors();
                formMySponsors.Show();
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormMyResults formMyResults = new FormMyResults();
            checkCancelButton = true;
            formMyResults.Show();
            this.Close();
        }
    }
}