using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "My Name is Ezgi";

            //Cümlenin uzunluğu verir
            var result = sentence.Length;

            //Cümle "M" ile başlıyorsa true, başlamıyorsa false döner
            bool result2 = sentence.StartsWith("M");

            //Cümle "g" ile bitiyorsa true, bitmiyorsa false döner
            bool result3 = sentence.EndsWith("g");

            //Cümleyi baştan arar. İlk "i" harfini gördüğü yerde durur, devamına bakmaz
            var result4 = sentence.IndexOf("i");

            //Cümleyi sondan arar. İlk "s" harfi gördüğü yerde durur, devamına bakmaz
            var result5 = sentence.LastIndexOf("s");

            //Cümleye ekleme yapmak için kullanılır
            var result6 = sentence.Insert(0,"Hello, " );

            //Metni parçalamak için kullanılır. 3 => 3. karakterden itibaren böl demektir.
            var result7 = sentence.Substring(3);

            //Hepsini küçük harfle yazar.
            var result8 = sentence.ToLower();


            //Hepsini büyük harfe çevirir
            var result9 = sentence.ToUpper();

            Console.WriteLine(result7);

            Console.ReadLine();
        }
    }
}
