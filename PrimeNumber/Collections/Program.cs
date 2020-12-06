using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities2 = new string[2] { "Ankara", "İstanbul" };

            //new string diyerek yeni bir array oluşturduk.
            //Bu nedenle yukardakilerin bir hükmü kalmadı.
            //Yeni oluşturulan bu 3 array'e de bir atama yapılmadığı için içi şu an boş
            //Ekrana yazdırmak istediğimizde boş bir ekran görmemizin nedeni bu
            cities2 = new string[3];

            Console.WriteLine(cities2[0]);



            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add(1);

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            cities.Add("İstanbul");
            Console.WriteLine(cities[3]);

            Console.ReadLine();
        }
    }
}
