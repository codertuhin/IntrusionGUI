using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

using System.Timers;
using System.Windows;
using System.Windows.Controls;



namespace Ofir_Shtainfeld
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : UserControl
    {
        #region Fields
        protected static PerformanceCounter cpuCounter;
        protected static PerformanceCounter ramCounter;
        #endregion

        #region Constructor
        public MainPage()
        {
            InitializeComponent();

            //Initilize ViewModel
            var model = new MainPageViewModel();

            tButton4.IsChecked = model.Channel1_SelectedAlerts.First != os.model.AlertType.None;
            tButton5.IsChecked = model.Channel1_SelectedAlerts.Second != os.model.AlertType.None;
            tButton6.IsChecked = model.Channel1_SelectedAlerts.Third != os.model.AlertType.None;

            tButton1.IsChecked = model.Channel2_SelectedAlerts.First != os.model.AlertType.None;
            tButton2.IsChecked = model.Channel2_SelectedAlerts.Second != os.model.AlertType.None;
            tButton3.IsChecked = model.Channel2_SelectedAlerts.Third != os.model.AlertType.None;

            this.DataContext = model;


            GetSystemStat();

            //Get system culture information
            var culture = CultureInfo.GetCultureInfo("en-US");

            Dispatcher.Thread.CurrentCulture = culture;
            Dispatcher.Thread.CurrentUICulture = culture;


            

        }

        #endregion
        
        #region Get System Status

        /// <summary>
        /// Gets Processor and Memory consumption
        /// </summary>
        void GetSystemStat()
        {

            Process p = Process.GetCurrentProcess(); /*get the desired process here*/
            ramCounter = new PerformanceCounter("Process", "Working Set", p.ProcessName);
            cpuCounter = new PerformanceCounter("Process", "% Processor Time", p.ProcessName);

            try
            {
                Timer t = new Timer(1200);
                t.Elapsed += new ElapsedEventHandler(TimerElapsed);
                t.Start();
               
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            
        }



        public void TimerElapsed(object source, ElapsedEventArgs e)
        {
           
            double ram = ramCounter.NextValue();
            double cpu = cpuCounter.NextValue();
           

            this.Dispatcher.Invoke(() =>
            {
                label_cpu.Content = string.Format("CPU: {0}%", Math.Round(cpu));
                label_ram.Content = string.Format("RAM: {0}MB", Math.Round(ram/1024/1024));
            });


            
        }

        #endregion



    }
}
