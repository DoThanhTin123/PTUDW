using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass.Model
{
    public class MyDBContext: DbContext
    {
        //tao ket noi
        public MyDBContext(): base("name = StrConnect") { }
        //ket noi cac bang
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Links> Links { get; set; }
        public DbSet<Menus> Menus { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Orders> Oders { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Slider> Slider { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Topics> Topics { get; set; }
        public DbSet<Users> Users { get; set; }


    }
}
