using System;
using System.Collections.Generic;
using System.Linq;

namespace Patika.dev_Csharp101_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini
            //isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini
            //isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar
            //console'a yazdırın.
            int n;

            while (true)
            {
                Console.Write("Pozitif bir sayı giriniz: ");
                n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("Lütfen pozitif bir sayi giriniz.");
                }
                else
                {
                    break;
                }

            }

            List<int> cift = new();

            for (int i = 0; i < n; i++)
            {
                while (true)
                {
                    Console.Write((i + 1) + ".Pozitif sayıyı giriniz: ");
                    int sayi = int.Parse(Console.ReadLine());
                    if (sayi < 0)
                    {
                        Console.WriteLine("Lütfen pozitif bir sayı giriniz.");
                    }
                    else if (sayi > 0 && sayi2 % 2 == 0)
                    {
                        cift.Add(sayi2);
                    }
                    if (sayi > 0)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("Girilen sayılardan çift olanlar: ");
            foreach (var item in cift)
            {
                Console.WriteLine(item);
            }


            //2.Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini
            //isteyin(n, m).Sonrasında kullanıcıdan n adet pozitif sayı girmesini
            //isteyin.Kullanıcının girmiş olduğu sayılardan
            //m'e eşit yada tam bölünenleri console'a yazdırın.
            int n;
            int m;
            while (true)
            {
                Console.Write("Birinci pozitif sayıyı giriniz: ");
                n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("Lütfen pozitif bir sayi giriniz.");
                }
                else
                {
                    break;
                }

            }

            while (true)
            {
                Console.Write("İkinci pozitif sayıyı giriniz: ");
                m = int.Parse(Console.ReadLine());
                if (m < 0)
                {
                    Console.WriteLine("Lütfen pozitif bir sayi giriniz.");
                }
                else
                {
                    break;
                }

            }

            List<int> kosul = new();

            for (int i = 0; i < n; i++)
            {
                while (true)
                {
                    Console.Write((i + 1) + ".Pozitif sayıyı giriniz: ");
                    int sayi = int.Parse(Console.ReadLine());
                    if (sayi < 0)
                    {
                        Console.WriteLine("Lütfen pozitif bir sayı giriniz.");
                        continue;
                    }

                    if (sayi > 0 && sayi == m || sayi % m == 0)
                    {
                        kosul.Add(sayi);
                        break;
                    }
                    if (sayi > 0)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(m + " sayısına eşit veya tam bölünen sayılar: ");
            foreach (var item in kosul)
            {
                Console.WriteLine(item);
            }


            //3.Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini
            //isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
            //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru
            //console'a yazdırın.

            int n;

            while (true)
            {
                Console.Write("Pozitif bir sayı giriniz: ");
                n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("Lütfen pozitif bir sayi giriniz.");
                }
                else
                {
                    break;
                }

            }

            string[] kelimeler = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write((i + 1) + ".kelimeyi giriniz: ");
                string kelime = Console.ReadLine();
                kelimeler[i] += kelime;
            }

            for (int i = n; i > 0; i--)
            {
                Console.WriteLine(kelimeler[i - 1]);
            }


            //4.Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
            //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.Write("Cümle yazınız: ");
            string cumle = Console.ReadLine();
            List<string> harfbulma = new();
            string[] metin = cumle.Split(" ");
            int kelimeSayisi = metin.Count();
            Console.WriteLine("Kelime sayısı : " + kelimeSayisi);

            string alfabe =  "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ"+"abcçdefgğhiıjklmnoöprsştuüvyz";
            int sayac = 0;
            for (int i = 0; i < cumle.Length; i++)
            {
                if (alfabe.Contains(cumle[i]))
                {
                    sayac++;
                }
            }
            Console.WriteLine("Harf sayısı: {0} ", sayac);


           

        }
    }
}

