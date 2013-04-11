using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace GuidComb
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ItemContext())
            {
                for (var i = 0; i < 10; i++)
                    db.Items.Add(new Item());

                db.SaveChanges();
            }

            using (var db = new ItemContext())
            {
                foreach (var item in db.Items)
                    Console.WriteLine(item.Id);
            }

            Console.ReadKey();
        }
    }

    public class Item
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
    }

    public class ItemContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
    }
}
