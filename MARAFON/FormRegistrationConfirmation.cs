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
    public partial class FormRegistrationConfirmation : Form
    {
        DateTime voteTime = new DateTime(2021, 04, 24, 6, 0, 0);
        public FormRegistrationConfirmation()
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
    }
}
