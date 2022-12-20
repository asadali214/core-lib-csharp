﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Test.MockTypes.Convertors;
using APIMatic.Core.Utilities.Date;
using Newtonsoft.Json;

namespace APIMatic.Core.Test.MockTypes.Models
{
    internal class TestModelB
    {
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        public DateTime TestDateTime { get; set; }

    }
}