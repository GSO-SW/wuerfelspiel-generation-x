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
            int max = 6;
            int min = 1;

            //Act
            Wuerfel wuerfel = new Wuerfel;

            //Assert
            Assert.AreEqual(max, wuerfel.AnzahlSeiten);
            Assert.AreEqual(min, wuerfel.AnzahlSeiten);
            Assert.IsFalse(wuerfel.Gesichert);


        }
    }
}
