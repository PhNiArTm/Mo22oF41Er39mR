using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MARAFON
{
    public partial class FormConfirmDonate : Form
    {
        public FormConfirmDonate()
        {
            InitializeComponent();
            showInfoDonate();
        }
        public void showInfoDonate()
        {
            labelNameRunner.Text = $"{FormSponsoreRunner.fullName[0]} {FormSponsoreRunner.fullName[2]} {FormSponsoreRunner.fullName[4]}";
            labelFund.Text = FormSponsoreRunner.sponsorName;
            labelCountDonate.Text = $"${FormSponsoreRunner.num}.00";
        }
    }
}
