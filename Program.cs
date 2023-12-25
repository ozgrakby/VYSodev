using Npgsql;
using System.Formats.Tar;



int cevap = 0;
string input;
int cevap1 = 0;
string input1;

do
{
    Console.WriteLine("Lutfen bir islem seciniz:");
    Console.WriteLine("1. Goruntule");
    Console.WriteLine("2. Ekleme");
    Console.WriteLine("3. Silme");

    input = Console.ReadLine();
    cevap = Int32.Parse(input);

    switch (cevap)
    {
        case 1:
            do
            {
                //goruntule
                Console.WriteLine("Lutfen bir islem seciniz:");
                Console.WriteLine("1. Yayimcilari goruntule");
                Console.WriteLine("2. Gelistirici goruntule");
                Console.WriteLine("3. Kategori goruntule");
                Console.WriteLine("4. Urun goruntule");
                Console.WriteLine("5. Kullanici goruntule");
                Console.WriteLine("6. Satis goruntule");
                Console.WriteLine("7. Degerlendirme goruntule");
                Console.WriteLine("8. Istekler goruntule");
                Console.WriteLine("9. Kullanici urun sayisi goruntule");
                Console.WriteLine("10. Urun satis miktari goruntule");
                Console.WriteLine("11. Urun degerlendirmesi goruntule");
                Console.WriteLine("12. Urun istek orani goruntule");

                input1 = Console.ReadLine();
                cevap1 = Int32.Parse(input1);

                switch (cevap1)
                {
                    case 1:
                        yayimciGoruntule(); 
                        break;
                    case 2:
                        gelistiriciGoruntule();
                        break;
                    case 3:
                        kategoriGoruntule();
                        break;
                    case 4:
                        urunGoruntule();
                        break;
                    case 5:
                        kullaniciGoruntule();
                        break;
                    case 6:
                        satislariGoruntule();
                        break;
                    case 7:
                        degerlendirmeleriGoruntule();
                        break;
                    case 8:
                        istekleriGoruntule();
                        break;
                    case 9:
                        kullaniciUrunSayisi();
                        break;
                    case 10:
                        urunSatisMiktari();
                        break;
                    case 11:
                        urunDegerlendirmeYuzdesi();
                        break;
                    case 12:
                        urunIstekYuzdesi();
                        break;
                    default:
                        cevap1 = 0;
                        break;
                }
            } while (cevap1 != 0);
            break;
        case 2:
            do
            {
                //ekleme
                Console.WriteLine("Lutfen bir islem seciniz:");
                Console.WriteLine("1. Yayimcilara ekle");
                Console.WriteLine("2. Gelistiricilere ekle");
                Console.WriteLine("3. Kategorilere ekle");
                Console.WriteLine("4. Urunlere ekle");
                Console.WriteLine("5. Kullanicilara ekle");
                Console.WriteLine("6. Satislara ekle");
                Console.WriteLine("7. Degerlendirmelere ekle");
                Console.WriteLine("8. Isteklerlere ekle");

                input1 = Console.ReadLine();
                cevap1 = Int32.Parse(input1);

                switch (cevap1)
                {
                    case 1:
                        yayimciEkle();
                        break;
                    case 2:
                        gelistiriciEkle();
                        break;
                    case 3:
                        kategoriEkle();
                        break;
                    case 4:
                        urunEkle();
                        break;
                    case 5:
                        kullaniciEkle();
                        break;
                    case 6:
                        satisEkle();
                        break;
                    case 7:
                        degerlendirmeEkle();
                        break;
                    case 8:
                        istekEkle();
                        break;
                    default:
                        cevap1 = 0;
                        break;
                }
            } while (cevap1 != 0);
            break;
        case 3:
            do
            {
                //silme
                Console.WriteLine("Lutfen bir islem seciniz:");
                Console.WriteLine("1. Yayimcilardan sil");
                Console.WriteLine("2. Gelistiricilerden sil");
                Console.WriteLine("3. Kategorilerden sil");
                Console.WriteLine("4. Urunlerden sil");
                Console.WriteLine("5. Kullanicilardan sil");
                Console.WriteLine("6. Satislardan sil");
                Console.WriteLine("7. Degerlendirmelerden sil");
                Console.WriteLine("8. Isteklerden sil");

                input1 = Console.ReadLine();
                cevap1 = Int32.Parse(input1);

                switch (cevap1)
                {
                    case 1:
                        yayimciSil();
                        break;
                    case 2:
                        gelistiriciSil();
                        break;
                    case 3:
                        kategoriSil();
                        break;
                    case 4:
                        urunSil();
                        break;
                    case 5:
                        kullaniciSil();
                        break;
                    case 6:
                        satisSil();
                        break;
                    case 7:
                        degerlendirmeSil();
                        break;
                    case 8:
                        istekSil();
                        break;
                    default:
                        cevap1 = 0;
                        break;
                }
            } while (cevap1 != 0);
            break;
        default:
            cevap = 0;
            break;
    }
} while (cevap != 0);

