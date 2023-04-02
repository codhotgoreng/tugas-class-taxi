using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects
{
    class Taxi
    { 
        // Properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        // Method
        public void TaxiInfo()
        {
            Console.WriteLine("TaxiInfo : {0}", DriverName);
            if (OnDuty == true)
            {
                Console.WriteLine("PickUpPassenger : Yes", OnDuty);
            }
            else
            {
                Console.WriteLine("PickUpPassenger : No", OnDuty);
            }

            Console.WriteLine("DropOffPassenger : {0}", NumPassenger );
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("Jono sedang menjemput penumpang");
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("Jono selesai mengantar penumpang");
        }
    }
}
