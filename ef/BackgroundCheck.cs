using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRVDomain
{
    public class BackgroundCheck
    {
        [Key]
        public int BackgroundCheckId { get; set; }

        public bool Tuberculosis { get; set; }
        public bool Disorder { get; set; }
        public string Explanation1 { get; set; }  
        public bool StudyWorkWithoutAuthorization { get; set; }
        public bool AnyApplicationRefused { get; set; }
        public bool AppliedCanada { get; set; }
        public string Explanation2 { get; set; }
        public bool Criminal { get; set; }
        public string Explanation3 { get; set; }
        public bool Military { get; set; }
        public string Explanation4 { get; set; }
        public bool PoliticalCriminal { get; set; }
        public bool IllTreatment { get; set; }
        public bool Imm5257B1Required { get; set; }
    }
}
