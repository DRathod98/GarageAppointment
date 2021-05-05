using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    interface IVehicles
    {
        int YearOfModel { get; set; }
        string Manufacturer { get; set; }
        string Model { get; set; }
        void ChangeOil();
        void ExtraOperation();
        void TransCleanUp();
        void EngineTune();

    }
}
