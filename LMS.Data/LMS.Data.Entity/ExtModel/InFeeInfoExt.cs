﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LMS.Data.Entity
{
    public class InFeeInfoExt : LighTake.Infrastructure.Seedwork.Entity
    {
        public string InStorageID { get; set; }
        public string WayBillNumber { get; set; }
        public string CustomerOrderNumber { get; set; }
        public string CustomerCode { get; set; }
        public string TrackingNumber { get; set; }
        public DateTime InDateTime { get; set; }
        public int ShippingMethodID { get; set; }
        public string ShippingMethodName { get; set; }
        public string CountryCode { get; set; }
        public string ChineseName { get; set; }
        public decimal? SettleWeight { get; set; }
        public decimal? Freight { get; set; }
        public decimal? FuelCharge { get; set; }
        public decimal? Register { get; set; }
        public decimal? TariffPrepayFee { get; set; }
        public decimal? Surcharge { get; set; }
        public decimal? TotalFee { get; set; }
        public decimal Weight { get; set; }
    }
}
