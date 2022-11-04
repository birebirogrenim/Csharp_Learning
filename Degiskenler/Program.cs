using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Değişkenler - Variables

            // Oluşturma 1)degiskenTipi 2) degiskenIsmi = deger;

            // int - Integer = Tam Sayılar

            //int sayi_1 = 10;
            ////Değişken
            //Console.WriteLine(sayi_1);
            //// Literal
            //Console.WriteLine(10);

            //Console.ReadKey();


            // String - Metinsel İfadeler 

            //Değişken
            //String metin_1 = "Merhaba_Değişken";
            //Console.WriteLine(metin_1);
            // Literal
            //Console.WriteLine("Merhaba_Literal");
            //Console.ReadKey();

            // Double-Float-Decimal  = Ondalıklı Sayılar ör= 19.90

            // 15.50 , 20.00 default = double
            // Float - Decimal = fF mM

            //double ondalikli_1 = 15.50;

            // Float = sayif - sayiF
            //float ondalikli_2 = 15.50f;

            //Decimal = sayim - sayiM
            //decimal ondalikli_3 = 15.50m;

            // Boolean = True / False -> Doğru veya Yanlış

            //Boolean yasiyormu = true;
            //Console.WriteLine("Yaşıyormu:"+yasiyormu);

            // Çıktı İçerisnde Matematiksel İşlemler
            //Console.WriteLine(ondalikli_1/sayi_1);
            //int sayi_2 = 20;
            //int toplam = sayi_1 + sayi_2;
            //Console.WriteLine("Toplam: {0}",toplam);

            // Char = Karakter
            // "Merhaba" -> 'M','e','r','a'
            //char m = 'M';
            //Console.WriteLine("Karakter: "+m);
            //Console.ReadKey();

            // Değişkenler VS Sabitler

            //// Değişken
            // int a = 0;
            // Console.WriteLine(a);
            // a = 10;
            // Console.WriteLine(a);
            // // Sabitler
            // const double pi = 3.14;
            // Console.WriteLine(pi);
            // //pi = 5.50;
            // Console.ReadKey();

            // Örtülü Değişken tanımı 

            //var isim = "eren";

            //var giris = Console.ReadLine();

            //Console.WriteLine(giris);
            //Console.ReadKey();

            // Tür Dönüşümleri - Convert Type

            // String to Integer
            //Console.Write("Bir Sayı Giriniz: ");
            //int strToint = int.Parse(Console.ReadLine());
            // Yontem 2 Convert.ToInt32(Console.ReadLine())
            //Console.WriteLine(strToint * 10);
            //Console.ReadKey();

            // Integer Double
            //int myInt = 15;
            //double myDouble = myInt; // Auto Convert
            //double myDouble2 = (double) myInt; // Manuel Convert



        }
    }
}
