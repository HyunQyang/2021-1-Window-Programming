using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInfoWIndowApp
{
    class EBook :Book,ISale
    {
        Book b;
        private int price;
        bool outOfStock = false;

        public EBook(string title,string author,int page,string ISBN,string publisher,int price):base (title,author,page,ISBN,publisher )
        {
            this.price = price;

        }

        public int Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public bool OutofStock
        {
            get
            {
                return this.outOfStock;
            }
            set
            {
                this.outOfStock = value;
            }
        }

        public bool 


        public override string ToString()
        {
            return base.ToString() + "\nprice:" + this.price;
        }
        public void DiscountPrice(int discount)
        {
            this.price = price - discount;
        }
        public void Stockout()
        {
            this.outOfStock = true;
        }
        public void StorageInWareHouse()
        {
            this.outOfStock = false;
        }


    }
}
