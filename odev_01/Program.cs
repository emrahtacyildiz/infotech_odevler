////Ödev 01 - Problem 1  -----------------------------------------------------------
//int tekToplam = 0;
//int ciftToplam = 0;
//for (int i = 0; i < 10; i++)
//{
//    Console.Write("Lütfen {0}. sayıyı giriniz: ", i + 1);
//    int sayi = int.Parse(Console.ReadLine());
//    if (sayi % 2 == 1) tekToplam += sayi;
//    else ciftToplam += sayi;
//}
//Console.WriteLine("Girdiğiniz tek sayıların toplamı: {0}", tekToplam);
//Console.WriteLine("Girdiğiniz çift sayıların toplamı: {0}", ciftToplam);

////--------------------------------------------------------------------------------

////Ödev 01 - Problem 2  -----------------------------------------------------------
//int[] sayilar = new int[10];
//for (int i = 0; i < 10; i++)
//{
//    Console.Write("Lütfen {0}. sayıyı giriniz: ", i + 1);
//    int sayi = int.Parse(Console.ReadLine());
//    sayilar[i] = sayi;
//}
//Array.Sort(sayilar);
//Console.WriteLine("Girdiğiniz en büyük sayı: {0}\nGirdiğiniz en küçük sayı: {1}\nGirdiğiniz en büyük ve en küçük sayıların farkı: {2}", sayilar[0], sayilar[9], sayilar[9] - sayilar[0]);

////--------------------------------------------------------------------------------

////Ödev 01 - Problem 3  -----------------------------------------------------------
//int toplam = 0;
//Console.Write("Lütfen 5 basamaklı bir sayıyı giriniz: ");
//int sayi = int.Parse(Console.ReadLine());
//while (sayi > 0)
//{
//    toplam += sayi % 10;
//    sayi /= 10;
//}
//Console.Write("Girdiğiniz sayının basamaklarının sayı değerleri toplamı: {0}", toplam);

////--------------------------------------------------------------------------------

////Ödev 01 - Problem 4  -----------------------------------------------------------
//int tek = 0;
//int cift = 0;
//Random rnd = new Random();
//for (int i = 0; i < 10; i++)
//{
//    int sayi = rnd.Next(1000);
//    Console.WriteLine(sayi);
//    if (sayi % 2 == 0) cift++;
//    else if (sayi % 2 == 1) tek++;
//}
//Console.WriteLine("Oluşturulan tek sayı adedi: {0}\nOluşturulan çift sayı adedi: {1}", tek, cift);

////--------------------------------------------------------------------------------

////Ödev 01 - Problem 5  -----------------------------------------------------------
//string[] kelimeler = new string[10];
//for (int i = 0; i < 10; i++)
//{
//    Console.Write("Lütfen {0}. kelimeyi giriniz: ", i + 1);
//    kelimeler[i] = Console.ReadLine();
//}
//Array.Sort(kelimeler, (x, y) => x.Length.CompareTo(y.Length));
//Console.WriteLine("Girdiğiniz en uzun kelime {0}\nBu kelime {1} harf uzunluğundadır.", kelimeler[9], kelimeler[9].Length);
//foreach (string s in kelimeler)
//    Console.WriteLine(s + " " + s.Length);

////--------------------------------------------------------------------------------

////Ödev 01 - Problem 6  -----------------------------------------------------------
//Console.WriteLine("Lütfen bir cümle yazınız: ");
//string cumle = Console.ReadLine().ToLower();
//Console.WriteLine("Lütfen saymak istediğiniz harfi yazınız: ");
//char harf = char.Parse(Console.ReadLine().ToLower());
//int sayi = 0;

//foreach (char c in cumle)
//    if (c == harf) sayi++;

//Console.WriteLine("Yazdığınız cümlede saymak istediğiniz harften {0} adet bulunuyor.", sayi);

Console.ReadKey();