using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanieabstrakcja
{
    interface IZarzadzaniePozycjami
    {
        Pozycja ZnajdzPozycjePoTytule(string tytul);
        Pozycja ZnajdzPozycjePoId(int id);
        void WypiszWszystkiePozycje();
    }
}
