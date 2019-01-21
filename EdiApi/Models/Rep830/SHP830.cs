﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdiApi
{
    public class SHP830 : EdiBase
    {
        public const string Init = "SHP";
        public const string Self = "Shipped/Received Information";
        public string QuantityQualifier { get; set; }
        public string Quantity { get; set; }
        public string DateTimeQualifier { get; set; }
        public string AccumulationStartDate { get; set; }
        public string AccumulationTime { get; set; }
        public string AccumulationEndDate { get; set; }
        public SHP830(string _SegmentTerminator) : base(_SegmentTerminator)
        {
            Orden = new string[]{
                "Init",
                "QuantityQualifier", "Quantity",
                "DateTimeQualifier", "AccumulationStartDate",
                "AccumulationTime", "AccumulationEndDate"
            };
        }
    }
}