using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Appointment : IComparable<Appointment>, IDisposable, ICloneable
    {
        private string time;
        private Vehicle vehicle;
        public string Time { get => this.time; set => this.time = value; }
        public Vehicle Vehicle { get => this.vehicle; set => this.vehicle = value; }
        public Appointment()
        {

        }
        public Appointment(Vehicle vehicle)
        {
            this.vehicle = vehicle;
        }
        public Appointment(Vehicle vehicle, string time)
        {
            this.vehicle = vehicle;
            this.time = time;
        }
        public object Clone()
        {
            return new Appointment(this.vehicle, this.time);
        }
        public int CompareTo(Appointment Object)
        {
            return this.vehicle.YearOfModel.CompareTo(Object.vehicle.YearOfModel);
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public string ToString()
        {
            return string.Format("Time of Appointment: {0} | {1} \n", Time,Vehicle.ToString());
        }
    }
}