void yayimciSil()
{
    Console.WriteLine("Yayimci: ");
    Console.Write("Kodu: ");
    string kodu = Console.ReadLine();
    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost:5432;User Id=postgres; " + "Password=120980;Database=store;");
    conn.Open();
    NpgsqlCommand command = new NpgsqlCommand("DELETE FROM yayimcilar WHERE yayimcikodu = " + kodu, conn);
    int dr = command.ExecuteNonQuery();
    conn.Close();
}

void gelistiriciSil()
{
    Console.WriteLine("Gelistirici: ");
    Console.Write("Kodu: ");
    string kodu = Console.ReadLine();
    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost:5432;User Id=postgres; " + "Password=120980;Database=store;");
    conn.Open();
    NpgsqlCommand command = new NpgsqlCommand("DELETE FROM gelistiriciler WHERE gelistiricikodu = " + kodu, conn);
    int dr = command.ExecuteNonQuery();
    conn.Close();
}

void kategoriSil()
{
    Console.WriteLine("Kategori: ");
    Console.Write("Kodu: ");
    string kodu = Console.ReadLine();
    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost:5432;User Id=postgres; " + "Password=120980;Database=store;");
    conn.Open();
    NpgsqlCommand command = new NpgsqlCommand("DELETE FROM kategoriler WHERE kategorikodu = " + kodu, conn);
    int dr = command.ExecuteNonQuery();
    conn.Close();
}

void urunSil()
{
    Console.WriteLine("Urun: ");
    Console.Write("Kodu: ");
    string kodu = Console.ReadLine();
    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost:5432;User Id=postgres; " + "Password=120980;Database=store;");
    conn.Open();
    NpgsqlCommand command = new NpgsqlCommand("DELETE FROM urunler WHERE urunkodu = " + kodu, conn);
    int dr = command.ExecuteNonQuery();
    conn.Close();
}

void kullaniciSil()
{
    Console.WriteLine("Kullanici: ");
    Console.Write("Kodu: ");
    string kodu = Console.ReadLine();
    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost:5432;User Id=postgres; " + "Password=120980;Database=store;");
    conn.Open();
    NpgsqlCommand command = new NpgsqlCommand("DELETE FROM kullanicilar WHERE kullanicikodu = " + kodu, conn);
    int dr = command.ExecuteNonQuery();
    conn.Close();
}

void satisSil()
{
    Console.WriteLine("Satis: ");
    Console.Write("Kodu: ");
    string kodu = Console.ReadLine();
    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost:5432;User Id=postgres; " + "Password=120980;Database=store;");
    conn.Open();
    NpgsqlCommand command = new NpgsqlCommand("DELETE FROM satislar WHERE satiskodu = " + kodu, conn);
    int dr = command.ExecuteNonQuery();
    conn.Close();
}

void degerlendirmeSil()
{
    Console.WriteLine("Degerlendirme: ");
    Console.Write("Kodu: ");
    string kodu = Console.ReadLine();
    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost:5432;User Id=postgres; " + "Password=120980;Database=store;");
    conn.Open();
    NpgsqlCommand command = new NpgsqlCommand("DELETE FROM degerlendirmeler WHERE degerlendirmekodu = " + kodu, conn);
    int dr = command.ExecuteNonQuery();
    conn.Close();
}

void istekSil()
{
    Console.WriteLine("Istek: ");
    Console.Write("Kodu: ");
    string kodu = Console.ReadLine();
    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost:5432;User Id=postgres; " + "Password=120980;Database=store;");
    conn.Open();
    NpgsqlCommand command = new NpgsqlCommand("DELETE FROM istekler WHERE istekkodu = " + kodu, conn);
    int dr = command.ExecuteNonQuery();
    conn.Close();
}

