using System;

namespace ABC.BL
{
    public class Zemowienie
    {
        public Zemowienie()
        {
        }

        public Zemowienie(int zamowienieId)
        {
            ZamowienieId = zamowienieId;
        }

        public int ZamowienieId { get; private set; }
        public DateTimeOffset? DataZamowienia { get; set; }

        /// <summary>
        /// Pobieramy jedno zamowienie
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public Zemowienie Pobierz(int zamowienieId)
        {
            // Kod, który pobiera zdefiniowane zamowienie
            return new Zemowienie();
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
