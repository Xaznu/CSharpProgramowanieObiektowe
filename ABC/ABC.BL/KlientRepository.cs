using System.Collections.Generic;

namespace ABC.BL
{
    public class KlientRepository
    {
        /// <summary>
        /// Pobieramy jednego klienta.
        /// </summary>
        public Klient Pobierz(int klientId)
        {
            // Tworzymy instancję klasy Klienta
            Klient klient = new Klient(klientId);

            // kod, który pobiera określonego klienta

            // Tymczasowo zakodowane wartości, aby zwrocic klienta
            if (klientId == 1)
            {
                klient.Email = "marcin#dev-hobby.pl";
                klient.Imie = "Marcin";
                klient.Nazwisko = "Nowak";
            }

            return new Klient();
        }

        /// <summary>
        /// Pobieramy wszystkich klientów.
        /// </summary>
        public List<Klient> Pobierz()
        {
            // Kod, który pobiera wszystkich klientów
            return new List<Klient>();
        }

        /// <summary>
        /// Zapisujemy obecnego klienta
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // Kod, który zapisuje zdefiniowanego klienta
            return true;
        }
    }
}
