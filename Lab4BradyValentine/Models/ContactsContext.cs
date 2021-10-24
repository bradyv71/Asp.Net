using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;

namespace Lab4BradyValentine.Models
{
    public class ContactsContext : DbContext
    {
        public ContactsContext(DbContextOptions<ContactsContext> options)
            : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
              new Category
              {
                  Id = 1,
                  Name = "Family",
              }
             );

            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    Id = 1,
                    CategoryId = 1,
                    FirstName = "Brady",
                    LastName = "Valentine",
                    Email = "bradyv@gmail.com",
                    PhoneNumber = "330-333-3333"

                },
                new Contact
                {
                    Id = 2,
                    CategoryId = 1,
                    FirstName = "Nick",
                    LastName = "Owen",
                    Email = "Nickowen@gmail.com",
                    PhoneNumber = "330-444-4444"

                },
                 new Contact
                 {
                     Id = 3,
                     CategoryId = 1,
                     FirstName = "Patrick",
                     LastName = "Valentine",
                     Email = "pvalentine@gmail.com",
                     PhoneNumber = "241-444-5666"

                 }


                );
        }
    }

}