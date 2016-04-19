using System;
using System.Collections.Generic;
using System.Data.Entity;


namespace ef
{
    public class SPDBContext: DbContext
    {
        public SPDBContext() : base("SP")
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
