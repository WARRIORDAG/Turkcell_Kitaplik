using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turkcell_Kitaplik
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            islem = Convert.ToChar(Console.ReadLine());     // kullanıcıdan aldığım değeri chara çevireceğim çünkü işlem değişkenini char yaptım

            if (islem == '1')       // char değeri olduğu için tek tırnak kullandım???
            {
                Console.WriteLine();
                Console.Write("İşlem: Lütfen Fiyatını öğrenmek istediğiniz kitabın numarasını giriniz");
                
                string numara;
                numara = Console.ReadLine();
                
                switch (numara)
                {
                    case "1": Console.Write("Çalıkuşu: 12 TL"); 
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
                    case "6":
                        Console.Write("Kuyucaklı Yusuf: 13 TL");
                        break;
                }

            }   
            if (islem == '2')       // char değeri olduğu için tek tırnak kullandım???
            {
                Console.WriteLine();
                Console.WriteLine("İşlem: Yeni Okur Kaydı");
            }
            if (islem == '3')       // char değeri olduğu için tek tırnak kullandım???
            {
                Console.WriteLine();
                Console.WriteLine("İşlem: Günün Kitabı");
            }
            if (islem == '4')       // char değeri olduğu için tek tırnak kullandım???
            {
                Console.WriteLine();
                Console.WriteLine("İşlem: Kitap Arşivi");
            }
            if (islem == '5')       // char değeri olduğu için tek tırnak kullandım???
            {
                Console.WriteLine();
                Console.WriteLine("İşlem: Yeni Kitap Al");
            }
            if (islem == '6')       // char değeri olduğu için tek tırnak kullandım???
            {
                Console.WriteLine();
                Console.WriteLine("İşlem: Oyun");
            }



            Console.Read();         // konsol açık kalsın diye yazıyorum

           
        
        }
    }
}

