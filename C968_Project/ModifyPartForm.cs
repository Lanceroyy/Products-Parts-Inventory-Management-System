using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_Project
{
    public partial class ModifyPartForm : Form
    {

        private Part existingPart;
        private Inhouse inhousePart;
        private Outsourced outsourcedPart;
        private int newPartID;

        public ModifyPartForm()
        {
            InitializeComponent();


        }

        public void formatAddPartForm(Part part)
        {
            //If part is null, return
            if (part == null)
            {
                MessageBox.Show("The part provided is null. Please select a valid part.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //If part is not null, retrieve the data from current part and populate the form
            if (part != null)
            {
                idTextBox.Text = part.PartID.ToString();
                nameTextBox.Text = part.Name;
                inStockTextBox.Text = part.InStock.ToString();
                priceCostTextBox.Text = part.Price.ToString();
                maxTextBox.Text = part.Max.ToString();
                minTextBox.Text = part.Min.ToString();

                if (part is Inhouse)
                {
                    inHouseRadioButton.Checked = true;

                    machineOrCompanyTextBox.Text = ((Inhouse)part).MachineID.ToString();

                }

                if (part is Outsourced)
                {
                    outSourcedRadioButton.Checked = true;
                    machineOrCompanyTextBox.Text = ((Outsourced)part).CompanyName;
                }


                //Grab Existing Part by grabbing the ID and comparing it
                newPartID = int.Parse(idTextBox.Text);
                existingPart = Inventory.AllParts.FirstOrDefault(p => p.PartID == newPartID);

            }
        }


        private void addPartSaveButton_Click(object sender, EventArgs e)
        {
            // Ensure Min is less than Max
            if (int.TryParse(maxTextBox.Text, out int maxValue) && int.TryParse(minTextBox.Text, out int minValue) && maxValue < minValue)
            {
                MessageBox.Show("Min must be less than Max.");
                return;
            }

            // Ensure all required fields are filled
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(inStockTextBox.Text) ||
                string.IsNullOrWhiteSpace(priceCostTextBox.Text) ||
                string.IsNullOrWhiteSpace(maxTextBox.Text) ||
                string.IsNullOrWhiteSpace(minTextBox.Text))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            //Make sure the inventory count is between the min and max
            if (Inventory.validateInventoryCount(int.Parse(inStockTextBox.Text), int.Parse(maxTextBox.Text), int.Parse(minTextBox.Text)) == false)
            {
                return;
            }

            // Parse common fields
            int id = int.Parse(idTextBox.Text);
            string name = nameTextBox.Text;
            decimal price = decimal.Parse(priceCostTextBox.Text);
            int stock = int.Parse(inStockTextBox.Text);
            int min = int.Parse(minTextBox.Text);
            int max = int.Parse(maxTextBox.Text);


            // Determine part type and create the appropriate object
            Part newPart;

            if (inHouseRadioButton.Checked)
            {
                if (!int.TryParse(machineOrCompanyTextBox.Text, out int machineID))
                {
                    MessageBox.Show("Please enter a valid Machine ID.");
                    return;
                }
                newPart = new Inhouse(id, name, price, stock, min, max, machineID);
            }
            else if (outSourcedRadioButton.Checked)
            {
                string companyName = machineOrCompanyTextBox.Text;
                if (string.IsNullOrWhiteSpace(companyName))
                {
                    MessageBox.Show("Please enter a valid Company Name.");
                    return;
                }
                newPart = new Outsourced(id, name, price, stock, min, max, companyName);
            }
            else
            {
                MessageBox.Show("Please select either In-House or Outsourced.");
                return;
            }


            // Update the inventory
            Inventory.updatePart(id, newPart);


            this.Close();
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (inHouseRadioButton.Checked == true)
            {
                machineOrCompanyLabel.Text = "Machine ID";

                if (int.TryParse(machineOrCompanyTextBox.Text, out _))
                {
                    machineOrCompanyTextBox.BackColor = Color.White;
                }
                else
                {
                    machineOrCompanyTextBox.BackColor = Color.Red;
                }

            }
            else if (outSourcedRadioButton.Checked == true)
            {
                machineOrCompanyLabel.Text = "Company Name";

                if(!string.IsNullOrWhiteSpace(machineOrCompanyTextBox.Text))
                {
                    machineOrCompanyTextBox.BackColor = Color.White;
                }
                else
                {
                    machineOrCompanyTextBox.BackColor = Color.Red;
                }

            }
        }

        private void machineOrCompanyTextBox_TextChanged(object sender, EventArgs e)
        {


            if (inHouseRadioButton.Checked == true)
            {
                machineOrCompanyLabel.Text = "Machine ID";

                if (int.TryParse(machineOrCompanyTextBox.Text, out _))
                {
                    machineOrCompanyTextBox.BackColor = Color.White;
                }
                else
                {
                    machineOrCompanyTextBox.BackColor = Color.Red;
                }

            }

            else if (outSourcedRadioButton.Checked == true)
            {
                machineOrCompanyLabel.Text = "Company Name";

                if (!string.IsNullOrWhiteSpace(machineOrCompanyTextBox.Text))
                {
                    machineOrCompanyTextBox.BackColor = Color.White;
                }
                else
                {
                    machineOrCompanyTextBox.BackColor = Color.Red;
                }

            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            //If Name Text Box is not a String
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                nameTextBox.BackColor = Color.Red;
                addPartSaveButton.Enabled = false;
            }
            else
            {
                nameTextBox.BackColor = Color.White;
                addPartSaveButton.Enabled = true;
            }

        }

        private void inStockTextBox_TextChanged(object sender, EventArgs e)
        {
            //if InStock Text Box is not an Integer
            if (int.TryParse(inStockTextBox.Text, out _))
            {
                // Valid integer, reset background color
                inStockTextBox.BackColor = Color.White;
                addPartSaveButton.Enabled = true;
            }
            else
            {
                // Invalid input, highlight with red background
                inStockTextBox.BackColor = Color.Red;
                addPartSaveButton.Enabled = false;
            }
        }

        private void priceCostTextBox_TextChanged(object sender, EventArgs e)
        {
            //if Price Text Box is not an Integer
            if (int.TryParse(priceCostTextBox.Text, out _) || decimal.TryParse(priceCostTextBox.Text, out _))
            {
                // Valid integer, reset background color
                priceCostTextBox.BackColor = Color.White;
                addPartSaveButton.Enabled = true;
            }
            else
            {
                // Invalid input, highlight with red background
                priceCostTextBox.BackColor = Color.Red;
                addPartSaveButton.Enabled = false;
            }
        }

        private void maxTextBox_TextChanged(object sender, EventArgs e)
        {
            //if Max Text Box is not an Integer
            if (int.TryParse(maxTextBox.Text, out _))
            {
                // Valid integer, reset background color
                maxTextBox.BackColor = Color.White;
                addPartSaveButton.Enabled = true;
            }
            else
            {
                // Invalid input, highlight with red background
                maxTextBox.BackColor = Color.Red;
                addPartSaveButton.Enabled = false;
            }
        }

        private void minTextBox_TextChanged(object sender, EventArgs e)
        {
            //if Max Text Box is not an Integer
            if (int.TryParse(minTextBox.Text, out _))
            {
                // Valid integer, reset background color
                minTextBox.BackColor = Color.White;
                addPartSaveButton.Enabled = true;
            }
            else
            {
                // Invalid input, highlight with red background
                minTextBox.BackColor = Color.Red;
                addPartSaveButton.Enabled = false;
            }
        }

        private void addPartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
