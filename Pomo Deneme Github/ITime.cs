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
    }
}