void yayimciEkle()
{
    Console.WriteLine("Yayimci: ");
    Console.Write("Adi: "); 
    string adi = Console.ReadLine();
    Console.Write("Tam adresi: "); 
    string tamadres = Console.ReadLine();
    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost:5432;User Id=postgres; " + "Password=120980;Database=store;");
    conn.Open();
    NpgsqlCommand command = new NpgsqlCommand("INSERT INTO yayimcilar(yayimciadi) VALUES('" + adi + "')", conn);
    NpgsqlCommand command2 = new NpgsqlCommand("INSERT INTO yayimciadresler(tamadres, sirketkodu) VALUES('" + tamadres + "', CURRVAL('yayimcilar_yayimcikodu_seq'))", conn);
    int dr = command.ExecuteNonQuery(); 
    int dr2 = command2.ExecuteNonQuery();
    conn.Close();
}

void gelistiriciEkle()
{
    Console.WriteLine("Gelistirici: ");
    Console.Write("Adi: ");
    string adi = Console.ReadLine();
    Console.Write("Tam adresi: ");
    string tamadres = Console.ReadLine();
    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost:5432;User Id=postgres; " + "Password=120980;Database=store;");
    conn.Open();
    NpgsqlCommand command = new NpgsqlCommand("INSERT INTO gelistiriciler(gelistiriciadi) VALUES('" + adi + "')", conn);
    NpgsqlCommand command2 = new NpgsqlCommand("INSERT INTO gelistiriciadresler(tamadres, sirketkodu) VALUES('" + tamadres + "', CURRVAL('gelistiriciler_gelistiricikodu_seq'))", conn);
    int dr = command.ExecuteNonQuery();
    int dr2 = command2.ExecuteNonQuery();
    conn.Close();
}

void kategoriEkle()
{
    Console.WriteLine("Kategori: ");
    Console.Write("Adi: ");
    string adi = Console.ReadLine();
    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost:5432;User Id=postgres; " + "Password=120980;Database=store;");
    conn.Open();
    NpgsqlCommand command = new NpgsqlCommand("INSERT INTO kategoriler(kategoriadi) VALUES('" + adi + "')", conn);
    int dr = command.ExecuteNonQuery();
    conn.Close();
}

void urunEkle()
{
    Console.WriteLine("Urun: ");
    Console.Write("UrunAdi: ");
    string adi = Console.ReadLine();
    Console.Write("CikisTarihi(YYYY-MM-DD): ");
    string tarih = Console.ReadLine();
    Console.Write("Aciklama: ");
    string aciklama = Console.ReadLine();
    Console.Write("Fiyat: ");
    string fiyat = Console.ReadLine();
    kategoriGoruntule();
    Console.Write("KategoriKodu: ");
    string kategori = Console.ReadLine();
    yayimciGoruntule();
    Console.Write("YayimciKodu: ");
    string yayimci = Console.ReadLine();
    gelistiriciGoruntule();
    Console.Write("GelistiriciKodu: ");
    string gelistirici = Console.ReadLine();
    Console.Write("Urun turu(oyun icin 'FALSE', yazilim icin 'TRUE' )");
    string tur = Console.ReadLine();
    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost:5432;User Id=postgres; " + "Password=120980;Database=store;");
    conn.Open();
    NpgsqlCommand command = new NpgsqlCommand("INSERT INTO urunler(urunadi, cikistarihi, aciklama, fiyat, kategorikodu, yayimcikodu, gelistiricikodu, urunturu) VALUES('" + adi +"', '" + tarih + "', '" + aciklama + "', '" + fiyat + "', '" + kategori + "', '" + yayimci + "', '" + gelistirici + "', '" + tur + "'); ", conn);
    int dr = command.ExecuteNonQuery();
    if (tur == "TRUE") {
        Console.Write("YasKisitlamasi: ");
        string yas = Console.ReadLine();
        NpgsqlCommand command1 = new NpgsqlCommand("INSERT INTO oyunlar(urunkodu, yaskisitlamasi) VALUES (CURRVAL('urunler_urunkodu_seq'), '" + yas + "')", conn);
        dr = command1.ExecuteNonQuery();
    }
    else if(tur == "FALSE") {
        Console.Write("KullanimAmaci: ");
        string amac = Console.ReadLine();
        NpgsqlCommand command1 = new NpgsqlCommand("INSERT INTO yazilimlar(urunkodu, kullanimamaci) VALUES (CURRVAL('urunler_urunkodu_seq'), '" + amac + "');", conn);
        dr = command1.ExecuteNonQuery();
    }
    conn.Close();
}

