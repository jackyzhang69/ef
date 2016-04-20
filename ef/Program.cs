using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.FamilyName = "Zhang";
            p1.GivenName = "Jacky";
            p1.Dob = new DateTime(1969, 02, 11);
            Address ad1 = new Address();
            ad1.POBox = "1023";
            ad1.StreetNo = "1411";
            ad1.StreetName = "Garibaldi Pl";
            ad1.City = "Coquitlam";
            ad1.Province = "BC";
            ad1.Country = "Canada";
            ad1.PostCode = "V3E 2S6";
            p1.MailingAddress = ad1;
            p1.ResidentialAddress = ad1;

            using(SPDBContext sdb = new SPDBContext())
            {
               
                sdb.Addresses.Add(ad1);
                sdb.People.Add(p1);
                sdb.SaveChanges();
                Address ad = sdb.Addresses.Where(x => x.City == "Coquitlam").FirstOrDefault();
                Console.WriteLine(ad==null?"":ad.GetStreetAddress());
                Console.WriteLine(p1.ResidentialAddress.GetFullAddress());
                
                Console.WriteLine("Mailing address and residential address is same is "+p1.MailingAddress.IsSameAs(p1.ResidentialAddress).ToString());
                Console.ReadKey();
            }



        }

    }


}
