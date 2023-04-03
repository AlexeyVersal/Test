using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Stock
    {
        public delegate void PriceChange(int price);
        public PriceChange priceChange { get; set; }

        public void Start()
        {
            while (true)
            {
                int priceBank = (new Random()).Next(100);

                
            }
        }
    }

}
