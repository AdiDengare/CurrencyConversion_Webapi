﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webapi_Project.Models
{
    public class CurrencyRateRequest
    {
        public string From { get; set; }
        public string To { get; set; }
        public double Amount { get; set; }
    }
}
