using System.Xml.Linq;

namespace Appliance_Rental_System__Assignment_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void SignUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        //load registered user's data
        private User LoadUserData(string enteredUsername)
        {

            string filePath = $"{enteredUsername}.txt";

            try
            {
                if (File.Exists(filePath))
                {
                    //read the saved text files for registered users 
                    string[] lines = File.ReadAllLines(filePath);
                    string? username = lines.FirstOrDefault(line => line.StartsWith("Username:"))?.Split(':')[1];
                    string? password = lines.FirstOrDefault(line => line.StartsWith("Password:"))?.Split(':')[1];

                    //extract admin and user info from text file then convert the string values into boolean
                    bool isAdmin = Convert.ToBoolean(lines.FirstOrDefault(line => line.StartsWith("isAdmin:"))?.Split(':')[1]?.Trim());
                    bool isCustomer = Convert.ToBoolean(lines.FirstOrDefault(line => line.StartsWith("isCustomer:"))?.Split(':')[1]?.Trim());

                    if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                    {
                        //create user  object
                        return new User
                        {
                            Id = username,
                            Password = password,
                            isAdmin = isAdmin,
                            isCustomer = isCustomer
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            return null;
        }

        private int loginattempt = 0;
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string enteredUsername = UserTxt.Text;
            string enteredPassword = PassTxt.Text;
            //call the load user method
            User loadedUser = LoadUserData(enteredUsername);

            // Check if a user with the entered username and password was found 
            if (loadedUser != null && loadedUser.Password == enteredPassword)
            {
                if (loadedUser.isAdmin || loadedUser.isCustomer)
                {
                    MessageBox.Show($"Login successful!, Welcome back {enteredUsername}");

                    string userRole = loadedUser.isAdmin ? "admin " : "customer";

                    Form3 form3 = new Form3(enteredUsername, userRole);
                    form3.Show();

                    UserTxt.Clear();
                    PassTxt.Clear();
                    this.Hide();
                }
            }
            else
            {
                loginattempt++;

                //closes the app when certain number of failed attempts are reached 
                if (loginattempt >= 5)
                {
                    MessageBox.Show("Too many login attempts!, Application closing", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again or sign up");
                    UserTxt.Clear();
                    PassTxt.Clear();
                    return;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}