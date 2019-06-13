using System;
using System.Collections.Generic;
using System.Linq;
using Reporting.Business.Models;

namespace Reporting.Business
{
    public class ReportingResult
    {
        public string WorkOrderNo { get; set; }
        public int TotalMinutes { get; set; }
        public List<ReportingResultItem> Items { get; set; }

        public ReportingResult()
        {
            Items = new List<ReportingResultItem>();
            foreach (var reason in Enum.GetValues(typeof(WaitingReason)).Cast<WaitingReason>())
            {
                Items.Add(new ReportingResultItem
                {
                    Minutes = 0,
                    WaitingReason = reason
                });
            }
        }
    }
    public class ReportingResultItem
    {
        public WaitingReason WaitingReason { get; set; }
        public int Minutes { get; set; }
    }
}