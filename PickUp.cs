using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class PickUp : Vehicle
    {
        private bool CoverInstallationRrquired { get; set; }
        public PickUp()
        {

        }
        public PickUp(string Manufacturer, string Model, int YearOfModel, bool CoverInstallationRequired) : base(Manufacturer, Model, YearOfModel)
        {
            this.CoverInstallationRrquired = CoverInstallationRrquired;
        }
        public override void ExtraOperation()
        {
            if(this.CoverInstallationRrquired)
            {
                Console.WriteLine("Installation of the cover was required. It has been completed.");
            }
            else
            {
                Console.WriteLine("No cover installation was required.");
            }
        }
        public override string ToString()
        {
            return string.Format("{0} | Cover Installation Required? {1}", base.ToString(), this.CoverInstallationRrquired ? "Yes" : "No");
        }
        public PickUp(string Manufacturer, string Model, int YearOfModel) : base(Manufacturer, Model, YearOfModel)
        {

        }
    }
}
