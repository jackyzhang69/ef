using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRVDomain
{
    public abstract class Application
    {
        [Key]
        public int ApplicationId { get; set; }
        public DateTime CreatedDate { get; set;}
        public DateTime SubmittedDate { get; set; }
        public string ApplicationNumber { get; set; }

    }

    public class SPApplication:Application
    {
        public bool InitialSPApplicaiton { get; set; }
        public bool InCanada { get; set; }
        public string ApplicationType { get; set; }
        public Student TheStudent { get; set; }
        public bool IsInGroup { get; set; } // for Education and Employment Form
        public string Explanation { get; set; } // for Education and Employment Form

    }

    public class VisaApplication : Application
    {
        public bool InitialVisaApplicaiton { get; set; }
        public bool InCanada { get; set; }
        public Person ThePerson { get; set; } // or do I need to create a Visitor class?

    }
}
