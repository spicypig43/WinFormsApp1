using System;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int count = 50;
        private Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000; // �]�w�p�ɾ����j��1��
            timer.Tick += timer1_Tick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count--;
            label1.Text = count.ToString();
            if (count <= 0)
            {
                timer.Stop();
                MessageBox.Show("�ɶ���!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
            timer.Interval = 1000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

