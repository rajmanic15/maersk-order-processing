using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing
{
    public class PackageSlipDetails
    {
        public int PackageSlipId { get; set; }
        public string PackageSlipName { get; set; }
        public string PackageSlipDescription { get; set; }

        public string ProductDescription { get; set; }
        public bool IsDuplicateSlipGenerated { get; set; }
        public string DuplicateSlipDetails { get; set; }
    }
}
