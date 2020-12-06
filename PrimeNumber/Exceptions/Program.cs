using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] students = new string[3] { "Ezgi", "Ece", "Orkun" };
                students[3] = "Büşra"; //Arrayler 0'dan başladığı için üst sınırı 2 olan bir array'i olmayan bir üç ile değiştirmeye çalışmak hata verir


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException); //Daha detaylı hatayı açıklar

            }




            Console.ReadLine();
        }
    }
}
