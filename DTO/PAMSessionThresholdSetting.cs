﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PerfectAndMergeData.DTO
{
    public class PAMSessionThresholdSetting
    {
        public string  SessionThresholdId { get; set; }
        public string SessionId { get; set; }
        public int Threshold1 { get; set; }
        public int Threshold2 { get; set; }
        public Nullable<System.Guid> LanguageId { get; set; }
        public Nullable<bool> IncludeOriginal { get; set; }
        public Nullable<bool> TreatAccountNulls { get; set; }
        public Nullable<bool> TreatNulls { get; set; }
        public Nullable<System.Guid> MatchKeyID { get; set; }
        public string ViewType { get; set; }
        public string ViewName { get; set; }
        public string FetchXML { get; set; }

        public string MatchKey { get; set; }

        public Nullable<bool> ValueToNull { get; set; }
    }
}
