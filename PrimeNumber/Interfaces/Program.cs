using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleCustomerDal());



            PersonManager manager = new PersonManager();
           
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Ezgi",
                Lastname = "Dörtköşe",
                Address = "İstanbul"
            };

            Student student = new Student
            {
                Id = 1,
                FirstName = "Ece",
                Lastname = "Dörtköşe",
                Department="MF"
            };

            manager.Add(customer); 
            manager.Add(student);

            Console.ReadLine();


        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string Lastname { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }


        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }

        public string Department { get; set; }
    }

    //Aşağıdaki yorum satırı şeklinde yazılırsa sadece customer için ekleme yapar.

    //class PersonManager
    //{
    //    public void Add(Customer customer)
    //    {
    //        Console.WriteLine(customer.FirstName);
    //    }
    //}


    //Fakat bu şekile yazılırsa IPerson'dan implement'e olmuş olan hepsi için ekleme yapar.
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
