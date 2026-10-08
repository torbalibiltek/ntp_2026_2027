using System;

// =====================================================================
// ÖRNEK 1: Basit If Yapısı (Ehliyet Yaş Kontrolü)
// Açıklama: Sadece 'if' bloğu kullanılmıştır. Koşul sağlanmazsa 
// program hiçbir şey yazdırmadan biter.
// =====================================================================
Console.Write("Yaşınızı giriniz: ");
int yas = int.Parse(Console.ReadLine());

if (yas >= 18)
{
    Console.WriteLine("Tebrikler! Ehliyet başvurusu yapabilirsiniz.");
}

// =====================================================================
// ÖRNEK 2: If-Else Yapısı (Geçme/Kalma Durumu)
// Açıklama: Koşulun hem sağlanması hem de sağlanmaması durumlarında 
// farklı işlemler yapmak için kullanılır.
// =====================================================================
Console.Write("Sınav notunuzu giriniz (0-100): ");
int notOrtalamasi = int.Parse(Console.ReadLine());

if (notOrtalamasi >= 50)
{
    Console.WriteLine("Dersten geçtiniz. Tebrikler!");
}
else
{
    Console.WriteLine("Üzgünüm, dersten kaldınız. Seneye tekrar bekleriz.");
}

// =====================================================================
// ÖRNEK 3: If-Else If-Else Yapısı (Harf Notu Hesaplama)
// Açıklama: Birden fazla koşulu sırayla kontrol etmek için kullanılır. 
// İlk doğru bulunan koşul çalışır ve blok sonlanır.
// =====================================================================
Console.Write("Ortalamanızı giriniz: ");
double ortalama = double.Parse(Console.ReadLine());

if (ortalama >= 90 && ortalama <= 100)
{
    Console.WriteLine("Harf Notunuz: AA (Pekiyi)");
}
else if (ortalama >= 80 && ortalama < 90)
{
    Console.WriteLine("Harf Notunuz: BA (İyi)");
}
else if (ortalama >= 70 && ortalama < 80)
{
    Console.WriteLine("Harf Notunuz: BB (Orta)");
}
else if (ortalama >= 50 && ortalama < 70)
{
    Console.WriteLine("Harf Notunuz: CC (Geçer)");
}
else
{
    Console.WriteLine("Harf Notunuz: FF (Kaldı)");
}

// =====================================================================
// ÖRNEK 4: Mantıksal Operatörler (Hava Durumuna Göre Tavsiye)
// Açıklama: && (VE) ve || (VEYA) operatörlerinin koşullu ifadelerle 
// birlikte kullanımı.
// =====================================================================
Console.Write("Sıcaklık (Derece): ");
int sicaklik = int.Parse(Console.ReadLine());
Console.Write("Hava yağmurlu mu? (e/h): ");
char yagmur = char.Parse(Console.ReadLine());

if (sicaklik > 25 && yagmur == 'h')
{
    Console.WriteLine("Hava çok güzel! Sahile gidebilirsiniz.");
}
else if (sicaklik < 10 || yagmur == 'e')
{
    Console.WriteLine("Hava soğuk veya yağmurlu. Evde kalıp çay içmelisiniz.");
}
else
{
    Console.WriteLine("Normal bir hava durumu. Yürüyüşe çıkabilirsiniz.");
}

// =====================================================================
// ÖRNEK 5: İç İçe (Nested) If Yapısı (Kullanıcı Girişi ve Yetki)
// Açıklama: Bir koşulun içinde başka bir koşul kontrol edilir. 
// Önce kullanıcı adı/şifre, ardından rol kontrolü yapılır.
// =====================================================================
Console.Write("Kullanıcı Adı: ");
string kullaniciAdi = Console.ReadLine();
Console.Write("Şifre: ");
string sifre = Console.ReadLine();

if (kullaniciAdi == "admin" && sifre == "1234")
{
    Console.WriteLine("Giriş başarılı! Hoşgeldiniz.");
    
    Console.Write("Yetkinizi görmek ister misiniz? (e/h): ");
    char secim = char.Parse(Console.ReadLine());
    
    if (secim == 'e')
    {
        Console.WriteLine("Siz bir YÖNETİCİ (Admin) hesabına sahipsiniz.");
    }
    else
    {
        Console.WriteLine("Panele yönlendiriliyorsunuz...");
    }
}
else
{
    Console.WriteLine("Hatalı giriş! Kullanıcı adı veya şifre yanlış.");
}

// =====================================================================
// ÖRNEK 6: Temel Switch Yapısı (Gün İsimleri)
// Açıklama: Bir değişkenin alabileceği belirli değerlere göre işlem 
// yapmak için switch kullanılır.
// =====================================================================
Console.Write("Bir gün numarası giriniz (1-7): ");
int gunNo = int.Parse(Console.ReadLine());

