using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef
{
    public class Phone
    {
        [Key]
        public int PhoneId { get; set; }
        //TRV requirement starts here
        public bool CanadaOrUs { get; set; }
        public string CountryCode { get; set; }
        public string Number { get; set; }
        public string Extension { get; set; }
        //TRV requirement ends here
    }

}
