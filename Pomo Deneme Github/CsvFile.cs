using System;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration.Attributes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Pomo_Deneme_Github
{
    internal class CsvFile
    {
        [Format("AZ MMM dd, yyyy HH:mm:ss")]
        public DateTime BaslangicDate { get; set; }
        [Format("AZ MMM dd, yyyy HH:mm:ss")]
        public DateTime BitisDate { get; set; }
        public string  TaskSelect { get; set; }
        // public string Zaman { get; set; }
    }
}
