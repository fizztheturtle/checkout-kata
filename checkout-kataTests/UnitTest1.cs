using System.Collections.Generic;
using checkout_kata;
using NUnit.Framework;

namespace checkout_kataTests
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void scan_IsTotal50WithOneApple_True()
        {

            Basket.Scan(Stock.Apple);
            Assert.AreEqual(50, Basket.Total());
           
        }

        [Test]
        public void scan_IsTotal100WithTwoApples_True()
        {
            Basket.Scan(Stock.Apple);
            Basket.Scan(Stock.Apple);
            Assert.AreEqual(100, Basket.Total());
            
        }

        [Test]
        public void scan_IsTotal80WithOneAppleOneBanana_true()
        {
            Basket.Scan(Stock.Apple);
            Basket.Scan(Stock.Banana);
            Assert.AreEqual(80, Basket.Total());
        }


        [Test]
        public void scan_IsTotal269WithOneOfEachStockAndTwoBananas_true()
        {
            Basket.Scan(Stock.Apple);
            Basket.Scan(Stock.Banana);
            Basket.Scan(Stock.Banana);
            Basket.Scan(Stock.Crackers);
            Basket.Scan(Stock.TidePod);
            Assert.AreEqual(254, Basket.Total());
            
        }
        [Test]
        public void scan_IsTotal130WithThreeApples()
        {
            Basket.Scan(Stock.Apple);
            Basket.Scan(Stock.Apple);
            Basket.Scan(Stock.Apple);
            Assert.AreEqual(130,Basket.Total());
        }
        [Test]
        public void scan_IsTotal175WithThreeApplesAndTwoBananas()
        {
            Basket.Scan(Stock.Apple);
            Basket.Scan(Stock.Apple);
            Basket.Scan(Stock.Apple);
            Basket.Scan(Stock.Banana);
            Basket.Scan(Stock.Banana);
            Assert.AreEqual(175, Basket.Total());
        }
    }
}