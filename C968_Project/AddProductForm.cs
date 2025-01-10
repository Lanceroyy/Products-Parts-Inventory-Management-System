using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C968_Project
{
    public partial class AddProductForm : Form
    {
        private Inventory inventory = new Inventory();
        private Product product = new Product();

        public AddProductForm()
        {
            InitializeComponent();

            inventory.IntializeDataGridView(allPartsDataGridView);
            inventory.IntializeDataGridView(partsAssociatedDataGridView);

            addColumnsToAddProductForm();


            allPartsDataGridView.DataSource = Inventory.AllParts;
            partsAssociatedDataGridView.DataSource = product.AssociatedParts;

            autoGenerateProductID();

            formatAddProductForm();
        }

        private void formatAddProductForm()
        {
            nameTextBox.BackColor = Color.Red;
            inStockTextBox.BackColor = Color.Red;
            priceCostTextBox.BackColor = Color.Red;
            maxTextBox.BackColor = Color.Red;
            minTextBox.BackColor = Color.Red;

        }

        public void addColumnsToAddProductForm()
        {

            //Add Columns to ALL Part DataGridView
            allPartsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PartID",
                HeaderText = "Part ID",
                DataPropertyName = "PartID" // Matches the property in the data source
            });

            allPartsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                HeaderText = "Name",
                DataPropertyName = "Name" // Matches the property in the data source
            });

            allPartsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "InStock",
                HeaderText = "In Stock",
                DataPropertyName = "InStock" // Matches the property in the data source
            });

            allPartsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Price",
                HeaderText = "Price",
                DataPropertyName = "Price" // Matches the property in the data source
            });


            //Add Columns to Product ASSOCIATED DataGridView
            partsAssociatedDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PartID",
                HeaderText = "Part ID",
                DataPropertyName = "PartID" // Matches the property in the data source
            });

            partsAssociatedDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                HeaderText = "Name",
                DataPropertyName = "Name" // Matches the property in the data source
            });

            partsAssociatedDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "InStock",
                HeaderText = "In Stock",
                DataPropertyName = "InStock" // Matches the property in the data source
            });

            partsAssociatedDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Price",
                HeaderText = "Price",
                DataPropertyName = "Price" // Matches the property in the data source
            });

        }



        private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            allPartsDataGridView.ClearSelection();
            allPartsDataGridView.ClearSelection();

        }


        private void autoGenerateProductID()
        {
            //Auto Generate ID for the idTextBox
            int nextID = 1;
            if (Inventory.Products.Count > 0)
            {
                nextID = Inventory.Products.Max(p => p.ProductID) + 1;
            }
            idTextBox.Text = nextID.ToString();
        }



        private void addProductSaveButton_Click(object sender, EventArgs e)
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



            //Make sure the product text properties are not null
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

            //Retrieve the infromation from the text boxes and add the attributes to the product
            Product product = new Product
            {
                ProductID = int.Parse(idTextBox.Text),
                Name = nameTextBox.Text,
                InStock = int.Parse(inStockTextBox.Text),
                Price = decimal.Parse(priceCostTextBox.Text),
                Max = int.Parse(maxTextBox.Text),
                Min = int.Parse(minTextBox.Text),

                AssociatedParts = new BindingList<Part>()
            };

            //If price does not have a decimal point add .00
            string priceText = priceCostTextBox.Text;
            if (!priceText.Contains("."))
            {
                priceText += ".00";
            }
            product.Price = decimal.Parse(priceText);


            // Add parts from the DataGridView to the product's AssociatedParts
            foreach (Part part in partsAssociatedDataGridView.DataSource as BindingList<Part>)
            {
                product.addAssociatedPart(part);
            }

            //Add the product to the Inventory
            Inventory.addProduct(product);

            this.Close();
            MessageBox.Show("Product added successfully!");
        }

        private void addPartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addAssociatedPartButton_Click_1(object sender, EventArgs e)
        {
            //Make sure to handle the case where no row is selected
            if (allPartsDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a part to add.");
                return;
            }


            //Retrieve the selected row from the DataGridView
            DataGridViewRow selectedPart = allPartsDataGridView.SelectedRows[0];

            //Add the selected row to the partsAssociatedDataGridView DataGridView
            product.addAssociatedPart(selectedPart.DataBoundItem as Part);

        }

        private void deleteAssociatedPartButton_Click(object sender, EventArgs e)
        {

            //Retrieve the selected row from the DataGridView
            DataGridViewRow selectedPart = partsAssociatedDataGridView.SelectedRows[0];

            //Remove the selected row from the partsAssociatedDataGridView DataGridView
            product.removeAssociatedPart(selectedPart.DataBoundItem as Part);
        }

        private void searchAllPartsButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(searchAllPartsTextBox.Text, out int partID))
            {
                Part foundPart = product.lookupAssociatedPart(partID);

                if (foundPart != null)
                {
                    MessageBox.Show($"Part found: {foundPart.Name} (ID: {foundPart.PartID})");
                }
                else
                {
                    MessageBox.Show("Part not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Part ID.");
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


        private void allPartsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
