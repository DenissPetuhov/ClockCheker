namespace ClockCheker
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LargeNameApp = new System.Windows.Forms.Label();
            this.lab_MoscowLargeTime = new System.Windows.Forms.Label();
            this.cb_CityList = new System.Windows.Forms.ComboBox();
            this.btn_AddCity = new System.Windows.Forms.Button();
            this.cb_SetHours = new System.Windows.Forms.ComboBox();
            this.lab_Hours = new System.Windows.Forms.Label();
            this.lab_enterTime = new System.Windows.Forms.Label();
            this.lab_enterCity = new System.Windows.Forms.Label();
            this.tb_CityName = new System.Windows.Forms.TextBox();
            this.btn_Complet = new System.Windows.Forms.Button();
            this.lab_MoscowName = new System.Windows.Forms.Label();
            this.lab_LondonName = new System.Windows.Forms.Label();
            this.lab_LondonLargeTime = new System.Windows.Forms.Label();
            this.Lab_VladivostokName = new System.Windows.Forms.Label();
            this.lab_VladovostokLagreTime = new System.Windows.Forms.Label();
            this.lab_NewCityName = new System.Windows.Forms.Label();
            this.lab_NewCItyLargeTime = new System.Windows.Forms.Label();
            this.btnStopTImer = new System.Windows.Forms.Button();
            this.btnStartTImer = new System.Windows.Forms.Button();
            this.btn_StopClockTimer = new System.Windows.Forms.Button();
            this.btn_StartClockTimer = new System.Windows.Forms.Button();
            this.numeric_SelectSecondInterval = new System.Windows.Forms.NumericUpDown();
            this.lab_SelectSecondIntervalTime = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_SelectSecondInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Name = "panel1";
            // 
            // LargeNameApp
            // 
            resources.ApplyResources(this.LargeNameApp, "LargeNameApp");
            this.LargeNameApp.Name = "LargeNameApp";
            // 
            // lab_MoscowLargeTime
            // 
            resources.ApplyResources(this.lab_MoscowLargeTime, "lab_MoscowLargeTime");
            this.lab_MoscowLargeTime.Name = "lab_MoscowLargeTime";
            // 
            // cb_CityList
            // 
            resources.ApplyResources(this.cb_CityList, "cb_CityList");
            this.cb_CityList.FormattingEnabled = true;
            this.cb_CityList.Name = "cb_CityList";
            this.cb_CityList.SelectedIndexChanged += new System.EventHandler(this.cb_CityList_SelectedIndexChanged);
            // 
            // btn_AddCity
            // 
            resources.ApplyResources(this.btn_AddCity, "btn_AddCity");
            this.btn_AddCity.Name = "btn_AddCity";
            this.btn_AddCity.UseVisualStyleBackColor = true;
            this.btn_AddCity.Click += new System.EventHandler(this.btn_AddCity_Click);
            // 
            // cb_SetHours
            // 
            resources.ApplyResources(this.cb_SetHours, "cb_SetHours");
            this.cb_SetHours.FormattingEnabled = true;
            this.cb_SetHours.Items.AddRange(new object[] {
            resources.GetString("cb_SetHours.Items"),
            resources.GetString("cb_SetHours.Items1"),
            resources.GetString("cb_SetHours.Items2"),
            resources.GetString("cb_SetHours.Items3"),
            resources.GetString("cb_SetHours.Items4"),
            resources.GetString("cb_SetHours.Items5"),
            resources.GetString("cb_SetHours.Items6"),
            resources.GetString("cb_SetHours.Items7"),
            resources.GetString("cb_SetHours.Items8"),
            resources.GetString("cb_SetHours.Items9"),
            resources.GetString("cb_SetHours.Items10"),
            resources.GetString("cb_SetHours.Items11"),
            resources.GetString("cb_SetHours.Items12"),
            resources.GetString("cb_SetHours.Items13"),
            resources.GetString("cb_SetHours.Items14"),
            resources.GetString("cb_SetHours.Items15"),
            resources.GetString("cb_SetHours.Items16"),
            resources.GetString("cb_SetHours.Items17"),
            resources.GetString("cb_SetHours.Items18"),
            resources.GetString("cb_SetHours.Items19"),
            resources.GetString("cb_SetHours.Items20"),
            resources.GetString("cb_SetHours.Items21"),
            resources.GetString("cb_SetHours.Items22"),
            resources.GetString("cb_SetHours.Items23")});
            this.cb_SetHours.Name = "cb_SetHours";
            this.cb_SetHours.SelectedIndexChanged += new System.EventHandler(this.cb_SetHours_SelectedIndexChanged);
            // 
            // lab_Hours
            // 
            resources.ApplyResources(this.lab_Hours, "lab_Hours");
            this.lab_Hours.Name = "lab_Hours";
            // 
            // lab_enterTime
            // 
            resources.ApplyResources(this.lab_enterTime, "lab_enterTime");
            this.lab_enterTime.Name = "lab_enterTime";
            // 
            // lab_enterCity
            // 
            resources.ApplyResources(this.lab_enterCity, "lab_enterCity");
            this.lab_enterCity.Name = "lab_enterCity";
            // 
            // tb_CityName
            // 
            resources.ApplyResources(this.tb_CityName, "tb_CityName");
            this.tb_CityName.Name = "tb_CityName";
            // 
            // btn_Complet
            // 
            resources.ApplyResources(this.btn_Complet, "btn_Complet");
            this.btn_Complet.Name = "btn_Complet";
            this.btn_Complet.UseVisualStyleBackColor = true;
            this.btn_Complet.Click += new System.EventHandler(this.btn_Complet_Click);
            // 
            // lab_MoscowName
            // 
            resources.ApplyResources(this.lab_MoscowName, "lab_MoscowName");
            this.lab_MoscowName.Name = "lab_MoscowName";
            // 
            // lab_LondonName
            // 
            resources.ApplyResources(this.lab_LondonName, "lab_LondonName");
            this.lab_LondonName.Name = "lab_LondonName";
            // 
            // lab_LondonLargeTime
            // 
            resources.ApplyResources(this.lab_LondonLargeTime, "lab_LondonLargeTime");
            this.lab_LondonLargeTime.Name = "lab_LondonLargeTime";
            // 
            // Lab_VladivostokName
            // 
            resources.ApplyResources(this.Lab_VladivostokName, "Lab_VladivostokName");
            this.Lab_VladivostokName.Name = "Lab_VladivostokName";
            // 
            // lab_VladovostokLagreTime
            // 
            resources.ApplyResources(this.lab_VladovostokLagreTime, "lab_VladovostokLagreTime");
            this.lab_VladovostokLagreTime.Name = "lab_VladovostokLagreTime";
            // 
            // lab_NewCityName
            // 
            resources.ApplyResources(this.lab_NewCityName, "lab_NewCityName");
            this.lab_NewCityName.Name = "lab_NewCityName";
            // 
            // lab_NewCItyLargeTime
            // 
            resources.ApplyResources(this.lab_NewCItyLargeTime, "lab_NewCItyLargeTime");
            this.lab_NewCItyLargeTime.Name = "lab_NewCItyLargeTime";
            // 
            // btnStopTImer
            // 
            resources.ApplyResources(this.btnStopTImer, "btnStopTImer");
            this.btnStopTImer.Name = "btnStopTImer";
            this.btnStopTImer.UseVisualStyleBackColor = true;
            this.btnStopTImer.Click += new System.EventHandler(this.btnStopTimer_click);
            // 
            // btnStartTImer
            // 
            resources.ApplyResources(this.btnStartTImer, "btnStartTImer");
            this.btnStartTImer.Name = "btnStartTImer";
            this.btnStartTImer.UseVisualStyleBackColor = true;
            this.btnStartTImer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // btn_StopClockTimer
            // 
            resources.ApplyResources(this.btn_StopClockTimer, "btn_StopClockTimer");
            this.btn_StopClockTimer.Name = "btn_StopClockTimer";
            this.btn_StopClockTimer.UseVisualStyleBackColor = true;
            this.btn_StopClockTimer.Click += new System.EventHandler(this.btn_StopClockTimer_Click);
            // 
            // btn_StartClockTimer
            // 
            resources.ApplyResources(this.btn_StartClockTimer, "btn_StartClockTimer");
            this.btn_StartClockTimer.Name = "btn_StartClockTimer";
            this.btn_StartClockTimer.UseVisualStyleBackColor = true;
            this.btn_StartClockTimer.Click += new System.EventHandler(this.btn_StartClockTimer_Click);
            // 
            // numeric_SelectSecondInterval
            // 
            resources.ApplyResources(this.numeric_SelectSecondInterval, "numeric_SelectSecondInterval");
            this.numeric_SelectSecondInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_SelectSecondInterval.Name = "numeric_SelectSecondInterval";
            this.numeric_SelectSecondInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_SelectSecondInterval.ValueChanged += new System.EventHandler(this.numeric_SelectSecondInterval_ValueChanged);
            // 
            // lab_SelectSecondIntervalTime
            // 
            resources.ApplyResources(this.lab_SelectSecondIntervalTime, "lab_SelectSecondIntervalTime");
            this.lab_SelectSecondIntervalTime.Name = "lab_SelectSecondIntervalTime";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lab_SelectSecondIntervalTime);
            this.Controls.Add(this.numeric_SelectSecondInterval);
            this.Controls.Add(this.btn_StopClockTimer);
            this.Controls.Add(this.btn_StartClockTimer);
            this.Controls.Add(this.btnStopTImer);
            this.Controls.Add(this.btnStartTImer);
            this.Controls.Add(this.lab_NewCityName);
            this.Controls.Add(this.lab_NewCItyLargeTime);
            this.Controls.Add(this.Lab_VladivostokName);
            this.Controls.Add(this.lab_VladovostokLagreTime);
            this.Controls.Add(this.lab_LondonName);
            this.Controls.Add(this.lab_LondonLargeTime);
            this.Controls.Add(this.lab_MoscowName);
            this.Controls.Add(this.btn_Complet);
            this.Controls.Add(this.cb_SetHours);
            this.Controls.Add(this.lab_Hours);
            this.Controls.Add(this.lab_enterTime);
            this.Controls.Add(this.lab_enterCity);
            this.Controls.Add(this.tb_CityName);
            this.Controls.Add(this.btn_AddCity);
            this.Controls.Add(this.cb_CityList);
            this.Controls.Add(this.lab_MoscowLargeTime);
            this.Controls.Add(this.LargeNameApp);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_SelectSecondInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LargeNameApp;
        private System.Windows.Forms.Label lab_MoscowLargeTime;
        private System.Windows.Forms.ComboBox cb_CityList;
        private System.Windows.Forms.Button btn_AddCity;
        private System.Windows.Forms.ComboBox cb_SetHours;
        private System.Windows.Forms.Label lab_Hours;
        private System.Windows.Forms.Label lab_enterTime;
        private System.Windows.Forms.Label lab_enterCity;
        private System.Windows.Forms.TextBox tb_CityName;
        private System.Windows.Forms.Button btn_Complet;
        private System.Windows.Forms.Label lab_MoscowName;
        private System.Windows.Forms.Label lab_LondonName;
        private System.Windows.Forms.Label lab_LondonLargeTime;
        private System.Windows.Forms.Label Lab_VladivostokName;
        private System.Windows.Forms.Label lab_VladovostokLagreTime;
        private System.Windows.Forms.Label lab_NewCityName;
        private System.Windows.Forms.Label lab_NewCItyLargeTime;
        private System.Windows.Forms.Button btnStopTImer;
        private System.Windows.Forms.Button btnStartTImer;
        private System.Windows.Forms.Button btn_StopClockTimer;
        private System.Windows.Forms.Button btn_StartClockTimer;
        private System.Windows.Forms.NumericUpDown numeric_SelectSecondInterval;
        private System.Windows.Forms.Label lab_SelectSecondIntervalTime;
    }
}

