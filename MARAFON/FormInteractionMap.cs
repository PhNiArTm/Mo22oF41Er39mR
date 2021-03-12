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
    public partial class FormInteractionMap : Form
    {
        public FormInteractionMap()
        {
            InitializeComponent();
        }
        private void FillingPanel(string Checkpint, string Namen, string Text, bool checkStart)
        {
            labelCheckpoint.Text = Checkpint;
            labelName.Text = Namen;
            label2.Text = checkStart ? "" : "Особенности:";
            label3.Text = Text;
        }
        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            panelBaner.Visible = true;
            FillingPanel("Checkpoit 1", "Avenida Rudge", "- Стенд питья\n- Энергетические батончики", false);
        }
        private void pictureBox15_MouseHover(object sender, EventArgs e)
        {
            panelBaner.Visible = true;
            FillingPanel("Race Start", "Samba Full Marathon", "", true);
        }
        private void pictureBox11_MouseHover(object sender, EventArgs e)
        {
            panelBaner.Visible = true;
            FillingPanel("Checkpoit 2", "Theatro Municipal", "- Стенд питья\n- Энергетические батончики\n- Туалет\n- Информационный стенд \n- Медицинский пункт", false);
        }
        private void pictureBox12_MouseHover(object sender, EventArgs e)
        {
            panelBaner.Visible = true;
            FillingPanel("Checkpoit 3", "Parque do Ibirapuera", "- Стенд питья\n- Энергетические батончики\n- Туалет", false);
        }
        private void pictureBox17_MouseHover(object sender, EventArgs e)
        {
            panelBaner.Visible = true;
            FillingPanel("Race Start", "Capoeira 5km Fun Run", "", true);
        }
        private void pictureBox13_MouseHover(object sender, EventArgs e)
        {
            panelBaner.Visible = true;
            FillingPanel("Checkpoit 4", "Jardim Luzitania", "- Стенд питья\n- Энергетические батончики\n- Туалет\n- Медицинский пункт", false);
        }
        private void pictureBox14_MouseHover(object sender, EventArgs e)
        {
            panelBaner.Visible = true;
            FillingPanel("Checkpoit 5", "Iguatemi", "- Стенд питья\n- Энергетические батончики\n- Туалет\n- Информационный стенд", false);
        }
        private void pictureBox18_MouseHover(object sender, EventArgs e)
        {
            panelBaner.Visible = true;
            FillingPanel("Race Start", "Jongo Half Marathon", "", true);
        }
        private void pictureBox16_MouseHover(object sender, EventArgs e)
        {
            panelBaner.Visible = true;
            FillingPanel("Checkpoit 6", "Rua Lisboa", "- Стенд питья\n- Энергетические батончики\n- Туалет", false);
        }
        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            panelBaner.Visible = false;
            FillingPanel("Checkpoit 1", "Avenida Rudge", "- Стенд питья\n- Энергетические батончики", false);
        }
        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            panelBaner.Visible = false;
            FillingPanel("Checkpoit 3", "Parque do Ibirapuera", "- Стенд питья\n- Энергетические батончики\n- Туалет", false);
        }
        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            panelBaner.Visible = false;
            FillingPanel("Checkpoit 2", "Theatro Municipal", "- Стенд питья\n- Энергетические батончики\n- Туалет\n- Информационный стенд \n- Медицинский пункт", false);
        }
        private void pictureBox15_MouseLeave(object sender, EventArgs e)
        {
            panelBaner.Visible = false;
            FillingPanel("Race Start", "Samba Full Marathon", "", true);
        }
        private void pictureBox16_MouseLeave(object sender, EventArgs e)
        {
            panelBaner.Visible = false;
            FillingPanel("Checkpoit 6", "Rua Lisboa", "- Стенд питья\n- Энергетические батончики\n- Туалет", false);
        }
        private void pictureBox18_MouseLeave(object sender, EventArgs e)
        {
            panelBaner.Visible = false;
            FillingPanel("Race Start", "Jongo Half Marathon", "", true);
        }
        private void pictureBox14_MouseLeave(object sender, EventArgs e)
        {
            panelBaner.Visible = false;
            FillingPanel("Checkpoit 5", "Iguatemi", "- Стенд питья\n- Энергетические батончики\n- Туалет\n- Информационный стенд", false);
        }
        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            panelBaner.Visible = false;
            FillingPanel("Checkpoit 4", "Jardim Luzitania", "- Стенд питья\n- Энергетические батончики\n- Туалет\n- Медицинский пункт", false);
        }
        private void pictureBox17_MouseLeave(object sender, EventArgs e)
        {
            panelBaner.Visible = false;
            FillingPanel("Race Start", "Capoeira 5km Fun Run", "", true);
        }
    }
}
