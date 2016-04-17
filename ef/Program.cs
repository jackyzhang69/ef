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
            Address ad1 = new Address();
            ad1.City = "Nanjing";
            p1.WorkingAddress = ad1;
            Console.WriteLine(p1);
      

        }

    }
   
   
}
