using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {

            //Aşağıdaki paranteze 10 değeri girilirse 10 yazar,
            //Girilmezse aşağıdaki _count değeri olan 15 yazar.
            //Buna overload method denir. 
            CustomerManager customerManager = new CustomerManager(10);
            customerManager.List();

            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        // private int _count; //bu bir field
        private int _count = 15;
        public CustomerManager(int count)
        {
            _count = count;
        }

        public CustomerManager()
        {

        }
        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }
        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }
}