void kullaniciEkle()
{
    Console.WriteLine("Kullanici: ");
    Console.Write("KullaniciAdi: ");
    string adi = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Parola: ");
    string parola = Console.ReadLine();
    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost:5432;User Id=postgres; " + "Password=120980;Database=store;");
    conn.Open();
    NpgsqlCommand command = new NpgsqlCommand("INSERT INTO kullanicilar(kullaniciadi, email, parola) VALUES('" + adi + "', '" + email + "', '"+ parola +"');", conn);
    int dr = command.ExecuteNonQuery();
    conn.Close();
}

void satisEkle()
{
    Console.WriteLine("Satis: ");
    Console.Write("KullaniciKodu: ");
    string kullanici = Console.ReadLine();
    Console.Write("UrunKodu: ");
    string urun = Console.ReadLine();
    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost:5432;User Id=postgres; " + "Password=120980;Database=store;");
    conn.Open();
    NpgsqlCommand command = new NpgsqlCommand("INSERT INTO satislar(satistarihi, urunkodu, kullanicikodu) VALUES(NOW()::date, '" + urun + "', '" + kullanici + "')", conn);
    int dr = command.ExecuteNonQuery();
    conn.Close();
}

void degerlendirmeEkle()
{
    Console.WriteLine("Degerlendirme: ");
    Console.Write("KullaniciKodu: ");
    string kullanici = Console.ReadLine();
    Console.Write("UrunKodu: ");
    string urun = Console.ReadLine();
    Console.Write("Durumu(olumlu ise 'TRUE', olumsuz ise 'FALSE'): ");
    string durum = Console.ReadLine();
    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost:5432;User Id=postgres; " + "Password=120980;Database=store;");
    conn.Open();
    NpgsqlCommand command = new NpgsqlCommand("INSERT INTO degerlendirmeler(durumu, urunkodu, kullanicikodu) VALUES('" + durum + "', '" + urun + "', '" + kullanici + "')", conn);
    int dr = command.ExecuteNonQuery();
    conn.Close();
}

void istekEkle()
{
    Console.WriteLine("Istek: ");
    Console.Write("KullaniciKodu: ");
    string kullanici = Console.ReadLine();
    Console.Write("UrunKodu: ");
    string urun = Console.ReadLine();
    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost:5432;User Id=postgres; " + "Password=120980;Database=store;");
    conn.Open();
    NpgsqlCommand command = new NpgsqlCommand("INSERT INTO istekler(urunkodu, kullanicikodu) VALUES('" + urun + "', '" + kullanici + "')", conn);
    int dr = command.ExecuteNonQuery();
    conn.Close();
}

void yayimciGoruntule() 
{
    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost:5432;User Id=postgres; " + "Password=120980;Database=store;");
    conn.Open();
    NpgsqlCommand command = new NpgsqlCommand("SELECT yayimciadi, tamadres FROM yayimcilar INNER JOIN yayimciadresler ON yayimcikodu = sirketkodu", conn);
    NpgsqlDataReader dr = command.ExecuteReader();
    Console.Write("{0,-20}\t{1,-20}\n", "-Yayimci Adi-", "-Tam Adres-");
    while (dr.Read())
        Console.Write("{0,-20}\t{1,-20}\n", dr[0], dr[1]);
    conn.Close();
}

void gelistiriciGoruntule()
{
    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost:5432;User Id=postgres; " + "Password=120980;Database=store;");
    conn.Open();
    NpgsqlCommand command = new NpgsqlCommand("SELECT gelistiriciadi, tamadres FROM gelistiriciler INNER JOIN gelistiriciadresler ON gelistiricikodu = sirketkodu", conn);
    NpgsqlDataReader dr = command.ExecuteReader();
    Console.Write("{0,-20}\t{1,-20}\n", "-Gelistirici Adi-", "-Tam Adres-");
    while (dr.Read())
        Console.Write("{0,-20}\t{1,-20}\n", dr[0], dr[1]);
    conn.Close();
}

