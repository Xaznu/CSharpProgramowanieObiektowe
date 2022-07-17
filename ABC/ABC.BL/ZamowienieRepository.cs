using System;

namespace ABC.BL
{
    public class ZamowienieRepository
    {
        /// <summary>
        /// Pobieramy jedno zamowienie
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public Zamowienie Pobierz(int zamowienieId)
        {
            // Tworzymy instancję klasy zamowenia i przekazujemy identyfikator
            Zamowienie zamowienie = new Zamowienie(zamowienieId);

            // Kod, który pobiera zdefiniowane zamowienie

            // Tymczasowe zakodowane wartosci zamowienia do zwrocenia
            if (zamowienieId == 10)
                zamowienie.DataZamowienia = new DateTimeOffset(2018, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));

            return zamowienie;
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
    }
}
