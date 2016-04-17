using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FamilyName { get; set; }
        public string GivenName { get; set; }
        public string AliasFamilyName { get; set; }
        public string AliasGivenName { get; set; }
        public string Sex { get; set; }
        public DateTime DOB { get; set; }
        public string BirthPlace { get; set; }
        public string BirthCountry { get; set; }

        public Address ResidentialAddress { get; set; }
        public Address WorkingAddress { get; set; }
    }
}
