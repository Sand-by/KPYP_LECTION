using System;
using System.Threading;
using System.Windows.Forms;
namespace Temp
{
    class Program:Form
    {
        Button[] b = new Button[3];
        delegate void Message();
        public Program()
        {
            int Count = 3;
            for (int i = 0; i < Count; i++)
            {
                this.b[i] = new Button();
                b[i].Name = "btn" + i;
                b[i].Location = new System.Drawing.Point(i*250+50, i);
                b[i].Text = "Button" + i;
                b[i].Size = new System.Drawing.Size(151, 79);
                b[i].UseVisualStyleBackColor = true;
                b[i].Click += button1_Click;
                this.Controls.Add(b[i]);
            }
            InitializeComponent();
            
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(694, 375);
            this.Name = "Program";
            this.ResumeLayout(false);

        }
        

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Temp.Program form = new Program();
            Application.Run(form);
            Console.ReadKey();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(sender == b[0])
            {
                MessageBox.Show("Test");
            }
            else if(sender == b[1])
            {
                MessageBox.Show("Test1");
            }
            else
            {
                MessageBox.Show("Test3");
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
