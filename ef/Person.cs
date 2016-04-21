using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRVDomain
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        //TRV requirement starts here
        public string UCI { get; set; }
        public string FamilyName { get; set; }
        public string GivenName { get; set; }
        public string AliasFamilyName { get; set; }
        public string AliasGivenName { get; set; }
        public string Sex { get; set; }
        public DateTime Dob { get; set; }
        public string BirthPlace { get; set; }
        public string BirthCountry { get; set; }
        public string Citizenship { get; set; }

        public Residence CurrentResidence { get; set; }
        public List<Residence> PreviousCountryResidence { get; set; }
        public Marriage TheMarriage { get; set; }
        public Language TheLanguage { get; set; }
        public Passport ThePassport { get; set; }
        public Address MailingAddress { get; set; }
        public Address ResidentialAddress { get; set; }
        public Phone PrimaryPhone { get; set; }
        public Phone AlternatePhoen { get; set; }
        public Phone Fax { get; set; }
        public string Email { get; set; }
        //TRV requirement ends here
    }

    public class Student : Person
    {
        //SP requirement starts here
        public LOA Loa { get; set; }
        public CanadaVisitHistory VisitHistory { get; set; }
        public bool HasPostSecondary { get; set; }
        public Education PostSecondary { get; set; }
        public List<Education> UnderPostSecondaryList { get; set;}  // if apply from China, should include Chinese Content
        public List<Employment> EmploymentList { get; set; }
    }
    public class Visitor : Person
    {
        //Visitor requirement starts here
        public CanadaVisitDetails VisitDetails { get; set; }
        public CanadaVisitHistory VisitHistory { get; set; }
        public bool HasPostSecondary { get; set; }
        public Education PostSecondary { get; set; }
        public List<Education> UnderPostSecondaryList { get; set; }  // if apply from China, should include Chinese Content
        public List<Employment> EmploymentList { get; set; }
    }


}

