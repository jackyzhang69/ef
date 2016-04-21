using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRVDomain
{
    public class CanadaVisitDetails
    {
        [Key]
        public string CanadaVisitDetailsId { get; set; }
        public int PersonId { get; set; }
        public string  Purpose { get; set; }
        public string  OtherPurpose { get; set; }
        public DateTime From { get; set; }
        public decimal Funds { get; set; }
        public string VisitedPersonName1 { get; set; }
        public string VisitedPersonRelatiop1 { get; set; }
        public string VisitedPersonAddress1 { get; set; }
        public string VisitedPersonName2{ get; set; }
        public string VisitedPersonRelatiop2 { get; set; }
        public string VisitedPersonAddress2 { get; set; }

    }
    
}
