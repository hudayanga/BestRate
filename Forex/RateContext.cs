using System;
using System.Collections.Generic;

namespace Forex
{
    public class RateContext
    {
        public List<RateData> Rates { get; set; }

        public RateContext()
        {
            Rates = new List<RateData>()
            {

                new RateData() {Id=1,Partner="A",Supply=100,Rate=1.3M},
                new RateData() {Id=2,Partner="B",Supply=50,Rate=1.35M},
                new RateData() {Id=3,Partner="C",Supply=20,Rate=1.37M}

            };
        }

        internal List<RateData> GetAllRates()
        {
            return Rates;
        }
    }
}
