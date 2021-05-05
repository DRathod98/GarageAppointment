using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Car : Vehicle
    {
        public bool BodyTuneUpRequire;
        public Car()
        {

        }
        public Car(string Manufacturer, string Model, int YearOfModel, bool BodyTuneUpRequire) : base(Manufacturer,Model,YearOfModel)
        {
            this.BodyTuneUpRequire = BodyTuneUpRequire;
        }
        public override void ExtraOperation()
        {
            if(this.BodyTuneUpRequire)
            {
                Console.WriteLine("Body Tune-Up was required. It has been completed.");
            }
            else
            {
                Console.WriteLine("No Body Tune Up was needed.");
            }
        }
        public Car(string Manufacturer, string Model, int YearOfModel) : base (Manufacturer, Model, YearOfModel)
        {
    
        }
        public override string ToString()
        {
            return string.Format("{0} | Require Body TuneUp?  ", base.ToString(), this.BodyTuneUpRequire ? "Yes" : "No");
        }
    }
}
