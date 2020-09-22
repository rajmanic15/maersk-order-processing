using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing
{
    public class OrderProcesser
    {
        public int OrderNo { get; set; }
        public Product Item { get; set; }
       // public ProductPaymentType PaymentType { get; set; }


        //Initialize
        //D

        public PhyscialMaster InitializePhyscial(Product prod)
        {
            PhyscialMaster physcialMaster=null;
            if (prod.ProductType ==ProductPaymentType.Physical)
            {
                PhyscialProduct physcialProduct = new PhyscialProduct();
                physcialMaster=physcialProduct;
            }
            else if(prod.ProductType == ProductPaymentType.Book)
             {
                BookProduct bookProduct = new BookProduct();
                physcialMaster=bookProduct;
            }

            return physcialMaster;
        }

        public MembershipMaster InitiliazeMembership(Product prod)
        {
            MembershipMaster memberShipMaster = null;
            if(prod.ProductType==ProductPaymentType.BasicMemberShip)
            {
                memberShipMaster = new BasicMembership();
            }
            else if(prod.ProductType==ProductPaymentType.PremierMemberShip)
            {
                memberShipMaster = new PremierMemberShip();
            }
            return memberShipMaster;
        }



        //public bool DoPayments(Product prod)
        //{
        //    bool isSuccess = false;
        //    //Do Payment
        //    isSuccess = true;
        //    return isSuccess;

        //}

        public bool DoActionsPhyscial(Product prod, PhyscialMaster physcialMaster)
        {
            bool isSuccess = false;

            //DoActions

            if (prod.ProductType == ProductPaymentType.Physical)
            {
                PhyscialProduct physcialProduct =new  PhyscialProduct();
                PackageSlipDetails packageSlipDetails =physcialMaster.GeneratePackageSlip(prod);
                CommissionPayment commissionPayment = physcialMaster.GenerateCommisionPayment(prod);
              
            }
            else if (prod.ProductType == ProductPaymentType.Book)
            {
                BookProduct bookProduct = new BookProduct();
                PackageSlipDetails packageSlipDetails = bookProduct.GeneratePackageSlip(prod);
                CommissionPayment commissionPayment = bookProduct.GenerateCommisionPayment(prod);
            }

            isSuccess = true;
            return isSuccess;
        }

        public bool DoActionsMembership(Product prod, MembershipMaster membershiplMaster)
        {
            bool isSuccess = false;

            //DoActions

            if (prod.ProductType == ProductPaymentType.BasicMemberShip)
            {
                BasicMembership basicMembership = new BasicMembership();
                bool IsActivated = basicMembership.Activate(prod);
                //bool commissionPayment = basicMembership.IsActivated(prod);

            }
            else if (prod.ProductType == ProductPaymentType.Book)
            {
                PremierMemberShip premierMemberShip = new PremierMemberShip();
                Product product = premierMemberShip.Upgrade(prod);
                bool isNotified = premierMemberShip.NotifyOwners(prod);
            }


            isSuccess = true;
            return isSuccess;
        }

    }
}
