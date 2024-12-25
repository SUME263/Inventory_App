using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Text.Json;
using System.IO;
using System.Xml.Linq;
//using static System.Net.WebRequestMethods;

namespace Appliance_Rental_System__Assignment_
{
    public partial class Form3 : Form
    {
        private string userRole;
        private string username;

        public Form3(string enteredUsername, string userRole)
        {
            InitializeComponent();
            this.username = enteredUsername;
            this.userRole = userRole;

            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;

            label2.Text = (enteredUsername);

            if (userRole == "admin")
            {
                tabControl1.SelectedTab = adminTab;
            }
            else if (userRole == "customer")
            {
                tabControl1.SelectedTab = customerTab;
            }
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // prevent customers from accessing admin tab
            if (tabControl1.SelectedTab == adminTab && userRole == "customer")
            {
                tabControl1.SelectedTab = customerTab;
                MessageBox.Show("Only admins can access this page.", "MessageBoxIcon.Warning");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            InitializeDataGrid(dataGridView1);
            InitializeDataGrid(dataGridView2);

            string filename = "appliance.txt";

            //restrict customers from editing
            dataGridView2.ReadOnly = true;

            LoadApplianceData(filename, dataGridView1);
            LoadApplianceData(filename, dataGridView2);
        }

        private void InitializeDataGrid(DataGridView dataGridView)
        {
            dataGridView.Columns.Add("Appliance ID", "Appliance ID");
            dataGridView.Columns.Add("Type", "Type");
            dataGridView.Columns.Add("Name", "Name");
            dataGridView.Columns.Add("Description", "Description(Model, Dimension, Colour)");
            dataGridView.Columns.Add("PowerConsumption", "Power Consumption (Watts)");
            dataGridView.Columns.Add("Cost", "Cost/Month (£)");
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out ?", "SIGN OUT", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Form1 form = new Form1();
                form.Show();
                this.Close();
            }
        }

        List<Appliance> appliances = new List<Appliance>();
        private void Addbtn_Click(object sender, EventArgs e)
        {
            string filename = "appliance.txt";

            int maxAppID = appliances.Count > 0 ? appliances.Max(a => a.ApplianceID) : 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //skip bottom row
                if (!row.IsNewRow)
                {

                    int app_ID = maxAppID + 1;

                    Appliance existingAppliance = appliances.FirstOrDefault(a => a.ApplianceID == app_ID);

                    //checks if appliance being saved already exists
                    if (existingAppliance != null)
                    {
                        existingAppliance.ApplianceID = int.Parse(row.Cells["Appliance ID"].Value.ToString());
                        existingAppliance.Type = row.Cells["Type"].Value.ToString();
                        existingAppliance.Name = row.Cells["Name"].Value.ToString();
                        existingAppliance.Description = row.Cells["Description"].Value.ToString();
                        existingAppliance.PowerConsumption = row.Cells["PowerConsumption"].Value.ToString();
                        existingAppliance.Cost = decimal.Parse(row.Cells["Cost"].Value.ToString());

                        MessageBox.Show("Appliance already exists");

                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            cell.Value = string.Empty;
                        }
                    }
                    else
                    {
                        string type = row.Cells["Type"].Value.ToString();
                        string name = row.Cells["Name"].Value.ToString();
                        string description = row.Cells["Description"].Value.ToString();
                        string powerConsumption = row.Cells["PowerConsumption"].Value.ToString();
                        decimal cost = decimal.Parse(row.Cells["Cost"].Value.ToString());

                        //create appliance object & add to the list
                        Appliance appliance = new Appliance(app_ID, type, name, description, powerConsumption, cost);
                        appliances.Add(appliance);
                        maxAppID = app_ID;
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Appliance appliance in appliances)
                {
                    writer.WriteLine($"{appliance.ApplianceID}, {appliance.Type},{appliance.Name},{appliance.Description},{appliance.PowerConsumption},{appliance.Cost}");
                }

                MessageBox.Show("Added item Successfully");
            }
        }

        //Load applaince data from saved text file 
        private void LoadApplianceData(string filename, DataGridView dataGridView)
        {
            if (File.Exists(filename))
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        if (parts.Length == 6)
                        {
                            int appID = int.Parse(parts[0]);
                            string type = parts[1];
                            string name = parts[2];
                            string description = parts[3];
                            string powerConsumption = parts[4];
                            decimal cost = decimal.Parse(parts[5]);

                            dataGridView.Rows.Add(appID, type, name, description, powerConsumption, cost);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("The appliances file cannot be found");
            }
        }

        //Deletes appliances from data grid
        private void Deletebtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    dataGridView1.Rows.Remove(selectedRow);

