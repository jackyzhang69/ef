using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRVDomain;
using System.Data.Entity;

namespace DBContextLayer
{
    class VisaDBContext: DbContext
    {
        public VisaDBContext() : base("TRV")
        {

        }
        public DbSet<Visitor> Visitors { get; set; }

    }
}