switch (gunNo)
{
    case 1:
        Console.WriteLine("Pazartesi");
        break;
    case 2:
        Console.WriteLine("Salı");
        break;
    case 3:
        Console.WriteLine("Çarşamba");
        break;
    case 4:
        Console.WriteLine("Perşembe");
        break;
    case 5:
        Console.WriteLine("Cuma");
        break;
    case 6:
        Console.WriteLine("Cumartesi");
        break;
    case 7:
        Console.WriteLine("Pazar");
        break;
    default:
        Console.WriteLine("Geçersiz gün numarası! (1-7 arası giriniz)");
        break;
}

// =====================================================================
// ÖRNEK 7: Switch'te Çoklu Durum (Hafta İçi / Hafta Sonu)
// Açıklama: Birden fazla case'in aynı kod bloğunu çalıştırması için 
// break kullanılmadan alt case'e düşürülür.
// =====================================================================
Console.Write("Gün numarasını girin (1-7): ");
int gun = int.Parse(Console.ReadLine());

switch (gun)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Bu bir hafta içi günüdür. Mesai zamanı!");
        break;
    
    case 6:
    case 7:
        Console.WriteLine("Bu bir hafta sonu günüdür. Tatil zamanı!");
        break;
        
    default:
        Console.WriteLine("Hatalı giriş.");
        break;
}

// =====================================================================
// ÖRNEK 8: If İçinde Switch (Sinema Bilet Fiyatlandırma)
// Açıklama: Koşullu ifadeler ve switch yapıları iç içe kullanılabilir. 
// Önce yaş kontrolü (If), ardından öğrenci durumu (Switch) yapılır.
// =====================================================================
Console.Write("Yaşınız: ");
int yas2 = int.Parse(Console.ReadLine());
Console.Write("Öğrenci misiniz? (1: Evet, 2: Hayır): ");
int ogrenciDurumu = int.Parse(Console.ReadLine());
int biletFiyati = 0;

if (yas2 < 6)
{
    biletFiyati = 0;
}
else if (yas2 >= 65)
{
    biletFiyati = 25;
}
else
{
    switch (ogrenciDurumu)
    {
        case 1:
            biletFiyati = 40;
            break;
        case 2:
            biletFiyati = 75;
            break;
        default:
            Console.WriteLine("Geçersiz öğrenci kodu.");
            break;
    }
}

Console.WriteLine($"Ödeyeceğiniz bilet ücreti: {biletFiyati} TL");

// =====================================================================
// ÖRNEK 9: Switch İçinde If (ATM Para Çekme Simülasyonu)
// Açıklama: Switch bloğunun içinde de if yapıları kullanılabilir. 
// Menü seçimine göre farklı kontroller yapılır.
// =====================================================================
Console.WriteLine("--- ATM MENÜSÜ ---");
Console.WriteLine("1. Bakiye Sorgulama");
Console.WriteLine("2. Para Çekme");
Console.Write("İşlem Seçiniz: ");
int islem = int.Parse(Console.ReadLine());

int bakiye = 1000;

switch (islem)
{
    case 1:
        Console.WriteLine($"Mevcut bakiyeniz: {bakiye} TL");
        break;
        
    case 2:
        Console.Write("Çekmek istediğiniz tutar: ");
        int cekilecekTutar = int.Parse(Console.ReadLine());
        
        if (cekilecekTutar > bakiye)
        {
            Console.WriteLine("Hata: Bakiyeniz yetersiz!");
        }
        else if (cekilecekTutar % 20 != 0)
        {
            Console.WriteLine("Hata: Sadece 20 ve katları tutarları çekebilirsiniz.");
        }
        else
        {
            bakiye -= cekilecekTutar;
            Console.WriteLine($"Paranız verildi. Kalan bakiye: {bakiye} TL");
        }
        break;
        
    default:
        Console.WriteLine("Geçersiz menü seçimi.");
        break;
}

// =====================================================================
// ÖRNEK 10: Kapsamlı Senaryo (Kargo Ücreti Hesaplama)
// Açıklama: Gerçek hayat senaryolarına yakın, hem mantıksal operatörleri, 
// hem iç içe if yapılarını hem de switch yapısını barındıran kompleks örnek.
// =====================================================================
Console.Write("Paket ağırlığı (kg): ");
double agirlik = double.Parse(Console.ReadLine());
Console.Write("Gönderim bölgesi (1: Yakın, 2: Orta, 3: Uzak): ");
int bolge = int.Parse(Console.ReadLine());
Console.Write("Üye misiniz? (e/h): ");
char uyeMi = char.Parse(Console.ReadLine());

double ucret = 0;

if (agirlik > 30)
{
    Console.WriteLine("Hata: Paket 30 kg'dan fazla olamaz!");
}
else
{
    switch (bolge)
    {
        case 1:
            ucret = 50;
            break;
        case 2:
            ucret = 100;
            break;
        case 3:
            ucret = 150;
            break;
        default:
            Console.WriteLine("Geçersiz bölge kodu.");
            break;
    }

    if (agirlik > 10)
    {
        ucret += (agirlik - 10) * 10;
    }

    if (uyeMi == 'e' && ucret > 100)
    {
        ucret *= 0.90;
        Console.WriteLine("Üyelik indirimi uygulandı!");
    }

    Console.WriteLine($"Toplam kargo ücreti: {ucret} TL");
}
