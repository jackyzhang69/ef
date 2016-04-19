using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef
{
    public abstract class Application
    {
        [Key]
        public int ApplicationId { get; set; }
        public int ApplicantId { get; set; }
        public DateTime CreatedDate { get; set;}
        public DateTime SubmittedDate { get; set; }
        public string ApplicationNumber { get; set; }

    }

    public class SPApplication:Application
    {
        public bool InitialSPApplicaiton { get; set; }
        public bool InCanada { get; set; }
        public string ApplicationType { get; set; }
       
    }
}
