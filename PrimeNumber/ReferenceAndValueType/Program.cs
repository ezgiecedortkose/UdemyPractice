using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1; //İKİNCİ SAYININ DEĞERİ = BİRİNCİ SAYININ DEĞERİ 
            number1 = 30;

            Console.WriteLine(number2);

            string[] cities = new string[] { "Ankara", "Adana", "Afyon" };
            string[] cities2 = new string[] { "Bursa", "Bolu", "Balıkesir" };

            cities2 = cities; //CITIES2'NİN REFERANSI = CITIES'İN REFERANSI

            cities[0] = "İstanbul"; // Bu şekilde oluşturduğumuzda Her ikisinde de ilk şehir İstanbul olarak değişir.
                                    //Yani aslında ekrana tek bir İstanbul verisi gelecektir. 
                                    //Çünkü ikisi de bellekte aynı yerde olduğu için cities2'nin değeri diye ayrı bir başlık yoktur.
            


            Console.WriteLine(cities2[0]);

            Console.ReadLine();
        }
    }
}
