using System;

namespace QUIZ09092019
{
    class Program
    {
        static void Main(string[] args)
        {
             BangunDatar obj = new BangunDatar();

             int s;

             Console.WriteLine("------------------------");
             Console.WriteLine("Menghitung luas persegi:");
             Console.WriteLine("------------------------");

             Console.Write("masukkan nilai sisi:");
             s = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Nilai luas persegi adalah:" +BangunDatar.Luas_Persegi(s));

             int a, t;

             Console.WriteLine("------------------------");
             Console.WriteLine("menghitung luas segitiga");
             Console.WriteLine("------------------------");

             Console.WriteLine("masukkan alas :");
             a = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("masukkan tinggi:");
             t = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Nilai luas segitiga adalah:"+BangunDatar.Luas_Segitiga(a,t));

            
            int rusuk; 

            Console.WriteLine("masukkan nilai rusuk: ");
            rusuk = Convert.ToInt32(Console.ReadLine());

            

            
           obj.Luas_Lingkaran(rusuk);
        
    

        
            BangunRuang objt = new BangunRuang();

            int tinggi, lebar, panjang;

            Console.WriteLine("Masukkan nilai tinggi: ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan nilai lebar: ");
            lebar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan nilai panjang: ");
            panjang = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nilai volume balok adalah: "+BangunRuang.volume_balok(tinggi, lebar, panjang));

            int sisi;

            Console.WriteLine("masukkan nilai rusuk: ");
            sisi = Convert.ToInt32(Console.ReadLine());

            BangunRuang.volume_balok(tinggi,lebar,panjang);
        }
    }
}

