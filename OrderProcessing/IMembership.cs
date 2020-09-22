using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing
{
    public interface IMembership
    {
        public bool Activate(Product product);
        public Product Upgrade(Product product);

        public bool NotifyOwners(Product product);

    }
}
