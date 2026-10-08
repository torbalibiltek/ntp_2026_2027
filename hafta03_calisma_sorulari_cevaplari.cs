using System;

// =====================================================================
// ÖRNEK 1: Pozitif Sayı Kontrolü (Basit If Yapısı)
// Açıklama: Sadece 'if' bloğu kullanılmıştır. Koşul sağlanmazsa 
// program hiçbir şey yazdırmadan bir sonraki örneğe geçer.
// =====================================================================
Console.WriteLine("--- ÖRNEK 1: Pozitif Sayı Kontrolü ---");
Console.Write("Bir tam sayı giriniz: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());

if (sayi1 > 0)
{
    Console.WriteLine("Bu sayı pozitiftir.");
}
Console.WriteLine();
Console.WriteLine("Devam etmek için Enter'a basın...");
Console.ReadLine();

// =====================================================================
// ÖRNEK 2: Çift mi, Tek mi? (If-Else Yapısı)
// Açıklama: Koşulun hem sağlanması hem de sağlanmaması durumlarında 
// farklı işlemler yapmak için if-else kullanılır.
// =====================================================================
Console.WriteLine("--- ÖRNEK 2: Çift mi, Tek mi? ---");
Console.Write("Bir tam sayı giriniz: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

if (sayi2 % 2 == 0)
{
    Console.WriteLine("Çift sayı");
}
else
{
    Console.WriteLine("Tek sayı");
}
Console.WriteLine();
Console.WriteLine("Devam etmek için Enter'a basın...");
Console.ReadLine();

// =====================================================================
// ÖRNEK 3: Basit Şifre Doğrulama (String Karşılaştırma)
// Açıklama: Metinsel verilerin eşitlik kontrolü için == operatörü 
// kullanılır. Tek = atama yapar, == karşılaştırır.
// =====================================================================
Console.WriteLine("--- ÖRNEK 3: Basit Şifre Doğrulama ---");
Console.Write("Şifrenizi giriniz: ");
string sifre = Console.ReadLine();

if (sifre == "12345")
{
    Console.WriteLine("Giriş Başarılı");
}
else
{
    Console.WriteLine("Hatalı Şifre");
}
Console.WriteLine();
Console.WriteLine("Devam etmek için Enter'a basın...");
Console.ReadLine();

// =====================================================================
// ÖRNEK 4: Sayının İşareti (If-Else If-Else Yapısı)
// Açıklama: Üç farklı durum için if, else if ve else blokları kullanılır.
// İlk doğru bulunan koşul çalışır ve blok sonlanır.
// =====================================================================
Console.WriteLine("--- ÖRNEK 4: Sayının İşareti (3 Durumlu) ---");
Console.Write("Bir sayı giriniz: ");
int sayi4 = Convert.ToInt32(Console.ReadLine());

if (sayi4 > 0)
{
    Console.WriteLine("Pozitif");
}
else if (sayi4 == 0)
{
    Console.WriteLine("Sıfır");
}
else
{
    Console.WriteLine("Negatif");
}
Console.WriteLine();
Console.WriteLine("Devam etmek için Enter'a basın...");
Console.ReadLine();

// =====================================================================
// ÖRNEK 5: Basit Not Sistemi (Aralık Kontrolü)
// Açıklama: && (VE) operatörü ile bir sayının belirli bir aralıkta 
// olup olmadığı kontrol edilir.
// =====================================================================
Console.WriteLine("--- ÖRNEK 5: Basit Not Sistemi ---");
Console.Write("Notunuzu giriniz (0-100): ");
int not = Convert.ToInt32(Console.ReadLine());

if (not >= 85 && not <= 100)
{
    Console.WriteLine("AA (Pekiyi)");
}
else if (not >= 50 && not < 85)
{
    Console.WriteLine("CC (Geçer)");
}
else if (not >= 0 && not < 50)
{
    Console.WriteLine("FF (Kaldı)");
}
else
{
    Console.WriteLine("Geçersiz not girdiniz.");
}
Console.WriteLine();
Console.WriteLine("Devam etmek için Enter'a basın...");
Console.ReadLine();

// =====================================================================
// ÖRNEK 6: Lunapark Kontrolü (VE Operatörü - &&)
// Açıklama: İki koşulun DA aynı anda doğru olması gerektiğinde 
// && (VE) operatörü kullanılır.
// =====================================================================
Console.WriteLine("--- ÖRNEK 6: Lunapark Kontrolü (VE Operatörü
