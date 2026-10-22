// See https://aka.ms/new-console-template for more information
string cevap = "hayır";
int i = 0;
while((cevap == "hayır" || cevap == "Hayır") && (i <= 20))
{
    i++;
    Console.WriteLine($"{i}. dilim Pizza ile Doydunuz mu ?");
    cevap = Console.ReadLine();
}
Console.WriteLine("Afiyet Olsun");
Console.WriteLine($"toplam da {i} dilim Pizza yediniz");









/*
Console.Write("Sınıftaki Öğrenci Sayısını Gir :");
int ogrenci_sayisi = Convert.ToInt16(Console.ReadLine());
double sinif_ortalama_toplami = 0;
double sinif_ortalama = 0;
int x = 1;
while (x<= ogrenci_sayisi)
{
    Console.WriteLine($"Notu Hesaplanacak {x}. Öğrenciyi Gir :");
    int toplam = 0;
    int i = 1;
    double ort = 0;
    while (i <= 3)
    {
        //i++;
        Console.Write($"{x}. Öğrencinin Toplanacak {i}. Notu Gir :");
        int sayi = Convert.ToInt16(Console.ReadLine());
        toplam += sayi;
        i++;
    }
    Console.WriteLine("Girilen notların toplamı : " + toplam);
    ort = toplam / 3;
    Console.WriteLine("Girilen Notların Ortalaması : " + ort);
    sinif_ortalama_toplami += ort;
    x++;
}
sinif_ortalama = sinif_ortalama_toplami / ogrenci_sayisi;
Console.WriteLine($"{ogrenci_sayisi} kadar öüğrencinin Ortalaması {sinif_ortalama}");

*/

/*
Console.Write("Sınıftaki Öğrenci Sayısını Gir :");
int ogrenci_sayisi = Convert.ToInt16(Console.ReadLine());
double sinif_ortalama_toplami = 0;
double sinif_ortalama = 0;
for (int x = 1; x <= ogrenci_sayisi; x++)
{    Console.WriteLine($"Notu Hesaplanacak {x}. Öğrenciyi Gir :");
    int toplam = 0;
    double ort = 0;
    for (int i = 1; i <= 3; i++)
    {
        Console.Write($"{x}. Öğrencinin Toplanacak {i}. Notu Gir :");
        toplam += Convert.ToInt16(Console.ReadLine());
    }
    ort = toplam / 3;
    Console.WriteLine($"Girilen Notların Ortalama {ort}");
    sinif_ortalama_toplami += ort;
}

sinif_ortalama = sinif_ortalama_toplami / ogrenci_sayisi;
Console.WriteLine($"{ogrenci_sayisi} kadar öüğrencinin Ortalaması {sinif_ortalama}");
*/
