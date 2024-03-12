using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugaspbo3
{
    internal class Showroom
    {
        public string Tipe;
        public int Stock;
        public string Warna;
    }
    class MobilSedan : Showroom
    {
        public void setMobilSedan(string Tipe,int Stock,string Warna)
        {
            this.Tipe = Tipe;
            this.Stock = Stock;
            this.Warna = Warna;
        }
        public (string,int,string) getMobilSedan()
        {
            return (Tipe,Stock,Warna);
        }
    }
}
