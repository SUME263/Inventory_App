using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Appliance_Rental_System__Assignment_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = UserTxt.Text;
                string password = PassTxt.Text;
                bool isCustomer = chkCustomer.Checked;
                bool isAdmin = chkAdmin.Checked;

                //checks if admin or custromer check boxes have been clicked 
                if (!isAdmin && !isCustomer)
                {
                    MessageBox.Show("Register as customer or admin to continue");
                    return;
                }

                //only allows users to regsiter when passowrd has atleast 8 characters 
                if (password.Length < 8 || password.Length > 16)
                {
                    MessageBox.Show("Password must contain 8 to 16 characters");
                    return;
                }

                //user's password must have a capital letter
                if (!password.Any(char.IsUpper))
                {
                    MessageBox.Show("Password must conatin at least one capital letter");
                    return;
                }

                //ensures you can Only login as a either a customer or admin
                if (chkAdmin.Checked == true && chkCustomer.Checked == true)
                {
                    MessageBox.Show("Can't register as both admin and customer");
                    return;
                }

                //create new user object
                User newUser = new User
                {
                    Id = username,
                    Password = password,
                    isCustomer = isCustomer,
                    isAdmin = isAdmin
                };

                //stores user data in directory the app is using to run
                string filepath = $"{username}.txt";

                //Checks for already existing users with same details 
                if (File.Exists(filepath))
                {
                    MessageBox.Show("User with same details already exists");
                    return;
                }

                //write input data to a text file
                using (StreamWriter writer = new StreamWriter(filepath, false, Encoding.UTF8))
                {
                    writer.WriteLine($"Username:{newUser.Id}");
                    writer.WriteLine($"Password:{newUser.Password}");
                    writer.WriteLine($"isAdmin:{newUser.isAdmin}");
                    writer.WriteLine($"isCustomer:{newUser.isCustomer}");
                }
                MessageBox.Show("User succesfully registered!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            //clear input fields 
            UserTxt.Clear();
            PassTxt.Clear();
            chkCustomer.Checked = false;
            chkAdmin.Checked = false;
        }
    }
}
