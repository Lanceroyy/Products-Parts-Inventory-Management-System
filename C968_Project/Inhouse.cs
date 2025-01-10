using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Project
{
    public class Inhouse : Part
    {
        //need to inherit from part class
        public Inhouse(int partID, string partName, decimal partPrice, int inStock, int min, int max, int machineID)
            : base(partID, partName, partPrice, inStock, min, max) 
        { 
            //SETTING THNIS 
            MachineID = machineID;
        }

        public int MachineID { get; set; } //UML Required
    }



}
