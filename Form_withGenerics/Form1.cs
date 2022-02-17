using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Form_withGenerics.Classes;

namespace Form_withGenerics
{
    public  partial class Form1 : Form
    {
        public List<SomeClass> la = new List<SomeClass>();
        public BindingSource bs = new BindingSource();
        public ImageList imgList = new ImageList { ImageSize = new Size(48, 48) };

        public Form1()
        {
            InitializeComponent();
            InitializeSource();
            itinImages();

            bs.DataSource = la;

            dataGridView1.DataSource = bs;
            dataGridView1.Columns["Name"].HeaderText = "Имя";
            dataGridView1.Columns["Author"].HeaderText = "Автор";
            dataGridView1.Columns["Cost"].HeaderText = "Ценность";

            listBox1.DataSource = bs;
            listBox1.DisplayMember = "Name";

            listView1.Items.Add(la[0].Name + " (" + la[0].Author + ") ");
            listView1.Items.Add(la[1].Name + " (" + la[0].Author + ") ");
            listView1.LargeImageList = imageList1;
            listView1.Items[0].ImageKey = imageList1.Images.Keys[0];


            listView2.Items.Add(la[1].Name);
            listView2.Items[0].ImageKey = imgList.Images.Keys[0];
        }
        public void InitializeSource()
        {
            la.Add(new SomeClass() { Name = "Библия", Author = "Бог", Cost = 1000000 });
            la.Add(new SomeClass() { Name = "История", Author = "Понасенков", Cost = 1 });
        }

        public void itinImages()
        {
            Image img = new Bitmap(Resource1.cover_med);
            imgList.Images.Add(img);
            listView2.View = View.LargeIcon;
            listView2.LargeImageList = imgList;
            imgList.Images.SetKeyName(0, "cover-med.jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(name_txt.Text == String.Empty || name_txt.Text == String.Empty || name_txt.Text == String.Empty)
            {
                MessageBox.Show("Ошибка");
            }
            else
            {
                var kniga = new SomeClass { Name = name_txt.Text, Author = author_txt.Text, Cost = float.Parse(cost_txt.Text) };
                la.Add(kniga);
                bs.ResetBindings(false);


                listView2.Items.Add(la[la.Count-1].Name);
                Image img = new Bitmap(Resource1.cover_med);
                imgList.Images.Add(img);
                listView2.View = View.LargeIcon;
                listView2.LargeImageList = imgList;
                imgList.Images.SetKeyName(0, "cover-med.jpg");
                listView2.Items[listView2.Items.Count-1].ImageKey = imgList.Images.Keys[0];
            }

        }

        private void cost_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && 
                !char.IsDigit(e.KeyChar)   &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        

        private void listView2_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView2.SelectedItems.Count >= 1)
            {
                ListViewItem item = listView2.SelectedItems[0];

                if (item.Bounds.Contains(e.Location))
                {
                    MessageBox.Show(item.Text);
                }
            }
        }
    }
}
