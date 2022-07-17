using System.Collections.Generic;

namespace ABC.BL
{
    public class AdresRepository
    {
        /// <summary>
        /// Pobieramy jeden adres.
        /// </summary>
        /// <param name="adresId"></param>
        /// <returns></returns>
        public Adres Pobierz(int adresId)
        {
            // Tworzymy instancję klasy Adres i przekazujemy żądany identyfikator
            Adres adres = new Adres(adresId);

            // Kod, który pobiera zdefiniowany adres

            //Tymczasowo zakodowane wartości do zwrócenia adresu
            if (adresId == 1)
            {
                adres.AdresTyp = 1;
                adres.Ulica = "Gościnna";
                adres.Miasto = "Katowice";
                adres.Kraj = "Polska";
                adres.KodPocztowy = "40-467";
            }
            return adres;
        }

        /// <summary>
        /// Pobieramy wszystkie zdefiniowane adresy dla klienta
        /// </summary>
        /// <param name="klientId"></param>
        /// <returns></returns>
        public IEnumerable<Adres> PobierzPoKlientId(int klientId)
        {
            // Kod, który pobiera zdefiniowane adresy dla klienta

            // Tymczasowo zakodowane wartosci do zwrócenia, zestaw adresów dla klienta
            var adresList = new List<Adres>();

            Adres adres = new Adres(1)
            {
                AdresTyp = 1,
                Ulica = "Goscina",
                Miasto = "Katowice",
                KodPocztowy = "40-476",
                Kraj = "Polska"
            };
            adresList.Add(adres);

            adres = new Adres(2)
            {
                AdresTyp = 2,
                Ulica = "Kosmiczna",
                Miasto = "Kraków",
                KodPocztowy = "22-321",
                Kraj = "Polska"
            };
            adresList.Add(adres);

            return adresList;
        }

        /// <summary>
        /// Zapisuje aktualny adres.
        /// </summary>
        /// <returns></returns>
        public bool Zapisz(Adres adres)
        {
            // Kod, który zapisuje zdefiniowany adres.

            return true;
        }
    }
}
