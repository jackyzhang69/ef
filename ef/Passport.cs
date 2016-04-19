using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef
{
    public class Passport
    {
        [Key]
        public int PassportId { get; set; }
        public int PersonId { get; set; }
        //TRV requirement starts here
        public string PassportNumber { get; set; }
        public string CountryOfIssue { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        //TRV requirement ends here

    }
}
