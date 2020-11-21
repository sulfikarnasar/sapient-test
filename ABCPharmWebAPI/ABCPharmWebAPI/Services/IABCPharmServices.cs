using ABCPharmWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABCPharmWebAPI.Services
{
    public interface IABCPharmServices
    {
        Medicine GetDetailedInfoById(int id);
        List<Medicine> GetAllMedicines();

        void AddMedicine(Medicine medcine);
    }
}
