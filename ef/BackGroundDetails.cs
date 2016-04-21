using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRVDomain
{
    // in IMM5257B1 shold declare following
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Location { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
    }

    public class Military : Event
    {
       
    }   
    public class IllTreatment: Event
    {
        public string Details { get; set; }

    }
    public class Member: Event
    {
        public string OrgnizationName { get; set; }
        public string ActivityOrPosition { get; set; }
    }

    public class GovernmentPosition : Event
    {
        public string Level { get; set; }
        public string Department { get; set; }
        public string ActivityOrPosition { get; set; }
    }

}
