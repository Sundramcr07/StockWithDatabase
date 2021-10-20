using StockWithDatabase.Models;
using StockWithDatabase.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockWithDatabase.ServiceLayer
{
    public class MedicineStockService : IMedicineStockService
    {
        private readonly IMedicineStockRepository IMedicineStock;
        public MedicineStockService(IMedicineStockRepository IMedicineStock)
        {
            this.IMedicineStock = IMedicineStock;
        }
        public async Task<List<MedicineStock>> GetAll()
        {
            return await IMedicineStock.GetMedicineStocks();
        }
    }
}
