using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C968_Project
{
    public partial class MainScreen : Form
    {
        public event EventHandler OnButtonClicked;

        private static MainScreen instance;

        public static MainScreen Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainScreen();
                }
                return instance;
            }
        }

        private Inventory inventory = new Inventory();


        public MainScreen()
        {
            InitializeComponent();

            //Intialize DataGridViews
            inventory.IntializeDataGridView(partsDataGridView);
            inventory.IntializeDataGridView(productsDataGridView);

            //Adds Columns
            addColumns();

            //Add Test Data
            Inventory.Products.Add(new Product { ProductID = 5, Name = "Car", InStock = 1, Price = 100.00m, Max = 10, Min = 1 });
            Inventory.AllParts.Add(new Outsourced(1, "Outsourced Tire", 1.00m, 1, 1, 10, "Yahoo"));
            Inventory.AllParts.Add(new Inhouse(3, "Inhouse Door", 2.00m, 1, 1, 10, 777));

            //Populate DataGridViews
            productsDataGridView.DataSource = Inventory.Products;
            partsDataGridView.DataSource = Inventory.AllParts;

        }

        public void addColumns()
        {

            //Add Columns to Part DataGridView
            partsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PartID",
                HeaderText = "Part ID",
                DataPropertyName = "PartID" // Matches the property in the data source
            });

            partsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                HeaderText = "Name",
                DataPropertyName = "Name" // Matches the property in the data source
            });

            partsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "InStock",
                HeaderText = "In Stock",
                DataPropertyName = "InStock" // Matches the property in the data source
            });

            partsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Price",
                HeaderText = "Price",
                DataPropertyName = "Price" // Matches the property in the data source
            });


            //Add Columns to Product DataGridView
            productsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProductID",
                HeaderText = "Product ID",
                DataPropertyName = "ProductID" // Matches the property in the data source
            });

            productsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                HeaderText = "Name",
                DataPropertyName = "Name" // Matches the property in the data source
            });

            productsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "InStock",
                HeaderText = "In Stock",
                DataPropertyName = "InStock" // Matches the property in the data source
            });

            productsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Price",
                HeaderText = "Price",
                DataPropertyName = "Price" // Matches the property in the data source
            });

        }

        //Clears Initial Selection Upon DatagridView Binding Complete
        private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            partsDataGridView.ClearSelection();
            productsDataGridView.ClearSelection();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //-------------Main Screen Parts Elements--------------//

        private void partsAddButtonMS_Click(object sender, EventArgs e)
        {
            AddPartForm addPartForm = new AddPartForm();

            var addPartFormExists = Application.OpenForms["AddPartForm"];
            if (addPartFormExists == null)
            {
                addPartForm.Show();
            }
            
        }


        private void partsTitleText_TextChanged(object sender, EventArgs e)
        {

        }

        private void partsModifyButtonMS_Click(object sender, EventArgs e)
        {
            //If no row is selected show message
            if (!partsDataGridView.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a part to modify.");
                return;
            }

            Part part = partsDataGridView.CurrentRow.DataBoundItem as Part;
            int index = partsDataGridView.CurrentCell.RowIndex;

            MessageBox.Show(part.ToString() + " at row index of " + index);

            //Create new ModifyPartForm
            ModifyPartForm modifyPartForm = new ModifyPartForm();

            var modifyPartFormExists = Application.OpenForms["ModifyPartForm"];
            if (modifyPartFormExists == null)
            {
                modifyPartForm.Show();
                modifyPartForm.formatAddPartForm(part);

            }
        }

        private void partsDeleteButtonMS_Click(object sender, EventArgs e)
        {
            //If no row is selected show message
            if (!partsDataGridView.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a part to delete.");
                return;
            }


            //If part is associated with a product do not allow deletion
            //If part is in the associated parts list do not allow deletion
            Part selectedPart = Inventory.AllParts[partsDataGridView.CurrentCell.RowIndex];

            // Check if the part is associated with any products
            foreach (Product product in Inventory.Products) // Assume Inventory.Products contains all products
            {
                if (product.AssociatedParts.Contains(selectedPart))
                {
                    MessageBox.Show("This part is associated with a product and cannot be deleted.");
                    return;
                }
            }



            //Show delete confirm message
            var confirmResult = MessageBox.Show("Are you sure you want to delete this part?",
                                     "Confirm Deletion?",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                //Delete Part
                inventory.deletePart(Inventory.AllParts[partsDataGridView.CurrentCell.RowIndex]);
                //Inventory.AllParts.RemoveAt(partsDataGridView.CurrentCell.RowIndex);
            }
            else
            {
                return;
            }

        }

        private void partsSearchButtonMS_Click(object sender, EventArgs e)
        {
            if (int.TryParse(partsSearchTextBox.Text, out int partID))
            {
                Part foundPart = inventory.lookupPart(partID);

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


        //--------------Main Screen Products Elements--------------//

        private void productsSearchButtonMS_Click(object sender, EventArgs e)
        {
            if (int.TryParse(productsSearchTextBox.Text, out int productID))
            {
                Product foundProduct = inventory.lookupProduct(productID);

                if (foundProduct != null)
                {
                    MessageBox.Show($"Product found: {foundProduct.Name} (ID: {foundProduct.ProductID})");
                }
                else
                {
                    MessageBox.Show("Product not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid product ID.");
            }


        }

        private void productsAddButtonMS_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();

            var addProductFormExists = Application.OpenForms["AddProductForm"];
            if (addProductFormExists == null)
            {
                addProductForm.Show();

            }

        }

        private void productsModifyButtonMS_Click(object sender, EventArgs e)
        {
            //If no row is selected show message
            if (!productsDataGridView.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a product to modify.");
                return;
            }

            Product product = productsDataGridView.CurrentRow.DataBoundItem as Product;
            int index = productsDataGridView.CurrentCell.RowIndex;

            MessageBox.Show(product.ToString() + " at row index of " + index);

            //Create new ModifyProductForm
            ModifyProductForm modifyProductForm = new ModifyProductForm();

            var modifyProductFormExists = Application.OpenForms["ModifyProductForm"];

            if (modifyProductFormExists == null) //If window does not exist
            {
                modifyProductForm.Show();
                modifyProductForm.formatModifyProductForm(product);
            }
        }

        private void productsDeleteButtonMS_Click(object sender, EventArgs e)
        {
            //If no row is selected show message
            // Ensure a row is selected

            if (!productsDataGridView.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            //If product has associated parts do not allow deletion
            if (productsDataGridView.CurrentRow.DataBoundItem is Product product)
            {
                if (product.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Cannot delete product with associated parts.");
                    return;
                }
            }


            // Confirm deletion
            var confirmResult = MessageBox.Show(
                "Are you sure you want to delete this product?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                // Delete the product
                int rowIndex = productsDataGridView.CurrentCell.RowIndex;
                inventory.removeProduct(rowIndex);

                // Refresh the DataGridView
                productsDataGridView.DataSource = null;
                productsDataGridView.DataSource = Inventory.Products;
            }
            return;

        }

        private void productsTitleText_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainScreenTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show has 3 arguements, The first is the message, the second is the caption/title, and the third are the buttons.
            var confirmResult = MessageBox.Show("Are you sure you want to exit the application?",
                                     "Confirm Exit!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void productsSearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
