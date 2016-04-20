using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef
{
    public class LOA
    {
        [Key]
        public int LOAId { get; set; }
        public string NameOfSchool { get; set; }
        public string StudyLevel { get; set; }
        public string StudyField { get; set; }
        public Address SchoolAddress { get; set; }
        public string DLINumber { get; set; }
        public string StudentIdNumber { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public decimal Tuition { get; set; }
        public decimal RoomAndBoard { get; set; }
        public decimal Other { get; set; }
        public decimal FundsAvailable { get; set; }
        public string ExpensePaidBY { get; set; }
        public string ExpensePaidByOther { get; set; }

    }
}
