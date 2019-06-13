using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Reporting.Business.Models
{
    public static class Database
    {
       

        private static List<WorkOrder> WorkOrders { get; } = new List<WorkOrder>();
        private static List<Waiting> WaitingList { get; } = new List<Waiting>();
        public static List<WorkOrder> GetWorkOrders()
        {
            if (WorkOrders.Any() == false)
            {
                AddWorkOrderTempData();
            }
            return WorkOrders;
        }
        public static List<Waiting> GetWaitingList()
        {
            if (WaitingList.Any() == false)
            {
                AddWaitingTempData();
            }
            return WaitingList;
        }
        private static DateTime ParseDateTime(string date)
        {
            return DateTime.Parse(date, new CultureInfo("tr"));
        }



        #region hazır iş emirlerinin eklenmesi

        private static void AddWorkOrderTempData()
        {

            WorkOrders.Add(new WorkOrder { No = "1001", StartDate = ParseDateTime("1.01.2017 08:00:00"), EndDate = ParseDateTime("1.01.2017 16:00:00") });
            WorkOrders.Add(new WorkOrder { No = "1002", StartDate = ParseDateTime("1.01.2017 16:00:00"), EndDate = ParseDateTime("2.01.2017 00:00:00") });
            WorkOrders.Add(new WorkOrder { No = "1003", StartDate = ParseDateTime("2.01.2017 00:00:00"), EndDate = ParseDateTime("2.01.2017 08:00:00") });
            WorkOrders.Add(new WorkOrder { No = "1004", StartDate = ParseDateTime("2.01.2017 08:00:00"), EndDate = ParseDateTime("2.01.2017 16:00:00") });
            WorkOrders.Add(new WorkOrder { No = "1005", StartDate = ParseDateTime("2.01.2017 16:00:00"), EndDate = ParseDateTime("3.01.2017 00:00:00") });
            WorkOrders.Add(new WorkOrder { No = "1006", StartDate = ParseDateTime("3.01.2017 00:00:00"), EndDate = ParseDateTime("3.01.2017 08:00:00") });
            WorkOrders.Add(new WorkOrder { No = "1007", StartDate = ParseDateTime("3.01.2017 08:00:00"), EndDate = ParseDateTime("3.01.2017 16:00:00") });
            WorkOrders.Add(new WorkOrder { No = "1008", StartDate = ParseDateTime("3.01.2017 16:00:00"), EndDate = ParseDateTime("4.01.2017 00:00:00") });
            WorkOrders.Add(new WorkOrder { No = "1009", StartDate = ParseDateTime("4.01.2017 00:00:00"), EndDate = ParseDateTime("4.01.2017 08:00:00") });
        }
        #endregion

        #region hazır duruş listelerinin eklenmesi
        private static void AddWaitingTempData()
        {

            WaitingList.Add(new Waiting { Reason = WaitingReason.Break, StartDate = ParseDateTime("1.01.2017 10:00:00"), EndDate = ParseDateTime("1.01.2017 10:10:00") });
            WaitingList.Add(new Waiting { Reason = WaitingReason.Fault, StartDate = ParseDateTime("1.01.2017 10:30:00"), EndDate = ParseDateTime("1.01.2017 11:00:00") });
            WaitingList.Add(new Waiting { Reason = WaitingReason.Break, StartDate = ParseDateTime("1.01.2017 12:00:00"), EndDate = ParseDateTime("1.01.2017 12:30:00") });
            WaitingList.Add(new Waiting { Reason = WaitingReason.Break, StartDate = ParseDateTime("1.01.2017 14:00:00"), EndDate = ParseDateTime("1.01.2017 14:10:00") });
            WaitingList.Add(new Waiting { Reason = WaitingReason.Setup, StartDate = ParseDateTime("1.01.2017 15:00:00"), EndDate = ParseDateTime("1.01.2017 16:30:00") });
            WaitingList.Add(new Waiting { Reason = WaitingReason.Break, StartDate = ParseDateTime("1.01.2017 18:00:00"), EndDate = ParseDateTime("1.01.2017 18:10:00") });
            WaitingList.Add(new Waiting { Reason = WaitingReason.Break, StartDate = ParseDateTime("1.01.2017 20:00:00"), EndDate = ParseDateTime("1.01.2017 20:30:00") });
            WaitingList.Add(new Waiting { Reason = WaitingReason.Break, StartDate = ParseDateTime("1.01.2017 22:00:00"), EndDate = ParseDateTime("1.01.2017 22:10:00") });
            WaitingList.Add(new Waiting { Reason = WaitingReason.Rad, StartDate = ParseDateTime("1.01.2017 23:00:00"), EndDate = ParseDateTime("2.01.2017 08:30:00") });
            WaitingList.Add(new Waiting { Reason = WaitingReason.Break, StartDate = ParseDateTime("2.01.2017 10:00:00"), EndDate = ParseDateTime("2.01.2017 10:10:00") });
            WaitingList.Add(new Waiting { Reason = WaitingReason.Break, StartDate = ParseDateTime("2.01.2017 12:00:00"), EndDate = ParseDateTime("2.01.2017 12:30:00") });
            WaitingList.Add(new Waiting { Reason = WaitingReason.Fault, StartDate = ParseDateTime("2.01.2017 13:00:00"), EndDate = ParseDateTime("2.01.2017 13:45:00") });
            WaitingList.Add(new Waiting { Reason = WaitingReason.Break, StartDate = ParseDateTime("2.01.2017 14:00:00"), EndDate = ParseDateTime("2.01.2017 14:10:00") });
            WaitingList.Add(new Waiting { Reason = WaitingReason.Break, StartDate = ParseDateTime("2.01.2017 18:00:00"), EndDate = ParseDateTime("2.01.2017 18:10:00") });
            WaitingList.Add(new Waiting { Reason = WaitingReason.Rad, StartDate = ParseDateTime("2.01.2017 20:00:00"), EndDate = ParseDateTime("3.01.2017 02:10:00") });
            WaitingList.Add(new Waiting { Reason = WaitingReason.Break, StartDate = ParseDateTime("3.01.2017 04:00:00"), EndDate = ParseDateTime("3.01.2017 04:30:00") });
            WaitingList.Add(new Waiting { Reason = WaitingReason.Setup, StartDate = ParseDateTime("3.01.2017 06:00:00"), EndDate = ParseDateTime("3.01.2017 09:30:00") });
            WaitingList.Add(new Waiting { Reason = WaitingReason.Break, StartDate = ParseDateTime("3.01.2017 10:00:00"), EndDate = ParseDateTime("3.01.2017 10:10:00") });
            WaitingList.Add(new Waiting { Reason = WaitingReason.Break, StartDate = ParseDateTime("3.01.2017 12:00:00"), EndDate = ParseDateTime("3.01.2017 12:30:00") });
            WaitingList.Add(new Waiting { Reason = WaitingReason.Break, StartDate = ParseDateTime("3.01.2017 14:00:00"), EndDate = ParseDateTime("3.01.2017 14:10:00") });
            WaitingList.Add(new Waiting { Reason = WaitingReason.Fault, StartDate = ParseDateTime("3.01.2017 15:00:00"), EndDate = ParseDateTime("3.01.2017 18:45:00") });
            WaitingList.Add(new Waiting { Reason = WaitingReason.Break, StartDate = ParseDateTime("3.01.2017 20:00:00"), EndDate = ParseDateTime("3.01.2017 20:30:00") });
            WaitingList.Add(new Waiting { Reason = WaitingReason.Break, StartDate = ParseDateTime("3.01.2017 22:00:00"), EndDate = ParseDateTime("3.01.2017 22:10:00") });
        }


        #endregion
     

    }
}