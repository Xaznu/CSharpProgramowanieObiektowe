using System.Collections.Generic;
using System.Linq;

namespace ABC.BL
{
    public class KlientRepository
    {
        private AdresRepository adresRepository { get; set; }

        public KlientRepository()
        {
            adresRepository = new AdresRepository();
        }

        /// <summary>
        /// Pobieramy jednego klienta.
        /// </summary>
        public Klient Pobierz(int klientId)
        {
            // Tworzymy instancję klasy Klienta
            Klient klient = new Klient(klientId);
            klient.ListaAdresow = adresRepository.PobierzPoKlientId(klientId).ToList();

            // kod, który pobiera określonego klienta

            // Tymczasowo zakodowane wartości, aby zwrocic klienta
            if (klientId == 1)
            {
                klient.Email = "marcin@dev-hobby.pl";
                klient.Imie = "Marcin";
                klient.Nazwisko = "Nowak";
            }

            return klient;
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
        public bool Zapisz(Klient klient)
        {
            // Kod, który zapisuje zdefiniowanego klienta
            return true;
        }
    }
}
