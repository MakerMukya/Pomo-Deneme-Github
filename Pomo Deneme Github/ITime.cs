using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomo_Deneme_Github
{
    internal interface ITime
    {
        string StartTime { get; set; }
        string EndTime { get; set; }
        void Hesaplayici();
        string Hesapla();
        void WorkTime();
        string GecenTime();
        void CsvWrite();
        string Task { get; set; }
        string PauseTime { get; set; }
        string ContinueTime { get; set; }
        string BreakTime { get; set; }
        void Break();



    }
}