void kategoriGoruntule()
{
    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost:5432;User Id=postgres; " + "Password=120980;Database=store;");
    conn.Open();
    NpgsqlCommand command = new NpgsqlCommand("SELECT kategorikodu, kategoriadi FROM kategoriler" , conn);
    NpgsqlDataReader dr = command.ExecuteReader();
    Console.Write("{0,-20}\t{1,-20}\n", "-Kategori Kodu-", "-Kategori Adi-");
    while (dr.Read())
        Console.Write("{0,-20}\t{1,-20}\n", dr[0], dr[1]);
    conn.Close();
}

void urunGoruntule()
{
    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost:5432;User Id=postgres; " + "Password=120980;Database=store;");
    conn.Open();
    NpgsqlCommand command = new NpgsqlCommand("SELECT urunkodu, urunadi, cikistarihi, fiyat, kategoriadi, yayimciadi, gelistiriciadi FROM urunler INNER JOIN kategoriler ON urunler.kategorikodu = kategoriler.kategorikodu INNER JOIN yayimcilar ON urunler.yayimcikodu = yayimcilar.yayimcikodu INNER JOIN gelistiriciler ON urunler.gelistiricikodu = gelistiriciler.gelistiricikodu", conn);
    NpgsqlDataReader dr = command.ExecuteReader();
    while (dr.Read())
    {
        Console.Write("UrunKodu: {0}\n", dr[0]);
        Console.Write("UrunAdi: {0}\n", dr[1]);
        Console.Write("CikisTarihi: {0}\n", dr[2]);
        Console.Write("Fiyat: {0}\n", dr[3]);
        Console.Write("Kategori: {0}\n", dr[4]);
        Console.Write("Yayimci: {0}\n", dr[5]);
        Console.Write("Gelistirici: {0}\n", dr[6]);
        Console.ReadLine();
    }
    conn.Close();
}

void kullaniciGoruntule()
{
    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost:5432;User Id=postgres; " + "Password=120980;Database=store;");
    conn.Open();
    NpgsqlCommand command = new NpgsqlCommand("SELECT kullanicilar.kullanicikodu, kullanicilar.kullaniciadi, kullanicilar.email, kullanicilar.parola, cuzdanlar.miktar FROM kullanicilar INNER JOIN cuzdanlar ON kullanicilar.kullanicikodu = cuzdanlar.kullanicikodu;", conn);
    NpgsqlDataReader dr = command.ExecuteReader();
    while (dr.Read())
    {
        Console.Write("KullaniciKodu: {0}\n", dr[0]);
        Console.Write("KullaniciAdi: {0}\n", dr[1]);
        Console.Write("Email: {0}\n", dr[2]);
        Console.Write("Parola: {0}\n", dr[3]);
        Console.Write("Miktar: {0}\n", dr[4]);
        Console.ReadLine();
    }
    conn.Close();
}

void satislariGoruntule()
{
    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost:5432;User Id=postgres; " + "Password=120980;Database=store;");
    conn.Open();
    NpgsqlCommand command = new NpgsqlCommand("SELECT satislar.satiskodu, urunler.urunadi, kullanicilar.kullaniciadi FROM satislar INNER JOIN urunler ON satislar.urunkodu = urunler.urunkodu INNER JOIN kullanicilar ON satislar.kullanicikodu = kullanicilar.kullanicikodu ", conn);
    NpgsqlDataReader dr = command.ExecuteReader();
    Console.Write("{0,-20}\t{1,-30}\t{2,-20}\n", "-SatisKodu-", "-UrunAdi-", "-KullaniciAdi-");
    while (dr.Read())
        Console.Write("{0,-20}\t{1,-30}\t{2,-20}\n", dr[0], dr[1], dr[2]);
}

void degerlendirmeleriGoruntule()
{
    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost:5432;User Id=postgres; " + "Password=120980;Database=store;");
    conn.Open();
    NpgsqlCommand command = new NpgsqlCommand("SELECT degerlendirmeler.degerlendirmekodu, degerlendirmeler.durumu, urunler.urunadi, kullanicilar.kullaniciadi FROM degerlendirmeler INNER JOIN urunler ON degerlendirmeler.urunkodu = urunler.urunkodu INNER JOIN kullanicilar ON degerlendirmeler.kullanicikodu = kullanicilar.kullanicikodu ", conn);
    NpgsqlDataReader dr = command.ExecuteReader();
    Console.Write("{0,-20}\t{1,-10}\t{2,-30}\t{3,-20}\n", "-DegerlendirmeKodu-", "-Durumu-", "-UrunAdi-", "-KullaniciAdi-");
    while (dr.Read())
        Console.Write("{0,-20}\t{1,-10}\t{2,-30}\t{3,-20}\n", dr[0], dr[1], dr[2], dr[3]);
    conn.Close();
}

