using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Forex
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            GetBestRate getBestRate = new GetBestRate();
            getBestRate.FindRate();
        }
    }
}
