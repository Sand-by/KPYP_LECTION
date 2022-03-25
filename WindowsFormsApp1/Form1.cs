using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void темныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ControlDark;
           
        }

        private void светлыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            


        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text|*.txt|All|*.*";
            ofd.Multiselect = false;
            ofd.ShowDialog();
        }

        private void развернутьНаВесьЭкранToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            richTextBox1.Text = "x: "+e.Location.X.ToString()+
                "\ny: "+ e.Location.Y.ToString();
        }

    }
}
