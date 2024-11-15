using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanieabstrakcja
{
    internal class Bibliotekarz : Osoba
    {
        private string dataZatrudnienia;
        private double wynagrodzenie;

        public string DataZatrudnienia
        {
            get { return dataZatrudnienia; }
            set { dataZatrudnienia = value; }
        }

        public double Wynagrodzenie
        {
            get { return wynagrodzenie; }
            set { wynagrodzenie = value; }
        }

        public Bibliotekarz()
        {

        }

        public Bibliotekarz(string imie_, string nazwisko_, string dataZatrudnienia_, double wynagrodzenie_) : base(imie_, nazwisko_)
        {
            this.DataZatrudnienia = dataZatrudnienia_;
            this.Wynagrodzenie = wynagrodzenie_;
        }
    }
}
