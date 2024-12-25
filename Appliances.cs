using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliance_Rental_System__Assignment_
{
   public class Appliance
    {
        public int ApplianceID {  get; set; }
        public string Type { get; set;}
        public string Name { get; set;}  
        public string Description { get; set;}
        public string PowerConsumption { get; set;}
        public decimal Cost { get; set;}
        /*public string Model { get; internal set; }
        public int Dimension { get; internal set; }
        public string Colour { get; internal set; }*/

        public Appliance(int appID, string type, string name, string description, string powerConsumption, decimal cost)
        {
            ApplianceID = appID;
            Type = type;
            Name = name;
            Description = description;
            PowerConsumption = powerConsumption;
            Cost = cost;
        }
    }
}
