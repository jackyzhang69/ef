using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef
{
    public class CanadaVisitHistory
    {
        [Key]
        public int CanadaVisitHistoryId { get; set; }
        public DateTime OriginalEntry { get; set; }
        public string OriginalPlace { get; set; }
        public string OriginalPurpose { get; set; }
        public string OtherPurpose { get; set; }
        public DateTime MostRecentEntry { get; set; }
        public string MostRecentPlace { get; set; }
        public string DocumentNumber { get; set; }
    }
}
