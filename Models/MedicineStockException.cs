using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockWithDatabase.Models
{
    public class MedicineStockException : Exception
    {
        public MedicineStockException(string errMsg) : base(errMsg)
        {

        }
    }
}
