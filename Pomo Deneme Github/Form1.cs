using System.Diagnostics;

namespace Pomo_Deneme_Github
{
    public partial class Form1 : Form
    {
        TimeStartAbD timeDa = new TimeStartAbD();
        string timeFormat = "HH:mm:ss";
        string basildiStart;
        int sayac;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerLbl.Interval = 1000;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timeDa.StartTime = DateTime.Now.ToString(timeFormat);
            basildiStart = timeDa.StartTime;
            timerLbl.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timeDa.EndTime = DateTime.Now.ToString(timeFormat);
            timerLbl.Stop();
            timeDa.CsvWrite();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            timeDa.Hesaplayici();
            lblTime.Text = timeDa.Hesapla();
        }

        private void timerLbl_Tick(object sender, EventArgs e)
        {
            
            timeDa.WorkTime();
            lblTime.Text = timeDa.GecenTime();

            /*
             * 1    lblTime.Text = timeDa.GecenTime();
             * 2    1 nolu satýr çalýþmýyor
             * 3    Bu yüzden hesaplamayý burada yapacaðým
             */

            //DateTime dtStart = Convert.ToDateTime(basildiStart);
            //DateTime dtEnd = DateTime.Now;
            //TimeSpan tsSonuc = dtEnd.Subtract(dtStart);
            //lblTime.Text = tsSonuc.ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            timeDa.Task = comboBox1.Text;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(txtTask.Text);
            comboBox1.Items.AddRange(new object[] {txtTask.Text});
        }
        private void run_cmd()
        {

            string fileName = @"C:\Users\sebim\Desktop\Python_notion.py";

            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(@"C:\Users\sebim\AppData\Local\Programs\Python\Python311\python.exe", fileName)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = false
            };
            p.Start();

            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            label1.Text = output;
            Console.WriteLine(output);

            Console.ReadLine();

        }

        private void btnNotion_Click(object sender, EventArgs e)
        {
            run_cmd();
        }
    }
}