void istekleriGoruntule()
{
    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost:5432;User Id=postgres; " + "Password=120980;Database=store;");
    conn.Open();
    NpgsqlCommand command = new NpgsqlCommand("SELECT istekler.istekkodu, urunler.urunadi, kullanicilar.kullaniciadi FROM istekler INNER JOIN urunler ON istekler.urunkodu = urunler.urunkodu INNER JOIN kullanicilar ON istekler.kullanicikodu = kullanicilar.kullanicikodu ", conn);
    NpgsqlDataReader dr = command.ExecuteReader();
    Console.Write("{0,-20}\t{1,-30}\t{2,-20}\n", "-IstekKodu-", "-UrunAdi-", "-KullaniciAdi-");
    while (dr.Read())
        Console.Write("{0,-20}\t{1,-30}\t{2,-20}\n", dr[0], dr[1], dr[2]);
    conn.Close();
}

void kullaniciUrunSayisi()
{
    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost:5432;User Id=postgres; " + "Password=120980;Database=store;");
    conn.Open();
    NpgsqlCommand command = new NpgsqlCommand("CALL kullaniciurunsayisihesapla()", conn);
    int dr = command.ExecuteNonQuery();
    NpgsqlCommand command1 = new NpgsqlCommand("SELECT kullaniciadi, urunsayisi FROM kullaniciurunsayisi", conn);
    NpgsqlDataReader dr1 = command1.ExecuteReader();
    Console.Write("{0,-20}\t{1,-30}\n", "-KullaniciAdi-", "-UrunSayisi-");
    while (dr1.Read())
        Console.Write("{0,-20}\t{1,-30}\n", dr1[0], dr1[1]);
    conn.Close();
}

void urunSatisMiktari()
{
    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost:5432;User Id=postgres; " + "Password=120980;Database=store;");
    conn.Open();
    NpgsqlCommand command = new NpgsqlCommand("CALL urunsatismiktarhesapla()", conn);
    int dr = command.ExecuteNonQuery();
    NpgsqlCommand command1 = new NpgsqlCommand("SELECT urunadi, miktar FROM urunsatismiktar", conn);
    NpgsqlDataReader dr1 = command1.ExecuteReader();
    Console.Write("{0,-20}\t{1,-30}\n", "-UrunAdi-", "-SatisMiktari-");
    while (dr1.Read())
        Console.Write("{0,-20}\t{1,-30}\n", dr1[0], dr1[1]);
    conn.Close();
}

void urunDegerlendirmeYuzdesi()
{
    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost:5432;User Id=postgres; " + "Password=120980;Database=store;");
    conn.Open();
    NpgsqlCommand command = new NpgsqlCommand("CALL degerlendirmeyuzdesihesapla();", conn);
    int dr = command.ExecuteNonQuery();
    NpgsqlCommand command1 = new NpgsqlCommand("SELECT urunadi, yuzde FROM degerlendirmeyuzde", conn);
    NpgsqlDataReader dr1 = command1.ExecuteReader();
    Console.Write("{0,-20}\t{1,-30}\n", "-UrunAdi-", "-Degerlendirme-");
    while (dr1.Read())
        Console.Write("{0,-20}\t{1,-30}\n", dr1[0], dr1[1]);
    conn.Close();
}

void urunIstekYuzdesi()
{
    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost:5432;User Id=postgres; " + "Password=120980;Database=store;");
    conn.Open();
    NpgsqlCommand command = new NpgsqlCommand("CALL istekyuzdesihesapla()", conn);
    int dr = command.ExecuteNonQuery();
    NpgsqlCommand command1 = new NpgsqlCommand("SELECT urunadi, yuzde FROM istekyuzde", conn);
    NpgsqlDataReader dr1 = command1.ExecuteReader();
    Console.Write("{0,-20}\t{1,-30}\n", "-UrunAdi-", "-IstekYuzdesi-");
    while (dr1.Read())
        Console.Write("{0,-20}\t{1,-30}\n", dr1[0], dr1[1]);
    conn.Close();
}