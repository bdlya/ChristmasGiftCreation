using System.Collections.Generic;
using Box;
using Domain.Confections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utils.Builders.GiftBox;

namespace Testing
{
    [TestClass]
    public class GiftFunctionsTesting
    {
        [TestMethod]
        public void CountWeightTest()
        {
            Gift testGift = new StandardGiftBuilder().Build();
            double expectedWeight = 610;
            Assert.AreEqual(expectedWeight, testGift.CountWeight());
        }
    }
}
