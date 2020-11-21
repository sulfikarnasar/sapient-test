using ABCPharmWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABCPharmWebAPI.DAL
{
    public class ABCPharmRepository : IABCPharmRepository
    {
        List<Medicine> medicineCollection = new List<Medicine>();
        public ABCPharmRepository()
        {
            medicineCollection.Add(new Medicine
            {
                Id=1,
                Name = "Cipla",
                Brand = "ABCPharm",
                Expiry = System.DateTime.Now.ToString("MM/dd/yyyy"),
                Quantity=4,
                Price=10
            }) ;
            medicineCollection.Add(new Medicine
            {
                Id=2,
                Name = "Termol",
                Brand = "WestPharm",
                Expiry = System.DateTime.Now.ToString("MM/dd/yyyy"),
                Quantity = 100,
                Price = 10
            });
        }
        public List<Medicine> GetMedicines()
        {
            return medicineCollection;
        }
        public Medicine GetById(int id)
        {
            return medicineCollection.SingleOrDefault(x=>x.Id==id);
        }
        public void AddItem(Medicine item)
        {
            medicineCollection.Add(item);
        }
    }
}
