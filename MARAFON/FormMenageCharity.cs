using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MARAFON
{
    public partial class FormMenageCharity : Form
    {
        MySqlDataAdapter da;
        DataTable dt;
        public FormMenageCharity()
        {
            InitializeComponent();
            loadData();
        }
        protected void loadData()
        {
            listViewCompany.Items.Clear();
            ImageList image = new ImageList();
            image.ImageSize = new Size(80, 40);


            Bitmap emptyImage = new Bitmap(30, 30);

            using (Graphics gr = Graphics.FromImage(emptyImage))
            {
                gr.Clear(Color.White);
            }

            string sql = "SELECT Charity.CharityName, Charity.CharityDescription, Charity.CharityLogo FROM Charity";
            MySqlCommand command = new MySqlCommand(sql, Program.connection);
            da = new MySqlDataAdapter();
            da.SelectCommand = command;
            dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //image.Images.Add(new Bitmap(String.Format("image/{0}", dt.Rows[i]["CharityLogo"].ToString())));

                ListViewItem listViewItem = new ListViewItem(new string[] { "", dt.Rows[i]["CharityName"].ToString(), dt.Rows[i]["CharityDescription"].ToString() });
                listViewItem.ImageIndex = i;
                listViewCompany.Items.Add(listViewItem);
            }
            image.Images.Add(emptyImage);
            listViewCompany.SmallImageList = image;
            listViewCompany.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewCompany.SelectedItems.Count == 1)
            {
                Program.companyName = listViewCompany.SelectedItems[0].SubItems[1].Text;
                Form frm = new FormAddOrEditCompanyDonate();
                frm.Show();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form frm = new FormAddOrEditCompanyDonate();
            frm.Show();
        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            FormMenuAdmin frm = new FormMenuAdmin();
            frm.Show();
            this.Hide();
        }
    }
}