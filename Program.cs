

using libraryApp;

Kitap kitap1 = new Kitap();   // New: "Kitap" sınıfından bir nesne oluşturmak için kullanılır. Nesne bellekte oluşturulur.
                              // Default constructor kullanılarak bir nesne oluşturuluyor.


// Properties: Nesnenin özellikleri elle atanıyor.

kitap1.Ad = "Savaş ve Barış";
kitap1.YazarAdi = "Lev";
kitap1.YazarSoyadi = "Tolstoy";
kitap1.YayinEvi = "İş Bankası Yayınları";
kitap1.SayfaSayisi = 1225;

Console.WriteLine("Kitap adı: "+kitap1.Ad);
Console.WriteLine("Yazar Adı Soyadı: "+kitap1.YazarAdi+" "+kitap1.YazarSoyadi);
Console.WriteLine("Sayfa Sayısı: "+kitap1.SayfaSayisi);
Console.WriteLine("Kayıt Tarihi: " + kitap1.KayitTarihi);

Console.WriteLine("-------------------------------------");

Kitap kitap2 = new Kitap("Simyacı","Paulo",208,"Can Yayınları");   // Yeni bir kitap nesnesi, parametreli constructor ile oluşturuluyor.

kitap2.YazarSoyadi = "Coelho";

Console.WriteLine("Kitap adı: " + kitap2.Ad);
Console.WriteLine("Yazar Adı Soyadı: " + kitap2.YazarAdi + " " + kitap2.YazarSoyadi);
Console.WriteLine("Sayfa Sayısı: " + kitap2.SayfaSayisi);
Console.WriteLine("Kayıt Tarihi: " + kitap2.KayitTarihi);

Console.WriteLine("-------------------------------------");

Kitap kitap3 = new Kitap("Dönüşüm", "Franz", 112, "Cem YayınEvi");

kitap3.YazarSoyadi = "Kafka";

Console.WriteLine("Kitap adı: " + kitap3.Ad);
Console.WriteLine("Yazar Adı Soyadı: " + kitap3.YazarAdi + " " + kitap3.YazarSoyadi);
Console.WriteLine("Sayfa Sayısı: " + kitap3.SayfaSayisi);
Console.WriteLine("Kayıt Tarihi: " + kitap3.KayitTarihi);

// Kavramlar:

// Class: Bir nesnenin (örneğin bir kitabın) modelini oluşturan bir yapı.
// Örnek: "Kitap" bir class'tır. Bu class içinde kitabın adı, yazarı, sayfa sayısı gibi özellikler yer alır.

// Property: Class içerisindeki verileri (özellikleri) tanımlamak ve saklamak için kullanılır.
// Örnek: "Ad", "YazarAdi", "YazarSoyadi", "SayfaSayisi" gibi kitapla ilgili bilgiler birer property'dir.

// New: Bir class'tan bir nesne oluşturmak için kullanılan anahtar kelimedir. Bellekte bir örneğini oluşturur.
// Örnek: "Kitap kitap1 = new Kitap();" ile Kitap class'ından bir kitap nesnesi oluşturulur.

// Constructor: Bir class'ın nesnesi oluşturulurken çalışan özel bir metottur. Nesnenin ilk değerlerini belirlemek için kullanılır.
// Örnek: "public Kitap(string kitapAdi, string yazarAdi) {...}" şeklinde bir constructor, kitap adı ve yazar adı bilgilerini alıp özelliklere atar.

