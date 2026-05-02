using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form4 : Form
    {
        Timer timer = new Timer();
        Timer mainTimer = new Timer();
        Timer loadingDotsTimer = new Timer();
        int dotCount = 0;

        public Form4()
        {
            InitializeComponent();
            timer.Interval = 3000;
            timer.Tick += timer1_Tick;
            timer.Start();

            mainTimer.Interval = 5000; 
            mainTimer.Tick += timer1_Tick;
            mainTimer.Start();
         
            loadingDotsTimer.Interval = 500;
            loadingDotsTimer.Tick += timer2_Tick;
            loadingDotsTimer.Start();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Hide();

            mainTimer.Stop();
            loadingDotsTimer.Stop();
            new Form1();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            dotCount++;
            if (dotCount > 3)
                dotCount = 1;

            string dots = new string('.', dotCount);
            label2.Text = "Loading" + dots;
        }
    }
}
