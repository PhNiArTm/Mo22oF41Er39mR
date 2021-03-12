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
    public partial class FormConfirmROM : Form
    {
        DateTime voteTime = new DateTime(2021, 04, 24, 6, 0, 0);
        bool checkCancelButton = false;
        public FormConfirmROM()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenuRunner formMenuRunner = new FormMenuRunner();
            checkCancelButton = true;
            formMenuRunner.Show();
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMenuRunner formMenuRunner = new FormMenuRunner();
            checkCancelButton = true;
            formMenuRunner.Show();
            this.Close();
        }

        private void FormConfirmROM_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!checkCancelButton)
            {
                Application.Exit();
            }
        }
    }
}