using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervariHotel
{
    [Serializable]
    public class ColectieRezervari : ICloneable
    {
        private List<RezervareOnline> rezervari;

        public ColectieRezervari()
        {
            rezervari = new List<RezervareOnline>();
        }

        public ColectieRezervari(List<RezervareOnline> Rezervari)
        {
            rezervari = Rezervari;
        }

        public List<RezervareOnline> Rezervari
        {
            get { return rezervari; }
            set { if (value != null) rezervari = value; }
        }

        public object Clone()
        {
            ColectieRezervari colectie = (ColectieRezervari)this.MemberwiseClone();
            List<RezervareOnline> lista = new List<RezervareOnline>();
            foreach (RezervareOnline r in rezervari)
                lista.Add(r);
            colectie.rezervari = lista;
            return colectie;
        }

        public override string ToString()
        {
            string result="";
            foreach(RezervareOnline r in rezervari)
            {
                result += r.ToString() + Environment.NewLine;
            }
            return result;
        }

        public RezervareOnline this[int index]
        {
            get
            {
                if (index < rezervari.Count() && index >= 0 && rezervari != null)
                {
                    return rezervari[index];
                }
                else
                    return null;
            }
        }

        public static ColectieRezervari operator+(ColectieRezervari c, RezervareOnline r)
        {
            c.rezervari.Add(r);
            return c;
        }
    }
}
