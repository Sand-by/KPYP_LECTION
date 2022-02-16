using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_threadings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int currentX, currentY;
        bool dragging = false;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            currentY = e.Y;
            currentX = e.X;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Top += (e.Y - currentY);
                Left += (e.X - currentX);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SystemSounds.Question.Play();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
