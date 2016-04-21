using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRVDomain
{
    public class Marriage
    {
        [Key]
        public int MarriageId { get; set; }

        //TRV Requirement starts here
        public string MarriageStuatus { get; set; }
        public DateTime CurrentMarriageStartDate { get; set; }
        public string CurrentSpouseFamilyName { get; set; }
        public string CurrentSpouseGivenName { get; set; }
        public bool HasPreviousMarrage { get; set; }
        public string PreviousSpouseFamilyName { get; set; }
        public string PreviousSpouseGivenName { get; set; }
        public DateTime PreviousSpouseDob { get; set; }
        public string PreviousTypeOfRelationship { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        ////TRV Requirement ends here
       



    }
}
