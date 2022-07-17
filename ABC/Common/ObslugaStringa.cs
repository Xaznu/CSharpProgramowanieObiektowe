using System;

namespace Common
{
    public class ObslugaStringa
    {
        public string WstawSpacje(string zrodlo)
        {
            string wynik = string.Empty;

            if (!String.IsNullOrWhiteSpace(zrodlo))
            {
                foreach (var litera in zrodlo)
                {
                    if (char.IsUpper(litera))
                    {
                        //przycinamy wszystkie spacje, które już tam są, a potem dodamy naszą spację.
                        wynik = wynik.Trim();
                        wynik += " ";
                    }
                    wynik += litera;
                }
                wynik = wynik.Trim();
            }

            return wynik;
        }
    }
}
