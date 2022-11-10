using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClockCheker
{
    public partial class MainForm : Form
    {
        Clock defaultClock = new Clock();
        Clock clock = new Clock();
        List<string> CityesNamesList;
        TimeSpan SlectNewTime;
        private string CityName;
     
        public MainForm()
        {
            InitializeComponent();
            
            CityesNamesList = clock.GetCityNamesList();
            defaultClock.SeconTick += SetTimeTick;
            clock.SeconTick += SetSelectTimerTick;

        }

        private void SetSelectTimerTick()
        {
            if(CityName != null)
            {
                TimeSpan time = clock.GetTimeCityNow(CityName);
                SetLableTime(time, CityName);
            }
            
        }

        private void SetTimeTick()
        {
            CityesNamesList = clock.GetCityNamesList();

            TimeSpan MoscowTime = defaultClock.GetTimeCityNow("Москва");
            lab_MoscowLargeTime.Text = MoscowTime.Hours.ToString() +":"+ MoscowTime.Minutes.ToString()+":"+ MoscowTime.Seconds.ToString();

            TimeSpan LondonTime = defaultClock.GetTimeCityNow("Лондон");
            lab_LondonLargeTime.Text = LondonTime.Hours.ToString() + ":" + LondonTime.Minutes.ToString() + ":" + LondonTime.Seconds.ToString();

            TimeSpan VladivostokTime = defaultClock.GetTimeCityNow("Владивосток");
            lab_VladovostokLagreTime.Text = VladivostokTime.Hours.ToString() + ":" + VladivostokTime.Minutes.ToString() + ":" + VladivostokTime.Seconds.ToString();

            if (cb_CityList.Items.Count != CityesNamesList.Count)
            {
                UpdateComboBoxItem();
            }

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
            defaultClock.AddCity("Москва", new TimeSpan(0, 0, 0));
            defaultClock.AddCity("Лондон", new TimeSpan(22, 0, 0));
            defaultClock.AddCity("Владивосток", new TimeSpan(7, 0, 0));
        }

        private void btn_StartClockTimer_Click(object sender, EventArgs e) => defaultClock.StartTimer();
        private void btn_StopClockTimer_Click(object sender, EventArgs e) => defaultClock.StopTimer();
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
                defaultClock.StartTimer();

            }
            if (e.Control && e.KeyCode == Keys.C)
            {
                clock.StopTimer();
                defaultClock.StopTimer();

            }
        }
    }
}
