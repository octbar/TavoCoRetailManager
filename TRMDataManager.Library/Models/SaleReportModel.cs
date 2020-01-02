﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDataManager.Library.Models
{
    public class SaleReportModel
    {
        public DateTime dateTime { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
        public string LastName { get; set; }
        public string  FirstName { get; set; }
        public string  EmailAdress { get; set; }
    }
}
