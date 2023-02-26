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
    }
}