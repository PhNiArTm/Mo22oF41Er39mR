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
    public partial class FormHowLong : Form
    {
        public enum ListImage
        {
            F1Car,
            Sloth,
            Bus,
            AirbusA380,
            Ronaldinho,
            Jaguar,
            Worm,
            Capybara,
            PairOfHavaianas,
            FootballField,

        }
        public FormHowLong()
        {
            InitializeComponent();
        }
        protected void selectType(ListImage imageInfo)
        {
            switch (imageInfo)
            {
                case ListImage.Bus:
                    pictureBoxMain.Image = Image.FromFile("image/how-long-is-a-marathon-images/bus.jpg");
                    labelNameLong.Text = "Автобус";
                    labelInfo.Text = "Дистанция 10м";
                    break;
                case ListImage.AirbusA380:
                    pictureBoxMain.Image = Image.FromFile("image/how-long-is-a-marathon-images/airbus-a380.jpg");
                    labelNameLong.Text = "Самолет А380";
                    labelInfo.Text = "Дистанция 73м";
                    break;
                case ListImage.Ronaldinho:
                    pictureBoxMain.Image = Image.FromFile("image/how-long-is-a-marathon-images/ronaldinho.jpg");
                    labelNameLong.Text = "Рональдинио";
                    labelInfo.Text = "Дистанция 1.81м";
                    break;
                case ListImage.FootballField:
                    pictureBoxMain.Image = Image.FromFile("image/how-long-is-a-marathon-images/football-field.jpg");
                    labelNameLong.Text = "Футбольное поле";
                    labelInfo.Text = "Дистанция 105м";
                    break;
                case ListImage.PairOfHavaianas:
                    pictureBoxMain.Image = Image.FromFile("image/how-long-is-a-marathon-images/pair-of-havaianas.jpg");
                    labelNameLong.Text = "Сандали";
                    labelInfo.Text = "Дистанция 0.245м";
                    break;
                case ListImage.Capybara:
                    pictureBoxMain.Image = Image.FromFile("image/how-long-is-a-marathon-images/capybara.jpg");
                    labelNameLong.Text = "Капибара";
                    labelInfo.Text = "Скорость 35км/ч";
                    break;
                case ListImage.Jaguar:
                    pictureBoxMain.Image = Image.FromFile("image/how-long-is-a-marathon-images/jaguar.jpg");
                    labelNameLong.Text = "Ягуар";
                    labelInfo.Text = "Скорость 80км/ч";
                    break;
                case ListImage.F1Car:
                    pictureBoxMain.Image = Image.FromFile("image/how-long-is-a-marathon-images/f1-car.jpg");
                    labelNameLong.Text = "Гоночная машина F1";
                    labelInfo.Text = "Скорость 345км/ч";
                    break;
                case ListImage.Worm:
                    pictureBoxMain.Image = Image.FromFile("image/how-long-is-a-marathon-images/worm.jpg");
                    labelNameLong.Text = "Червь";
                    labelInfo.Text = "Скорость 0.03км/ч";
                    break;
                case ListImage.Sloth:
                    pictureBoxMain.Image = Image.FromFile("image/how-long-is-a-marathon-images/sloth.jpg");
                    labelNameLong.Text = "Ленивец";
                    break;
            }
        }

        private void pictureBoxSloth_Click(object sender, EventArgs e)
        {
            selectType(ListImage.Sloth);
        }

        private void pictureBoxCapybara_Click(object sender, EventArgs e)
        {
            selectType(ListImage.Capybara);
        }

        private void pictureBoxWorm_Click(object sender, EventArgs e)
        {
            selectType(ListImage.Worm);
        }

        private void pictureBoxF1Car_Click(object sender, EventArgs e)
        {
            selectType(ListImage.F1Car);
        }

        private void pictureBoxJaguar_Click(object sender, EventArgs e)
        {
            selectType(ListImage.Jaguar);
        }

        private void pictureBoxPairOfHavaianas_Click(object sender, EventArgs e)
        {
            selectType(ListImage.PairOfHavaianas);
        }

        private void pictureBoxFootballField_Click(object sender, EventArgs e)
        {
            selectType(ListImage.FootballField);
        }

        private void pictureBoxRonaldinho_Click(object sender, EventArgs e)
        {
            selectType(ListImage.Ronaldinho);
        }

        private void pictureBoxAirbusA380_Click(object sender, EventArgs e)
        {
            selectType(ListImage.AirbusA380);
        }

        private void pictureBoxBus_Click(object sender, EventArgs e)
        {
            selectType(ListImage.Bus);
        }
    }
}
