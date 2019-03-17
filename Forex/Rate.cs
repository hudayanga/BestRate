using System;
namespace Forex
{
    public class RateData
    {
        public int Id { get; set; }
        public string Partner { get; set; }
        public int Supply { get; set; }
        public decimal Rate { get; set; }
    }
}
