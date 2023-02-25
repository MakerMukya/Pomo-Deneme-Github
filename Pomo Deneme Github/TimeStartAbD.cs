using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomo_Deneme_Github
{
    internal class TimeStartAbD : ITime
    {
        private string _timeStart;
        private string _timeEnd;
        private string _timeSonuc;
        private string _hesaplandi;
        private string _gecen;
        private string _workTime;

        public string StartTime 
        {
            get { return _timeStart; } 
            set { _timeStart = value; } 
        }
        public string EndTime 
        { 
            get { return _timeEnd; }
            set { _timeEnd = value; }
        }

        public string Hesapla()
        {
            _hesaplandi = _timeSonuc;
            return _hesaplandi;
        }

        public void Hesaplayici()
        {
            DateTime basStart = Convert.ToDateTime(_timeStart);
            DateTime basEnd = Convert.ToDateTime(_timeEnd);
            TimeSpan basSonuc = basEnd.Subtract(basStart);
            _timeSonuc = basSonuc.ToString();

        }
        public string GecenTime()
        {
            _gecen = _workTime;
            return _gecen;
        }
        public void WorkTime()
        {
            
            DateTime basStart = Convert.ToDateTime(_timeStart);
            DateTime basEnd = DateTime.Now;
            TimeSpan basSonuc = basEnd.Subtract(basStart);
            _workTime = basSonuc.ToString();


        }
    }
}
