using System;
using System.Collections.ObjectModel;

namespace PhysioApi.Core.Models
{
    public class Visit
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
        public Patient Patient { get; set; }
        public Physio Physio { get; set; }
    }
}