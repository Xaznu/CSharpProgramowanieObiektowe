using System;
using System.Collections.Generic;

namespace ABC.BL
{
    public class Zamowienie
    {
        public Zamowienie()
        {
        }

        public Zamowienie(int zamowienieId)
        {
            ZamowienieId = zamowienieId;
        }

        public int ZamowienieId { get; private set; }
        public DateTimeOffset? DataZamowienia { get; set; }

        public List<PozycjaZamowienia> pozycjeZamowienia { get; set; }

        public int KlientId { get; set; }

        public int AdresDostawyId { get; set; }


        /// <summary>
        /// Pobieramy jedno zamowienie
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public Zamowienie Pobierz(int zamowienieId)
        {
            // Kod, który pobiera zdefiniowane zamowienie
            return new Zamowienie();
        }

        /// <summary>
        /// Zapisujemy biezace zamowienie
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // Kod, który zapisuje zdefiniowane zamowienie
            return true;
        }

        /// <summary>
        /// Sprawdzamy dane zamowienia
        /// </summary>
        /// <returns></returns>
        public bool Zwaliduj()
        {
            var poprawne = true;

            if (DataZamowienia == null)
                poprawne = false;

            return poprawne;
        }
    }
}
