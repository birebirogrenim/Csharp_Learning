using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aritmetik Operatörler

            // +,-,*,/,%
            //int a = 10;
            //int b = 20;
            //Console.WriteLine(a+b);
            //Console.WriteLine(b-a);
            //Console.WriteLine(a*b);
            //Console.WriteLine(b/a);
            //Console.WriteLine(b%a);
            //Console.ReadKey();

            // Arttırma Ve Azaltma Operatörleri

            // A++,A--,++B,--B // 1 arttır veya azalt
            //int A = 5;
            //int B = 10;
            //Console.WriteLine(A++);
            //Console.WriteLine(A);
            //Console.WriteLine(--B);
            //Console.WriteLine(B);
            //Console.ReadKey();

            //Atama Operatörleri (=,+=,-=,*=)
            //int x = 10;
            //x += 5; // x = x+5
            //Console.WriteLine(x);
            //x -= 2; // x = x-2
            //x *= 3;
            //Console.WriteLine(x);
            //Console.ReadKey();

            // Karşılaştırma Opearatörleri (==,<,>,<=,>=,!=)

            //int a = 5;
            //int b = 10;
            //int x = 5;

            //Boolean esitmi = a == b; // a b'ye eşit mi?
            //Boolean kucuk_buyuk = a < b;
            //Boolean buyuk_kucuk = a > b;
            //Boolean kucuk_esitmi = a <= x;
            //Boolean buyuk_esitmi = b >= x;
            //Boolean degil = a != b;
            //Boolean degil_2 = a != x;
            //Console.WriteLine(esitmi);
            //Console.WriteLine(kucuk_buyuk);
            //Console.WriteLine(buyuk_kucuk);
            //Console.WriteLine(kucuk_esitmi);
            //Console.WriteLine(buyuk_esitmi);
            //Console.WriteLine(degil);
            //Console.WriteLine(degil_2);


            //Console.ReadKey();

            // Mantıksal Operatörler
            // (VE/AND && , VEYA/OR || , ! DEĞİL)

            //int a = 10;
            //int b = 20;
            //Boolean ve = (a<b) && (b < a); // her iki koşulda true veriyorsa true değeri olur
            //Boolean veya = (a < b) || (b < a); // iki koşuldan birisinin true olması yeterli
            //Boolean degil = !(a<b) || !(b < a); 
            //Console.WriteLine(ve);
            //Console.WriteLine(veya);
            //Console.WriteLine(degil);
            //Console.ReadKey();

            // Diğer Operatörler

            // ()Casting Opearatörü
            //char a_char = 'a';
            //int a_int = (int) a_char; //  97
            //Console.WriteLine(a_int);
            //Console.ReadKey();


            // typeof() Operatörü
            //Console.WriteLine(typeof(int));
            //Console.ReadKey();

            // int = System.Int32



            // ?: [true:false] ? [işlem1] : [işlem2] 
            //String mesaj = (10 > 5) ? "Eren" : "Mehmet";
            //Console.WriteLine(mesaj);
            //Console.ReadKey();



            // Null Opearatörü ?? (yeniMesaj = mesaj ?? "Merhaba") 

            //String mesaj_2 = "merhaba"; // Değeri Yok
            //String yeniMesaj = mesaj_2 ?? "Yeni Mesaj";
            //Console.WriteLine(yeniMesaj);
            //Console.ReadKey();

            // Index(İndis) Operatörü []
            String metin = "Eren";
            //              0123
            Console.WriteLine(metin[3]);
            Console.ReadKey();
        }
    }
}
