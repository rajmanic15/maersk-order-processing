using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing
{
    public abstract class PhyscialMaster
    {
        public virtual PackageSlipDetails GeneratePackageSlip(Product prod)
        {
            PackageSlipDetails packageSlipDetails = new PackageSlipDetails();
            packageSlipDetails.PackageSlipName = "Packaging for " + prod.ProductName;
            packageSlipDetails.ProductDescription = prod.ProductType.ToString();
            return packageSlipDetails;
        }

        public CommissionPayment GenerateCommisionPayment(Product prod)
        {
            CommissionPayment commissionPayment = new CommissionPayment();
            commissionPayment.Amount = prod.TotalAmount * 10 / 100;
            commissionPayment.CommisionPaymentName = "Commission for " + prod.ProductName;
            commissionPayment.CommisionDescription = "ProductType:" + prod.ProductType.ToString();
            return commissionPayment;
        }
    }
}
