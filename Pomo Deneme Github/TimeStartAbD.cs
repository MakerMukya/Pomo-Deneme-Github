using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration.Attributes;
using static System.Windows.Forms.LinkLabel;

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
        private string _task;

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
        public void CsvWrite()
        {
            var myFile = new List<CsvFile>()
            {
                new CsvFile { BaslangicDate = Convert.ToDateTime(_timeStart) , BitisDate= Convert.ToDateTime(_timeEnd)/*,Zaman = _hesaplandi */, TaskSelect = _task}
            };
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                // Don't write the header again.
                HasHeaderRecord = false,
            };
            using (var stream = File.Open("filePersonsWithDoB.csv", FileMode.Append))
            using (var writer = new StreamWriter(stream))
            using (var csv = new CsvWriter(writer, config))
            {
                csv.WriteRecords(myFile);
            }
        }
        public string Task 
        { 
            get { return _task; } 
            set { _task = value; }
        }


    }
}
