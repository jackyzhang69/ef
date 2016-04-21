using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TRVDomain;
using DBContextLayer;

namespace Applications
{
    class Program
    {
        static void Main(string[] args)
        {
            Student p1 = new Student();
            p1.FamilyName = "Zhang";
            p1.GivenName = "Jacky";
            p1.Dob = new DateTime(1969, 02, 11);
            Address ad1 = new Address();
            ad1.POBox = "2319";
            ad1.StreetNo = "4500";
            ad1.StreetName = "Kingsway";
            ad1.City = "Burnaby";
            ad1.Province = "BC";
            ad1.Country = "Canada";
            ad1.PostCode = "V3E 2S6";
            p1.MailingAddress = ad1;
            p1.ResidentialAddress = ad1;

            using (SPDBContext sdb = new SPDBContext())
            {

                sdb.Students.Add(p1);
                sdb.SaveChanges();
                                
                IStudentRepository<Student> repository = new StudentRepository(sdb);
                var result = repository.List;
                foreach (var r in result)
                {
                    Console.WriteLine(r.GivenName);
                }
                var p = repository.FindById(1);
                Console.WriteLine(p.FamilyName+" "+p.GivenName);
                
                IAddressRepository<Address> addrepo = new AddressRepository(sdb);
                var add = addrepo.FindById(1);
                Console.WriteLine(add.GetFullAddress());
                Console.ReadKey();
            }

           
        }
    }
}
