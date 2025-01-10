using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C968_Project
{

    internal class Inventory
    {
        
        public static BindingList<Product> Products = new BindingList<Product>(); //UML Required
        public static BindingList<Part> AllParts = new BindingList<Part>();  //UML Required

        public void IntializeDataGridView(DataGridView dataGridView)
        {
            //Upon Click Selects Whole Row
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Make parts grid read only
            dataGridView.ReadOnly = true;

            //Multiple Selection not allowed
            dataGridView.MultiSelect = false;

            //Remove Bottom Empty Row
            dataGridView.AllowUserToAddRows = false;

            dataGridView.AutoGenerateColumns = false;

        }


        //MUST IMPLEMENT THESE METHODS
        public static void addProduct(Product product)  //UML Required
        {

            //Add Product Form
            Products.Add(product);

        }

        public bool removeProduct(int productIndex)  //UML Required
        {
            //return true if able to remove, false if not.

            // Ensure the index is within the valid range
            if (productIndex >= 0 && productIndex < Products.Count)
            {
                // Remove the product from the list
                Products.RemoveAt(productIndex);

                return true; // Successfully removed
            }

            // If the index is invalid
            MessageBox.Show("Invalid product index.");

            return false;
        }

        public Product lookupProduct(int productID) //UML Required
        {

            // Access the MainScreen form instance
            MainScreen mainScreen = Application.OpenForms["MainScreen"] as MainScreen;

            if (mainScreen != null)
            {
                var dataGridView = mainScreen.productsDataGridView;

                // Iterate over rows to find the product ID
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.DataBoundItem is Product product && product.ProductID == productID)
                    {
                        row.Selected = true; // Select the row
                        dataGridView.FirstDisplayedScrollingRowIndex = row.Index; // Scroll to it
                        return product; // Return the matching product
                    }
                }
            }

            return null; // Return null if the product is not found
        }

        public static void updateProduct(int productID, Product product) //UML Required
        {
            //int could be a product id or product index
            //Product arguement is the replacment product

            //Modify Product Form

            //update the product with the new product
            var existingProduct = Inventory.Products.FirstOrDefault(p => p.ProductID == productID);
            if (existingProduct != null)
            {
                // Update the properties of the existing product
                int index = Inventory.Products.IndexOf(existingProduct);
                existingProduct.Name = product.Name;
                existingProduct.InStock = product.InStock;
                existingProduct.Price = product.Price;
                existingProduct.Max = product.Max;
                existingProduct.Min = product.Min;

                //Notify the BindingList of the change
                Inventory.Products[index] = existingProduct;

            }
            else
            {
                MessageBox.Show($"No product found with ID {productID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void addPart(Part part) //UML Required
        {
            //adds a part to inventory parts list???
            if (part != null)
            {
                AllParts.Add(part);
            }

        }

      
        public bool deletePart(Part part) //UML Required
        {
            //returns true if able to remove, false if not.
            if (part != null)
            {
                AllParts.Remove(part);
                return true;
            }

            return false;
        }


        public Part lookupPart(int partID) //UML Required
        {
            MainScreen mainScreen = Application.OpenForms["MainScreen"] as MainScreen;

            if (mainScreen != null)
            {
                var dataGridView = mainScreen.partsDataGridView;

                // Iterate over rows to find the product ID
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.DataBoundItem is Part part && part.PartID == partID)
                    {
                        row.Selected = true; // Select the row
                        dataGridView.FirstDisplayedScrollingRowIndex = row.Index; // Scroll to it
                        return part; // Return the matching product
                    }
                }
            }

            return null; // Return null if the product is not found

        }


        public static void updatePart(int partID, Part updatedPart) // UML Required
        {
            // Locate the existing part by partID
            var existingPart = Inventory.AllParts.FirstOrDefault(p => p.PartID == partID);

            if (existingPart != null)
            {
                // Find the index of the existing part
                int index = Inventory.AllParts.IndexOf(existingPart);

                // Replace the existing part with the updated one
                Inventory.AllParts[index] = updatedPart;

                MessageBox.Show("Part updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show($"No part found with ID {partID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }


        public static bool validateInventoryCount(int inventoryCount, int max, int min)
        {

            if (inventoryCount < min || inventoryCount > max)
            {
                MessageBox.Show("Inventory count must be between the Min of " + min + " and the Max of " + max + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            else
            {
                return true;
            }
        }



    }

    } 
