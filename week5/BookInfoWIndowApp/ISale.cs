using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInfoWIndowApp
{
    interface ISale
    {
        void DiscountPrice(int discount);
      void StockOut();
       void StorageInWareHouse();
    }
}
