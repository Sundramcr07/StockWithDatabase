using StockWithDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockWithDatabase.Repository
{
    public interface IMedicineStockRepository
    {
        Task<List<MedicineStock>> GetMedicineStocks();
    }
}
