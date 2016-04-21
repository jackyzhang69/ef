using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRVDomain
{
    public class Travel
    {
        [Key]
        public int TravelId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Destination { get; set; }
        public string DestinationInNativeLanguage { get; set; }
        public string Purpose { get; set; }
    }
}
