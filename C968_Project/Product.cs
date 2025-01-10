using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_Project
{
    public class Product
    {

        public int ProductID { get; set; } //UML Required
        public string Name { get; set; } //UML Required
        public decimal Price { get; set; } //UML Required
        public int InStock { get; set; } //UML Required
        public int Min { get; set; } //UML Required
        public int Max { get; set; } //UML Required

        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>(); //UML Required

        static Product() 

        {

     
        }

        public void addAssociatedPart(Part part)  //UML Required
        { 
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(Part part)  //UML Required
        {
            // Confirm deletion
            var confirmResult = MessageBox.Show(
                "Are you sure you want to delete this part associated with this product?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                // Delete the product
                if (AssociatedParts.Contains(part))
                {
                    AssociatedParts.Remove(part);
                    return true;
                }
            }
            
            if (confirmResult == DialogResult.No)
            {
                return false;
            }

            MessageBox.Show("Part not found.");
            return false;
        }

        public Part lookupAssociatedPart(int partID)  //UML Required
        {
            AddProductForm addProductForm = Application.OpenForms["AddProductForm"] as AddProductForm;
            ModifyProductForm modifyProductForm = Application.OpenForms["ModifyProductForm"] as ModifyProductForm;

            if (addProductForm != null)
            {
                var dataGridView = addProductForm.allPartsDataGridView;

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

            if (modifyProductForm != null)
            {
                var dataGridView = modifyProductForm.allPartsDataGridView;

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

            return null; // Return null if the product is not found*/
        }
    }
}
