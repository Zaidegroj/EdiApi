﻿using System;
using System.Collections.Generic;

namespace EdiApi.Models
{
    public partial class LearN1830
    {
        public string OrganizationId { get; set; }
        public string Name { get; set; }
        public string IdCodeQualifier { get; set; }
        public string IdCode { get; set; }
        public string EdiStr { get; set; }
        public string HashId { get; set; }
    }
}
