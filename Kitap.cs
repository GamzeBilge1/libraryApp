using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryApp
{
    public class Kitap   // Bu class, bir kitabın bilgilerini tutmak için kullanılır.

    {
        // Properties: Kitap sınıfının özelliklerini tanımlar. Her bir kitap için "Ad", "YazarAdi", "YazarSoyadi", "SayfaSayisi", "YayinEvi" ve "KayitTarihi" bilgileri tutulur.
        public string Ad { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyadi { get; set; }
        public int SayfaSayisi { get; set; }
        public string YayinEvi { get; set; }
        public DateTime KayitTarihi { get; set; }


        public Kitap()  // Constructor: Varsayılan constructor. Parametre almaz ve Kayıt Tarihini otomatik olarak atanır.
        {
            KayitTarihi = DateTime.Now;
        }

        public Kitap(string kitapAdi, string yazarAdi, int sayfaSayisi,string yayınEvi)   // Constructor: Kitap nesnesi oluşturulurken parametre alır. Alınan değerler özelliklere atanır ve Kayıt Tarihi yine otomatik atanır.
                                                                                         
        {
            Ad = kitapAdi;
            YazarAdi = yazarAdi;
            SayfaSayisi = sayfaSayisi;
            YayinEvi = yayınEvi;

            KayitTarihi = DateTime.Now;
        }
    }
}
