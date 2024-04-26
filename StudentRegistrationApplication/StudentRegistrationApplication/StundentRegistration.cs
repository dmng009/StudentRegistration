using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class StundentRegistration : Form
    {
        public StundentRegistration()
        {
            InitializeComponent();
            string[] array = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            for (int i = 1; i <= 31; i++)
            {
                comboBox1.Items.Add(i);
            }

            foreach (string month in array)
            {

                comboBox2.Items.Add(month);
            }

            for (int i = 1900; i <= 2024; i++)
            {
                comboBox3.Items.Add(i);
            }

            ArrayList programs = new ArrayList();
            programs.Add("Bachelor of Science in Computer Science");
            programs.Add("Bachelor of Science in Information Technology");
            programs.Add("Bachelor of Science in Information Systems");
            programs.Add("Bachelor of Science in Computer Engineering");

            foreach (string programList in programs)
            {
                comboBox4.Items.Add(programList);
            }
        }

        private void StundetRegistration_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lastName, firstName, middleName;
            string gender = "";
            string program = comboBox4.Text;
            string day = comboBox1.Text;
            string month = comboBox2.Text;
            string year = comboBox3.Text;
            lastName = textBox1.Text;
            firstName = textBox2.Text;
            middleName = textBox3.Text;


            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }    

            if (firstName != null && middleName != null && lastName != null && gender != null && day != "-Day-" && month != "-Month-" && year != "-Year-" && program != null)
            {
                studentInfo(firstName, middleName, lastName, gender, day, month, year, program);
            }
            else if (firstName != null && middleName != null && lastName != null && program != null)
            {
                studentInfo(firstName, middleName, lastName, program);
            }
            else if (firstName != null && lastName != null && program != null)
            {
                studentInfo(firstName, lastName, program);
            }

        }
        private void studentInfo(string firstName, string middleName, string lastName, string gender, string day, string month, string year, string program)
        {
            MessageBox.Show("Student name: " + firstName + " " + middleName + " " + lastName + "\n" +
                "Gender: " + gender + "\n" +
                "Date of birth: " + day + "/" + month + "/" + year + "\n" +
                "Program: " + program);
        }
        private void studentInfo(string firstName, string middleName, string lastName, string program)
        {
            MessageBox.Show("Student name: " + firstName + " " + middleName + " " + lastName + "\n" +
                "Program: " + program);
        }
        private void studentInfo(string firstName, string lastName, string program)
        {
            MessageBox.Show("Student name: " + firstName + " " + lastName + "\n" + 
                "Program: " + program);
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            openFileDialog1.InitialDirectory = "";
            openFileDialog1.Title = "Profiles";
            openFileDialog1.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);        
        }

    }
}

