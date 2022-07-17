namespace ABC.BL
{
    public class PozycjaZamowienia
    {
        public PozycjaZamowienia()
        {
        }

        public PozycjaZamowienia(int pozycjaZamowieniaId)
        {
            PozycjaZamowieniaId = pozycjaZamowieniaId;
        }

        public int PozycjaZamowieniaId { get; private set; }
        public int Ilosc { get; set; }
        public int ProduktId { get; set; }
        public decimal? CenaZakupu { get; set; }

        /// <summary>
        /// Pobieramy jedną pozycje zamowienia
        /// </summary>
        /// <param name="pozycjaZamowienieId"></param>
        /// <returns></returns>
        public PozycjaZamowienia Pobierz(int pozycjaZamowienieId)
        {
            // Kod, który pobiera zdefiniowany element zamowienia
            return new PozycjaZamowienia();
        }

        /// <summary>
        /// Zapisujemy biezacy element zamowienia
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // Kod, który zapisuje zdefiniowany element zamowienia
            return true;
        }

        /// <summary>
        /// Sprawdzamy dane pozycji zamowienia
        /// </summary>
        /// <returns></returns>
        public bool Zwaliduj()
        {
            var poprawne = true;

            if (Ilosc <= 0)
                poprawne = false;
            if (ProduktId <= 0)
                poprawne = false;
            if (CenaZakupu == null)
                poprawne = false;

            return poprawne;
        }
    }
}
