using System;
using System.Collections.Generic;
using Box;
using Domain.Confections;
using Domain.Confections.Characteristics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utils.Builders.Confection;
using Utils.Builders.GiftBox;

namespace Testing
{
    [TestClass]
    public class GiftFunctionsTesting
    {
        [TestMethod]
        public void CountWeightTest()
        {
            Gift testGift = new StandardGiftBuilder(new List<ConfectionBase>()).Build();
            double expectedWeight = 610;
            Assert.AreEqual(expectedWeight, testGift.CountWeight());
        }
    }
}
