using System;

namespace OrderProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ORder Processing starts!");

            //Create OrderProcessing

            //Do the Payment

            //Do the actions

            OrderProcesser orderProcesser = new OrderProcesser();


            Product prod = new Product();
            prod.ProductType = ProductPaymentType.Physical;
            prod.ProductName = "PhysicalItem";
            //PhyscialProduct physcialProductExpected = new PhyscialProduct();


            PhyscialMaster physcialMaster = orderProcesser.InitializePhyscial(prod);

            bool doActionsResult = orderProcesser.DoActionsPhyscial(prod, physcialMaster);


            prod.ProductType = ProductPaymentType.Book;
            prod.ProductName = "BookItem";
            //PhyscialProduct physcialProductExpected = new PhyscialProduct();


            PhyscialMaster bookProduct = orderProcesser.InitializePhyscial(prod);

            doActionsResult = orderProcesser.DoActionsPhyscial(prod, bookProduct);


            prod.ProductType = ProductPaymentType.BasicMemberShip;
            prod.ProductName = "BasicMembershipItem";
            //PhyscialProduct physcialProductExpected = new PhyscialProduct();


            MembershipMaster membershipMaster = orderProcesser.InitiliazeMembership(prod);

            doActionsResult = orderProcesser.DoActionsMembership(prod, membershipMaster);

            prod.ProductType = ProductPaymentType.PremierMemberShip;
            prod.ProductName = "PremierMembershipItem";
            //PhyscialProduct physcialProductExpected = new PhyscialProduct();


            membershipMaster = orderProcesser.InitiliazeMembership(prod);

            doActionsResult = orderProcesser.DoActionsMembership(prod, membershipMaster);

            Console.ReadLine();
            Console.WriteLine("Order Processing ends! Press any key to end.");
        }
    }
}
