using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Bus : Vehicle
    {
        private bool InteriorCleanUpRequire;
        public Bus()
        {

        }
        public Bus(string Manufacturer, string Model, int YearOfModel, bool InteriorCleanUpRequire) : base (Manufacturer, Model, YearOfModel)
        {
            this.InteriorCleanUpRequire = InteriorCleanUpRequire;
        }
        public Bus(string Manufacturer, string Model, int YearOfModel, bool InteriorCleanUpRequire) : base(Manufacturer, Model, YearOfModel)
        {

        }
        public override ExtraOperations()
        {
            if(this.InteriorCleanUpRequire)
            {
                Console.Write("Interior Clean Up was required. The clean up is completed.");
            }
            else
            {
                Console.WriteLine("There are no Interior clean up needed.");
            }
        }
        public override string ToString()
        {
            return string.Format("{0} | Require interior clean up required? {1}", base.ToString(), this.InteriorCleanUpRequire ? "Yes" : "No");
        }

    }
}
