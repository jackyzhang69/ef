using System.Data.Entity.ModelConfiguration;
using TRVDomain;

namespace DBContextLayer
{
    public class StudentMaping: EntityTypeConfiguration<Student>
    {
        public StudentMaping()
        {
            //HasRequired(ad => ad.PersonId);
        }
    }
}