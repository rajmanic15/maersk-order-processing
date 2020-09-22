using NUnit.Framework;
using OrderProcessing;

namespace NUnitTestOrderProcessing
{
    public class Tests
    {
        private OrderProcesser _orderProcessorTests;
        [SetUp]
        public void Setup()
        {
            _orderProcessorTests = new OrderProcesser();
        }

        [Test]
        public void CallOrderProcessor_InitliazePhyscialReturn_ValidPhyscialMAster()
        {
          //  Assert.Pass();
            Product prod = new Product();
            prod.ProductType = ProductPaymentType.Physical;
            prod.ProductName = "PhysicalItem";
            //PhyscialProduct physcialProductExpected = new PhyscialProduct();
           

             PhyscialMaster physcialMaster=  _orderProcessorTests.InitializePhyscial(prod);
            Assert.IsNotNull(physcialMaster);

        }
        [Test]
        public void CallOrderProcessor_InitliazeBookReturn_ValidBookMAster()
        {
            //  Assert.Pass();
            Product prod = new Product();
            prod.ProductType = ProductPaymentType.Book;
            prod.ProductName = "BookItem";
            //PhyscialProduct physcialProductExpected = new PhyscialProduct();


            PhyscialMaster physcialMaster = _orderProcessorTests.InitializePhyscial(prod);
            Assert.IsNotNull(physcialMaster);

        }

        [Test]
        public void CallOrderProcessor_DoActions_PhyicalReturns_ValidObject()
        {
            Product prod = new Product();
            prod.ProductType = ProductPaymentType.Physical;
            prod.ProductName = "PhysicalItem";
            //PhyscialProduct physcialProductExpected = new PhyscialProduct();


            PhyscialMaster physcialMaster = _orderProcessorTests.InitializePhyscial(prod);

            bool doActionsResult=_orderProcessorTests.DoActionsPhyscial(prod, physcialMaster);

            Assert.IsNotNull(physcialMaster);
            Assert.IsTrue(doActionsResult);
        }

        [Test]
        public void CallOrderProcessor_InitliazeBasicMembershipReturn_ValidMemberShipMaster()
        {
            //  Assert.Pass();
            Product prod = new Product();
            prod.ProductType = ProductPaymentType.BasicMemberShip;
            prod.ProductName = "BasicMemberShip";
            //PhyscialProduct physcialProductExpected = new PhyscialProduct();


            MembershipMaster membershipMaster = _orderProcessorTests.InitiliazeMembership(prod);
            Assert.IsNotNull(membershipMaster);

        }
        [Test]
        public void CallOrderProcessor_InitliazePremierMemberShipReturn_ValidMembershipMaster()
        {
            //  Assert.Pass();
            Product prod = new Product();
            prod.ProductType = ProductPaymentType.PremierMemberShip;
            prod.ProductName = "PremierMemberShip";
            //PhyscialProduct physcialProductExpected = new PhyscialProduct();


            MembershipMaster membershipMaster = _orderProcessorTests.InitiliazeMembership(prod);
            Assert.IsNotNull(membershipMaster);

        }

        [Test]
        public void CallOrderProcessor_DoActions_BasicMemberShiReturns_ValidObject()
        {
            Product prod = new Product();
            prod.ProductType = ProductPaymentType.BasicMemberShip;
            prod.ProductName = "BasicMemberShip";
            //PhyscialProduct physcialProductExpected = new PhyscialProduct();


            MembershipMaster membershipMaster = _orderProcessorTests.InitiliazeMembership(prod);

            bool doActionsResult = _orderProcessorTests.DoActionsMembership(prod, membershipMaster);

            Assert.IsNotNull(membershipMaster);
            Assert.IsTrue(doActionsResult);
        }

        [Test]
        public void CallOrderProcessor_DoActions_PremierMemberShipReturns_ValidObject()
        {
            Product prod = new Product();
            prod.ProductType = ProductPaymentType.PremierMemberShip;
            prod.ProductName = "PremierMemberShip";
            //PhyscialProduct physcialProductExpected = new PhyscialProduct();


            MembershipMaster membershipMaster = _orderProcessorTests.InitiliazeMembership(prod);

            bool doActionsResult = _orderProcessorTests.DoActionsMembership(prod, membershipMaster);

            Assert.IsNotNull(membershipMaster);
            Assert.IsTrue(doActionsResult);
        }
    }
}