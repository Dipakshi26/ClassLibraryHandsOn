using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EbillClass;

namespace EbillPrroject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EBill eBill = new EBill();
            eBill.EnterDetails();
           
            Customers customer = new Customers();
            customer.ShowDetails(11);

            customer.ShowEBill(11);

            customer.ShowEbBillReport();


        }
    }
}
