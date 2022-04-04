using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {
        [TestMethod]
        public void Wuerfel_grossklein()
        {
            //Arrange
            int maxSeiten = 6;
            int minSeiten = 1;

            //Act
            Wuerfel wuerfel = new Wuerfel;

            //Assert
            Assert.AreEqual(maxSeiten, wuerfel.AnzahlSeiten);
            Assert.AreEqual(minSeiten, wuerfel.AnzahlSeiten);
            


        }
    }
}
