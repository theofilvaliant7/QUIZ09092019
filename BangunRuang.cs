using System;

namespace QUIZ09092019
{
    class BangunRuang
    {
        public static int volume_balok(int tinggi, int lebar, int panjang)
        {
            return tinggi * lebar * panjang;
        }


        

        public void volume_kubus(int angka1)
        {
            Console.WriteLine("Nilai volume kubus adalah:"+angka1 * angka1 * angka1);
        }
    }
}