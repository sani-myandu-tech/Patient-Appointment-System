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
    public partial class Form1 : Form
    {
        private int queueCounter = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                radioButton2.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton1.Enabled = false;
                Form2 newPatientForm = new Form2();
                newPatientForm.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int queueCounter = 1;
            textBox2.Text = queueCounter.ToString();

            button2.Enabled = false;
            textBox2.Text = queueCounter.ToString();

            queueCounter++;

            if (queueCounter > 1000)
            {
                queueCounter = 1; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Form3 appointmentForm = new Form3();
            appointmentForm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = false;
            string service = comboBox1.Text;

            switch (service)
            {
                case "Consultation":
                    comboBox2.Enabled = true;
                    comboBox2.SelectedIndex = -1;
                    textBox1.Clear();
                    break;
                case "Vaccination":
                    textBox1.Text = "R200";
                    break;
                case "Family Planning":
                    textBox1.Text = "R250";
                    break;
                case "Other":
                    textBox1.Text = "See Receptionist";
                    comboBox2.Enabled = true;
                    break;
                default:
                    textBox1.Clear();
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clinician = comboBox2.Text;

            if (clinician == "Doctor")
            {
                textBox1.Text = "R500";
            }
            if (clinician == "Nurse")
            {
                textBox1.Text = "R400";
            }
            if (clinician == "Dentist")
            {
                textBox1.Text = "See Receptionist";
            }
            if (clinician == "Psychologist")
            {
                textBox1.Text = "R1 500";
            }
            if (clinician == "Dietician")
            {
                textBox1.Text = "R500";
            }
            if (clinician == "Optometrist")
            {
                textBox1.Text = "See Receptionist";
            }
            if (clinician == "Podiatrist")
            {
                textBox1.Text = "See Receptionist";
            }
            if (clinician == "Physiotherapist")
            {
                textBox1.Text = "See Receptionist";
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string payment = comboBox3.Text;

              if (payment == "Medical Aid")
            {
                textBox1.Text = "Payable by Medical Aid";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                radioButton4.Enabled = false;
                maskedTextBox2.Enabled = false;
                maskedTextBox2.Clear();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                radioButton3.Enabled = false;
                maskedTextBox2.Enabled = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;

            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;

            
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;


           
            textBox1.Clear(); 
            textBox2.Clear();
            maskedTextBox2.Clear(); 
            maskedTextBox1.Clear(); 

            
            button1.Enabled = true;
            button2.Enabled = true;

            comboBox2.Enabled = true;

            maskedTextBox2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 ||
             comboBox3.SelectedIndex == -1 ||
            string.IsNullOrWhiteSpace(maskedTextBox1.Text) ||
            string.IsNullOrWhiteSpace(textBox1.Text) ||
            string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please fill in all required fields before saving.", "Indicating Empty Cells", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Information saved successfully! Proceed to book an appointment.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Enabled = false;
            maskedTextBox2.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
