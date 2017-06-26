using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AvaliacaoInfnet.MVC.Models
{
    public class Class1
    {
        private decimal orderAllowanceRate;

        public decimal OrderAllowanceRate
        {
            get { return orderAllowanceRate; }
            set { orderAllowanceRate = value < default(decimal) ? throw new Exception($"{nameof(OrderAllowanceRate)} cannot be lower than 0") : value; }
        }
    }
}