                    UpdateData("appliance.txt");
                    MessageBox.Show("Item deleted succesfully");
                }
                else
                {
                    MessageBox.Show("Select item to delete");
                }
            }
        }

        //Updates the appliance list whenever an appliance has been deleted
        private void UpdateData(string filename)
        {
            using (StreamWriter write = new StreamWriter(filename))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        //int appID = int.Parse(row.Cells["Appliance ID"].Value.ToString());
                        string type = row.Cells["Type"].Value.ToString();
                        string name = row.Cells["Name"].Value.ToString();

                        string description = row.Cells["Description"].Value.ToString();
                        string powerConsumption = row.Cells["PowerConsumption"].Value.ToString();
                        decimal cost = decimal.Parse(row.Cells["Cost"].Value.ToString());

                        write.WriteLine($"{type},{name},{description},{powerConsumption},{cost}");
                    }
                }
            }
        }

        //list to store cart items and class to represent cart items
        List<CartItem> cart = new List<CartItem>();
        public class CartItem
        {
            public int ApplianceID { get; set; }
            public decimal cost { get; set; }
        }

        //add items to the cart
        private void CartBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select appliance to rent");
                return;
            }

            //Gets selected Appliance's ID
            int applianceID = int.Parse(dataGridView2.SelectedRows[0].Cells["Appliance ID"].Value.ToString());

            if (ApplianceRented(applianceID))
            {
                MessageBox.Show("You are already renting this appliance");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to add this appliance to your cart?", "CONFIRM PURCHASE", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    decimal monthlyCost = decimal.Parse(dataGridView2.SelectedRows[0].Cells["Cost"].Value.ToString());
                    AddRecord(applianceID, monthlyCost);
                    UpdateCartAndTotalCost(monthlyCost);

                    MessageBox.Show("Appliance added to cart");
                }
            }
        }

        //checks if appliance is already being rented by customer
        private bool ApplianceRented(int applianceID)
        {
            String filename = "rental_records.txt";

            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 1)
                    {
                        int rentedApplianceID = int.Parse(parts[0]);

                        if (rentedApplianceID == applianceID)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        //keeps track of appliances that have been added to the cart
        private void AddRecord(int applianceID, decimal monthlyCost)
        {
            string filename = "rental_records.txt";

            if (!ApplianceRented(applianceID))
            {
                using (StreamWriter writer = File.AppendText(filename))
                {
                    writer.WriteLine($"{applianceID}");
                }
            }
        }

        //calculate the cost of appliance
        private void UpdateCartAndTotalCost(decimal monthlyCost)
        {
            cart.Add(new CartItem { ApplianceID = int.Parse(dataGridView2.SelectedRows[0].Cells["Appliance ID"].Value.ToString()), cost = monthlyCost });
            decimal totalCost = cart.Sum(item => item.cost);
            TotalCost.Text = "£" + totalCost.ToString("0.00");
        }

        //search for type in the text file and displays it at the top
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string keyword = Searchtxt.Text;

            dataGridView2.Rows.Clear();

            using (StreamReader reader = new StreamReader("appliance.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(keyword))
                    {
                        string[] columns = line.Split(',');

                        if (columns.Length >= 6)
                        {
                            dataGridView2.Rows.Add(columns[0], columns[1], columns[2], columns[3], columns[4], columns[5]);
                        }
                    }
                }
            }

            using (StreamReader reader = new StreamReader("appliance.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (!line.Contains(keyword))
                    {
                        string[] columns = line.Split(',');

                        if (columns.Length >= 6)
                        {
                            dataGridView2.Rows.Add(columns[0], columns[1], columns[2], columns[3], columns[4], columns[5]);
                        }
                    }
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            string filename = "appliance.txt";

            int maxAppID = appliances.Count > 0 ? appliances.Max(a => a.ApplianceID) : 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    int app_ID = int.Parse(row.Cells["Appliance ID"].Value.ToString());
                    string type = row.Cells["Type"].Value.ToString();
                    string name = row.Cells["Name"].Value.ToString();
                    string description = row.Cells["Description"].Value.ToString();
                    string powerConsumption = row.Cells["PowerConsumption"].Value.ToString();
                    decimal cost = decimal.Parse(row.Cells["Cost"].Value.ToString());

                    //create appliance object & add to the list
                    Appliance appliance = new Appliance(app_ID, type, name, description, powerConsumption, cost);
                    appliances.Add(appliance);

                    
                }
            }

            DialogResult result = MessageBox.Show("Are you sure you want to make these changes ?", "Edit Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("changes made successfully");
            }

            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Appliance appliance in appliances)
                {
                    writer.WriteLine($"{appliance.ApplianceID}, {appliance.Type},{appliance.Name},{appliance.Description},{appliance.PowerConsumption},{appliance.Cost}");
                }
            }

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        //Refresh items on the grid
        private string filePath = "appliance.txt";
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();

            // Read the data from the text file and populate the DataGridView
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] columns = line.Split(',');

                    if (columns.Length >= 6) // Assuming 7 columns as per your provided data
                    {
                        // Add the row to the DataGridView
                        dataGridView2.Rows.Add(columns[0], columns[1], columns[2], columns[3], columns[4], columns[5]);
                    }
                }
            }


        }
    }
}