using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ETradeContext : DbContext
    {
        //benim bir product'ım var ben bunu Products ismi ile kullanacağım. 
        //Yani Veritabanı tablolarında Products varsa kod çalışır.
        public DbSet<Product> Products { get; set; } 

    }
}
