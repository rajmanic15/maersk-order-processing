using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing
{
    public class CommissionPayment
    {
        public int CommisionPaymentId { get; set; }
        public string CommisionPaymentName { get; set; }
        public decimal Amount { get; set; }
        public string CommisionDescription { get; set; }
    }
}
