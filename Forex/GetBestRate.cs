using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Forex
{
    public class GetBestRate
    {
        private RateContext context;

        public GetBestRate()
        {
             context = new RateContext();
        }

        internal void FindRate()
        {
            Console.WriteLine("Please Enter Selling Amount");
            var amount = Console.ReadLine();

            var bestRate = FindBestRate(amount);

            Console.WriteLine($"Here are the best rate {bestRate}");

            FindRate();

        }

        private decimal FindBestRate(string amount)
        {
            var rates= context.GetAllRates();

            var sorted=rates.OrderByDescending(x=>x.Rate);

            var bestrate=CalcBestRate(sorted, Convert.ToInt32(amount));

            return bestrate;
        }

        private decimal CalcBestRate(IEnumerable<RateData> rates, int amount)
        {
            for (int i = 1; i < rates.Count()+1; i++)
            {
                var sumSupply = rates.Take(i).Sum(x => x.Supply);

                if (sumSupply >= amount)
                {
                    var final = 0M;
                    var balance = amount;

                    for (int j = 0; j < i; j++)
                    {
                        var su = (rates.ElementAt(j).Supply);
                        var ra = (rates.ElementAt(j).Rate);

                        if (balance > su)
                        {
                            final = final + (ra * su);
                        }
                        else
                        {
                            final = final + (balance * ra);
                        }

                        balance = balance - su;

                    }

                    var bestRate= final / amount;

                    return bestRate;
                }
                else
                {
                    continue;
                }

            }

            return 0;

        }


    }
}
