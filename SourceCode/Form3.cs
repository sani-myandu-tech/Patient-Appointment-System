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
    public partial class Form3 : Form
    {
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonBack;

        public Form3()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; 
            this.Text = "Appointment Booking"; 
            this.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                    DateTime selectedDate = monthCalendar1.SelectionStart;

                    DialogResult result = MessageBox.Show("Do you want to confirm your appointment for {selectedDate.ToShortDateString()}?",
                        "Confirm Appointment",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                 {
                MessageBox.Show("Appointment successfully booked for {selectedDate.ToShortDateString()}!",
                            "Appointment Confirmed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                 }
            }
                catch
                {
                    MessageBox.Show("An error occurred while selecting a date: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonBack.Text = "Back to Menu";
            this.buttonBack.Click += new System.EventHandler(this.button1_Click);
            this.Controls.Add(this.button1);
            this.Close();

        }
    }
}
