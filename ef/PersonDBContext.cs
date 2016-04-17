using System;
using System.Collections.Generic;
using System.Data.Entity;


namespace ef
{
    public class PersonDBContext: DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
