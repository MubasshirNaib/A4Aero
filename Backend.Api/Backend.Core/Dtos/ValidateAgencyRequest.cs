﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Core.Dtos
{
    public class ValidateAgencyRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string BookingMode { get; set; }
        public string IPAddress { get; set; }
    }
}
