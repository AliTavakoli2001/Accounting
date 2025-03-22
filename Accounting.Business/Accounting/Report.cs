using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer;
using Accounting.DataLayer.UnitOfWork;
using Accounting.ViewModel.Accounting;

namespace Accounting.Business.Accounting
{
    public static class Report
    {
        public static ReportForm Create()
        {
            ReportForm report = new ReportForm();

            using (UnitOfWork DB = new UnitOfWork())
            {
                DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
                DateTime endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59, 999);

                var pay = DB.accountingRepository.Get(transaction => transaction.DateTime >= startDate
                && transaction.DateTime <= endDate && transaction.Type == 1).
                Select(transaction => transaction.Amount).ToList();

                var recive = DB.accountingRepository.Get(transaction => transaction.DateTime >= startDate
                && transaction.DateTime <= endDate && transaction.Type == 2).
                Select(transaction => transaction.Amount).ToList();

                report.recive = recive.Sum();
                report.pay = pay.Sum();
                report.balance = report.recive - report.pay;
            }
            return report;
        }
    }
}
