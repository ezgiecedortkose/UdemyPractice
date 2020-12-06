using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = "İstanbul";
            string city2 = "İzmir";

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(String.Format("{0} {1}", city, city2));

            Console.ReadLine();
        }
    }
}
