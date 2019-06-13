using System;

namespace Reporting.Business.Models
{
    public class Waiting
    {
        public WaitingReason Reason { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        
    }
}