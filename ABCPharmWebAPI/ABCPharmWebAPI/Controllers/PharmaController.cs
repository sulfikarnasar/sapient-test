using ABCPharmWebAPI.Models;
using ABCPharmWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ABCPharmWebAPI.Controllers
{
    [Route("medicine/api")]
    [ApiController]
    public class PharmaController : ControllerBase
    {
        private IABCPharmServices pharmaService;
        public PharmaController(IABCPharmServices _pharmaService)
        {
            pharmaService = _pharmaService;
        }
        [HttpGet]
        public IActionResult GetMedicines()
        {
            return new  OkObjectResult(pharmaService.GetAllMedicines());
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var item = pharmaService.GetDetailedInfoById(id);
            if (item == null) return new NotFoundObjectResult("Item not found");
            return new OkObjectResult(item);
        }

        [HttpPut]
        public IActionResult AddMedicine(Medicine medicine)
        {
            pharmaService.AddMedicine(medicine);
            return Ok("Medicine added to Database successfully");

        }
    }
}
