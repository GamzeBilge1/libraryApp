# LibraryApp

Bu proje, kitap kayıtlarını tutan bir uygulamadır. Projede bir kitap sınıfı (`Kitap`) tanımlanmıştır. Her kitap, adı, yazarı, sayfa sayısı, yayınevi ve kayıt tarihi gibi bilgilere sahiptir. Ayrıca, uygulamada kitap nesneleri oluşturmak ve bu nesnelerin bilgilerini görüntülemek için örnek kullanım senaryoları sunulmuştur.

## Özellikler
- **Kitap Sınıfı**:
  - Kitap bilgilerini tutmak için `Ad`, `YazarAdi`, `YazarSoyadi`, `SayfaSayisi`, `YayinEvi` ve `KayitTarihi` özelliklerini içerir.
  - Varsayılan ve parametreli olmak üzere iki adet constructor içerir.
  - Varsayılan constructor: Kitap nesnesi oluşturulduğunda `KayitTarihi` otomatik olarak atanır.
  - Parametreli constructor: Kitap adı, yazar adı, yazar soyadı, sayfa sayısı ve yayınevi bilgileri ile kitap nesnesi oluşturulur. `KayitTarihi` yine otomatik atanır.

- **Program.cs**:
  - Kitap nesneleri oluşturulup bilgileri ekrana yazdırılmıştır.
  - Hem varsayılan hem de parametreli constructor kullanımına örnekler verilmiştir.

## Kullanılan Kavramlar
### 1. **Class**
- Bir nesnenin (örneğin bir kitabın) modelini oluşturan bir yapı.
- Örnek: `Kitap` sınıfı, bir kitabın tüm bilgilerini tanımlamak için kullanılmıştır.

### 2. **Property**
- Bir sınıfın özelliklerini tanımlar ve değerlerini saklar.
- Örnek: `Ad`, `YazarAdi`, `YazarSoyadi`, `SayfaSayisi`, `YayinEvi` ve `KayitTarihi` kitapla ilgili özelliklerdir.

### 3. **Constructor**
- Bir sınıftan nesne oluşturulurken çalışan özel bir metottur. Nesnenin başlangıç değerlerini atar.
- Örnek:
  - Varsayılan constructor: `Kitap()` - Kayıt Tarihi otomatik atanır.
  - Parametreli constructor: `Kitap(string kitapAdi, string yazarAdi, ...)` - Kitap bilgileri oluşturma sırasında atanır.

### 4. **New**
- Bir sınıftan nesne oluşturmak için kullanılan anahtar kelimedir.
- Örnek: `Kitap kitap1 = new Kitap();` ile `Kitap` sınıfından bir nesne oluşturulmuştur.

## Örnek Kullanım

```csharp
Kitap kitap1 = new Kitap(); // Varsayılan constructor ile nesne oluşturulur
kitap1.Ad = "Savaş ve Barış";
kitap1.YazarAdi = "Lev";
kitap1.YazarSoyadi = "Tolstoy";
kitap1.SayfaSayisi = 1225;
kitap1.YayinEvi = "İş Bankası Yayınları";

Console.WriteLine($"Kitap adı: {kitap1.Ad}");
Console.WriteLine($"Yazar Adı Soyadı: {kitap1.YazarAdi} {kitap1.YazarSoyadi}");
Console.WriteLine($"Sayfa Sayısı: {kitap1.SayfaSayisi}");
Console.WriteLine($"Kayıt Tarihi: {kitap1.KayitTarihi}");

Kitap kitap2 = new Kitap("Simyacı", "Paulo", "Coelho", 208, "Can Yayınları");
Console.WriteLine($"Kitap adı: {kitap2.Ad}");
Console.WriteLine($"Yazar Adı Soyadı: {kitap2.YazarAdi} {kitap2.YazarSoyadi}");
Console.WriteLine($"Sayfa Sayısı: {kitap2.SayfaSayisi}");
Console.WriteLine($"Kayıt Tarihi: {kitap2.KayitTarihi}");
