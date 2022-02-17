using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form_withGenerics.Classes;

namespace Form_withGenerics
{
    public partial class Form1 : Form
    {
        public List<SomeClass> la = new List<SomeClass>();
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

            listBox1.DataSource = la;
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
    }
}
