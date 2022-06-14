using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSP.Helper.Models
{
    public class Meter
    {
        public string Id { get; set; }
        public string subject { get; set; }
        public string source { get; set; }
        public string customerAccountNumber { get; set; }
        public string serviceAccountNumber { get; set; }
        public string accountType { get; set; }
        public string siteId { get; set; }
        public string meterSerialNumber { get; set; }
        public string readingDate { get; set; }
        public List<Register> registers { get; set; }
    }

    public class Register
    {
        public string rate { get; set; }
        public string value { get; set; }
    }

    public class SubmittedMeter
    {
        public Meter Payload { get; set; }
    }
}
