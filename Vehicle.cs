using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public abstract class Vehicle : IVehicles
    {
        private string manufacturer;
        private string model;
        private int yearOfModel;
        public int YearOfModel { get => this.yearOfModel; set => this.yearOfModel = value; }
        public string Manufacturer { get => this.manufacturer; set => this.manufacturer = value; }
        public string Model { get => this.model; set => this.model = value; }
        public Vehicle()
        {

        }
        public Vehicle(string manufacturer,string model, int yearOfModel)
        {
            this.manufacturer = manufacturer;
            this.yearOfModel = yearOfModel;
            this.model = model;
        }
        public void TransCleanUp()
        {
            Console.WriteLine("Transmission Clean up is in process.");
        }
        public void ChangeOil()
        {
            Console.WriteLine("Oil is being changed.");
        }
        public void EngineTune()
        {
            Console.WriteLine("Engine is being tuned up.");
        }
        public abstract void ExtraOperation();
        public override string ToString()
        {
            return string.Format("| Company: " +this.manufacturer+ "| Model: " +this.model+ "| Year of make: " +this.yearOfModel+ "");
        }
    }

}
