using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        //TRV requirement starts here
        public string POBox { get; set; }
        public string AptUnit { get; set; }
        public string StreetNo { get; set; }
        public string StreetName { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string PostCode { get; set; }
        //TRV requirement ends here


        public string GetFullAddress()
        {
            string pb = string.IsNullOrEmpty(POBox) ? "" : (POBox + "-");
            string au = string.IsNullOrEmpty(AptUnit) ? "" : (AptUnit + "-");
            return pb + au + StreetNo + " " + StreetName + ", " + City+ ", "+Province + ", " + Country +" "+PostCode;

        }
        public string GetStreetAddress()
        {
            string pb = string.IsNullOrEmpty(POBox)? "": (POBox + "-");
            string au = string.IsNullOrEmpty(AptUnit)? "": (AptUnit + "-");
            return pb + au + StreetNo+" "+StreetName;
        }

        public bool IsSameAs(Address address)
        {
            return (POBox == address.POBox && AptUnit == address.AptUnit && StreetNo == address.StreetNo && StreetName == address.StreetName && District == address.District && City == address.City && Province==address.Province && Country==address.Country && PostCode==address.PostCode);
        }

        //Country name and Id need be matched by dictionary...
    }
}
