using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing
{
    public interface IProduct
    {
        public PackageSlipDetails GeneratePackageSlip(Product prod);
        public PackageSlipDetails GenerateDuplicatePackageSlip(Product prod);
       // public void AddFirstAidToVideo();

        public CommissionPayment GenerateCommisionPayment(Product product);
            
    }
}
