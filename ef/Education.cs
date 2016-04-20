using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef
{
    public class Education
    {
        [Key]
        public int EducationId { get; set; }
        
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string FieldAndLevel { get; set; }
        public string School { get; set; }
        public string City { get; set; }
        public string Country { get; set;}
        public string Province { get; set; }
    }
}
