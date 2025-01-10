using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Project
{
    public abstract class Part
    {

        public int PartID { get; set; }
        public string Name { get; set; } 
        public decimal Price { get; set; } 
        public int InStock { get; set; } 
        public int Min { get; set; }
        public int Max { get; set; }

        public Part(int partID, string partName, decimal partPrice, int inStock, int min, int max)
        {
            this.PartID = partID;
            this.Name = partName;
            this.Price = partPrice;
            this.InStock = inStock;
            this.Min = min;
            this.Max = max;
        }

    }
}


