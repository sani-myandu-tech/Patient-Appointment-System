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
    public partial class Form2 : Form
    {
        private System.Windows.Forms.ProgressBar progressBarSaving;
        private System.Windows.Forms.Timer savingTimer;

        int progressValue = 0;

        public Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            this.progressBarSaving = new System.Windows.Forms.ProgressBar();
            this.progressBarSaving.Location = new System.Drawing.Point(100, 420);
            this.progressBarSaving.Name = "progressBarSaving";
            this.progressBarSaving.Size = new System.Drawing.Size(400, 23);
            this.progressBarSaving.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarSaving.Visible = false; 

            this.Controls.Add(this.progressBarSaving);

            this.savingTimer = new System.Windows.Forms.Timer();
            this.savingTimer.Interval = 100;
            this.savingTimer.Tick += new System.EventHandler(this.timer3_Tick);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox2.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox1.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox4.Clear();
            textBox6.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
            maskedTextBox4.Clear();
           
            comboBox1.SelectedIndex = -1;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBox1.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBox3.Text) ||
               (checkBox2.Checked && comboBox1.SelectedIndex == -1))
            {
              MessageBox.Show("Please fill in all required fields before saving.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            else try
            {
                progressBarSaving.Visible = true;
                progressBarSaving.Value = 0;
                progressValue = 0;
                savingTimer.Start();
            }
            catch
            {
               MessageBox.Show("An error occurred while saving: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressValue += 5;

            if (progressValue <= 100)
            {
                progressBarSaving.Value = progressValue;
            }
            else
            {
                savingTimer.Stop();
                progressBarSaving.Visible = false;
                MessageBox.Show("Patient information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
