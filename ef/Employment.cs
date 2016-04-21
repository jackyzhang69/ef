using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRVDomain
{
    public class Employment
    {
        [Key]
        public int EmploymentId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string ActivityOrOccupation { get; set; }
        public string CompayOrFacilty { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
    }
}
