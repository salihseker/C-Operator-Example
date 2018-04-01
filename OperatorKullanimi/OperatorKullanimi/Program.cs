using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {

            //www.salihseker.com
                string ekranaYazilicakMetin, anaMetin, yedekMetin;

                Console.WriteLine("------------------------- Örnek 1 ------------------------------");
                Console.WriteLine();

                anaMetin = null;
                yedekMetin = "Ana metin girilmemiş!";
                ekranaYazilicakMetin = anaMetin ?? yedekMetin; // anaMetin Null Gelmesi durumunda yedekMetin ekrana yazılacaktır
                Console.WriteLine(ekranaYazilicakMetin);

                Console.WriteLine();
                Console.WriteLine("------------------------- Örnek 2 ------------------------------");
                Console.WriteLine();

                anaMetin = "Merhaba Dünya!";
                yedekMetin = "Ana metin girilmemiş!";
                ekranaYazilicakMetin = anaMetin ?? yedekMetin; // anaMetin Null Gelmesi durumunda yedekMetin ekrana yazılacaktır
                Console.WriteLine(ekranaYazilicakMetin);

                Console.WriteLine();
                Console.WriteLine("------------------------- Örnek 3 ------------------------------");
                Console.WriteLine();

                anaMetin = ""; // boşluk karakteri olduğu için ekrana boşluk karakterini yazdıracaktır.
                yedekMetin = "Ana metin girilmemiş!";
                ekranaYazilicakMetin = anaMetin ?? yedekMetin; // anaMetin Null Gelmesi durumunda yedekMetin ekrana yazılacaktır
                Console.WriteLine(ekranaYazilicakMetin);

                Console.WriteLine();
                Console.WriteLine("------------------------- Örnek 4 ------------------------------");
                Console.WriteLine();

                // Aynı işlemi kısa if - else kullanımı ilede yapabiliriz , yazıcağımız kod biraz daha uzayacaktır.
                anaMetin = null;
                yedekMetin = "Ana metin girilmemiş!";
                ekranaYazilicakMetin = anaMetin == null ? yedekMetin : anaMetin; // anaMetin Null Gelmesi durumunda yedekMetin ekrana yazılacaktır
                Console.WriteLine(ekranaYazilicakMetin);

                Console.WriteLine();
                Console.WriteLine("------------------------- Örnek 5 ------------------------------");
                Console.WriteLine();

                // Aynı işlemi normal if-else kullanımı ile yaparsakta yazdığımız kod dahada uzayacaktır..
                anaMetin = null;
                yedekMetin = "Ana metin girilmemiş!";

                if (anaMetin == null)  // anaMetin Null Gelmesi durumunda yedekMetin ekrana yazılacaktır
                    ekranaYazilicakMetin = yedekMetin;
                else
                    ekranaYazilicakMetin = anaMetin;

                Console.WriteLine(ekranaYazilicakMetin);

                Console.ReadKey();
            }
    }
}
