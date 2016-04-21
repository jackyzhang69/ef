using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRVDomain
{
    public class Language
    {
        public int LanguageId { get; set; }

        // TRV requirement starts here
        public string NativeLanguage { get; set; }
        public string MostUsedLanguage { get; set; }
        public string CommunicateIn { get; set; }
        public bool LanguageAssessed { get; set; }
        // // TRV requirement ends here


    }
}
