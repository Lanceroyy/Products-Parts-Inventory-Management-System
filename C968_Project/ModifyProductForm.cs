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
    public partial class ModifyProductForm : Form
    {
        private Inventory inventory = new Inventory();


        //WE DONT WANT THIS TO BE A NEW PRODUCT. WE WANT TO MODIFY THE EXISTING PRODUCT
        private Product existingProduct;
        private int productID;

        public ModifyProductForm()
        {
            InitializeComponent();

            inventory.IntializeDataGridView(allPartsDataGridView);
            inventory.IntializeDataGridView(partsAssociatedDataGridView);

            addColumnsToAddProductForm();


            allPartsDataGridView.DataSource = Inventory.AllParts;


        }

        public void formatModifyProductForm(Product product)
        {
            nameTextBox.BackColor = Color.Red;
            inStockTextBox.BackColor = Color.Red;
            priceCostTextBox.BackColor = Color.Red;
            maxTextBox.BackColor = Color.Red;
            minTextBox.BackColor = Color.Red;

            if (product != null)
            {
                idTextBox.Text = product.ProductID.ToString();
                nameTextBox.Text = product.Name;
                inStockTextBox.Text = product.InStock.ToString();
                priceCostTextBox.Text = product.Price.ToString();
                maxTextBox.Text = product.Max.ToString();
                minTextBox.Text = product.Min.ToString();

                //Grab Existing Product by grabbing the ID and comparing it
                productID = int.Parse(idTextBox.Text);
                existingProduct = Inventory.Products.FirstOrDefault(p => p.ProductID == productID);
                partsAssociatedDataGridView.DataSource = existingProduct.AssociatedParts;

            }
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



        private void modifyProductSaveButton_Click(object sender, EventArgs e)
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

            //Make sure the inventory count is between the min and max
            if (Inventory.validateInventoryCount(int.Parse(inStockTextBox.Text), int.Parse(maxTextBox.Text), int.Parse(minTextBox.Text)) == false)
            {
                return;
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


            if (existingProduct != null)
            {
                // Update the existing product directly
                existingProduct.Name = nameTextBox.Text;
                existingProduct.InStock = int.Parse(inStockTextBox.Text);
                existingProduct.Price = decimal.Parse(priceCostTextBox.Text);
                existingProduct.Max = int.Parse(maxTextBox.Text);
                existingProduct.Min = int.Parse(minTextBox.Text);

                //Update the product
                Inventory.updateProduct(existingProduct.ProductID, existingProduct);

                this.Close();

                MessageBox.Show("Product updated successfully!");
            }
            else
            {
                MessageBox.Show($"No product found with ID {productID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
            existingProduct.addAssociatedPart(selectedPart.DataBoundItem as Part);

        }

        private void deleteAssociatedPartButton_Click(object sender, EventArgs e)
        {

            //Retrieve the selected row from the DataGridView
            DataGridViewRow selectedPart = partsAssociatedDataGridView.SelectedRows[0];

            //Remove the selected row from the partsAssociatedDataGridView DataGridView
            existingProduct.removeAssociatedPart(selectedPart.DataBoundItem as Part);
        }

        private void searchAllPartsButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(searchAllPartsTextBox.Text, out int partID))
            {
                Part foundPart = existingProduct.lookupAssociatedPart(partID);

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
                modifyPartSaveButton.Enabled = true;
            }
            else
            {
                // Invalid input, highlight with red background
                inStockTextBox.BackColor = Color.Red;
                modifyPartSaveButton.Enabled = false;
            }
        }

        private void priceCostTextBox_TextChanged(object sender, EventArgs e)
        {
            //if Price Text Box is not an Integer
            if (int.TryParse(priceCostTextBox.Text, out _) || decimal.TryParse(priceCostTextBox.Text, out _))
            {
                // Valid integer, reset background color
                priceCostTextBox.BackColor = Color.White;
                modifyPartSaveButton.Enabled = true;
            }
            else
            {
                // Invalid input, highlight with red background
                priceCostTextBox.BackColor = Color.Red;
                modifyPartSaveButton.Enabled = false;
            }
        }

        private void maxTextBox_TextChanged(object sender, EventArgs e)
        {
            //if Max Text Box is not an Integer
            if (int.TryParse(maxTextBox.Text, out _))
            {
                // Valid integer, reset background color
                maxTextBox.BackColor = Color.White;
                modifyPartSaveButton.Enabled = true;
            }
            else
            {
                // Invalid input, highlight with red background
                maxTextBox.BackColor = Color.Red;
                modifyPartSaveButton.Enabled = false;
            }

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            //If Name Text Box is not a String
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                nameTextBox.BackColor = Color.Red;
                modifyPartSaveButton.Enabled = false;
            }
            else
            {
                nameTextBox.BackColor = Color.White;
                modifyPartSaveButton.Enabled = true;
            }
        }

        private void minTextBox_TextChanged(object sender, EventArgs e)
        {
            //if Max Text Box is not an Integer
            if (int.TryParse(minTextBox.Text, out _))
            {
                // Valid integer, reset background color
                minTextBox.BackColor = Color.White;
                modifyPartSaveButton.Enabled = true;
            }
            else
            {
                // Invalid input, highlight with red background
                minTextBox.BackColor = Color.Red;
                modifyPartSaveButton.Enabled = false;
            }
        }



        private void allPartsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }



}
