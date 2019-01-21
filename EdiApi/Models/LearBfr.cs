﻿using System;
using System.Collections.Generic;

namespace EdiApi.Models
{
    public partial class LearBfr
    {
        public LearBfr()
        {
            LearLin = new HashSet<LearLin>();
        }

        public int Id { get; set; }
        public string TransactionSetPurposeCode { get; set; }
        public string ForecastOrderNumber { get; set; }
        public string ReleaseNumber { get; set; }
        public string ForecastTypeQualifier { get; set; }
        public string ForecastQuantityQualifier { get; set; }
        public string ForecastHorizonStart { get; set; }
        public string ForecastHorizonEnd { get; set; }
        public string ForecastGenerationDate { get; set; }
        public string ForecastUpdatedDate { get; set; }
        public string ContractNumber { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public string Time { get; set; }
        public int IdGs { get; set; }

        public LearGs IdGsNavigation { get; set; }
        public ICollection<LearLin> LearLin { get; set; }
    }
}