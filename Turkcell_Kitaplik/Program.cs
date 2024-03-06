using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Turkcell_Kitaplik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int toplamfiyat = 0;    // birden fazla kitap almak istediklerinde kitap + toplam fiyat yapacağım   
            string secim;           // 5. basamakta seçeceğimiz kitabın numarası için değişken tanımladım!!

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("**     Türkçe Kitaplar Kategorisi   **    Yabancı Kitaplar Kategorisi        **");
            Console.WriteLine();
            Console.WriteLine("**   1- Çalıkuşu: Reşat Nuri        **   7- Tuna Kılavuzu: Jules VERNE       **");
            Console.WriteLine("**   2- Yaban: Yakup KADRİ          **   8- Bir Kuzey Macerası: Jack LONDON  **");
            Console.WriteLine("**   3- Sinekli Bakkal: Halide EDİP **   9- Altıncı Koğuş: Anton ÇEHOV       **");
            Console.WriteLine("**   4- Tehlikeli Oyunlar: Oğuz ATAY**   10-Kumarbaz Dostoyevski             **");
            Console.WriteLine("**   5- Geçtiğim Günlerden: H.YÜCEL **   11-İki Şehrin Hikayesi: C. DİCKENS  **");
            Console.WriteLine("**   6- Kuyucaklı Yusuf: S.ALİ      **   12-Vişne Bahçesi: Anton Çehov       **");
            Console.WriteLine();
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine();
            Console.WriteLine("***** İşlemler Menüsü *****");
            Console.WriteLine();
            Console.WriteLine("1- Fiyat Sorgulama");
            Console.WriteLine("2- Yeni Okur Kaydı");
            Console.WriteLine("3- Günün Kitabı");
            Console.WriteLine("4- Kitap Arşivi");
            Console.WriteLine("5- Yeni Kitap Satın Al");
            Console.WriteLine("6- Oyun");
            Console.WriteLine();
            Console.Write("Yapmak istediğiniz işlemin numarası: ");

            char islem;     // değişken türü char 1 ile 6 arasında olduğu için!!
            islem = Convert.ToChar(Console.ReadLine());     // kullanıcıdan aldığım değeri chara çevireceğim çünkü işlem değişkenini char yaptım    önce if bloklarını tamamladım sonra içini doldurmaya başladım

            if (islem == '1')       // char değeri olduğu için tek tırnak kullandım???
            {
                Console.WriteLine();
                Console.Write("İşlem: Lütfen Fiyatını öğrenmek istediğiniz kitabın numarasını giriniz: ");
                
                string numara;      // kitapların numarasını tutacak değişken!!
                numara = Console.ReadLine();    // klavyeden girilen değeri de numaraya atadım!!
                
                switch (numara)
                {
                    case "1": Console.Write("Çalıkuşu: 12 TL");     //kullanıcı 1 yazarsa bunu yazdıracak
                        break;
                    case "2":
                        Console.Write("Yaban: 14 TL");
                        break;
                    case "3":
                        Console.Write("Sinekli Bakkal: 16 TL");
                        break;
                    case "4":
                        Console.Write("Tehlikeli Oyunlar: 11 TL");
                        break;
                    case "5":
                        Console.Write("Geçtiğim Günlerden: 8 TL");
                        break;
                    case "6": Console.Write("Kuyucaklı Yusuf: 13 TL"); break;     // bu şekilde de yazabilirim

                    case "7": Console.Write("Tuna Kılavuzu: 13 TL"); break;
                    case "8": Console.Write("Bir Kuzey Macerası: 12 TL"); break;
                    case "9": Console.Write("Altıncı Koğuş: 18 TL"); break;
                    case "10": Console.Write("kumarbaz: 13 TL"); break;
                    case "11": Console.Write("İki Şehrin Hikayesi: 22 TL"); break;
                    case "12": Console.Write("Vişne Bahçesi: 9 TL"); break;
                }

            } 
            
            if (islem == '2')       // char değeri olduğu için tek tırnak kullandım???
            {
                //Console.WriteLine();
                //Console.WriteLine("İşlem: Yeni Okur Kaydı");
                Console.WriteLine("***** Yeni Okur Kaydı *****");
                string ad, soyad, universite;
                
                Console.WriteLine("adınızı giriniz: ");
                ad = Console.ReadLine();
                
                Console.WriteLine("Soyadınızı giriniz: ");
                soyad = Console.ReadLine();

                Console.WriteLine("Üniversitenizi Giriniz: ");
                universite = Console.ReadLine();

                //Console.WriteLine(ad + soyad + universite); // yazdığım kodları denemek için yazdım

                string dosya = (@"C:\Users\Hasan\Desktop\kullanıcı.txt");   //okur kayıtları için txt belgesi oluşturdum ve dosya adlı değişkene atadım  masaüstüne metinbelgesi oluşturup onun yolunu aldım
                StreamWriter sw = new StreamWriter(dosya);
                sw.WriteLine("Adınız: " + ad);                  // kullanıcıdan aldığım bilgileri kullanıcı .txt dosyasına yazdırıyorum!!!
                sw.WriteLine("Soyadınız: " + soyad);
                sw.WriteLine("Üniversiteniz: " + universite);
                sw.Close();
            }

            if (islem == '3')       // char değeri olduğu için tek tırnak kullandım???
            {
                Console.WriteLine();
                //Console.WriteLine("İşlem: Günün Kitabı");
                Console.WriteLine("*********************************************");
                Console.WriteLine();
                Console.WriteLine("***** Bugünün Kitabı: Tehlikeli Oyunlar *****");
                Console.WriteLine();
                Console.WriteLine("*********************************************");
            }

            if (islem == '4')       // char değeri olduğu için tek tırnak kullandım???
            {
                Console.WriteLine();
                //Console.WriteLine("İşlem: Kitap Arşivi");
                Console.WriteLine("*********************************************");
                Console.WriteLine();
                FileStream fs = new FileStream(@"C:\Users\Hasan\Desktop\kitaplar.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs); 
                string metin = sr.ReadLine();
                while(metin!= null)
                {
                    Console.WriteLine(metin);
                    metin = sr.ReadLine();
                }
                sr.Close();
                fs.Close();

                // burası kitap arşivi olacak
                Console.WriteLine();
                Console.WriteLine("*********************************************");
            }

            if (islem == '5')       // char değeri olduğu için tek tırnak kullandım???
            {
                //Console.WriteLine();
                //Console.WriteLine("İşlem: Yeni Kitap Al");
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine();
                    Console.Write("Alacağınız kitabın numarası:");
                    secim = Console.ReadLine();     // yukarıda tanımladığım seçim değişkenini atadım!!
                    if (secim == "1")
                    {
                        toplamfiyat = toplamfiyat + 12;
                    }
                    else if (secim == "2") 
                    {
                        toplamfiyat = toplamfiyat + 14;
                    }
                    else if (secim == "3")
                    {
                        toplamfiyat = toplamfiyat + 16;
                    }
                    else if (secim == "4")
                    {
                        toplamfiyat = toplamfiyat + 11;
                    }
                    else if (secim == "5")
                    {
                        toplamfiyat = toplamfiyat + 8;
                    }
                    else if (secim == "6")
                    {
                        toplamfiyat = toplamfiyat + 13;
                    }
                    else if (secim == "7")
                    {
                        toplamfiyat = toplamfiyat + 13;
                    }
                    else if (secim == "8")
                    {
                        toplamfiyat = toplamfiyat + 12;
                    }
                    else if (secim == "9")
                    {
                        toplamfiyat = toplamfiyat + 18;
                    }
                    else if (secim == "10")
                    {
                        toplamfiyat = toplamfiyat + 13;
                    }
                    else if (secim == "11")
                    {
                        toplamfiyat = toplamfiyat + 22;
                    }
                    else if (secim == "12")
                    {
                        toplamfiyat = toplamfiyat + 9;
                    }
                    else            // süslü parantezleri kaldırdım!!!
                    
                        Console.WriteLine("1 - 12 arası bir değer giriniz! ");
                        Console.WriteLine();
                        Console.Write("başka bir kitap almak istiyor musunuz? ");
                        string cevap = Console.ReadLine();
                        if (cevap == "h" ||  cevap == "H" || cevap == "hayır" || cevap == "HAYIR" )
                            break;

                    
                }
                Console.WriteLine("Toplam tutar: " + toplamfiyat);
            }

            if (islem == '6')       // char değeri olduğu için tek tırnak kullandım???
            {
                //Console.WriteLine();
                //Console.WriteLine("İşlem: Oyun");
                Console.WriteLine();
                int tahmin = 0;
                Random rand = new Random();     // random sınıfından rand isminde nesne türettim
                int sayi = rand.Next(1, 100);   // 1 dahil 100 hariç rastgele sayı türettim
                while (sayi != tahmin)
                {
                    Console.Write("Sayı Giriniz: ");
                    tahmin = Convert.ToInt16(Console.ReadLine());
                    if (tahmin > sayi)
                    {
                        Console.Write("Daha Küçük");
                    }
                    if (tahmin < sayi)
                    {
                        Console.Write("Daha Büyük");
                    }
                    if (tahmin == sayi)
                    {
                        Console.Write("Bildin Kardeş");
                    }
                }
            }


            Console.Read();         // konsol açık kalsın diye yazıyorum

        
        }
    }
}

