using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiObject
{
    class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine($"Driver Name : {DriverName}");
            Console.WriteLine($"On Duty     : {OnDuty}");
            Console.WriteLine($"Number Of Passengers : {NumPassenger}");
            Console.WriteLine();
        }

        public void PickUpPassenger()
        {
            Console.WriteLine($"{DriverName} sedang menjemput penumpang");
        }

        public void DropOffPassenger()
        {
            Console.WriteLine($"{DriverName} selesai mengantar penumpang");
        }
    }
}
