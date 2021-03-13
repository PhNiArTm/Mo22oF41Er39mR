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
    public partial class FormMain : Form
    {
        private bool checkCancelButton = false;
        public object sender = null;
        public EventArgs e = null;
        public Label label = null;
        DateTime voteTime = new DateTime(2021, 04, 24, 6, 0, 0);
        public FormMain()
        {
            InitializeComponent();
            timerEvent.Start();
            FillDate();
        }
        private void FillDate()
        {
            labelNameTag.Text += $"Москва, Россия  \n{DateTime.Now.ToLongDateString()}";
        }

        public void timerEvent_Tick(object sender, EventArgs e)
        {
            if (label == null)
            {
                TimeSpan TimeRemaining = voteTime - DateTime.Now;
                labelEventTime.Text = TimeRemaining.Days + " дней " + TimeRemaining.Hours + " часов " + TimeRemaining.Minutes + " минут " + TimeRemaining.Seconds + " секунд.";
            }
            else
            {
                TimeSpan TimeRemaining = voteTime - DateTime.Now;
                label.Text = TimeRemaining.Days + " дней " + TimeRemaining.Hours + " часов " + TimeRemaining.Minutes + " минут " + TimeRemaining.Seconds + " секунд.";
            }
        }

        private void buttonSponsore_Click(object sender, EventArgs e)
        {
            checkCancelButton = true;
            Form frm = new FormSponsoreRunner();
            frm.Show();
            this.Hide();
        }
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!this.checkCancelButton)
            {
                Application.Exit();
            }
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            checkCancelButton = true;
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            Program.formMain.Hide();
        }
        private void buttonRunner_Click(object sender, EventArgs e)
        {
            checkCancelButton = true;
            FormRegisterAsARunner formRegisterAsARunner = new FormRegisterAsARunner();
            formRegisterAsARunner.Show();
            this.Hide();
        }

        private void buttonEventInfo_Click(object sender, EventArgs e)
        {
            checkCancelButton = true;
            FormDetailInfo frm = new FormDetailInfo();
            frm.Show();
            this.Hide();
        }
    }
}