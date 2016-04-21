using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRVDomain
{
    public class Residence
    {
        [Key]
        public int ResidenceId { get; set;}
        public string Country { get; set; }
        public string  Status { get; set; }
        public string Other { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int ResidenceType { get; set; }  // Current residence, Previous courties of residence, country where applying
    }
}
