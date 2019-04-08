using System;
using System.Collections.Generic;


namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("NKE", "Nike");
            stocks.Add("TSLA", "Tesla");
            stocks.Add("NFLX", "Netflix");

            List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();

            purchases.Add(new Dictionary<string, double>() { { "GM", 230.21 } });
            purchases.Add(new Dictionary<string, double>() { { "GM", 580.98 } });
            purchases.Add(new Dictionary<string, double>() { { "CAT", 406.34 } });
            purchases.Add(new Dictionary<string, double>() { { "NKE", 406.34 } });
            purchases.Add(new Dictionary<string, double>() { { "GM", 406.34 } });
            purchases.Add(new Dictionary<string, double>() { { "TSLA", 406.34 } });
            purchases.Add(new Dictionary<string, double>() { { "NFLX", 406.34 } });
            purchases.Add(new Dictionary<string, double>() { { "NKE", 406.34 } });
            purchases.Add(new Dictionary<string, double>() { { "GM", 406.34 } });
            purchases.Add(new Dictionary<string, double>() { { "CAT", 406.34 } });
            purchases.Add(new Dictionary<string, double>() { { "NFLX", 406.34 } });
            purchases.Add(new Dictionary<string, double>() { { "GM", 406.34 } });

            /*
                Define a new Dictionary to hold the aggregated purchase information.
                - The key should be a string that is the full company name.
                - The value will be the total valuation of each stock

                Replace the questions marks below with the correct types.
            */

            Dictionary<string, double> stockReport = new Dictionary<string, double>();

            foreach (Dictionary<string, double> purchase in purchases)
            {
                foreach (KeyValuePair<string, double> stock in purchase)
                {
                    // Does the full company name key already exist in the `stockReport`?

                    // If it does, update the total valuation

                    /*
                        If not, add the new key and set its value.
                        You have the value of "GE", so how can you look
                        the value of "GE" in the `stocks` dictionary
                        to get the value of "General Electric"?
                    */
                    // Console.WriteLine($"value:{stock.Value} / stockSymbol: {stock.Key} / purchase: {stocks[stock.Key]}");

                    if (stockReport.ContainsKey(stocks[stock.Key]))
                    {
                        stockReport[stocks[stock.Key]] += stock.Value;
                    }
                    else
                    {
                        stockReport.Add(stocks[stock.Key], stock.Value);
                    }
                }
            }
            foreach (var stock in stockReport)
            {
                Console.WriteLine($"I own {stock.Value} of {stock.Key}");
            }
        }
    }
}
