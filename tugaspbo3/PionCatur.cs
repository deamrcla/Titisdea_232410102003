using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugaspbo3
{
    internal class PionCatur
    {
        public string Istilah;
        public int Jumlah;
    }
    class Raja : PionCatur
    {
        public void setRaja(string Istilah, int Jumlah)
        {
            this.Istilah = Istilah;
            this.Jumlah = Jumlah;
        }
        public (string, int) getRaja()
        {
            return (Istilah, Jumlah);
        }
    }
    class Menteri : PionCatur
    {
        public void setMenteri(string Istilah, int Jumlah)
        {
            this.Istilah = Istilah;
            this.Jumlah = Jumlah;
        }
        public (string, int) getMenteri()
        {
            return (Istilah, Jumlah);
        }
    }
    class Kuda : PionCatur
    {
        public void setKuda(string Istilah, int Jumlah)
        {
            this.Istilah = Istilah;
            this.Jumlah = Jumlah;
        }
        public (string, int) getKuda()
        {
            return (Istilah, Jumlah);
        }
    }
    class Benteng : PionCatur
    {
        public void setBenteng(string Istilah, int Jumlah)
        {
            this.Istilah = Istilah;
            this.Jumlah = Jumlah;
        }
        public (string, int) getBenteng()
        {
            return (Istilah, Jumlah);
        }

    }
    class Bidak : PionCatur
    {
        public void setBidak(string Istilah, int Jumlah)
        {
            this.Istilah = Istilah;
            this.Jumlah = Jumlah;
        }
        public (string, int) getBidak()
        {
            return (Istilah, Jumlah);
        }

    }
    class Gajah : PionCatur
    {
        public void setGajah(string Istilah, int Jumlah)
        {
            this.Istilah = Istilah;
            this.Jumlah = Jumlah;
        }
        public (string, int) getGajah()
        {
            return (Istilah, Jumlah);
        }
    }
}