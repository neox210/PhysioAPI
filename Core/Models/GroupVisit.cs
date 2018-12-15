using System;
using System.Collections.ObjectModel;

namespace PhysioApi.Core.Models
{
    public class GroupVisit
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
        public Collection<Patient> Patients { get; set; }
        public Collection<Physio> Physios { get; set; }
    }
}