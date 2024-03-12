using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugaspbo3
{
    internal class Ikan
    {
        public string Jenis;
        public int Jumlah;
        public string Gender;
    }
    class Fishiy : Ikan
    {
        public void setFishiy(string Jenis, int Jumlah, string Gender)
        {
            this.Jenis = Jenis;
            this.Jumlah = Jumlah;
            this.Gender = Gender;
        }
        public (string, int, string) getFishiy()
        {
            return (Jenis, Jumlah, Gender);
        }
    }
}
