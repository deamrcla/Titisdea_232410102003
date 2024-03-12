// See https://aka.ms/new-console-template for more information
using tugaspbo3;

//Console.WriteLine("Hello, World!");

namespace tugas2
{
    class Akses
    {
        static void Main(string[]args)
        {
            //akses object
            MobilSedan mobilsedan = new MobilSedan();
            Fishiy fishiy = new Fishiy();
            Bni bni = new Bni();
            Bri bri = new Bri();
            Raja raja = new Raja();
            Menteri menteri = new Menteri();
            Benteng benteng = new Benteng();
            Kuda kuda = new Kuda();
            Bidak bidak = new Bidak();
            Gajah gajah = new Gajah();



            //set Value
            mobilsedan.setMobilSedan("toyota", 15, "putih");
            fishiy.setFishiy("cupang", 25, "betina");
            bni.setBni("budi", "taplus muda");
            bri.setBri("sari", "gold");
            raja.setRaja("king", 1);
            menteri.setMenteri("queen", 1);
            benteng.setBenteng("rook", 2);
            kuda.setKuda("knight", 2);
            bidak.setBidak("pawn", 8);
            gajah.setGajah("bishop", 2);

            //get value dan pemisahnya

            //tentang showroom
            //mobil sedan
            (string, int, string) valuesmobilsedan = mobilsedan.getMobilSedan();
            string satumobilsedan = valuesmobilsedan.Item1;
            int duamobilsedan = valuesmobilsedan.Item2;
            string tigamobilsedan = valuesmobilsedan.Item3;

            //tentang ikan
            //fishiy
            (string,int, string) valuesfishiy = fishiy.getFishiy();
            string satufishiy = valuesfishiy.Item1;
            int duafishiy = valuesfishiy.Item2;
            string tigafishiy = valuesfishiy.Item3;


            //tentang rekening bank
            //bni
            (string, string) valuesbni = bni.getBni();
            string satubni = valuesbni.Item1;
            string duabni = valuesbni.Item2;

            //bri 
            (string,string) valuesbri = bri.getBri();
            string satubri = valuesbri.Item1;
            string duabri = valuesbri.Item2;

            //tentang pion catur
            //raja
            (string, int) valuesraja = raja.getRaja();
            string saturaja = valuesraja.Item1;
            int duaraja = valuesraja.Item2;

            //menteri
            (string, int) valuesmenteri = menteri.getMenteri();
            string satumenteri = valuesmenteri.Item1;
            int duamenteri = valuesmenteri.Item2;

            //benteng
            (string, int) valuesbenteng = benteng.getBenteng();
            string satubenteng = valuesbenteng.Item1;
            int duabenteng = valuesmenteri.Item2;

            //kuda
            (string, int) valueskuda = kuda.getKuda();
            string satukuda = valueskuda.Item1;
            int duakuda = valueskuda .Item2;

            //bidak
            (string, int) valuesbidak = bidak.getBidak();
            string satubidak = valuesbidak.Item1;
            int duabidak = valuesbidak.Item2;

            //gajah
            (string, int) valuesgajah = gajah.getGajah();
            string satugajah = valuesgajah.Item1;
            int duagajah = valuesgajah .Item2;

            //menampilkan ke konsol
            Console.WriteLine($"Showroom" +
                $"\nMobil Sedan" +
                $"\nTipe : {satumobilsedan}" +
                $"\nStock : {duamobilsedan}" +
                $"\nWarna : {tigamobilsedan}" +
                $"\n\nIkan" +
                $"\nFishiy" +
                $"\nJenis : {satufishiy}" +
                $"\nJumlah : {duafishiy}" +
                $"\nGender : {tigafishiy}" +
                $"\n\nPion Catur" +
                $"\n\nRaja" +
                $"\nIstilah : {saturaja}" +
                $"\nJumlah : {duaraja}" +
                $"\n\nMenteri" +
                $"\nIstilah : {satumenteri}" +
                $"\nJumlah : {duamenteri}" +
                $"\n\nBenteng" +
                $"\nIstilah : {satubenteng}" +
                $"\nJumlah :{duabenteng}" +
                $"\n\nKuda" +
                $"\nIstilah : {satukuda}" +
                $"\nJumlah : {duakuda}" +
                $"\n\nBidak" +
                $"\nIstilah : {satubidak}" +
                $"\nJumlah : {duabidak}" +
                $"\n\nGajah" +
                $"\nIstilah : {satugajah}" +
                $"\nJumlah : {duagajah}");
                

        }



            

    }
}