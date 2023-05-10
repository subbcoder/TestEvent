using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockOnliner
{
    public class StockExchangeMonitor
    {
        public delegate void PriceChange(int price, double price2);
        public PriceChange? PriceChangeHandler { get; set; }

        public void Start()
        {
            while(true)
            {
                int bankOfAmericaPrice = (new Random()).Next(100);
                double d = Math.Round(42.00000 + (new Random()).NextDouble() * (3.000), 3);


                PriceChangeHandler?.Invoke(bankOfAmericaPrice, d);

                Thread.Sleep(2000);
            }
        }
    }
}
