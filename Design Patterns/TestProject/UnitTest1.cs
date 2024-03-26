using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem4;
using Problem1;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// This method will start the auction and bidding will occur which according to implementation can be done upto maximum of 5 times,
        /// Thus the 5th highest bidder should be the price at which the item was sold.
        /// </summary>
        [TestMethod]
        public void Problem4_SoldAtPrice_Check()
        {
            //Arrange
            Auctioneer auctioneer = new Auctioneer();
            HigherBidder john = new HigherBidder("John");
            HigherBidder yash = new HigherBidder("Yash");
            LowBidder jems = new LowBidder("Jems");
            LowBidder smith = new LowBidder("Smith");
            Item kohinoor = new Item()
            {
                Name = "Kohinoor diamond",
                InitialPrice = 45.00,
                YearOfCreation = 1822
            };

            //Act
            auctioneer.RegisterBidder(john);
            auctioneer.RegisterBidder(yash);
            auctioneer.RegisterBidder(jems);
            auctioneer.RegisterBidder(smith);
            auctioneer.StartAuction(kohinoor);

            auctioneer.Bid(50.00, jems);
            auctioneer.Bid(99.00, smith);
            auctioneer.Bid(120.00, john);
            auctioneer.Bid(150.00, yash);
            auctioneer.Bid(190.00, john);

            //Assert
            Assert.AreEqual(kohinoor.SoldPrice, 190.00);
        }

        /// <summary>
        /// This method will test that the lowbidder if tires to bid more than MAXIMUM_AMOUNT, thas is 100.00, it will not be counted for the bid
        /// </summary>
        [TestMethod]
        public void TestingMaximumLimitConstraint()
        {

            //Arrange
            Auctioneer auctioneer = new Auctioneer();
            HigherBidder jake = new HigherBidder("Jake");
            LowBidder jems = new LowBidder("Jems");
            Item kohinoor = new Item()
            {
                Name = "Kohinoor diamond",
                InitialPrice = 45.00,
                YearOfCreation = 1822
            };

            //Act
            auctioneer.RegisterBidder(jake);
            auctioneer.RegisterBidder(jems);

            auctioneer.Bid(50.00, jems);
            auctioneer.Bid(99.00, jake);
            auctioneer.Bid(120.00, jems);

            //Assert
            Assert.AreNotEqual(auctioneer.getHighestBid(), 120.00);

        }
        
        /// <summary>
        /// Testing Problem 1 - Factor pattern - getting expected typed class name using Factory Creator.
        /// </summary>
        [TestMethod]
        public void TestingProblem1_DancingCactus()
        {

            //Arrange
            ToyCreater toyCreater = new ToyCreater();
            string expectedResult = "DancingCactus";

            //Act
            IToy dancingCactus = toyCreater.GetToy("DancingCactus");
            string result = dancingCactus.GetType().Name;

            //Assert
            Assert.AreEqual(result, expectedResult, "Checking problem1 works for Class Type (using DancingCactus)");
        }

        /// <summary>
        /// Testing Problem 1 - Factor pattern - Checking property of specific type class created by FactoryCreator
        /// </summary>
        [TestMethod]
        public void TestingProblem1_Car()
        {

            //Arrange
            ToyCreater toyCreater = new ToyCreater();
            bool expectedResult = true;

            //Act
            IToy car = toyCreater.GetToy("Car");
            bool result = car.ChokingHazard;

            //Assert
            Assert.AreEqual(result, expectedResult, "Checking problem1 works for Properties (using Car)");
        }

    }

}
