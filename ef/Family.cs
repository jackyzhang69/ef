using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef
{
    public class FamilyMember
    {
        [Key]
        public int FamilyMemberId { get; set; }
        //TRV Requirement starts here
        public string PinyingName { get; set; }
        public string NativeName { get; set; }
        public DateTime Dob { get; set; }
        public string CountryOfBirth { get; set; }
        public string MaritalStatus { get; set; }
        public Address theAddress { get; set; }
        public string Occupation { get; set; }
        public bool AccompanyToCanada { get; set; }
    }
    public class Family
    {
        [Key]
        public int FamilyId { get; set; }
        public int ApplicantId { get; set; }
        public FamilyMember Spouse { get; set; }
        public FamilyMember Mother { get; set; }
        public FamilyMember Father { get; set; }
        public List<FamilyMember> Children { get; set; }
        public List<FamilyMember> Siblings { get; set; }

    }
}
