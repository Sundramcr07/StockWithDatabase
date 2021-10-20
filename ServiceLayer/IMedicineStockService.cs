using StockWithDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockWithDatabase.ServiceLayer
{
    public interface IMedicineStockService
    {
         Task<List<MedicineStock>> GetAll();
    }
}
