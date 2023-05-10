// See https://aka.ms/new-console-template for more information
using StockOnliner;
using System.Security.Cryptography;
using static StockOnliner.StockExchangeMonitor;

class Program
{
    static void Main(string[] args)
    {
        StockExchangeMonitor stockExchangeMonitor = new StockExchangeMonitor();
        stockExchangeMonitor.PriceChangeHandler += ShowPrice;
        stockExchangeMonitor.PriceChangeHandler += ShowPrice2;
        stockExchangeMonitor.Start();
    }

    public static void ShowPrice(int price, double price2) => 
        Console.WriteLine($"Курс акции: {price}$");
 
    public static void ShowPrice2(int price, double price2)
    {
        Console.WriteLine($"Новая цена за акцию: {price2}$");
    }
}
