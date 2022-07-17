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

        [TestMethod]
        public void ImieNazwiskoImiePuste()
        {
            // Arrange (zaran¿uj test)
            Klient klient = new Klient();
            klient.Nazwisko = "Nowak";
            string oczekiwana = "Nowak";

            //ACT (dzia³aj)
            string aktualna = klient.ImieNazwisko;

            // Assert (potwierdz test)
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void ImieNazwiskoNazwiskoPuste()
        {
            // Arrange (zaran¿uj test)
            Klient klient = new Klient();
            klient.Imie = "Tomasz";
            string oczekiwana = "Tomasz";

            //ACT (dzia³aj)
            string aktualna = klient.ImieNazwisko;

            // Assert (potwierdz test)
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void StaticTest()
        {
            // Arrange (zaran¿uj test)
            Klient klient1 = new Klient();
            klient1.Imie = "Tomasz";
            Klient.Licznik += 1;

            Klient klient2 = new Klient();
            klient2.Imie = "Jacek";
            Klient.Licznik += 1;

            Klient klient3 = new Klient();
            klient3.Imie = "Marek";
            Klient.Licznik += 1;

            //Assert
            Assert.AreEqual(3, Klient.Licznik);
        }

        [TestMethod]
        public void ZwaljdujTest()
        {
            // Arrange (zaran¿uj test)
            var klient = new Klient();
            klient.Nazwisko = "Nowak";
            klient.Email = "tomek@dev-hobby.pl";
            var oczekiwana = true;

            //ACT (dzia³aj)
            var aktualna = klient.Zwaliduj();

            // Assert (potwierdz test)
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void ZwaljdujBrakNazwisa()
        {
            // Arrange (zaran¿uj test)
            var klient = new Klient();
            klient.Email = "tomek@dev-hobby.pl";
            var oczekiwana = false;

            //ACT (dzia³aj)
            var aktualna = klient.Zwaliduj();

            // Assert (potwierdz test)
            Assert.AreEqual(oczekiwana, aktualna);
        }
    }
}
