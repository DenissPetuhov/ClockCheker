using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClockCheker
{
    public partial class MainForm : Form
    {
        Clock MoskowClock = new Clock();
        Clock VladivostokClock = new Clock();
        Clock LondonClock = new Clock();
        Clock clock = new Clock();
        List<string> CityesNamesList;
        TimeSpan SlectNewTime;
        private string CityName;
     
        public MainForm()
        {
            InitializeComponent();
            
            CityesNamesList = clock.GetCityNamesList();
            MoskowClock.SeconTick += SetMoskowTimeTick;
            VladivostokClock.SeconTick += SetVladivostokTimeTick;
            LondonClock.SeconTick += SetLondonTimeTick;
            clock.SeconTick += SetSelectTimerTick;

        }

        private void SetSelectTimerTick()
        {
            if(CityName != null)
            {
                TimeSpan time = clock.GetTimeCityNow(CityName);
                SetLableTime(time, CityName);
            }
            if(cb_CityList.Items.Count != CityesNamesList.Count)
            {
                UpdateComboBoxItem();
            }
        }

        private void SetMoskowTimeTick()
        {
            CityesNamesList = clock.GetCityNamesList();

            TimeSpan MoscowTime = MoskowClock.GetTimeCityNow("Москва");
            lab_MoscowLargeTime.Text = MoscowTime.Hours.ToString() +":"+ MoscowTime.Minutes.ToString()+":"+ MoscowTime.Seconds.ToString();

        }
        private void SetLondonTimeTick()
        {
            CityesNamesList = clock.GetCityNamesList();
   
            TimeSpan LondonTime = LondonClock.GetTimeCityNow("Лондон");
            lab_LondonLargeTime.Text = LondonTime.Hours.ToString() + ":" + LondonTime.Minutes.ToString() + ":" + LondonTime.Seconds.ToString();

        }
        private void SetVladivostokTimeTick()
        {
            CityesNamesList = clock.GetCityNamesList();

            TimeSpan VladivostokTime = VladivostokClock.GetTimeCityNow("Владивосток");
            lab_VladovostokLagreTime.Text = VladivostokTime.Hours.ToString() + ":" + VladivostokTime.Minutes.ToString() + ":" + VladivostokTime.Seconds.ToString();

        }

        private void UpdateComboBoxItem()
        {
            cb_CityList.DataBindings.Clear();
            cb_CityList.DataSource = CityesNamesList;

        }

        public void SetLableTime(TimeSpan time,string CityName) 
        {
            lab_NewCityName.Text = CityName;
            lab_NewCItyLargeTime.Text = time.Hours.ToString() + ":" + time.Minutes.ToString() + ":" + time.Seconds.ToString();

        }

        private void cb_CityList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CityName = cb_CityList.SelectedItem.ToString();

        }

        private void btn_AddCity_Click(object sender, EventArgs e)
        {
            SetVisibleTrueFoNewElem();

        }

        private void cb_SetHours_SelectedIndexChanged(object sender, EventArgs e)
        {
            SlectNewTime = new TimeSpan(Convert.ToInt32(cb_SetHours.SelectedItem), 0, 0);

        }

        private void btn_Complet_Click(object sender, EventArgs e)
        {
            if (tb_CityName.Text == "")
            {
                MessageBox.Show("Ведите город");

            }
            else
           if (SlectNewTime == null)
            {
                MessageBox.Show("Выберте час");

            }
            else
            {
                clock.AddCity(tb_CityName.Text, SlectNewTime);
                SetVisibleFalseFoNewElem();
            }

        }

        private void SetVisibleTrueFoNewElem()
        {
            tb_CityName.Visible = true;
            cb_SetHours.Visible = true;
            lab_enterCity.Visible = true;
            lab_enterTime.Visible = true;
            lab_Hours.Visible = true;
            btn_Complet.Visible = true;
            this.Height = 840;
        }
        private void SetVisibleFalseFoNewElem()
        {
            tb_CityName.Visible = false;
            cb_SetHours.Visible = false;
            lab_enterCity.Visible = false;
            lab_enterTime.Visible = false;
            lab_Hours.Visible = false;
            btn_Complet.Visible = false;
            this.Height = 690;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Height = 690;
            MoskowClock.AddCity("Москва", new TimeSpan(0, 0, 0));
            LondonClock.AddCity("Лондон", new TimeSpan(22, 0, 0));
            VladivostokClock.AddCity("Владивосток", new TimeSpan(7, 0, 0));
        }

        private void btn_StartClockTimer_Click(object sender, EventArgs e)
        {
            MoskowClock.StartTimer();
            LondonClock.StartTimer();
            VladivostokClock.StartTimer();
        }
        private void btn_StopClockTimer_Click(object sender, EventArgs e)
        {
            MoskowClock.StopTimer();
            LondonClock.StopTimer();
            VladivostokClock.StopTimer();
        }
        private void btnStopTimer_click(object sender, EventArgs e) => clock.StopTimer();
        private void btnStartTimer_Click(object sender, EventArgs e) => clock.StartTimer();
        private void numeric_SelectSecondInterval_ValueChanged(object sender, EventArgs e)
        {
            clock.SetTimerInterval(Convert.ToInt32(numeric_SelectSecondInterval.Value));
        }

        private void HotKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                clock.StartTimer();
                MoskowClock.StartTimer();
                LondonClock.StartTimer();
                VladivostokClock.StartTimer();

            }
            if (e.Control && e.KeyCode == Keys.C)
            {
                clock.StopTimer();
                MoskowClock.StopTimer();
                LondonClock.StopTimer();
                VladivostokClock.StopTimer();

            }
        }

        private void numeric_MoskowInterval_ValueChanged(object sender, EventArgs e)
        {
            MoskowClock.SetTimerInterval(Convert.ToInt32(numeric_MoskowInterval.Value));
        }

        private void numeric_LondonInterval_ValueChanged(object sender, EventArgs e)
        {
            LondonClock.SetTimerInterval(Convert.ToInt32(numeric_LondonInterval.Value));
        }

        private void numeric_VladivostocInterval_ValueChanged(object sender, EventArgs e)
        {
            LondonClock.SetTimerInterval(Convert.ToInt32(numeric_VladivostocInterval.Value));
        }
    }
    
}
