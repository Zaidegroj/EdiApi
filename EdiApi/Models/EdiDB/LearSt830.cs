﻿using System;
using System.Collections.Generic;

namespace EdiApi.Models.EdiDB
{
    public partial class LearSt830
    {
        public string IdCode { get; set; }
        public string ControlNumber { get; set; }
        public string EdiStr { get; set; }
        public string HashId { get; set; }
        public string ParentHashId { get; set; }
    }
}
