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
            // Days
            for (int d = 1; d <= 31; d++)
            {
                comboBox1.Items.Add(d.ToString());
            }

            // Months
            string[] months = {
                "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"
            };
            foreach (string month in months)
            {
                comboBox2.Items.Add(month);
            }

            // Years
            int currentYear = DateTime.Now.Year;
            for (int y = 1900; y <= currentYear; y++)
            {
                comboBox3.Items.Add(y.ToString());
            }

            // Programs
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


        // Overload 1: Displays Name and Program
        public void DisplayStudentInfo(string firstName, string lastName, string program)
        {
            MessageBox.Show($"Student name: {firstName} {lastName}\n" +
                            $"Program: {program}", "Student Information");
        }

        // Overload 2: Displays Name, Gender, and Program
        public void DisplayStudentInfo(string firstName, string middleName, string lastName, string program)
        {
            MessageBox.Show($"Student name: {firstName} {middleName} {lastName}\n" +
                            $"Program: {program}", "Student Information");
        }

        // Overload 3: Displays all info
        public void DisplayStudentInfo(string firstName, string middleName, string lastName, string gender, string birthDate, string program)
        {
            MessageBox.Show($"Student name: {firstName} {middleName} {lastName}\n" +
                            $"Gender: {gender}\n" +
                            $"Date of birth: {birthDate}\n" +
                            $"Program: {program}", "Student Information");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string last = textBox1.Text;
            string first = textBox2.Text;
            string middle = textBox3.Text;

            string gender = radioButton1.Checked ? "Male" : (radioButton2.Checked ? "Female" : "Not Specified");
            string birthDate = $"{comboBox1.Text}/{comboBox2.Text}/{comboBox3.Text}";
            string program = comboBox4.Text;

            if (string.IsNullOrWhiteSpace(first) || string.IsNullOrWhiteSpace(last))
            {
                MessageBox.Show("Please enter at least First and Last name.", "System Message");
                return;
            }

            // 1. Full details
            DisplayStudentInfo(first, middle, last, gender, birthDate, program);

            // 2. Name with Middle Name and Program
            DisplayStudentInfo(first, middle, last, program);

            // 3. Just First/Last Name and Program
            DisplayStudentInfo(first, last, program);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}