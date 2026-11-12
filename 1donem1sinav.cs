/*
//soru 1 5 bilgi isteyen kendini tanıtan uygulama

using System;

string ad_soyad;
int ise_giris_yili;
int maas;
string engel_durumu;

Console.Write("Personelin Adı ve Soyadı:");
ad_soyad = Console.ReadLine();

Console.Write("Personelin İşe Giriş Yılı:");
ise_giris_yili = Convert.ToInt16( Console.ReadLine());

Console.Write("Personelin Maaşı:");
maas = Convert.ToInt16(Console.ReadLine());

Console.Write("Personelin Engeli Var Mı? (e/h):");
engel_durumu = Console.ReadLine();

Console.WriteLine("Personel Bilgileri:");
Console.WriteLine($"Personelin Adı ve Soyadı: {ad_soyad}");
Console.WriteLine($"Personelin İşe Giriş Yılı: {ise_giris_yili}");
Console.WriteLine($"Personelin Maaşı: {maas}");
Console.WriteLine($"Personelin Engeli Var Mı? :{engel_durumu}");
*/

/*
// esnaf işlemi

double kargo = 49.90;
double esnaf, site;
double islem_tutari;

Console.WriteLine("Sipariş Toplamını Giriniz:");
islem_tutari = Convert.ToDouble(Console.ReadLine());

if(islem_tutari >= 300)
{
    Console.WriteLine($"Esnafın Eline Geçecek Olan Ücret: {islem_tutari * 0.75 - 49.90}");

}
else {
    Console.WriteLine($"Esnafın Eline Geçecek Olan Ücret: {islem_tutari*0.75}");

}
*/

/*
// otopark 

int otopark_suresi;
Console.WriteLine("Toplam Otopark süresiniz giriniz:");
otopark_suresi = Convert.ToInt16(Console.ReadLine());

if (otopark_suresi <= 2)
{ Console.WriteLine("Otopark Ücreti Yok"); }
else if (otopark_suresi > 2 && otopark_suresi <= 6)
{
    Console.WriteLine("Otopark Ücreti 100");
}
else if (otopark_suresi > 6 && otopark_suresi <= 12)
{
    Console.WriteLine("Otopark Ücreti 150");
}
else
{ Console.WriteLine($"Otopark Ücreti {150+ (otopark_suresi-12)*15}");
}
*/

/*
// döngü ile toplama

int negatif_toplam = 0;
int pozitif_toplam = 0;

int sayi = 0;

Console.WriteLine("işlem için bir sayı giriniz (Çıkmak için 0):");
sayi = Convert.ToInt16(Console.ReadLine());

while(sayi != 0)
{
    if(sayi > 0)
        pozitif_toplam += sayi;
    else
        negatif_toplam += sayi;

    Console.WriteLine("işlem için bir sayı daha giriniz (Çıkmak için 0):");
    sayi = Convert.ToInt16(Console.ReadLine());
}

Console.WriteLine("Girilen Pozitif Sayıların Toplamı:"+ pozitif_toplam);
Console.WriteLine("Girilen Negatif Sayıların Toplamı:"+ negatif_toplam);

*/

/*
int[] sayilar = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.Write($"{i + 1}. sayıyı giriniz :");
    sayilar[i] = Convert.ToInt16(Console.ReadLine()); 
}
Console.Write($"Dizi Elemanarı Başa Doğru");
//Array.Reverse(sayilar);// böyle yapana okey
for (int i = 9; i >= 0; i--)
{
    Console.Write($"{sayilar[i]} _ ");
    
}

*/
