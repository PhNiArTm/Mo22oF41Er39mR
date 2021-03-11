﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MARAFON
{
    public partial class FormCompanyDonate : Form
    {
        MySqlDataAdapter da;
        DataTable dt;
        public FormCompanyDonate()
        {
            InitializeComponent();
            loadData();
        }
        protected void loadData()
        {
            listViewInfoCompany.Items.Clear();
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
                image.Images.Add(new Bitmap(String.Format("image/{0}", dt.Rows[i]["CharityLogo"].ToString())));

                ListViewItem listViewItem = new ListViewItem(new string[] { "", dt.Rows[i]["CharityName"].ToString(), dt.Rows[i]["CharityDescription"].ToString() });
                listViewItem.ImageIndex = i;
                listViewInfoCompany.Items.Add(listViewItem);
            }
            image.Images.Add(emptyImage);
            listViewInfoCompany.SmallImageList = image;
            listViewInfoCompany.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
