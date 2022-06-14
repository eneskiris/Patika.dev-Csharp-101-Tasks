using System;
using System.Collections.Generic;
using System.Linq;

namespace Patika.dev_Csharp101_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)
            //Negatif ve numeric olmayan girişleri engelleyin.
            //Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            //Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

            int sayi;
            bool num;
            string giris;
            ArrayList asal = new ArrayList();
            ArrayList asalOlmayan = new ArrayList();

            for (int i = 0; i < 20; i++)
            {
                while (true)
                {
                    Console.Write("Pozitif bir sayı giriniz: ");
                    giris = Console.ReadLine();

                    num = int.TryParse(giris, out sayi);
                    if (num == false || sayi < 0)
                    {
                        Console.WriteLine("Lütfen pozitif sayı giriniz.");
                        continue;
                    }
                    bool asalmi = AsalMi(sayi);
                    if (sayi == 1 || sayi == 0)
                    {
                        asalOlmayan.Add(sayi);
                        break;
                    }
                    if (asalmi)
                    {
                        asal.Add(sayi);
                        break;
                    }
                    else
                    {
                        asalOlmayan.Add(sayi);
                        break;
                    }
                }

            }

            Console.WriteLine("***** Asal sayıların büyükten küçüğe sıralanmış hali. *****");

            asal.Sort();
            asal.Reverse();
            foreach (var item in asal)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***** Asal sayıların eleman sayıları ve ortalaması. *****");
            Console.WriteLine("Eleman sayısı: " + asal.Count);

            float toplam = 0;
            foreach (var item in asal)
            {
                toplam += (int)item;
            }
            Console.WriteLine("Ortalaması: " + (toplam / asal.Count));

            Console.WriteLine("***** Asal olmayan sayıların büyükten küçüğe sıralanmış hali. *****");

            asalOlmayan.Sort();
            asalOlmayan.Reverse();
            foreach (var item in asalOlmayan)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***** Asal olmayan sayıların eleman sayıları ve ortalaması. *****");
            Console.WriteLine("Eleman sayısı: " + asalOlmayan.Count);

            float toplam2 = 0;
            foreach (var item in asalOlmayan)
            {
                toplam2 += (int)item;
            }
            Console.WriteLine("Ortalaması: " + (toplam2 / asalOlmayan.Count));
            static bool AsalMi(int sayi)
            {
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }



          //6.Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
            int sayi;
            bool num;
            string giris;
            ArrayList sayilar = new ArrayList();
            ArrayList enBuyuk = new ArrayList();
            ArrayList enKucuk = new ArrayList();

            for (int i = 0; i < 5; i++)
            {
                while (true)
                {
                    Console.Write("Pozitif bir sayı giriniz: ");
                    giris = Console.ReadLine();

                    num = int.TryParse(giris, out sayi);
                    if (num == false || sayi < 0)
                    {
                        Console.WriteLine("Lütfen pozitif sayı giriniz.");
                        continue;
                    }
                    else
                    {
                        sayilar.Add(sayi);
                        break;
                    }

                }

            }

            sayilar.Sort();
            enKucuk.Add(sayilar[0]);
            enKucuk.Add(sayilar[1]);
            enKucuk.Add(sayilar[2]);
            sayilar.Reverse();
            enBuyuk.Add(sayilar[0]);
            enBuyuk.Add(sayilar[1]);
            enBuyuk.Add(sayilar[2]);



            Console.WriteLine("***** En Küçük 3 Sayının Ortalaması.");
            int kucukToplam = 0;
            foreach (var item in enKucuk)
            {
                kucukToplam += (int)item;
            }
            float kucukOrtalama = ((float)kucukToplam / (float)enKucuk.Count);
            Console.WriteLine("Ortalama : " + (float)kucukOrtalama);

            Console.WriteLine("***** En Büyük 3 Sayının Ortalaması.");
            int buyukToplam = 0;
            foreach (var item in enBuyuk)
            {
                buyukToplam += (int)item;
            }
            float buyukOrtalama = ((float)buyukToplam / (float)enBuyuk.Count);
            Console.WriteLine("Ortalama : " + (float)buyukOrtalama);

            Console.WriteLine("***** En Küçük 3 Sayının Ortalaması ve En Büyük 3 Sayının Ortalamasının Toplamı");
            Console.WriteLine((float)buyukOrtalama + (float)kucukOrtalama);            


            //7.Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

            Console.Write("Cümle yazınız: ");
            string cumle = Console.ReadLine();
            string sesliHarfler = "aeıioöuü";
            //string sesliHarfler = new string {"a","e","ı","i","o","ö","u","ü"};
            ArrayList eslesenHarfler = new ArrayList();
            for (int i = 0; i < cumle.Length; i++)
            {
                for (int j = 0; j < sesliHarfler.Length; j++)
                {
                    if (cumle[i] == sesliHarfler[j])
                    {
                        eslesenHarfler.Add(cumle[i]);
                    }

                }
            }

            ArrayList eslesenHarfler2 = new ArrayList();
            foreach (var item in eslesenHarfler)
            {
                if (eslesenHarfler2.Contains(item))
                {
                    continue;
                }
                eslesenHarfler2.Add(item);
            }

            foreach (var item in eslesenHarfler2)
            {
                Console.Write(item + " ");
            }        
        }
    }

}


