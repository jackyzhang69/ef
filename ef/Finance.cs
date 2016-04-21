using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRVDomain
{
    public class Finance
    {
        [Key]
        public int FinanceId { get; set; }
        //TRV requirement starts here
        public decimal Amount { get; set; }
        public string Bank { get; set; }

    }
}
