using System.Collections.Generic;
using System;
using Calculator.API.Domain.Models.Interfaces;

namespace Calculator.API.Domain.Models
{
    public class AccessLog : IEntityBase
    {
        public int id { get; set; }
        public string IpAddress { get; set; }
        public DateTime dateOfAccess { get; set; }
    }
}