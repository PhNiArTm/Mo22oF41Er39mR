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
    public partial class FormRegisterAsARunner : Form
    {
        DateTime voteTime = new DateTime(2021, 04, 24, 6, 0, 0);
        FormMain formMain = new FormMain();
        public FormRegisterAsARunner()
        {
            InitializeComponent();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan TimeRemaining = voteTime - DateTime.Now;
            labelEventTime.Text = TimeRemaining.Days + " дней " + TimeRemaining.Hours + " часов " + TimeRemaining.Minutes + " минут " + TimeRemaining.Seconds + " секунд.";
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormRegisterAsARunner_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        private void buttonOldUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            FormRegistrationRunner formRegistrationRunner = new FormRegistrationRunner();
            formRegistrationRunner.Show();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
