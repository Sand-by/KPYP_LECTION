using System;
using  System.Windows.Forms;
using System.Threading;
namespace win_thr
{
    partial class Program: Form
    {
        public Program()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(608, 443);
            this.Name = "Program";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Program_MouseDown);
            this.ResumeLayout(false);

        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            win_thr.Program form = new win_thr.Program();
            Thread th = new Thread(() =>
            {
                Application.Run(form);
            });
            th.Start();

            new Thread(() =>
            {
                Thread.CurrentThread.Name = "Поток2";
                Thread.CurrentThread.IsBackground = true;

                Action action = () =>
                {
                    for (int i = 0; i < 10; i++)
                    {

                        Console.WriteLine($"{Thread.CurrentThread.Name} - Итерация N:{i} id-потока: " +
                            $"{Thread.CurrentThread.ManagedThreadId}");
                        Thread.Sleep(2000);
                    }
                };
                action();
            }).Start();
        }

        private void Program_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Console.WriteLine("Нажата левая кнопка мыши");
        }
    }
}
