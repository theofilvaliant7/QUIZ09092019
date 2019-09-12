using System;

namespace QUIZ09092019
{
    class BangunDatar
    {
        public static int Luas_Persegi(int angka1)
        {
            return angka1 * angka1;
        }

        public static int Luas_Segitiga(int tinggi, int alas)
        {
            return tinggi * alas / 2; 
        }

        public void Luas_Lingkaran(int rusuk)
        {
            Console.WriteLine("Luas lingkaran adalah: " +22/7  * rusuk * rusuk);
        }
    }
}