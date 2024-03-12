using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugaspbo3
{
    internal class RekeningBank
    {
        public string Nama;
        public string Jenis;
    }
    class Bni : RekeningBank
    {
        public void setBni(string Nama, string Jenis)
        {
            this.Nama = Nama;
            this.Jenis = Jenis;
        }
        public (string, string) getBni()
        {
            return (Nama, Jenis);
        }
    }
    class Bri : RekeningBank
    {
        public void setBri(string Nama, string Jenis)
        {
            this.Nama = Nama;
            this.Jenis = Jenis;
        }
        public (string, string) getBri()
        {
            return (Nama, Jenis);
        }
    }
}
