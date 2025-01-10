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
    public partial class AddPartForm : Form
    {
        public AddPartForm()
        {
            InitializeComponent();


            formatAddPartForm();
            autoGeneratePartID();
        }

        private void formatAddPartForm()
        {
            inHouseRadioButton.Checked = true;

            nameTextBox.BackColor = Color.Red;
            inStockTextBox.BackColor = Color.Red;
            priceCostTextBox.BackColor = Color.Red;
            maxTextBox.BackColor = Color.Red;
            minTextBox.BackColor = Color.Red;
        }

        private void autoGeneratePartID()
        {
            //Auto Generate ID for the idTextBox
            int nextID = 1;
            if (Inventory.AllParts.Count > 0)
            {
                nextID = Inventory.AllParts.Max(p => p.PartID) + 1;
            }
            idTextBox.Text = nextID.ToString();
        }

        private void addPartSaveButton_Click(object sender, EventArgs e)
        {
            //If the Max Box is less than the Min Box, return
            if (int.TryParse(maxTextBox.Text, out int max) && int.TryParse(minTextBox.Text, out int min))
            {
                if (max < min)
                {
                    MessageBox.Show("Min must be less than Max");
                    return;
                }
            }

            //Make sure the part text properties are not null
            if (string.IsNullOrEmpty(nameTextBox.Text) ||
                string.IsNullOrEmpty(inStockTextBox.Text) ||
                string.IsNullOrEmpty(priceCostTextBox.Text) ||
                string.IsNullOrEmpty(maxTextBox.Text) ||
                string.IsNullOrEmpty(minTextBox.Text))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            //Make sure the inventory count is between the min and max
            if (Inventory.validateInventoryCount(int.Parse(inStockTextBox.Text), int.Parse(maxTextBox.Text), int.Parse(minTextBox.Text)) == false)
            {
                return;
            }

            //Based on which radio button is checked, create a new Part
            if (inHouseRadioButton.Checked == true) 
            {

                Inhouse inHouse = new Inhouse(
                    int.Parse(idTextBox.Text),
                    nameTextBox.Text,
                    decimal.Parse(priceCostTextBox.Text),
                    int.Parse(inStockTextBox.Text),
                    int.Parse(minTextBox.Text),
                    int.Parse(maxTextBox.Text),
                    int.Parse(machineOrCompanyTextBox.Text)
                );

                //Format the price to have 2 decimal points
                string priceText = priceCostTextBox.Text;
                if (!priceText.Contains("."))
                {
                    priceText += ".00";
                }

                //Add the part to the Inventory
                Inventory.addPart(inHouse);


            }
            else if (outSourcedRadioButton.Checked == true)
            {
                Outsourced outsourced = new Outsourced(
                    int.Parse(idTextBox.Text),
                    nameTextBox.Text,
                    decimal.Parse(priceCostTextBox.Text),
                    int.Parse(inStockTextBox.Text),
                    int.Parse(minTextBox.Text),
                    int.Parse(maxTextBox.Text),
                    machineOrCompanyTextBox.Text
                );

                //Format the price to have 2 decimal points
                string priceText = priceCostTextBox.Text;
                if (!priceText.Contains("."))
                {
                    priceText += ".00";
                }

                //Add the part to the Inventory
                Inventory.addPart(outsourced);
            }


            this.Close();
            MessageBox.Show("Part added successfully!");
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
