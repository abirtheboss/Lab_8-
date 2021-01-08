using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCreate
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void phoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {
             string firstName = FirstName.Text;
            string lastName = LastName.Text;
            string gender = Gender.SelectedItem.ToString();
            string email = Email.Text;
            string reEmail = CheckEmail.Text;
            string password = Password.Text;
            string rePassword = RePassword.Text;
            string ques = securityQues.SelectedItem.ToString();
            string ans = textBox7.Text;
            string address = Address.Text;
            string city = City.Text;
            string zipCode = zip.Text;
            string phone = phoneNo.Text;
            string output = String.Format("Name : {0} {1}\nGender : {2}\nEmail : {3}\nPassword : {4}\nSecurity Question : {5}\nSecurity Answer : {6}\nAddress : {7}\nCity : {8}\nZip Code : {9}\nPhone No : {10}", firstName, lastName, gender, email, password, ques, ans, address, city, zipCode, phone);
            panel1.Visible = true;
            richTextBox1.Text = output;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void State_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void zip_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
