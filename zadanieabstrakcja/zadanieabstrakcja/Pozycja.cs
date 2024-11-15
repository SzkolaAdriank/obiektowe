using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanieabstrakcja
{
    abstract class Pozycja
    {
        protected string tytul;
        protected int id;
        protected string wydawnictwo;
        protected int rokWydania;

        public string Tytul
        {
            get { return tytul; }
            set { tytul = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Wydawnictwo
        {
            get { return wydawnictwo; }
            set { wydawnictwo = value; }
        }

        public int RokWydania
        {
            get { return rokWydania; }
            set { rokWydania = value; }
        }

        public Pozycja()
        {

        }
        public Pozycja(string tytul, int id, string wydawnictwo, int rokWydania)
        {
            this.Tytul = tytul;
            this.Id = id;
            this.Wydawnictwo = wydawnictwo;
            this.RokWydania = rokWydania;
        }

        public abstract void WypiszInfo();

    }
}
