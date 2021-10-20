using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockWithDatabase.Models;
using StockWithDatabase.Repository;
using StockWithDatabase.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockWithDatabase.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MedicineStockInformationController : ControllerBase
    {
        private readonly IMedicineStockService imss;
        public MedicineStockInformationController(IMedicineStockService mss)
        {
            imss = mss;
        }
        [HttpGet]
        public async Task<IActionResult> GetStock()
        {
            List<MedicineStock> medStock = await (imss.GetAll());
            if (medStock != null)
            {
                return Ok(medStock);
            }
            else
            {
                return NoContent();
            }
        }
    }
}
