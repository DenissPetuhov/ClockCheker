using System;
using System.Collections.Generic;
using System.Linq;
using Timer = System.Windows.Forms.Timer;

namespace ClockCheker
{

    internal class Clock
    {
        private static int secondInt = 1000;

        Timer timer = new Timer()
        {
            Interval = secondInt,
            Enabled = true
        };

        private TimeSpan timeNow = DateTime.Now.TimeOfDay;

        public delegate void TimeHAndler();
        
        public event TimeHAndler SeconTick;

        Dictionary<string, TimeSpan> Cities = new Dictionary<string, TimeSpan>();

        public Clock()
        {
            timer.Tick += Tick;
        }

        public void SetTimerInterval(int count)
        {
            timer.Interval = secondInt * count;
        }
        private void Tick(object sender, EventArgs e)
        {
            timeNow = DateTime.Now.TimeOfDay;
            SeconTick?.Invoke();
        }

        public TimeSpan GetTimeCityNow(string NameCity)
        {
            if(NameCity != null)
            {
                TimeSpan CityTime = timeNow + Cities[NameCity];
                return CityTime;
            }
            return new TimeSpan(0,0,0);

        }
        public void AddCity(String NameSity, TimeSpan offsetTime)
        {
            Cities.Add(NameSity, offsetTime);

        }
        public void StopTimer() => timer.Stop();

        public void StartTimer() => timer.Start();

        public List<string> GetCityNamesList()
        {
            List<string> CityNames = Cities.Keys.ToList();
            return CityNames;
        }
       

    }

}

