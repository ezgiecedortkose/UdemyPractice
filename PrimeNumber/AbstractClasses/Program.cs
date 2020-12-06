using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Oracle();
            database.Add();
            database.Delete();

            Database database1 = new SqlServer();
            database1.Add();
            database1.Delete();

            Console.ReadLine();
        }
    }

    abstract class Database
    {

        //Öyle ki Ekleme işlemi tüm senaryo için aynı
        public void Add()
        {
            Console.WriteLine("Added by default");
        }

        //Fakat silme işlemi veritabanlarında farklı gibi düşünerek;
        public abstract void Delete();
    }

    //aslında abstract Class içi dolu olmayan virtual method'dur.
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Sql");

        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");

        }
    }
}
