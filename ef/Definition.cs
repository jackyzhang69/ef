﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA.Immigration.Data
{
    public partial class Definition
    {
        //
        // TRV DICTIONARY
        //
        public static Dictionary<int, string> Gender = new Dictionary<int, string> {
            {0,"Male" },
            {1,"Female" },
            {2,"Unknown" }
        };
        public static Dictionary<int, string> AddressType = new Dictionary<int, string> {
            { 0,"Residential" },
            {1,"Business" },
            {2,"Mailing" },
            {3,"Work Location"}
        };

        public static Dictionary<string, string> PhoneType = new Dictionary<string, string>
        {
            {"Residence","01" }, //Value needs to be confirmed in imm form
            {"Cellular","02" },
            {"Business","03" }
        };

        public static Dictionary<string, string> CanadaStatus = new Dictionary<string, string> {
            {"Citizen","01" },
            {"Permanent resident","02"},
            {"Visitor","03"},
            {"Worker","04"},
            {"Student","05"},
            {"Other","06"},
            {"Protected Person","07"},
            {"Refugee Claimant","08" },
            {"Foreign National","09" }
        };
        public static Dictionary<string, string> MarriageStatus = new Dictionary<string, string>
        {
            {"Married","01" },
            {"Single","02" },
            {"Common-Law","03" },
            {"Divorced","04" },
            {"Legally Separated","05" },
            {"Widowed","06" },
            {"Annulled Marriaged","09" },
            {"Unknown","00" }
        };

        // Study permit 
        public static Dictionary<string, string> ExpensePaidBy = new Dictionary<string, string>
        {
            {"Myself","01" },
            {"Parents","02"},
            {"Other","03" }
        };

        public static Dictionary<string, string> ApplicationType = new Dictionary<string, string>
        {
            {"Initial Study Permit or Extension","01" }, //needs to be check in imm5709
            {"Restoration of TR Status as student","02" },
            {"Initial TRP or Extension of TRP","03" }
        };

        public static Dictionary<int, string> TRVEduLevel = new Dictionary<int, string>  // Should check imm form to define the value
        {
            {1,"Primary School"},
            {2,"Secondary School"},
            {3,"PTC/TCST/DVS/AVS"},
            {4,"CEGEP-Pre-universtiy"},
            {5,"CEGEP-Technical"},
            {6,"College-Certificate"},
            {7,"College-Diploma"},
            {8,"College-Applied Degree"},
            {9,"University-Bachelor Deg."},
            {10,"University-Master Deg"},
            {11,"University-Doctorate"},
            {12,"University-Other Studies"},
            {13,"ESL/FSL"},
            {14,"ESL/FSL and College"},
            {16,"ESL/FSL and University"},
            {17,"Other Studies"},
            {18,"Not Applicable"}
        };

        public static Dictionary<int, string> TRVVisitPurpose = new Dictionary<int, string>
        {
            {1, "Business"},
            {2, "Tourism"},
            {3, "Study"},
            {4, "Work"},
            {5, "Other"},
            {6, "Family Visit"}
        };

        // LMIA DICTIONARY
        public static Dictionary<int, string> LMIAStatus = new Dictionary<int, string>
        {
            {0, "Student"},
            {1,"Foreign Worker"},
            {2, "Visitor"}

        };
        public static Dictionary<int, string> MediaType = new Dictionary<int, string>
        {
            { -1,"" },
            {0,"Official"},
            {1,"General"},
            {2,"Specifical"},
            {3,"Own"},
            {4,"Other"}
        };
        public static Dictionary<int, string> MediaScope = new Dictionary<int, string>
        {
            {-1,"" },
            {0,"National"},
            {1,"Local"}
        };

        public static Dictionary<int, string> JobPostStatus = new Dictionary<int, string>
        {
            {-1, "" },
            {0,"Waiting for Approval" },
            {1,"Posted" },
            {2, "Expired" }

        };

        public static Dictionary<int, string> LMIAEduLevel = new Dictionary<int, string>
        {
            {0,"Doctorate/PhD"},
            {1,"Doctor of Medicine"},
            {2,"Master's Degree"},
            {3,"Bachelor's Degree"},
            {4,"College level diploma/certificate"},
            {5,"Apprenticeship diploma/certificate"},
            {6,"Trade diploma/certificate"},
            {7,"Secondary school"},
            {8,"Vocational school diploma/certificate"},
            {9,"No formal education requirement"}
        };

        public static Dictionary<int, string> LMIABenefit = new Dictionary<int, string>
        {
            {0,"Disability insurance"},
            {1,"Dental insurance"},
            {2,"Pension"},
            {3,"Extended medical insurance"},
            {4,"Other"}
        };

        public static Dictionary<int, string> DurationUnit = new Dictionary<int, string>
        {
            {0,"Days"},
            {1,"Weeks"},
            {2,"Months"},
            {3,"Years"},
            {4,"Permanent"},
        };


        public static Dictionary<int, string> CompanyType = new Dictionary<int, string> {
            { 0,"Incorporated" },
            { 1,"Partner" },
            { 2,"Solo Proprietor" },
            { 3,"Other" }
        };
        public static Dictionary<int, string> CndProvince = new Dictionary<int, string> {
            {-1,""},
            {0,"AB"},
            {1,"BC"},
            {2,"MB"},
            {3,"NB"},
            {4,"NL"},
            {5,"NS"},
            {6,"NT"},
            {7,"NU"},
            {8,"ON"},
            {9,"PE"},
            {10,"QC"},
            {11,"SK"},
            {12,"YT" }
        };


        public static Dictionary<int, string> ResidenceType = new Dictionary<int, string>
        {
            { 0,"Current"},
            {1,"Previous"},
            {2,"Country where applying"}
        };
        public static Dictionary<int, string> LMIAStream = new Dictionary<int, string> {
            {0,"High Wage Stream"},
            {1,"Low Wage Stream"}
         };
        public static Dictionary<int, string> LMIA11Factors = new Dictionary<int, string>
       {
            {0,"Job Creation / Job Retention of Canadians" },
            {1,"Development or Transfer of Skills and Knowledge" },
            {2,"Filling a Labour Shortage" },
            {3,"prevailing Wage Rate Offered"},
            {4,"Reasonable Efforts to Hire or Train Canadians"},
            {5,"Labour Dispute Settlements Unaffected" },
            {6,"Employer’s Commitments Fulfilled" },
            {7,"Employer is Actively Engaged in Business of Offered Position" },
            {8,"Offer is Consistent with Reasonable Employment Need" },
            {9,"Reasonably Able to Fulfill Terms of Offer" },
            {10,"Past Compliance" }
       };
    }
}
