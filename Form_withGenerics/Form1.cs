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
        public ObservableCollection<SomeClass> colr = new ObservableCollection<SomeClass>();
        public ImageList imgList = new ImageList { ImageSize = new Size(48, 48) };
        public Form1()
        {
            InitializeComponent();
            InitializeSource();
            itinImages();
            dataGridView1.DataSource = la;
            dataGridView1.Columns["Name"].HeaderText = "Имя";
            dataGridView1.Columns["Author"].HeaderText = "Автор";
            dataGridView1.Columns["Cost"].HeaderText = "Ценность";

            colr.Add(new SomeClass { Name = "sd", Author = "sdf", Cost = 10 });
            listBox1.DataSource = colr;
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
            if(name_txt.Text!="" && name_txt.Text!="" && name_txt.Text !="")
            {
                var kniga = new SomeClass { Name = name_txt.Text, Author = author_txt.Text, Cost = int.Parse(cost_txt.Text) };
                la.Add(kniga);
                colr.Add(kniga);
                MessageBox.Show("Добавлено!");
                MessageBox.Show(colr.Count.ToString());
            }
                
        }
    }
}
