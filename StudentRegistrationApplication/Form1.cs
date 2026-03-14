using System;
using System.Collections;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int d = 1; d <= 31; d++)
            {
                comboBox1.Items.Add(d.ToString());
            }

            string[] months = {
                "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"
            };

            foreach (string month in months)
            {
                comboBox2.Items.Add(month);
            }

            int currentYear = DateTime.Now.Year;
            for (int y = 1900; y <= currentYear; y++)
            {
                comboBox3.Items.Add(y.ToString());
            }

            ArrayList programs = new ArrayList();
            programs.Add("Bachelor of Science in Computer Science");
            programs.Add("Bachelor of Science in Information Technology");
            programs.Add("Bachelor of Science in Information Systems");
            programs.Add("Bachelor of Science in Computer Engineering");

            foreach (string program in programs)
            {
                comboBox4.Items.Add(program);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string studentName = textBox2.Text + " " + textBox3.Text + " " + textBox1.Text;

            string gender = "";
            if (radioButton1.Checked) gender = "Male";
            else if (radioButton2.Checked) gender = "Female";

            string birthDate = comboBox1.Text + " " + comboBox2.Text + " " + comboBox3.Text;
            string selectedProgram = comboBox4.Text;

            if (string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter at least First and Last name.", "Student Information");
                return;
            }

            string message = "Student name: " + studentName + "\n" +
                             "Gender: " + gender + "\n" +
                             "Date of birth: " + birthDate + "\n" +
                             "Program: " + selectedProgram;

            MessageBox.Show(message, "Student Information");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
    }
}