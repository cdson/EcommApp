﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZalandoAPIDemo.Models
{
    public class Price
    {
        public string Currency { get; set; }
        public double Value { get; set; }
        public string Formatted { get; set; }
    }
}
