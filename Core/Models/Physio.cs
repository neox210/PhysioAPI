using System.Collections.ObjectModel;

namespace PhysioApi.Core.Models
{
    public class Physio
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public Collection<Visit> Visits { get; set; }
        public Collection<GroupVisit> GroupVisits { get; set; }
    }
}