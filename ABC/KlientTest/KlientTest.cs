using System;
using ABC.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ABC.BLTest
{
    [TestClass]
    public class KlientTest
    {
        [TestMethod]
        public void ImieNazwiskoTest()
        {
            // Arrange (zaran¿uj test)
            Klient klient = new Klient();
            klient.Imie = "Tomasz";
            klient.Nazwisko = "Nowak";
            string oczekiwana = "Tomasz, Nowak";

            //ACT (dzia³aj)
            string aktualna = klient.ImieNazwisko;

            // Assert (potwierdz test)
            Assert.AreEqual(oczekiwana, aktualna);
        }
    }
}
