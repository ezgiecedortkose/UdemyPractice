using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
        private int Id;
        public void Save()
        {

        }
        public void Delete()
        {

        }
    }
    class Student : Customer
    {
        public void Save2()
        {
            Customer customer = new Customer();
            
        }
    }

    class Course //bir class'ın başında public, private ya da protected yazmıyorsa bu class default internal'dir. 
    {
        public string Name { get; set; }
    }
}
