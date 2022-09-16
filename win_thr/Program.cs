using System;
using  System.Windows.Forms;
using System.Threading;
using System.Windows.Media;
namespace win_thr
{
    partial class Program : Form
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
            this.MouseEnter += new System.EventHandler(this.Program_MouseEnter);
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
        private MediaPlayer m_mediaPlayer;
        private void Program_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Console.WriteLine("Нажата левая кнопка мыши");

            if (e.Button == MouseButtons.Right)
            {
                m_mediaPlayer = new MediaPlayer();
                m_mediaPlayer.Open(new Uri(@"C:\Windows\Media\Ring02.wav"));
                m_mediaPlayer.Play();
                m_mediaPlayer.MediaEnded += new EventHandler(Media_Ended);
            }

            if (e.Button == MouseButtons.Middle)
                m_mediaPlayer.Volume /= 2.0f;
        }
        private void Media_Ended(object sender, EventArgs e)
        {
            m_mediaPlayer.Position = TimeSpan.Zero;
            m_mediaPlayer.Play();
        }

        private void Program_MouseEnter(object sender, EventArgs e)
        {
            this.MouseWheel += new MouseEventHandler(over_MouseWheel);
        }
        float result = 0;

        private void over_MouseWheel(object sender, MouseEventArgs e)
        {
            const float scale_per_delta = 0.05f/120;
            if (e.Delta != 0)
            {
                result += e.Delta * scale_per_delta;
                Console.Out.WriteLine(result);
                if(m_mediaPlayer != null)
                {
                    if(result>0 && result<1)
                        m_mediaPlayer.Volume = result;
                }

            }
        }
    }
}
