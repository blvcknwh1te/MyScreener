﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyScreener
{
    class Stock
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public double Price { get; set; }
        public double Capitalization { get; set; }
        public int Volume { get; set; }
        public double Dividends { get; set; }
        public string Exchange { get; set; }

        public Dictionary<Ratio, double> Ratios { get; set; } = new Dictionary<Ratio, double>();
    }

    public enum Ratio
    {
        PE,
        PB,
        PS,
        EPS,
        PriceCashFlow,
        OperatingMargin,
        NetProfitMargin,
        ROE,
        ROA,
        PEG,
        DividendPayoutRatio
    }

}
