﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PerfectAndMergeData.DTO
{
    public class PAMSessionThresholdSettingResultSet : ResultSet
    {
        public List<PAMSessionThresholdSetting> PAMSessionThresholdSettings { get; set; }
    }
}
