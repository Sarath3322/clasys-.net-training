using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.ComponentModel;


namespace validation
{
    public partial class Form1 : Form
    {
        private bool emailValidationFailed = false;
        private bool phoneValidationFailed = false;
        private bool passValidationFailed = false;
        private bool cpassValidationFailed = false;
        public Form1()
        {
            InitializeComponent();
            mail.Validating += new CancelEventHandler(mail_Validating);
            mobile.Leave += new EventHandler(mobile_Leave);
            mail.Validated += new EventHandler(mail_Validated);
            mobile.Validated += new EventHandler(mobile_Validated);
            mobile.KeyPress += new KeyPressEventHandler(mobile_KeyPress);
            calender.ValueChanged += new EventHandler(calender_ValueChanged);
            calender.Value = new DateTime(2005, 1, 1);
            pass.Leave += new EventHandler(pass_Leave);
            pass.Validated += new EventHandler(pass_Validated);
            cpass.Validated += new EventHandler(cpass_Validated);
            cpass.Leave += new EventHandler(cpass_Leave);
            state.SelectedIndexChanged += new EventHandler(state_SelectedIndexChanged);
            state.SelectedIndexChanged += new EventHandler(state_SelectedIndexChanged);




        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void first_TextChanged(object sender, EventArgs e)
        {
            string enteredValue = first.Text;

            bool containsNumber = false;

            foreach (char c in enteredValue)
            {
                if (char.IsDigit(c))
                {
                    containsNumber = true;
                    break;
                }
            }

            if (containsNumber)
            {
                MessageBox.Show("first name cant include numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                first.Clear();
            }
            else
            {

            }
        }

        private void last_TextChanged(object sender, EventArgs e)
        {

            string enteredValue = last.Text;

            bool containsNumber = false;

            foreach (char c in enteredValue)
            {
                if (char.IsDigit(c))
                {
                    containsNumber = true;
                    break; // No need to continue checking once a digit is found
                }
            }

            if (containsNumber)
            {
                MessageBox.Show("last name cant include numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                last.Clear();
            }
            else
            {

            }
        }

        private void mail_Validating(object sender, CancelEventArgs e)
        {
            string mailValue = mail.Text;

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            bool isValidEmail = Regex.IsMatch(mailValue, pattern);

            if (!isValidEmail)
            {
                emailValidationFailed = true;

            }

        }

        private void mail_Validated(object sender, EventArgs e)
        {
            if (emailValidationFailed)
            {
                MessageBox.Show("Invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mail.Clear();
                emailValidationFailed = false;
            }
        }

        private void mobile_Leave(object sender, EventArgs e)
        {
            string aa = mobile.Text;
            if (aa.Length != 10)
            {
                phoneValidationFailed = true;



            }
        }
        private void mobile_Validated(object sender, EventArgs e)
        {
            if (phoneValidationFailed)
            {
                MessageBox.Show("Invalid phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mobile.Clear();
                phoneValidationFailed = false;

            }
        }
        private void mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void calender_ValueChanged(object sender, EventArgs e)
        {
            DateTime birthDate = calender.Value;
            DateTime currentDate = DateTime.Now;

            int age = CalculateAge(birthDate, currentDate);

            ageee.Text = age.ToString();
            DateTime maxDate = new DateTime(2005, 1, 1);

            if (calender.Value > maxDate)
            {
                calender.Value = maxDate;
            }
        }

        private void mobile_TextChanged(object sender, EventArgs e)
        {

        }
        private int CalculateAge(DateTime birthDate, DateTime currentDate)
        {
            int age = currentDate.Year - birthDate.Year;

            if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
            {
                age--;
            }

            return age;
        }

        private void age_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }
        private void pass_Leave(object sender, EventArgs e)
        {
            string bb = pass.Text;
            if (bb.Length < 8)
            {
                passValidationFailed = true;



            }

        }
        private void pass_Validated(object sender, EventArgs e)
        {
            if (passValidationFailed)
            {
                MessageBox.Show("password atleast contain 8 charcters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pass.Clear();
                passValidationFailed = false;

            }
        }


        private void cpass_Leave(object sender, EventArgs e)
        {
            string cc = cpass.Text;
            if (cc != pass.Text)
            {
                cpassValidationFailed = true;



            }

        }
        private void cpass_Validated(object sender, EventArgs e)
        {
            if (cpassValidationFailed)
            {
                MessageBox.Show("password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cpass.Clear();
                cpassValidationFailed = false;

            }
        }

        private void city_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void state_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (state.Text == "kerala")
            {
                city.Items.Clear();
                city.Items.Add("Thrissur");
                city.Items.Add("Kochi");
                city.Items.Add("Calicut");

            }
            else if (state.Text == "tamilnadu")
            {
                city.Items.Clear();
                city.Items.Add("Tirunelveli");
                city.Items.Add("chennai");
                city.Items.Add("tambaram");

            }
            else if (state.Text == "karnataka")
            {
                city.Items.Clear();
                city.Items.Add("banglore");
                city.Items.Add("belur");
                city.Items.Add("chicmanglore");

            }




        }
    }
}
