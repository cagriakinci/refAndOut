using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi1 = 22;
            int sayi1;
            int sayi2 = 12; 
            //var sonuc = Toplama(ref sayi1,sayi2);
            var sonuc = Toplama(out sayi1, sayi2);
            Console.WriteLine("Sayı1'in değeri: " + sayi1);
            Console.WriteLine("Sonuç: " + sonuc);
            
            
        }

        static int Toplama(out int sayi1,int sayi2)
        {
            sayi1 = 5;
            var sonuc = sayi1+sayi2;
            return sonuc;
        }
        /* ref keyword'ünü kullansakta kullanmasakta sonuç 17 çıkacaktır. 
         Çünkü int sayi1 ve int sayi2 değer tipindedir.
         Fakat yapılacak işleme göre bir değişiklik yapmak isteyip, yazdığımız metodu da 
         tekrar tekrar düzenlemek istemiyorsak ref keyword'unü kullanabiliriz.
         Ref keyword'ü değer tiplerin, referans tip gibi kullanılmasını sağlamış olur.*/

        /* out keyword'ünde ise değişkenlere değer ataması yapmadan dahi ref'teki gibi kullanım
         imkanına erişebiliriz.*/
    }
}
