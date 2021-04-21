using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervariHotel
{
    [Serializable]
    public class RezervareOnline
    {

        private string checkIn;
        private string checkOut;
        public string numeClient;
        public string nrCamera;
        private bool plata;

        public RezervareOnline(string CheckIn,string CheckOut, string NumeClient,string NrCamera,bool Plata)
        {
            checkIn=CheckIn;
            checkOut=CheckOut;
            numeClient = NumeClient;
            nrCamera = NrCamera;
            plata = Plata;
        }

        public bool Plata
        {
            get { return plata; }
            set { plata = value; }
        }
        public string CheckIn
        {
            get{ return checkIn; }
            set { checkIn = value; }            
        }

        public string CheckOut
        {
            get { return checkOut; }
            set {checkOut = value; }
        }

        public override string ToString()
        {
            return numeClient + "\t" + nrCamera + "\t" + checkIn + "\t" + checkOut+"\t"+plata;
        }

    }
}
