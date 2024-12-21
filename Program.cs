//210229049_MustafaEmirhanKartal
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Donemprojesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba(new List<string> { "1-Audi", "2-BMW", "3-Mercedes", "4-Chevrolet", "5-Ford", "6-Volkswagen", "7-Fiat", "8-Toyota", "9-Hyundai", "10-Renault" },
                         new List<string> { "Audi A6 Sedan","BMW x5","Mercedes g63", "Chevrolet Cruze", "Ford Focus", "Volkswagen Passat", "Fiat Linea", "Toyota Corolla", "Hyundai Tucson", "RenaultF luence" },
                         new List<string> { "Audi A6 S Line package", "Audi A6 Black Edition package", "BMW X5 Sport package", "BMW X5 Individual package", "Mercedes g63 AMG Line package", "Mercedes g63 Exclusive Line package", "Chevrolet Cruze LTZ package", "Chevrolet Cruze LS package", "Ford focus Titanium package", "Ford focus Trend X package", "Volksvagen Passsat Limited Edition package", "Volksvagen Passsat T SE 2.0 package", "Fiat linea Urban package", "Fiat linea Pop package", "Toyota corolla Prestigepackage", "Toyota corolla Vision package", "Hyundai Tucson Comfort package", "Hyundai Tucson Prime package", "Renault fluence Joy package", "Renault fluence Touch package" },
                         new List<string> { "1-Lastik", "2-Jant", "3-Fren Balatası", "4-Far", "5-Çamurluk", "6-Tampon", "7-Vites kolu", "8-Direksiyon simidi", "9-Egzoz" });
          
            Yonetici yonetici1 = new Yonetici()
            {
                KullanıcıAdı = "Emirhank",
                KullancıSifresi = "123456Ek@",
                Kullanıcıİsmi = "Emirhan",
                Eposta = "emirhan_kartal_55@hotmail.com",
                TelefonNumarası = "5422910826"
            };
            Yonetici.Yoneticilistesi.Add(yonetici1);         
            Musteri musteri1 = new Musteri()
            {
                KullanıcıAdı ="Fatihbaykal55",
                KullancıSifresi="987654321Fb_",
                Kullanıcıİsmi="Fatih",
                Eposta="fatihbykl@gmail.com",
                TelefonNumarası="5416470186"
            };
            Musteri.Musterilistesi.Add(musteri1);
            Musteri musteri2 = new Musteri()
            {
                KullanıcıAdı = "Mecitozturk10",
                KullancıSifresi = "Mecit12345_",
                Kullanıcıİsmi = "Mecit",
                Eposta = "Mecitozturk_54@gmail.com",
                TelefonNumarası="5424755688"
            };
            Musteri.Musterilistesi.Add(musteri2);
            Satıcı satıcı1 = new Satıcı()
            {
                KullanıcıAdı = "Ahmetyilmazz",
                KullancıSifresi = "Ahmt112233+",
                Kullanıcıİsmi = "Ahmet",
                Eposta = "Ahmetyilmaz.@hotmail.com",
                TelefonNumarası = "5417895623"
            };
            Satıcı.Satıcılistesi.Add(satıcı1 );
            Satıcı satıcı2 = new Satıcı()
            {
                KullanıcıAdı = "Ramazancanli",
                KullancıSifresi = "Asdw!1234",
                Kullanıcıİsmi = "Ramazan",
                Eposta = "ramazancanli_41@hotmail.com",
                TelefonNumarası = "5356549871"
            };
            Satıcı.Satıcılistesi.Add(satıcı2);
            int secim;
            bool kosul = true;
            while (kosul)
            {    Terminal:
                Console.WriteLine("Hoşgeldiniz");
                Console.WriteLine("Giriş yapmak için 1'i seçiniz");             
                Console.WriteLine("Yeni kayit için 2'yi seçiniz");
                Console.WriteLine("Çıkış yapmak için 3'yı seçiniz ");
                secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {
                    Console.WriteLine("Yönetici girişi için 1'i seçiniz");
                    Console.WriteLine("Satıcı girişi için 2'yi seçiniz");
                    Console.WriteLine("Müşteri girişi için 3'ü seçiniz");
                    int sorgulama = Convert.ToInt32(Console.ReadLine());
                    if(sorgulama == 1) { 
                    Console.Write("Kullanıcı Adı: ");
                    string kullaniciAdi = Console.ReadLine();
                    Console.Write("Şifre: ");
                    string sifre = Console.ReadLine();
                    Console.Write("İsminiz: ");
                    string isim = Console.ReadLine();
                    Console.Write("E-posta: ");
                    string eposta = Console.ReadLine();
                    Console.Write("Telefon Numarası: ");
                    string telefonNumarasi = Console.ReadLine();                  
                    bool kullaniciBilgileriDogru = false;
                    foreach (var yonetici in Yonetici.Yoneticilistesi)
                    {
                        if (yonetici.KullanıcıAdı == kullaniciAdi &&
                            yonetici.KullancıSifresi == sifre &&
                            yonetici.Kullanıcıİsmi == isim &&
                            yonetici.Eposta == eposta &&
                            yonetici.TelefonNumarası == telefonNumarasi)
                        {
                            kullaniciBilgileriDogru = true;
                            break; 
                        }
                    }
                    if (kullaniciBilgileriDogru)
                    {
                            Console.WriteLine("Giriş başarılı!");
                        Yoneticisecimekranı:
                            Console.WriteLine("-----------------------");                          
                            Console.WriteLine("Yapmak istediginiz işlemi seçiniz");
                            Console.WriteLine("Kayıtlı kullanıcıları görmek için 1'i seciniz");
                            Console.WriteLine("Müşteri hesabı silmek için 2'yi seciniz");
                            Console.WriteLine("Satıcı hesabı silmek için 3'ü seciniz");
                            Console.WriteLine("araba işlemleri için 4'ü seciniz");
                            Console.WriteLine("Çıkış yapmak için 5'i seciniz");
                            int tercih = Convert.ToInt32(Console.ReadLine());    
                            if ( tercih == 1)
                            {
                                Console.WriteLine("Kullanıcıları görmek için aşağıdaki seçenekleri kullanabilirsiniz:");
                                Console.WriteLine("Yöneticileri görmek için 1'i seçiniz");
                                Console.WriteLine("Satıcıları görmek için 2'yi seçiniz");
                                Console.WriteLine("Müşterileri görmek için 3'ü seçiniz");
                                int kullaniciSecim = Convert.ToInt32(Console.ReadLine());

                                if (kullaniciSecim == 1)
                                {
                                    Console.WriteLine("Yöneticiler:");
                                    Yonetici.yöneticilistele(Yonetici.Yoneticilistesi);
                                    goto Yoneticisecimekranı;

                                }
                              
                                else if (kullaniciSecim == 2)
                                {
                                    Console.WriteLine("Satıcılar:");
                                    Satıcı.Satıcılistele(Satıcı.Satıcılistesi);
                                    goto Yoneticisecimekranı;
                                }
                                else if (kullaniciSecim == 3)
                                {
                                    Console.WriteLine("Müşteriler:");
                                    Musteri.Müsterilistele(Musteri.Musterilistesi);
                                    goto Yoneticisecimekranı;
                                }                              
                            }
                            if (tercih == 2)
                            {
                                Console.Write("Silmek istediğiniz müşterinin kullanıcı adını giriniz: ");
                                string silinecekKullaniciAdi = Console.ReadLine();

                                Yonetici.MusteriSil(silinecekKullaniciAdi); 
                                goto Yoneticisecimekranı;

                            }
                            if (tercih == 3)
                            {
                                Console.Write("Silmek istediğiniz satıcının kullanıcı adını giriniz: ");
                                string silinecekKullaniciAdi = Console.ReadLine();

                                Yonetici.SatıcıSil(silinecekKullaniciAdi);
                                goto Yoneticisecimekranı;
                            }
                            if (tercih == 4)
                            { Arabaişlemleri:
                                Console.WriteLine("Araba markasını kaldırmak için 1'i seciniz:");
                                Console.WriteLine("Araba modelini kaldırmak için 2'yi seciniz");
                                Console.WriteLine("Araba donanımı kaldırmak için 3'ü seciniz");
                                Console.WriteLine("Yedek parca silmek için 4'ü seciniz");
                                Console.WriteLine("çıkış için 5'i seciniz");
                                int ytercih =Convert.ToInt32(Console.ReadLine());    
                                if (ytercih == 1)
                                {
                                    araba.List_cars();               
                                    Console.Write("Silmek istediğiniz araba markasını giriniz: ");
                                    string silinecekMarka = Console.ReadLine();                                 
                                  Yonetici.ArabaMarkaSil(araba, silinecekMarka);
                                    goto Arabaişlemleri;
                                }
                                if (ytercih == 2)
                                {
                                    araba.ArabaModel();
                                    Console.Write("Silmek istediğiniz araba Modelini giriniz: ");
                                    string silinecekModel = Console.ReadLine();
                                    Yonetici.ArabaModeliSil(araba, silinecekModel);
                                    goto Arabaişlemleri;
                                }
                                if (ytercih == 3)
                                {
                                    araba.ArabaDonanım();
                                    Console.Write("Silmek istediğiniz araba Donanımını giriniz: ");
                                    string silinecekDonanım = Console.ReadLine();
                                    Yonetici.ArabaDonanımıSil(araba, silinecekDonanım);
                                    goto Arabaişlemleri;
                                }
                                if (ytercih == 4)
                                {
                                    araba.Yedekparca();
                                    Console.Write("Silmek istediğiniz yedek parcayı giriniz: ");
                                    string silineceYedekParca = Console.ReadLine();
                                    Yonetici.ArabaYedekParcasıSil(araba, silineceYedekParca);
                                    goto Arabaişlemleri;
                                }
                                if (ytercih == 5)
                                {
                                    Console.WriteLine("Çıkışınız başarıyla yapılmıştır");
                                    goto Terminal;
                                }
                            }
                            if (tercih == 5)
                            {
                                Console.WriteLine("Çıkışınız başarıyla yapılmıştır");
                                goto Terminal;
                            }
                        }
                    else
                    {
                        Console.WriteLine("Sistemde bu bilgilerde yönetici bulunmamaktadır!");
                        Console.WriteLine("-----------------------");
                    }
                }
                    if (sorgulama==2)
                    {
                        Console.Write("Kullanıcı Adı: ");
                        string kullaniciAdi = Console.ReadLine();
                        Console.Write("Şifre: ");
                        string sifre = Console.ReadLine();
                        Console.Write("İsminiz: ");
                        string isim = Console.ReadLine();
                        Console.Write("E-posta: ");
                        string eposta = Console.ReadLine();
                        Console.Write("Telefon Numarası: ");
                        string telefonNumarasi = Console.ReadLine();
                        bool kullaniciBilgileriDogru = false;
                        foreach (var satıcı in Satıcı.Satıcılistesi)
                        {
                            if (satıcı.KullanıcıAdı == kullaniciAdi &&
                               satıcı.KullancıSifresi == sifre &&
                                satıcı.Kullanıcıİsmi == isim &&
                               satıcı.Eposta == eposta &&
                               satıcı.TelefonNumarası == telefonNumarasi)
                            {
                                kullaniciBilgileriDogru = true;
                                break;
                            }
                        }
                        if (kullaniciBilgileriDogru)
                        {   
                            Console.WriteLine("Giriş başarılı!"); 
                            Satıcıİşlemler:
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("Arac eklemek için 1'i seciniz");
                            Console.WriteLine("Yedek parça sayısını güncellemek için 2'yi seciniz");
                            Console.WriteLine("Donanım paketi silmek için 3'ü seciniz");
                            Console.WriteLine("Araba modeli silmek için 4'ü seciniz");
                            Console.WriteLine("Hesabınızı silmek için 5'seciniz");
                            Console.WriteLine("Satış işlemleri icin 6'yı seciniz");
                            Console.WriteLine("Cıkıs yapmak icin 7'yi seciniz");
                            int stercih=Convert.ToInt32(Console.ReadLine());
                            if (stercih == 1)
                            {
                                Console.WriteLine("Güncel araba listesi:");
                                araba.ArabaModel();
                                Console.Write("Eklemek istediğiniz araba modelini yazınız: ");
                                string yeniModel = Console.ReadLine();
                                Satıcı.ArabaModeliEkle(araba, yeniModel);
                                Console.Write("Yeni araba listesi: ");
                                araba.ArabaModel();
                                goto Satıcıİşlemler;
                            }
                            if (stercih == 2)
                            {
                                Console.WriteLine("Mevcut yedek parcalar ve stok bilgisi:");
                                araba.Yedekparca();
                                Satıcı.YedekParcaStokGuncelle(araba);
                                Console.WriteLine("Güncellenmiş yedek parcalar ve stok bilgisi:");
                                araba.Yedekparca();
                                goto Satıcıİşlemler;
                            }
                            if (stercih == 3)
                            {
                                Console.WriteLine("Mevcut Donanım paketleri:");
                                araba.ArabaDonanım();
                                Satıcı.DonanimPaketiSil(araba);
                                Console.WriteLine("Güncellenmiş Donanım paketleri:");
                                araba.ArabaDonanım();
                                goto Satıcıİşlemler;
                            }
                            if (stercih == 4)
                            {
                                Console.WriteLine("Mevcut araba modelleri:");
                                araba.ArabaModel();
                                Satıcı.ArabaModeliSil(araba);
                                Console.WriteLine("Güncel araba modelleri:");
                                araba.ArabaModel();
                                goto Satıcıİşlemler;
                            }
                            if (stercih == 5)
                            {
                                Satıcı.SatıcıSil();
                                goto Terminal;
                            }
                            if (stercih == 6)
                            {
                                Satıcı.MusteriSepetiniGoruntule(musteri2);
                                Console.WriteLine("Satın alma işlemini onaylıyorsanız 1'i,Onaylamıyorsanız 2'yi seciniz?");
                                int talep =Convert.ToInt32(Console.ReadLine());
                                if (talep == 1)
                                {
                                    Console.WriteLine("Satın alma talebi kabul edildi.");
                                    Musteri.alisverisDurumu = true;
                                    Musteri.alisverisDurumuMetni = "olumlu";
                                    goto Satıcıİşlemler;
                                }
                                else if (talep == 2)
                                {
                                    Console.WriteLine("Satın alma talebi reddedildi.");
                                    Musteri.alisverisDurumu = false;
                                    Musteri.alisverisDurumuMetni = "olumsuz";
                                         goto Satıcıİşlemler;
                                }
                                else
                                {
                                    Console.WriteLine("Geçersiz seçim. Lütfen 1 veya 2 girin.");
                                }

                                goto Satıcıİşlemler;
                            }

                            if (stercih == 7)
                            {
                                Console.WriteLine("Çıkışınız başarıyla yapılmıştır");
                                goto Terminal;
                               
                            }
                        }
                        else
                        {
                            Console.WriteLine("Sistemde bu bilgilerde satıcı bulunmamaktadır!");
                            Console.WriteLine("-----------------------");
                        }
                    }
                    if (sorgulama == 3)
                    {
                        Console.Write("Kullanıcı Adı: ");
                        string kullaniciAdi = Console.ReadLine();
                        Console.Write("Şifre: ");
                        string sifre = Console.ReadLine();
                        Console.Write("İsminiz: ");
                        string isim = Console.ReadLine();
                        Console.Write("E-posta: ");
                        string eposta = Console.ReadLine();
                        Console.Write("Telefon Numarası: ");
                        string telefonNumarasi = Console.ReadLine();
                        bool kullaniciBilgileriDogru = false;
                        foreach (var musteri in Musteri.Musterilistesi)
                        {
                            if (musteri.KullanıcıAdı == kullaniciAdi &&
                               musteri.KullancıSifresi == sifre &&
                               musteri.Kullanıcıİsmi == isim &&
                               musteri.Eposta == eposta &&
                               musteri.TelefonNumarası == telefonNumarasi)
                            {
                                kullaniciBilgileriDogru = true;
                                break;
                            }
                        }
                        if (kullaniciBilgileriDogru)
                        {                     
                            Console.WriteLine("Giriş başarılı!");
                            Musteriekran:
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("Yapmak istediginiz işlemi seçiniz");
                            Console.WriteLine("Araçları görmek için 1'i seciniz");
                            Console.WriteLine("Sepeti görüntülemek için 2'yi seciniz");
                            Console.WriteLine("Hesabınızı silmek için 3'ü seciniz");
                            Console.WriteLine("Çıkış yapmak için 4'ü seciniz");
                            int müsterisecim = Convert.ToInt32(Console.ReadLine());

                            if (müsterisecim == 1)
                            {
                                araba.List_cars();

                                Console.Write("Aracınıza ait markanızın numarasını giriniz: ");

                                int markaSecim = Convert.ToInt32(Console.ReadLine());

                                if (markaSecim >= 1 && markaSecim <= araba.ArabaFirmasi.Count)
                                {
                                    int markaIndex = markaSecim - 1;
                                    Console.WriteLine($"Modeller: 1- {araba.ArabaModeli[markaIndex]}");

                                    int modelSecim = Convert.ToInt32(Console.ReadLine());

                                    if (modelSecim == 1 )
                                    {
                                        Console.WriteLine($"Modelin Donanım Paketleri:");

                                        int donanimIndex = (markaIndex * 2) + modelSecim - 1;

                                        Console.WriteLine($"1- {araba.ArabaDonanimi[donanimIndex]}");
                                        Console.WriteLine($"2- {araba.ArabaDonanimi[donanimIndex + 1]}");

                                        Console.Write("Bir donanım paketi seçiniz: ");
                                        int donanimSecim = Convert.ToInt32(Console.ReadLine());

                                        if (donanimSecim >= 1 && donanimSecim <= 2)
                                        {
                                            Console.WriteLine($"Donanım Paketinin Yedek Parçaları ve Stok Miktarları:");

                                            int yedekParcaIndex = 0;
                                            araba.Yedekparca();
                                            Console.Write("Almak istediğiniz ürünün numarasını giriniz: ");
                                            int secilenParcaNumarasi = Convert.ToInt32(Console.ReadLine());

                                            if (secilenParcaNumarasi >= 1 && secilenParcaNumarasi <= araba.ArabaYedekParca.Count)
                                            {
                                                int secilenParcaIndex = yedekParcaIndex + secilenParcaNumarasi - 1;
                                                string secilenYedekParca = araba.ArabaYedekParca[secilenParcaIndex];
                                                int stokMiktari = araba.StokMiktarlari[secilenParcaIndex];
                                                Console.WriteLine($"Seçilen Yedek Parça: {secilenYedekParca} - Stok Miktarı: {stokMiktari}");
                                                Console.Write("Kaç adet almak istediğinizi giriniz: ");
                                                int adet = Convert.ToInt32(Console.ReadLine());

                                                if (adet > 0 && adet <= stokMiktari)
                                                {
                                                    araba.StokMiktarlari[secilenParcaIndex] -= adet;
                                                    Console.WriteLine($"Ürün başarıyla satın alındı. Yeni Stok Miktarı: {araba.StokMiktarlari[secilenParcaIndex]}");
                                                    Musteri.YedekParcaSatınAl(secilenYedekParca, adet);
                                                    goto Musteriekran;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Geçersiz adet girişi veya yetersiz stok miktarı!");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Geçersiz yedek parça numarası!");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Geçersiz donanım paketi seçimi!");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Geçersiz model seçimi!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Geçersiz marka seçimi!");
                                }
                            }
                            if (müsterisecim == 2)
                            {
                                Console.WriteLine("Sepetinizdeki ürünler:");
                                Musteri.SepetiGoruntule();
                                goto Musteriekran;

                            }
                            if (müsterisecim == 3)
                            {
                              Musteri.MusteriSil();
                                goto Terminal;
                            }
                            if (müsterisecim == 4)
                            {
                                Console.WriteLine("Çıkışınız başarıyla yapılmıştır");
                                goto Terminal;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Sistemde bu bilgilerde müşteri bulunmamaktadır!");
                            Console.WriteLine("-----------------------");
                        }
                    }
                }              
                else if (secim == 2)
                {
                    KayitIslemleri kayit = new KayitIslemleri();
                  kayit.Kayit();
                    
                }
                else if (secim == 3)
                {
                    Console.WriteLine("Sistemden çıkış yapıldı");
                    kosul = false;
                }              
                else
                {
                    Console.WriteLine("Geçersiz seçim");
                }
            }
            Console.ReadLine();
        }
        class Kullanıcı {
            public static List<Yonetici> Yoneticilistesi = new List<Yonetici>();
            public static List<Musteri> Musterilistesi = new List<Musteri>();
            public static List<Satıcı> Satıcılistesi = new List<Satıcı>();
        public string KullanıcıAdı { get; set; }
            public string KullancıSifresi { get; set; }
            public string Kullanıcıİsmi { get; set; }
            public string Eposta { get; set; }
            public string TelefonNumarası { get; set; }         
        }
        class Satıcı : Kullanıcı
        {         
            public static void Satıcılistele(List<Satıcı> Satıcılistesi)
            {
                foreach (var Satıcı in Satıcılistesi)
                {
                    Console.WriteLine("Kullanıcı Adı: " + Satıcı.KullanıcıAdı);
                    Console.WriteLine("Şifre: " + Satıcı.KullancıSifresi);
                    Console.WriteLine("İsim: " + Satıcı.Kullanıcıİsmi);
                    Console.WriteLine("E-posta: " + Satıcı.Eposta);
                    Console.WriteLine("Telefon Numarası: " + Satıcı.TelefonNumarası);
                    Console.WriteLine("-----------------------");
                }
            }
            public static void SatıcıSil()
            {
                Console.WriteLine("Hesabınızı silmek için doğrulama yapmalısınız.");
                Console.Write("Kullanıcı Adınızı Giriniz: ");
                string kullaniciAdi = Console.ReadLine();

                Console.Write("Şifrenizi Giriniz: ");
                string sifre = Console.ReadLine();

                Satıcı silinecekSatici = Satıcı.Satıcılistesi.FirstOrDefault(satici =>
                    satici.KullanıcıAdı == kullaniciAdi && satici.KullancıSifresi == sifre);

                if (silinecekSatici != null)
                {
                    Satıcı.Satıcılistesi.Remove(silinecekSatici);
                    Console.WriteLine("Hesabınız başarıyla silinmiştir.");
                    Console.WriteLine("-----------------------");
                }
                else
                {
                    Console.WriteLine("Girilen bilgilerle eşleşen satıcı bulunamadı. Hesap silme işlemi başarısız!");
                    Console.WriteLine("-----------------------");
                }
            }
            public static void ArabaModeliEkle(Araba araba, string yeniModel)
            {
                araba.ArabaModeli.Add(yeniModel);
                Console.WriteLine($"{yeniModel} modeli başarıyla eklendi.");
            }
            public static void YedekParcaStokGuncelle(Araba araba)
            {
                Console.Write("Güncellenecek yedek parça adını giriniz: ");
                string guncellenecekYedekParca = Console.ReadLine();
                Console.Write("Yeni stok miktarını giriniz: ");
                int yeniStokMiktar = Convert.ToInt32(Console.ReadLine());
                bool parcaBulundu = false;

                for (int i = 0; i < araba.ArabaYedekParca.Count; i++)
                {
                    if (araba.ArabaYedekParca[i].Contains(guncellenecekYedekParca))
                    {
                        araba.StokMiktarlari[i] = yeniStokMiktar;

                        Console.WriteLine($"{guncellenecekYedekParca} stok miktarı başarıyla güncellendi. Yeni stok miktarı: {yeniStokMiktar}");
                        parcaBulundu = true;
                        break;
                    }
                }

                if (!parcaBulundu)
                {
                    Console.WriteLine($"{guncellenecekYedekParca} adlı yedek parça bulunamadı.");
                }

            }
            public static void DonanimPaketiSil(Araba araba)
            {
                Console.Write("Silmek istediğiniz donanım paketi adını giriniz: ");
                string silinecekDonanimPaketi = Console.ReadLine();

                if (araba.ArabaDonanimi.Contains(silinecekDonanimPaketi))
                {
                    araba.ArabaDonanimi.Remove(silinecekDonanimPaketi);
                    Console.WriteLine($"{silinecekDonanimPaketi} donanım paketi başarıyla silindi.");
                }
                else
                {
                    Console.WriteLine($"{silinecekDonanimPaketi} adlı donanım paketi bulunamadı.");
                }
            }
            public static void ArabaModeliSil(Araba araba)
            {
                Console.Write("Silmek istediğiniz araba modelini giriniz: ");
                string silinecekArabaModeli = Console.ReadLine();

                int count = araba.ArabaModeli.Count;
                for (int i = 0; i < count; i++)
                {
                    if (araba.ArabaModeli[i] == silinecekArabaModeli)
                    {
                        araba.ArabaModeli.RemoveAt(i);
                        Console.WriteLine($"{silinecekArabaModeli} araba modeli başarıyla silindi.");
                        break;
                    }
                }

                if (!araba.ArabaModeli.Contains(silinecekArabaModeli))
                {
                    Console.WriteLine($"{silinecekArabaModeli} adlı araba modeli bulunamadı.");
                }
            }
            public static void MusteriSepetiniGoruntule(Musteri musteri)
            {
                if (Musterilistesi.Contains(musteri))
                {
                    Console.WriteLine($"{musteri.KullanıcıAdı}'nın Sepeti:");
                    Musteri.SepetiGoruntule();
                    Console.WriteLine("Müsterinin bilgileri:");
                    Console.WriteLine($"{musteri.KullanıcıAdı}-{musteri.Kullanıcıİsmi}-{musteri.TelefonNumarası}-{musteri.Eposta}");
                    Console.WriteLine("-----------------------");
                }
                else
                {
                    Console.WriteLine("Geçersiz müşteri.");
                }
            }

        }
        class Yonetici : Kullanıcı
        {      
          public static void yöneticilistele(List<Yonetici> Yoneticilistesi)
            {
                foreach (var yonetici in Yoneticilistesi)
                {
                    Console.WriteLine("Kullanıcı Adı: " + yonetici.KullanıcıAdı);
                    Console.WriteLine("Şifre: " + yonetici.KullancıSifresi);
                    Console.WriteLine("İsim: " + yonetici.Kullanıcıİsmi);
                    Console.WriteLine("E-posta: " + yonetici.Eposta);
                    Console.WriteLine("Telefon Numarası: " + yonetici.TelefonNumarası);
                    Console.WriteLine("-----------------------");
                }
            }
            public static void MusteriSil(string kullaniciAdi)
            {
                Musteri silinecekMusteri = null;
                foreach (var musteri in Musterilistesi)
                {
                    if (musteri.KullanıcıAdı == kullaniciAdi)
                    {
                        silinecekMusteri = musteri;
                        break;
                    }
                }

                if (silinecekMusteri != null)
                {
                    Musterilistesi.Remove(silinecekMusteri);

                    Console.WriteLine($"{kullaniciAdi} kullanıcı adlı müşteri başarıyla silindi.");
                }
                else
                {
                    Console.WriteLine($"{kullaniciAdi} kullanıcı adlı müşteri bulunamadı.");
                }      
           }
            public static void SatıcıSil(string kullaniciAdi)
            {
                Satıcı silinecekSatıcı = null;
                foreach (var satıcı in Satıcılistesi)
                {
                    if (satıcı.KullanıcıAdı == kullaniciAdi)
                    {
                        silinecekSatıcı = satıcı;
                        break;
                    }
                }
                if (silinecekSatıcı != null)
                {
                    Satıcılistesi.Remove(silinecekSatıcı);
                    Console.WriteLine($"{kullaniciAdi} kullanıcı adlı satıcı başarıyla silindi.");
                }
                else
                {
                    Console.WriteLine($"{kullaniciAdi} kullanıcı adlı satıcı bulunamadı.");
                }
            }
            public static void ArabaMarkaSil(Araba araba, string silinecekMarka)
            {           
                if (araba.ArabaFirmasi.Contains(silinecekMarka))
                {
                    araba.ArabaFirmasi.Remove(silinecekMarka);
                    Console.WriteLine($"{silinecekMarka} markası başarıyla silindi.");
                }
                else
                {
                    Console.WriteLine($"{silinecekMarka} markası bulunamadı.");
                }
            }
            public static void ArabaModeliSil(Araba araba, string silinecekModel)
            {         
                if (araba.ArabaModeli.Contains(silinecekModel))
                {
                    araba.ArabaModeli.Remove(silinecekModel);
                    Console.WriteLine($"{silinecekModel} Modeli başarıyla silindi.");
                }
                else
                {
                    Console.WriteLine($"{silinecekModel} Modeli bulunamadı.");
                }
            }
            public static void ArabaDonanımıSil(Araba araba, string silinecekDonanım)
            {
                if (araba.ArabaDonanimi.Contains(silinecekDonanım))
                {
                    araba.ArabaDonanimi.Remove(silinecekDonanım);
                    Console.WriteLine($"{silinecekDonanım} Donanımı başarıyla silindi.");
                }
                else
                {
                    Console.WriteLine($"{silinecekDonanım} Donanımı bulunamadı.");
                }
            }
            public static void ArabaYedekParcasıSil(Araba araba, string silinecekYedekParca)
            {               
                if (araba.ArabaYedekParca.Contains(silinecekYedekParca))
                {
                    araba.ArabaYedekParca.Remove(silinecekYedekParca);
                    Console.WriteLine($"{silinecekYedekParca}  başarıyla silindi.");
                }
                else
                {
                    Console.WriteLine($"{silinecekYedekParca}  bulunamadı.");
                }
            }

        }
        class Musteri : Kullanıcı
        {        
           public static List<Tuple<string, int>> alisverisSepeti = new List<Tuple<string, int>>();
            public static void Müsterilistele(List<Musteri> Musterilistesi)
            {
                foreach (var Musteri in Musterilistesi)
                {
                    Console.WriteLine("Kullanıcı Adı: " + Musteri.KullanıcıAdı);
                    Console.WriteLine("Şifre: " + Musteri.KullancıSifresi);
                    Console.WriteLine("İsim: " + Musteri.Kullanıcıİsmi);
                    Console.WriteLine("E-posta: " + Musteri.Eposta);
                    Console.WriteLine("Telefon Numarası: " + Musteri.TelefonNumarası);
                    Console.WriteLine("-----------------------");
                }
            }
            public static void MusteriSil()
            {   
                Console.WriteLine("Hesabınızı silmek için doğrulama yapmalısınız.");
                Console.Write("Kullanıcı Adınızı Giriniz: ");
                string kullaniciAdi = Console.ReadLine();

                Console.Write("Şifrenizi Giriniz: ");
                string sifre = Console.ReadLine();

                Musteri silinecekMusteri = null;

                foreach (var musteri in Musteri.Musterilistesi)
                {
                    if (musteri.KullanıcıAdı == kullaniciAdi && musteri.KullancıSifresi == sifre)
                    {
                        silinecekMusteri = musteri;
                        break;
                    }
                }
                if (silinecekMusteri != null)
                {
                    Console.WriteLine("Hesabınızı silmek istediginize emin misiniz?");
                    Console.WriteLine("1-Evet");
                    Console.WriteLine("2-Hayır");
                    int secim=Convert.ToInt32(Console.ReadLine());
                    if (secim == 1) { 
                    Musteri.Musterilistesi.Remove(silinecekMusteri);
                    Console.WriteLine("Hesabınız başarıyla silindi.");
                    }
                    if(secim == 2)
                    {
                        Console.WriteLine("Hesab silme işlemi iptal edildi.");
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz seçim.");
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz kullanıcı adı veya şifre. Hesap silme işlemi başarısız.");                 
                }
            }
            public static bool alisverisDurumu { get; set; }
            public static string alisverisDurumuMetni { get; set; }
            public static void SepetiGoruntule()
            {
                Console.WriteLine("Sepetinizdeki Ürünler:");
                foreach (var urun in alisverisSepeti)
                {
                    Console.WriteLine($"{urun.Item1} - Adet: {urun.Item2} - Satın Alma Durumu: {Musteri.alisverisDurumuMetni}");
                }
            }
            public static void YedekParcaSatınAl(string secilenParca, int adet)
            {
                alisverisSepeti.Add(new Tuple<string, int>(secilenParca, adet));
               Console.WriteLine($"Ürün başarıyla sepetinize eklendi.");
            }
        }
        class Araba
        {
            public List<string> ArabaFirmasi { get; set; }
            public List<string> ArabaModeli { get; set; }
            public List<string> ArabaDonanimi { get; set; }
            public List<string> ArabaYedekParca { get; set; }
            public List<int> StokMiktarlari { get; set; }
            public Araba(List<string> arabaFirmasi, List<string> arabaModeli, List<string> arabaDonanimi, List<string> arabaYedekParca)
            {
                this.ArabaFirmasi = arabaFirmasi;
                this.ArabaModeli = arabaModeli;
                this.ArabaDonanimi = arabaDonanimi;
                this.ArabaYedekParca = arabaYedekParca;
                this.StokMiktarlari = new List<int>();
                for (int i = 0; i < arabaYedekParca.Count; i++)
                {
                    this.StokMiktarlari.Add(10);
                }
            }
            public void List_cars()
            {
                Console.WriteLine("Araba firmalari");
                foreach (var item in ArabaFirmasi)
                {
                    Console.WriteLine(item);
                }
            }
            public void List_models(int aracIndex)
            {
                Console.WriteLine(string.Format("Modelleri: {0}", ArabaModeli[aracIndex]));
                Console.WriteLine(string.Format("Modelleri: {0}", ArabaModeli[aracIndex]));
            }
            public void ArabaModel()
            {
                Console.WriteLine("Araba Modelleri");
                foreach (var item in ArabaModeli)
                {
                    Console.WriteLine(item);
                }
            }
            public void ArabaDonanım()
            {
                Console.WriteLine("Araba donanımları");
                foreach (var item in ArabaDonanimi)
                {
                    Console.WriteLine(item);
                }
            }       
            public void Yedekparca ()
            {
                Console.WriteLine("Satışta olan yedek parça listesi");
                for (int i = 0; i<ArabaYedekParca.Count;i++)
                {
                    Console.WriteLine(ArabaYedekParca[i] + " " + StokMiktarlari[i]);
                   
                }             
            }    
        }
        class KayitIslemleri
        {
            public string Kullaniciadi { get; set; }
            public string Sifre { get; set; }
            public string KullaniciIsmi { get; set; }
            public string Eposta { get; set; }
            public string TelefonNumarasi { get; set; }
            public bool Kayit()
            {
                Console.WriteLine("Yonetici kaydi için 1'i seciniz:");
                Console.WriteLine("Satıcı kaydi için 2'yi seciniz:");
                Console.WriteLine("Müsteri kaydi için 3'ü seciniz:");
                int kullancısecımı;
                kullancısecımı = Convert.ToInt32(Console.ReadLine());

            KullaniciAdi:
                Console.Write("Kullanıcı adınızı giriniz:");
                Kullaniciadi = Console.ReadLine();

                if (Kullaniciadi.Length < 5 || 20 < Kullaniciadi.Length || !char.IsLetter(Kullaniciadi[0]))
                {
                    Console.WriteLine("Geçersiz kullanıcı adı girişi.Kullanıcı adı harfle başlamalı ve Kullanıcı adı 5 ila 20 karakterden oluşmalıdır");
                    goto KullaniciAdi;
                }
                if (KullaniciAdiMevcutMu(Kullaniciadi))
                {
                    Console.WriteLine("Bu kullanıcı adı zaten alınmış. Lütfen farklı bir kullanıcı adı seçin.");
                    goto KullaniciAdi;
                }
            SifreBelirle:
                Console.Write("Şirenizi giriniz:");
                Sifre = Console.ReadLine();

                if (Sifre.Length < 8 || 20 < Sifre.Length || !RakamIceriyorMu(Sifre) || !KucukHarfIceriyorMu(Sifre) || !BuyukHarfIceriyorMu(Sifre) || !OzelKarakterIceriyorMu(Sifre)|| Sifre.Contains(" "))
                {
                    Console.WriteLine("Geçersiz şifre girişi.şifre en az 8 en fazla 20 karakter içermelidir.En az bir tane özel karakter içermelidir.");
                    Console.WriteLine("En az bir tane rakam içermelidir,en az bir tane büyük harf ve küçük harf içermelidir.");

                    goto SifreBelirle;
                }
            isimkontrol:
                Console.Write("İsminizi giriniz:");
                KullaniciIsmi = Console.ReadLine();

                if (!char.IsUpper(KullaniciIsmi[0]) && !char.IsLower(KullaniciIsmi[0]) || OzelKarakterIceriyorMu(KullaniciIsmi))
                {
                    Console.WriteLine("Geçersiz isim girişi. İsim büyük veya küçük harfle başlamalıdır ve özel karakter içermemelidir.");
                    goto isimkontrol;
                }
            Epostakontrol:
                Console.WriteLine("E-posta adresinizi giriniz");
                Eposta = Console.ReadLine();
                if (!char.IsLetter(Eposta[0]) || !Eposta.Contains("@"))
                {
                    Console.WriteLine("Geçersiz e-posta girişi. E-posta özel karakterlerle başlatılamaz veya @ sembolü içermelidir.");
                    goto Epostakontrol;
                }
            TelefonNumarasıkontrol:
                Console.Write("Telefon numaranızı giriniz: ");
                TelefonNumarasi = Console.ReadLine();

                if (TelefonNumarasi.Length != 10 || !TelefonNumarasi.All(char.IsDigit))
                {
                    Console.WriteLine("Geçersiz telefon numarası girşi. Telefon numarası sadece 10 tane rakam içermelidir.");
                    goto TelefonNumarasıkontrol;
                }
                Console.WriteLine("Kaydınız başarıyla gerçekleştirilmiştir. Kullanıcı Adınız:{0}, Şifreniz:{1}, İsminiz:{2},", Kullaniciadi, Sifre, KullaniciIsmi);
                Console.WriteLine("E-postanız:{0}, Telefon numaranız:{1}", Eposta, TelefonNumarasi);
                Console.WriteLine("-----------------------");
                if (kullancısecımı == 1)
                {
                    Console.WriteLine("Yönetici kaydına hoş geldiniz");
                    Yonetici yeniYonetici = new Yonetici()
                    {
                        KullanıcıAdı = Kullaniciadi,
                        KullancıSifresi = Sifre,
                        Kullanıcıİsmi = KullaniciIsmi,
                        Eposta = Eposta,
                        TelefonNumarası = TelefonNumarasi
                    };

                    Yonetici.Yoneticilistesi.Add(yeniYonetici);
                }
                else if (kullancısecımı == 2)
                {
                    Console.WriteLine("Satıcı kaydına hoş geldiniz");
                    Satıcı yeniSatıcı = new Satıcı()
                    {
                        KullanıcıAdı = Kullaniciadi,
                        KullancıSifresi = Sifre,
                        Kullanıcıİsmi = KullaniciIsmi,
                        Eposta = Eposta,
                        TelefonNumarası = TelefonNumarasi
                    };
                    Satıcı.Satıcılistesi.Add(yeniSatıcı);
                }
                else if (kullancısecımı == 3)
                {
                    Console.WriteLine("Müşteri kaydına hosgeldiniz");
                    Musteri yeniMusteri = new Musteri()
                    {
                        KullanıcıAdı = Kullaniciadi,
                        KullancıSifresi = Sifre,
                        Kullanıcıİsmi = KullaniciIsmi,
                        Eposta = Eposta,
                        TelefonNumarası = TelefonNumarasi
                    };
                    Musteri.Musterilistesi.Add(yeniMusteri);
                }
                return true;
            }
            static bool KullaniciAdiMevcutMu(string kullaniciAdi)
            {
                foreach (Yonetici yonetici in Yonetici.Yoneticilistesi)
                {
                    if (yonetici.KullanıcıAdı == kullaniciAdi)
                    {
                        return true; 
                    }
                }
                foreach (Satıcı satici in Satıcı.Satıcılistesi)
                {
                    if (satici.KullanıcıAdı == kullaniciAdi)
                    {
                        return true; 
                    }
                }
                foreach (Musteri musteri in Musteri.Musterilistesi)
                {
                    if (musteri.KullanıcıAdı == kullaniciAdi)
                    {
                        return true;
                    }
                }
                return false; 
            }
            static bool RakamIceriyorMu(string metin)
            {
                return metin.Any(char.IsDigit);
            }

            static bool BuyukHarfIceriyorMu(string metin)
            {
                return metin.Any(char.IsUpper);
            }

            static bool KucukHarfIceriyorMu(string metin)
            {
                return metin.Any(char.IsLower);
            }
            static bool OzelKarakterIceriyorMu(string metin)
            {
                string ozelKarakterler = "!@#$%&*-+";
                return metin.Any(c => ozelKarakterler.Contains(c));
            }
        }
     
    }
}
   



