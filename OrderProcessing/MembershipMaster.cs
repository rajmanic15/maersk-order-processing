using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing
{
    public abstract class MembershipMaster
    {

        public bool Activate(Product product)
        {
            Console.WriteLine("Your order for  : " + product.ProductType + " has been" + "Notified");
            return true;
        }
        public virtual Product Upgrade(Product product)
        {
            Console.WriteLine("Your order for  : " + product.ProductType + " has been" + "Upgraded");
            return product;
        }

        public bool NotifyOwners(Product product)
        {
            Console.WriteLine("Your order for  : " + product.ProductType + " has been" + "Notified");
            return true;
        }
    }
}
