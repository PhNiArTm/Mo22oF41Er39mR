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
        DateTime voteTime = new DateTime(2021, 04, 24, 6, 0, 0);
        public FormMain()
        {
            InitializeComponent();
            timer1.Tick += timerEvent_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }
        Timer timer1 = new Timer();

        private void timerEvent_Tick(object sender, EventArgs e)
        {
            TimeSpan TimeRemaining = voteTime - DateTime.Now;
            labelEventTime.Text = TimeRemaining.Days + " дней " + TimeRemaining.Hours + " часов " + TimeRemaining.Minutes + " минут " + TimeRemaining.Seconds + " минут.";
        }

        private void buttonSponsore_Click(object sender, EventArgs e)
        {
            Form frm = new FormSponsoreRunner();
            frm.Show();
            this.Hide();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            Program.formMain.Hide();
        }
    }
}
