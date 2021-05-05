using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Tractor : Vehicle
    {
        private bool PTORequired;
        private Tractor()
        {

        }
        public Tractor(string Manufacturer, string Model, int YearOfModel, bool PTORequired) : base(Manufacturer,Model,YearOfModel)
        {
            this.PTORequired = PTORequired;
        }
        public Tractor(string Manufacturer, string Model, int YearOfModel) : base(Manufacturer,Model, YearOfModel)
        {

        }
        public override void ExtraOperation()
        {
            if(this.PTORequired)
            {
                Console.WriteLine("PTO Maintainance was reequired. It has been completed.");
            }
            else
            {
                Console.WriteLine("PTO Maintainance was not required.");
            }
        }
        public override string ToString()
        {
            return string.Format("{0} | PTO Maintainance Required? {1}", base.ToString(), this.PTORequired ? "Yes" : "No");
        }
    }
}
