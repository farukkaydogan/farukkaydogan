using System;
using System.Threading;
using System.Collections.Generic;

namespace Not_defterim
{
    

    class Program
    {

        static void Main(string[] args)
        {

        }



        
        static void Dna()
        {
             static void Main(string[] args)
            {
                int[] baba = new int[4];
                int[] anne = new int[4];
                int[] cocuk = new int[4];
                int[] cocukcağız = new int[4];
                int[] istenilengen = new int[4];


                Console.WriteLine("istenilen geni giriniz 4 haneli olarak giriniz \n örnek ----> 1  0  1  1");
                for (int j = 0; j < istenilengen.Length; j++)
                {
                    istenilengen[j] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("  ");


                }
                for (int i = 0; ; i++)
                {

                    int[] babagen = babakromozom(baba);
                    int[] annegen = annekromozom(anne);
                    int[] cocukgen = cocukkromozom(anne, baba);
                    Console.WriteLine($"  {i}.iterasyon:  ");
                    int[] mutasyoncuk = mutasyon(cocukgen, cocukcağız);

                    Thread.Sleep(500);
                    Console.Write("\n");
                    Console.Write("                  sizin istediğini gen :    ");
                    for (int P = 0; P < istenilengen.Length; P++)
                    {
                        Console.Write(istenilengen[P]);

                    }
                    Console.WriteLine("\n");
                    Console.Write("anne gen  =   ");
                    for (int k = 0; k < baba.Length; k++)
                    {
                        Console.Write(anne[k]);

                    }
                    Console.WriteLine("\n");
                    Console.Write("baba gen  =  ");
                    for (int f = 0; f < baba.Length; f++)
                    {
                        Console.Write(baba[f]);
                    }
                    Console.WriteLine("\n");
                    Console.Write("Caprazlama =  ");
                    for (int t = 0; t < cocukgen.Length; t++)
                    {
                        Console.Write(cocukgen[t]);
                    }

                    Console.WriteLine("\n");

                    if (istenilengen[0] == cocukgen[0] && istenilengen[1] == cocukgen[1] && istenilengen[2] == cocukgen[2]
                       && istenilengen[3] == cocukgen[3])
                    {
                        Console.WriteLine("istenilen gen bulundu "); break;
                    }
                    else { Console.WriteLine("istenilen gen bulunamadı  "); }



                    Console.Write("Mutasyon --->  ");
                    for (int İ = 0; İ < mutasyoncuk.Length; İ++)
                    {
                        Console.Write(mutasyoncuk[İ]);
                    }

                    Console.WriteLine("\n");
                    if (istenilengen[0] == cocukgen[0] && istenilengen[1] == cocukgen[1] && istenilengen[2] == cocukgen[2]
                        && istenilengen[3] == cocukgen[3])
                    {
                        Console.WriteLine("istenilen gen bulundu "); break;
                    }
                    else { Console.WriteLine("istenilen gen bulunamadı  "); continue; }


                }


                static int[] babakromozom(int[] baba)
                {

                    Random rnd = new Random();
                    for (int i = 0; i < 4; i++)
                    {
                        baba[i] = rnd.Next(0, 2);

                    }

                    return baba;

                }



                static int[] annekromozom(int[] anne)
                {
                    Random rnd = new Random();
                    for (int i = 0; i < anne.Length; i++)
                    {
                        anne[i] = rnd.Next(0, 2);

                    }

                    return anne;
                }


                static int[] cocukkromozom(int[] annegen, int[] babagen)
                {
                    int[] yavrunungeni = new int[4];


                    Random rnd = new Random();
                    int rastgeleanne = 0;
                    int rastgelebaba = 0;



                    rastgeleanne = rnd.Next(0, 2);
                    rastgelebaba = rnd.Next(0, 2);
                    for (int i = 0; i < 2; i++)
                    {
                        yavrunungeni[i] = annegen[i + rastgeleanne + rastgeleanne];
                        yavrunungeni[i + 2] = babagen[i + rastgelebaba + rastgelebaba];

                    }


                    return yavrunungeni;
                }

                static int[] mutasyon(int[] cocukgelen, int[] mutasyonreis)
                {
                    Random rnd = new Random();

                    int rastgele = rnd.Next(0, 2);
                    for (int i = 0; i < cocukgelen.Length; i++)
                    {
                        mutasyonreis[i] = cocukgelen[i];
                    }

                    for (int i = 0; i < cocukgelen.Length - 2; i++)
                    {
                        if (mutasyonreis[i + rastgele + rastgele] == 1)
                        {
                            mutasyonreis[i + rastgele + rastgele] = 0;
                        }
                        else
                        { mutasyonreis[i + rastgele + rastgele] = 1; }
                    }

                    return mutasyonreis;




                }

            }
        }
        static void liste()
        {
            List<int> liste = new List<int>();
            liste.Add(5);
            liste.Add(10);
            liste.Add(8);
            liste.Add(10);
            Console.WriteLine("Liste elemanları");
            foreach (int eleman in liste)
                Console.Write(eleman + " ");
            Console.WriteLine();
            //listede bulunan -10- değeri silinecek.
            //tekrar yazarsak diğeri de silinir.
            Console.WriteLine("\n Listedeki ilk-10- değerini sildik");
            liste.Remove(10);
            foreach (int eleman in liste)
                Console.Write(eleman + " ");
            Console.WriteLine();
            Console.WriteLine("\n Listedeki 2. indeksteki değeri sildik.");
            //eğer listedeki belirli bir indeksteki değeri sileceksek RemoveAt() kullanılır
            liste.RemoveAt(2);
            foreach (int eleman in liste)
                Console.Write(eleman + " ");
            //listeye yeni eleman ekleme
            liste.Add(4);
            liste.Add(-2);
            liste.Add(6);
            liste.Add(3);
            liste.Add(9);
            liste.Add(6);
            Console.WriteLine();
            Console.WriteLine("\n listeye yeni elemanlar ekleyip ekrana yazdıralım");
            foreach (int eleman in liste)
                Console.Write(eleman + " ");
            //belirlenen indeksten başlayarak istenilen sayıda elemanı listeden silelim
            liste.RemoveRange(3, 2);
            Console.WriteLine();
            Console.WriteLine("\n3. indeksten itibaren iki elemanı sildik");
            foreach (int eleman in liste)
                Console.Write(eleman + " ");
            //liste elemanlarını ters çevirelim
            liste.Reverse();
            Console.WriteLine();
            Console.WriteLine("\n dizi elemanlarını ters çevirdik");
            foreach (int eleman in liste)
                Console.WriteLine(eleman + " ");
            liste.Sort();
            Console.WriteLine("dizi elemanlarını sıralayalım");
            List<object> yeniliste = new List<object>();
        }
        static void uc_boyutlu_dizi_ornek()
        {
            //3 farklı dersin not ortalaması hesaplanacak(3 boyutlu düzensiz)
            // 1- dersleri alan öğrenci sayıları sırayla 3,4,2 dir
            // 2- ayrıca her dersten  sırayla 2,1,2 sınav yapılacak

            int i, j, k;
            int[] ort = new int[3];
            int nottoplam = 0;
            int ogrort = 0;
            int[][,] dersortalama = new int[3][,];
            dersortalama[0] = new int[3, 2];
            dersortalama[1] = new int[4, 1];
            dersortalama[2] = new int[2, 2];

            for (i = 0; i < dersortalama.GetLength(0); i++)
            {
                for (j = 0; j < dersortalama[i].GetLength(0); j++)
                {
                    for (k = 0; k < dersortalama[i].GetLength(1); k++)
                    {
                        Console.Write("{0}. dersin {1}. öğrencisinin {2}. notu: ", i + 1, j + 1, k + 1);
                        dersortalama[i][j, k] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            for (i = 0; i < dersortalama.GetLength(0); i++)
            {
                for (j = 0; j < dersortalama[i].GetLength(0); j++)
                {
                    for (k = 0; k < dersortalama[i].GetLength(1); k++)
                    {
                        nottoplam += dersortalama[i][j, k];
                    }
                    ogrort += nottoplam / dersortalama[i].GetLength(1);
                    nottoplam = 0;
                }
                ort[i] = ogrort / dersortalama[i].GetLength(0);
                ogrort = 0;
            }
            for (i = 0; i < dersortalama.GetLength(0); i++)
            {
                Console.WriteLine("{0}.dersin ortalaması: {1}", i + 1, ort[i]);
            }


        }
        static void iki_matrisin_toplamı()
        {
            Random rnd = new Random();
            int[,] dizi1 = new int[3, 3];
            int[,] dizi2 = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dizi1[i, j] = rnd.Next(0, 10);
                    dizi2[i, j] = rnd.Next(0, 10);

                }

            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0,5}", dizi1[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("*************");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0,5}", dizi2[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("*************");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0,5}", dizi1[i, j] + dizi2[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void buyuk_kucuk_harf()
        {
            string metin;
            metin = Console.ReadLine().ToLower();
            for (int i = 0; i < metin.Length; i++)
            {
                Thread.Sleep(750);

                Console.Clear();
                for (int j = 0; j < metin.Length; j++)
                {
                    if (i == j)
                        Console.Write(metin[j].ToString().ToUpper());
                    else
                        Console.Write(metin[j].ToString());
                }
            }
        }
        static void primer()
        {
            {
                for (int i = 0; ; i++)
                {


                    int sayac = 0;
                    Console.Write("Sayıyı Girin : ");
                    int s = Convert.ToInt32(Console.ReadLine());

                    if (asalmi(s))

                    {
                        Console.WriteLine($"{s}  sayısı asal değildir");

                    }
                    else
                    { Console.WriteLine($"{s} sayısı asaldır"); }
                    int sayac2 = 0;

                    for (int j = 2; ; j++)
                    {
                        s++;
                        if (asalmi(s) == false)
                        {
                            sayac2++;
                            Console.WriteLine(s);
                        }
                        if (sayac2 == 5)
                            break;

                    }


                }
            }


            static bool asalmi(int asal)
            {
                bool asallık = false;
                int dogruluma = 0;
                int sayac = 0;




                for (int i = 2; i < asal; i++)
                {
                    if (asal % i == 0)
                    {


                        sayac++;

                    }
                    else
                    if (sayac == 0)
                        asallık = false;
                    else asallık = true;

                }


                return asallık;

            }
        }
        static void dizi_kesme()
        {
            Console.Write("bir cümle giriniz:");
            string dizi = Console.ReadLine();
            string[] kelimeler = dizi.Split(' ');
            Console.WriteLine(kelimeler.Length);
        }
        static void string_kelime_bul()
        {
            string kelime = " ";
            int sonuc = 0;
            Console.WriteLine("metni gir");
            string cumle = Console.ReadLine();
            Console.WriteLine(("kelimeyi gir"));
            string sozcuk = Console.ReadLine();
            for (int i = 0; i < cumle.Length; i++)
            {
                if (cumle[i] != ' ')
                { kelime += cumle[i]; }


                else
                {
                    if (kelime == sozcuk)
                        sonuc++;
                    kelime = "";
                }
            }
            if (kelime == sozcuk) { sonuc++; }
            Console.WriteLine("SONUC {0}", sonuc);
            Console.ReadKey();
        }
        static void authenticator()
        {
            string[] harf = { "a", "b", "c", "ç","d", "e", "f", "g", "ğ", "h","i","ı", "j", "k","l", "m", "n", "o", "ö", "p", "r","s", "ş", "t", "u", "ü", "v", "y", "z", "x","q"
                                      ,"A","B","C","Ç","D","E","F", "G","Ğ","H","I","İ","J","K","L","M","N","O","Ö","P","R","S","Ş","T","U","Ü","V","Y","Z","X","Q"};

            int[] sayı = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Random rnd = new Random();
            string şifre = "";
            int rastgele;
            int rastgeleharf;
            int rastgelesayı;
            for (int i = 0; i < 10; i++)
            {
                rastgele = rnd.Next(0, 2);
                rastgelesayı = rnd.Next(0, 10);
                rastgeleharf = rnd.Next(0, 63);
                şifre += (rastgele == 0 ? $"{harf[rastgeleharf]}" : $"{sayı[rastgelesayı]}");
            }

            Console.WriteLine(" doğrulama kodunuzu giriniz");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(şifre[i]);


            }
        }
        static void dizi_sayılarını_sıralama()
        {

            int[] dizi = { 5, 2, 1, 4, 6, 0, 7 };
            int gecici, j;
            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] < dizi[i - 1])
                {
                    gecici = dizi[i];
                    for (j = i; j > 0 && gecici < dizi[j - 1]; --j)
                        dizi[j] = dizi[j - 1];
                    dizi[j] = gecici;
                }
            }

            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }
        static void diziler_ornek()
        {
            Random r = new Random();
            Array dizi = Array.CreateInstance(typeof(int), 4, 3, 2);
            for (int i = 0; i <= dizi.GetUpperBound(0); i++)
                for (int j = 0; j <= dizi.GetUpperBound(1); j++)
                    for (int k = 0; k <= dizi.GetUpperBound(2); k++)
                        dizi.SetValue(i + j + k, i, j, k);


            for (int i = 0; i < dizi.GetUpperBound(0); i++)
                for (int j = 0; j < dizi.GetUpperBound(1); j++)
                    for (int k = 0; k < dizi.GetUpperBound(2); k++)
                        dizi.GetValue(i + j + k, i, j, k);
            Console.WriteLine("***********");

            Console.ReadLine();


            for (int i = 0; i < dizi.GetUpperBound(0); i++)
                for (int j = 0; j < dizi.GetUpperBound(1); j++)
                    for (int k = 0; k < dizi.GetUpperBound(2); k++)
                    {
                        dizi.SetValue(r.Next(10, 100), i, j, k);
                        Console.WriteLine("{ 0}{1}{ 2}: {3}", i, j, k,
                        dizi.GetValue(
                            i, j, k));
                    }

            Console.WriteLine("***********");

            Console.ReadLine();
        }
        static void degil_baglacı()
        {

            int sayi1, sayi2;
            string islem;
            Console.Write("BİRİNCİ SAYIyı gir:   ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("ikinci  SAYIyı gir :   ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nToplama ----> t ");
            Console.WriteLine("Çıkarma ----> c ");
            Console.WriteLine("çarpma----> m ");
            Console.WriteLine("bölme ----> b");
            Console.Write("işleminizi seçiniz:    ");
            islem = Console.ReadLine();

            if (islem == "b")
                if (sayi2 != 0)
                {
                    float sonuc = (float)sayi1 / (float)sayi2;
                    Console.WriteLine("SONUÇ : {0} ", sonuc);
                }

                else
                    Console.WriteLine("bölen sıfır olamaz");
            if (islem == "t")
                Console.WriteLine("sonuc = {0}", sayi1 + sayi2);
            if (islem == "c")
                Console.WriteLine("sonuc = {0}", sayi1 - sayi2);
            if (islem == "c")
                Console.WriteLine("sonuc = {0}", sayi1 * sayi2);
            // if (islem !="b" && islem != "t" && islem != "m" && islem != "c" && islem != "t" ) ve  baplacı ile 
            if (!(islem != "b" || islem == "t" || islem == "m" || islem == "c" || islem == "t")) Console.WriteLine("yanlış bir seçim yaptınız.");

            Console.ReadLine();

        }
        static void Main_şifreleme()
        {
            Console.WriteLine("harf gir");

            string kelimee = Console.ReadLine();
            char[] şifre = şifreleme(kelimee);
            char[] şifre_çöz = şifrele_coz(şifre);


            Console.WriteLine($"şifrelenmiş hali =  ");
            foreach (char item in şifre)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            Console.WriteLine("şifre çözülmüş hali = ");

            foreach (char item in şifre_çöz)
            {
                Console.Write(item);
            }
        }
        public static char[] şifreleme(string x)
        {
            char[] şifre = new char[x.Length];

            for (int i = 0; i < şifre.Length; i++)
            {


                şifre[i] = Convert.ToChar((int)x[i] + 1);


            }

            return şifre;
        }
        public static char[] şifrele_coz(char[] x)
        {
            char[] şifre_cöz = new char[x.Length];

            for (int i = 0; i < x.Length; i++)
            {


                şifre_cöz[i] = Convert.ToChar((int)x[i] - 1);

            }
            return şifre_cöz;
        }
        static void yıldız()
        {
            int value = 21;
            int[,] dizi = new int[value, value];


            for (int i = 0; i < value; i++)
            {
                for (int j = 0; j < value; j++)
                {
                    if (i == j)
                    {
                        dizi[i, j] = 1;
                        dizi[i, value - j - 1] = 1;




                    }
                    if (i == value / 2)
                        dizi[i, j] = 1;

                    if (j == value / 2)
                    {
                        dizi[i, j] = 1;
                    }
                }

            }

            for (int i = 0; i < value; i++)
            {
                for (int j = 0; j < value; j++)
                {
                    if (dizi[i, j] == 1)
                        Console.Write("*");

                    else { Console.Write(" "); }
                }
                Console.WriteLine();
            }
        }
        static void arrays()
        {
            string[] dizi = new string[5];

            Console.WriteLine("  5 adet birşey gir");
            dizi[0] = Console.ReadLine();
            dizi[1] = Console.ReadLine();
            dizi[2] = Console.ReadLine();
            dizi[3] = Console.ReadLine();
            dizi[4] = Console.ReadLine();


            Array.Sort(dizi);
            foreach (string gez in dizi)
            {
                Console.Write(gez + "  ");
            }
            string yazı = Console.ReadLine();
            int indeks = Array.BinarySearch(dizi, yazı);
            if (indeks < -1)

            { Console.WriteLine(" bulunamadı "); }
            else
            {
                Console.WriteLine($"{yazı,-6}bulduk reis {++indeks}. satırda  ");
            }

        }
        static void H_sıralama()
        {
            string[] dizi = { "AHMET", "ALİ ", "VELİ ", "ALİSEFA" };
            for (int i = 0; i < dizi.Length; i++)
                Console.Write(dizi[dizi.Length - i - 1] + "      ");
        }
        static void zar_oyunu()

        {
            Console.WriteLine("Doğayı Severlere hoşgeldiniz  ");
            Thread.Sleep(3000);

            int toplam1 = 0, toplam2 = 0;

            int[] dizi1 = new int[5];
            int[] dizi2 = new int[5];
            Random rnd = new Random();

            Console.WriteLine("1. oyuncu adını girin  :  ");

            Console.ForegroundColor = ConsoleColor.Red;


            string oyuncu1 = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("2. Oyuncu adı giriniz:  ");
            Console.ForegroundColor = ConsoleColor.Blue;


            string oyuncu2 = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine("EVET BAHİSLER BEYLER");

            Thread.Sleep(1500);
            int bir = rnd.Next(150000, 1000000);
            Console.WriteLine(oyuncu1 + "   " + bir + "  Döler ile masaya katılıyor");
            int iki = rnd.Next(150000, 1000000);
            Console.WriteLine(oyuncu2 + "    " + iki + "    Döler ile masaya katılıyor ");

            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Thread.Sleep(1500);
                Console.WriteLine("{0} oynuyor", oyuncu1);
                dizi1[i] = rnd.Next(1, 7);
                toplam1 += dizi1[1];

                Console.WriteLine("\n      " + dizi1[i] + " geldi");
                Console.ForegroundColor = ConsoleColor.Blue;

                Thread.Sleep(1500);
                Console.WriteLine("{0} oynuyor", oyuncu2);
                dizi2[i] = rnd.Next(1, 7);
                toplam2 += dizi2[i];

                Console.WriteLine("\n     " + dizi2[i] + " geldi");

            }
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(1500);

            Console.WriteLine("PUAN DURUMU \n {0}--->{1}\n {2}--->{3}", oyuncu1, toplam1, oyuncu2, toplam2);

            Thread.Sleep(1500);

            if (toplam1 < toplam2)
            {
                Console.WriteLine("Tebrikler {0} bari zardan düşseydin {1} abi ", oyuncu2, oyuncu2);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(oyuncu2 + (bir + iki) + "  Dolar Hasılat ile masadan ayrılıyor ");

            }
            else if (toplam1 > toplam2)
            {
                Console.WriteLine("Tebrikler {0} bari zardan düşseydin {1} abi", oyuncu1, oyuncu1); Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n" + oyuncu1 + (bir + iki) + "  Dolar Hasılat ile masadan ayrılıyor ");
            }


            else Console.WriteLine("Durum Berabere");
            Console.ReadLine();
        }
        static void H_dinamik_dizi()
        {
            int[][] dizi = new int[3][];
            dizi[0] = new int[] { 1, 2, 3 };
            dizi[1] = new int[] { 4, 5, 6, 7 };
            dizi[2] = new int[] { 8, 9 };
            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                for (int j = 0; j < dizi[i].GetLength(0); j++)
                {
                    Console.WriteLine("dizi[{0 }][{1}]={2}", i, j, dizi[i][j]);

                }

            }
            Console.Write("\n*********\n");
            Console.ReadLine();
            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                for (int j = 0; j < dizi[i].GetLength(0); j++)
                {
                    Console.WriteLine(dizi[i][j] + " ");
                    Console.WriteLine();
                }
            }
            Console.Write("\n*********\n");
            Console.ReadLine();
            foreach (int[] boyut in dizi)
            {


                foreach (var eleman in boyut)
                { Console.WriteLine("{0,3}", eleman); }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
        static void ishak_Home()
        {
            Console.WriteLine(" Kuran hlme is Hacking");
            Thread.Sleep(1000);
            Random rnd = new Random();
            for (int i = 0; i < 10000;
                i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                double zar = rnd.Next();
                double zar1 = rnd.Next();
                double zar2 = rnd.Next();
                Console.WriteLine(zar2);
                Console.Write(zar);
                Console.Write(" ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(zar1);
                Console.Write(" ");
                Console.Write(zar);
                Console.Write(" ");
                Console.Write(" ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(zar);
                Console.Write(" ");
                Console.Write(zar);
                Console.Write(" ");
                Console.Write(" ");
                Console.Write(zar2);
                Console.Write(zar2); Console.Write(" ");
                Console.Write(" ");
                Console.Write(zar);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(zar);
                Console.Write(" ");
                Console.Write(" ");
                Console.Write(zar);
                Console.Write(" ");
                Console.Write(zar2);
                Console.Write(" ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(zar1);
                Console.Write(zar1);
            }
            Console.WriteLine("HACKED BY FARUK"); Thread.Sleep(1500); Console.WriteLine(" home is hacked %100");
        }



    }

   

}


