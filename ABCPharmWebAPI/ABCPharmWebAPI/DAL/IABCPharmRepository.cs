using ABCPharmWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABCPharmWebAPI.DAL
{
    public interface IABCPharmRepository
    {
        Medicine GetById(int id);
        List<Medicine> GetMedicines();
        void AddItem(Medicine item);
    }
}
