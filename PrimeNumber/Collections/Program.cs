using System;
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
            string[] cities = new string[2] { "Ankara", "İstanbul" };

            //new string diyerek yeni bir array oluşturduk.
            //Bu nedenle yukardakilerin bir hükmü kalmadı.
            //Yeni oluşturulan bu 3 array'e de bir atama yapılmadığı için içi şu an boş
            //Ekrana yazdırmak istediğimizde boş bir ekran görmemizin nedeni bu
            cities = new string[3];

            Console.WriteLine(cities[0]);

            Console.ReadLine();
        }
    }
}
