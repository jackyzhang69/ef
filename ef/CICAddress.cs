using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef
{
    public class CICAddress
    {
        public static Dictionary<string, Address> CICAddressDictionary = new Dictionary<string, Address>
        {
            { "BeijingOffice",BeijingOffice }

        };
        private static Address BeijingOffice = new Address()
        {
            Recipient= "Visa and Immigration Section",
            Host= "Embassy of Canada",
            StreetNo = "19",
            StreetName= "Dongzhimenwai Dajie",
            District="Chaoyang",
            City="Beijing",
            PostCode="100600"
        };
            
    }
}
