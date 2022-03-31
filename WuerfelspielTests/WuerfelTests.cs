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
            int max = 6;
            int min = 1;

            if (max > 6)
            {
                Console.WriteLine("es ist kein w6 wuerfel");
            }
            if (min < 1)
            {
                Console.WriteLine("Der Wuerfel kann nicht kleiner als 1 sein");
            }
        }
    }
}
