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
        static DateTime voteTime = new DateTime(2021, 04, 24, 6, 0, 0);
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
        private void timerEvent_Tick(object sender, EventArgs e)
        {
            TimeSpan TimeRemaining = voteTime - DateTime.Now;
            label12.Text = TimeRemaining.Days + " дней " + TimeRemaining.Hours + " часов " + TimeRemaining.Minutes + " минут " + TimeRemaining.Seconds + " секунд.";
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
        private void buttonRunner_Click(object sender, EventArgs e)
        {
            FormRegisterAsARunner formRegisterAsARunner = new FormRegisterAsARunner();
            this.Hide();
            formRegisterAsARunner.Show();
        }
    }
}