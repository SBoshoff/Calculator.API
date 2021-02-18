using System.Collections.Generic;
using System;

namespace Calculator.API.Domain.Models
{
    public class AccessLog
    {
        public int Id { get; set; }
        public string IpAddress { get; set; }
        public DateTime dateOfAccess { get; set; }
    }
}