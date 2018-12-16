using System.Collections.Generic;
using PhysioApi.Core.Models;

namespace PhysioApi.Services.Interfaces
{
    public interface IVisitService
    {
         void AddVisit(Visit visit);
         void EditVisit(Visit visit);
         void DeleteVisit(Visit visit);
         Visit GetVisit(int id);         
    }
}