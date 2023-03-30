using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanTaxi
{
    internal class Taxi
    {
        public string Drivername { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Nama Driver : {0}", Drivername);
            if (OnDuty == true)
            {
                Console.WriteLine("On duty : Yes");
            }
            if (OnDuty == false)
            {
                Console.WriteLine("On Duty : No");
            }
            Console.WriteLine ("Number of passenger : {0}", NumPassenger);
        }
        public void PickUpPassenger()
        {

            Console.WriteLine ("{0} sedang menjemput penumpang", Drivername);

        }
        public void DropOffPassenger()
        {

            Console.WriteLine ("{0} sudah selesai mengantar penumpang", Drivername);

        }
    }
}
