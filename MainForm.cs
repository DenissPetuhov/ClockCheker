using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockCheker
{
    public partial class MainForm : Form
    {
        Clock clock = new Clock();
        List<string> CityesNamesList;
        TimeSpan SlectNewTime;
        Timer timer = new Timer()
        {
            Interval = 1000,
            Enabled = false
            
        };
      
        private string CityName;
     
        public MainForm()
        {
            InitializeComponent();
            
            CityesNamesList = clock.GetCityNamesList();
          
        
        clock.SeconTick += SetTimeTick;
        timer.Tick += SetSelectTimerTick;

        }
        private void SetSelectTimerTick(object sender, EventArgs e)
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

            TimeSpan MoscowTime = clock.GetTimeCityNow("Москва");
            lab_MoscowLargeTime.Text = MoscowTime.Hours.ToString() +":"+ MoscowTime.Minutes.ToString()+":"+ MoscowTime.Seconds.ToString();

            TimeSpan LondonTime = clock.GetTimeCityNow("Лондон");
            lab_LondonLargeTime.Text = LondonTime.Hours.ToString() + ":" + LondonTime.Minutes.ToString() + ":" + LondonTime.Seconds.ToString();

            TimeSpan VladivostokTime = clock.GetTimeCityNow("Владивосток");
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
            clock.AddCity("Москва", new TimeSpan(0, 0, 0));
            clock.AddCity("Лондон", new TimeSpan(22, 0, 0));
            clock.AddCity("Владивосток", new TimeSpan(7, 0, 0));
        }

        private void cb_SelectIntervalUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_SelectIntervalUpdate.SelectedIndex == 0)
            {
                timer.Interval = 1000;
            }else if(cb_SelectIntervalUpdate.SelectedIndex == 1)
            {
                timer.Interval = 10000;
            }else if(cb_SelectIntervalUpdate.SelectedIndex == 2)
            {
                timer.Interval = 30000;
            }
        }

        private void btn_StartClockTimer_Click(object sender, EventArgs e) => clock.StartTimer();


        private void btn_StopClockTimer_Click(object sender, EventArgs e) => clock.StopTimer();
        private void btnStopTimer_click(object sender, EventArgs e) => timer.Stop();

        private void btnStartTimer_Click(object sender, EventArgs e) => timer.Start();

    
    }
}
