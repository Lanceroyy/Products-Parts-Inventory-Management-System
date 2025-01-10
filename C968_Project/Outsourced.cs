using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Project
{
    public class Outsourced : Part //Inherit from Part Class
    {
        //Create Constructor

        //When creating constructors we can add parameters
        public Outsourced(int partID, string partName, decimal partPrice, int inStock, int min, int max, string companyName)
            : base(partID, partName, partPrice, inStock, min, max)
        {
            CompanyName = companyName;
        }

        public string CompanyName { get; set; } //UML Required
    }
}
