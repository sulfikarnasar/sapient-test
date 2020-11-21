using ABCPharmWebAPI.DAL;
using ABCPharmWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABCPharmWebAPI.Services
{
    public class ABCPharmaService : IABCPharmServices
    {
        private IABCPharmRepository abcPharmRepo;
        public ABCPharmaService(IABCPharmRepository _abcPharmRepo)
        {
            abcPharmRepo = _abcPharmRepo;
        }

        public void AddMedicine(Medicine medcine)
        {
            abcPharmRepo.AddItem(medcine);
        }

        public List<Medicine> GetAllMedicines()
        {
            return abcPharmRepo.GetMedicines();
        }

        public Medicine GetDetailedInfoById(int id)
        {
            return abcPharmRepo.GetById(id);
        }
    }
}
