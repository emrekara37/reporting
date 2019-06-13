using System;
using System.Collections.Generic;
using System.Linq;
using Reporting.Business.Models;

namespace Reporting.Business
{
    public interface IReportingService
    {
        List<ReportingResult> GetReportingResults();
    }
    public class ReportingService:IReportingService
    {
        public List<ReportingResult> GetReportingResults()
        {
            var reportingList = new List<ReportingResult>();
            var workOrders = Database.GetWorkOrders();
            var waitingList = Database.GetWaitingList();
            foreach (var workOrder in workOrders)
            {
                var workOrderWaitingList = waitingList.Where(p => p.StartDate <= workOrder.EndDate && p.StartDate >= workOrder.StartDate).ToList();
                var reporting = new ReportingResult { TotalMinutes = 0, WorkOrderNo = workOrder.No };
                reportingList.Add(reporting);
                foreach (var waiting in workOrderWaitingList)
                {
                    var item = reporting.Items.Find(p => p.WaitingReason == waiting.Reason);
                    var minutes = GetMinutes(waiting.StartDate, GetLastDate(workOrder.EndDate, waiting.EndDate));
                    item.Minutes += minutes;
                    reporting.TotalMinutes += minutes;
                }
            }
            return reportingList;
        }
        private static DateTime GetLastDate(DateTime firstDate, DateTime secondDate)
        {
            return firstDate <= secondDate ? firstDate : secondDate;
        }
        private static int GetMinutes(DateTime startDate, DateTime endDate)
        {
            var subtract = endDate.Subtract(startDate);
            return Convert.ToInt32(subtract.TotalMinutes);
        }
    }
}
