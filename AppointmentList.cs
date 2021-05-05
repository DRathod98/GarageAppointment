using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace Assignment5
{
    class AppointmentList : IEnumerable<Appointment>
    {
        public List<Appointment> apptlist;
        public ListOfAppointment()
        {
            apptlist = new List<Appointment>();
        }
        public ListOfAppointment(List<Appointment> aList)
        {
            this.apptlist = aList;
        }
        public void SortList()
        {
            apptlist.Sort();
        }
        public int Count
        {
            get { return apptlist.Count; }
        }
        public Appt this[int d]
        {
            get { return List[d]; }
            set { List[d] = value; }
        }
        public void RemAt(int d)
        {
            this.apptlist.RemoveAt(d);
        }
        public void Add(Appointment appt)
        {
            this.apptlist.Add(appt);
        }
        public void Remove(Appointment appt)
        {
            this.apptlist.Remove(appt);
        }
        public IEnumerable<Appointment> GetEnumerator()
        {
            return apptlist.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return apptlist.GetEnumerator();
        }
    }
}
