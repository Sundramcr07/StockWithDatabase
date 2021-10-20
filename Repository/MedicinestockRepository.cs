using Microsoft.EntityFrameworkCore;
using StockWithDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockWithDatabase.Repository
{
    public class MedicinestockRepository : IMedicineStockRepository
    {
        private readonly MedicineStockContext dc = new MedicineStockContext();

        public async Task<List<MedicineStock>> GetMedicineStocks()
        {
            List<MedicineStock> stock = new List<MedicineStock>();
            try
            {
                stock = await (from s in dc.MedicineStocks select s).ToListAsync();
                return stock;
            }
            catch (Exception)
            {
                throw new MedicineStockException(" Medicine Out Of Stock ");
            }
        }
    }
}
