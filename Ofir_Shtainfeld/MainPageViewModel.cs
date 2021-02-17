using Ofir_Shtainfeld.os.model;
//using Shared_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Input;

namespace Ofir_Shtainfeld
{
    public class MainPageViewModel : INotifyPropertyChanged
    {


        #region Fields


        ICommand _SettingsButtonCommand;
        ICommand _MainButtonCommand;
        ICommand _PlaybackButtonCommand;


        ICommand _IsRecording_Left_Command;
        ICommand _IsRecording_Right_Command;


        ICommand _Channel1_First_AlertCommand;
        ICommand _Channel1_Second_AlertCommand;
        ICommand _Channel1_Third_AlertCommand;

        ICommand _Channel2_First_AlertCommand;
        ICommand _Channel2_Second_AlertCommand;
        ICommand _Channel2_Third_AlertCommand;


        ICommand _Channel1_Playback_Command;
        ICommand _Channel2_Playback_Command;


        private bool canExecute = true;

        private bool canMainButtonExecute = false;


        UI_Channel_Display Channel1;
        UI_Channel_Display Channel2;


        #endregion


        #region Constructors
        public MainPageViewModel()
        {
            //Get Channels//
            var channels = Data_CRUD.GetChannels();
            Channel1 = channels[0] as UI_Channel_Display;
            Channel2 = channels[1] as UI_Channel_Display;



            MainButtonCommand = new MainPageCommand(MainButtonExecuted, param => this.CanMainButtonExecute);

            SettingsButtonCommand = new MainPageCommand(SettingsButtonExecuted, param => this.canExecute);
            PlaybackButtonCommand = new MainPageCommand(PlaybackButtonExecuted, param => this.canExecute);

            IsRecordingLeft_Command = new MainPageCommand(IsRecordingLeftExecuted, param => this.CanExecute);
            IsRecordingRight_Command = new MainPageCommand(IsRecordingRightExecuted, param => this.CanExecute);


            Channel1FirstAlertCommand = new MainPageCommand(Channel1FirstAlertCommand_Executed, param => this.canExecute);
            Channel1SecondAlertCommand = new MainPageCommand(Channel1SecondAlertCommand_Executed, param => this.canExecute);
            Channel1ThirdAlertCommand = new MainPageCommand(Channel1ThirdAlertCommand_Executed, param => this.canExecute);

            Channel2FirstAlertCommand = new MainPageCommand(Channel2FirstAlertCommand_Executed, param => this.canExecute);
            Channel2SecondAlertCommand = new MainPageCommand(Channe21SecondAlertCommand_Executed, param => this.canExecute);
            Channel2ThirdAlertCommand = new MainPageCommand(Channel2ThirdAlertCommand_Executed, param => this.canExecute);


            Channel1_Playback_Command = new MainPageCommand(Channel1_Playback_Command_Executed, param => this.canExecute);
            Channel2_Playback_Command = new MainPageCommand(Channel2_Playback_Command_Executed, param => this.canExecute);


        }

        #endregion


        #region Properties Channel 1

        public string Channel1_Description
        {
            get
            {
                return Channel1.Description;
            }
            set
            {
                if (Channel1.Description != value)
                {
                    Channel1.Description = value;
                    InvokePropertyChanged("Channel1_Description");
                }
            }
        }

        public string Channel1_Name
        {
            get
            {
                return Channel1.Name;
            }
            set
            {
                if (Channel1.Name != value)
                {
                    Channel1.Name = value;
                    InvokePropertyChanged("Channel1_Name");
                }
            }
        }

        public int Channel1_ID
        {
            get
            {
                return Channel1.ID;
            }
            set
            {
                if (Channel1.ID != value)
                {
                    Channel1.ID = value;
                    InvokePropertyChanged("Channel1_ID");
                }
            }
        }

        public bool Channel1_IsConnected
        {
            get
            {
                return Channel1.IsConnected;
            }
            set
            {
                if (Channel1.IsConnected != value)
                {
                    Channel1.IsConnected = value;
                    InvokePropertyChanged("Channel1_IsConnected");
                }
            }
        }

        public byte[] Channel1_Image
        {
            get
            {
                return Channel1.Image;
            }
            set
            {
                if (Channel1.Image != value)
                {
                    Channel1.Image = value;
                    InvokePropertyChanged("Channel1_Image");
                }
            }
        }

        public bool Channel1_IsInDB
        {
            get
            {
                return Channel1.IsInDB;
            }
            set
            {
                if (Channel1.IsInDB != value)
                {
                    Channel1.IsInDB = value;
                    InvokePropertyChanged("Channel1_IsInDB");
                }
            }
        }

        public bool Channel1_IsRecording
        {
            get
            {
                return Channel1.IsRecording;
            }
            set
            {


                if (Channel1.IsRecording != value)
                {
                    Channel1.IsRecording = value;
                    InvokePropertyChanged("Channel1_IsRecording");
                }
            }
        }

        public List<Status> Channel1_LastAlert
        {
            get
            {
                return Channel1.Last_Alert.OrderByDescending(v => v.Date).ToList();
            }
            set
            {
                if (Channel1.Last_Alert != value)
                {
                    Channel1.Last_Alert = value;
                    InvokePropertyChanged("Channel1_LastAlert");
                }
            }
        }


        public UI_AlertSelection Channel1_SelectedAlerts
        {
            get
            {

                return Channel1.SelectedAlerts;
            }
            set
            {
                if (Channel1.SelectedAlerts != value)
                {
                    Channel1.SelectedAlerts = value;
                    InvokePropertyChanged("Channel1_SelectedAlerts");
                }
            }
        }




        #endregion


        #region Properties Channel 2 
        public string Channel2_Description
        {
            get
            {
                return Channel2.Description;
            }
            set
            {
                if (Channel2.Description != value)
                {
                    Channel2.Description = value;
                    InvokePropertyChanged("Channel2_Description");
                }
            }
        }

        public string Channel2_Name
        {
            get
            {
                return Channel2.Name;
            }
            set
            {
                if (Channel2.Name != value)
                {
                    Channel2.Name = value;
                    InvokePropertyChanged("Channel2_Name");
                }
            }
        }

        public int Channel2_ID
        {
            get
            {
                return Channel2.ID;
            }
            set
            {
                if (Channel2.ID != value)
                {
                    Channel2.ID = value;
                    InvokePropertyChanged("Channel2_ID");
                }
            }
        }

        public bool Channel2_IsConnected
        {
            get
            {
                return Channel2.IsConnected;
            }
            set
            {
                if (Channel2.IsConnected != value)
                {
                    Channel2.IsConnected = value;
                    InvokePropertyChanged("Channel2_IsConnected");
                }
            }
        }

        public byte[] Channel2_Image
        {
            get
            {
                return Channel2.Image;
            }
            set
            {
                if (Channel2.Image != value)
                {
                    Channel2.Image = value;
                    InvokePropertyChanged("Channel2_Image");
                }
            }
        }

        public bool Channel2_IsInDB
        {
            get
            {
                return Channel2.IsInDB;
            }
            set
            {
                if (Channel2.IsInDB != value)
                {
                    Channel2.IsInDB = value;
                    InvokePropertyChanged("Channel2_IsInDB");
                }
            }
        }

        public bool Channel2_IsRecording
        {
            get
            {
                return Channel2.IsRecording;
            }
            set
            {


                if (Channel2.IsRecording != value)
                {
                    Channel2.IsRecording = value;
                    InvokePropertyChanged("Channel2_IsRecording");
                }
            }
        }
        public List<Status> Channel2_LastAlert
        {
            get
            {
                return Channel2.Last_Alert.OrderByDescending(v => v.Date).ToList();
            }
            set
            {
                if (Channel2.Last_Alert != value)
                {
                    Channel2.Last_Alert = value;
                    InvokePropertyChanged("Channel2_LastAlert");
                }
            }
        }

        public UI_AlertSelection Channel2_SelectedAlerts
        {
            get
            {

                return Channel2.SelectedAlerts;
            }
            set
            {
                if (Channel2.SelectedAlerts != value)
                {
                    Channel2.SelectedAlerts = value;
                    InvokePropertyChanged("Channel2_SelectedAlerts");
                }
            }
        }
        #endregion


        #region Property
        public event PropertyChangedEventHandler PropertyChanged;
        private void InvokePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion



        #region Commands

        public bool CanExecute
        {
            get
            {
                return this.canExecute;
            }

            set
            {
                if (this.canExecute == value)
                {
                    return;
                }

                this.canExecute = value;
            }
        }

        public bool CanMainButtonExecute
        {
            get
            {
                return this.canMainButtonExecute;
            }

            set
            {
                if (this.canMainButtonExecute == value)
                {
                    return;
                }

                this.canExecute = value;
            }
        }


        /// <summary>
        /// IsRecording command
        /// </summary>
        public ICommand IsRecordingLeft_Command
        {
            get
            {
                return _IsRecording_Left_Command;
            }
            set
            {
                _IsRecording_Left_Command = value;
            }
        }


        public ICommand IsRecordingRight_Command
        {
            get
            {
                return _IsRecording_Right_Command;
            }
            set
            {
                _IsRecording_Right_Command = value;
            }
        }


        public ICommand SettingsButtonCommand
        {
            get
            {
                return _SettingsButtonCommand;
            }
            set
            {
                _SettingsButtonCommand = value;
            }
        }


        public ICommand MainButtonCommand
        {
            get
            {
                return _MainButtonCommand;
            }
            set
            {
                _MainButtonCommand = value;
            }
        }

        public ICommand PlaybackButtonCommand
        {
            get
            {
                return _PlaybackButtonCommand;
            }
            set
            {
                _PlaybackButtonCommand = value;
            }
        }


        public void IsRecordingLeftExecuted(object obj)
        {
            //MessageBox.Show(obj.ToString());

            bool _IsRecording = (bool)obj;

            Channel1.IsRecording = _IsRecording;
            Data_CRUD.UpdateChannelDisplay(Channel1);
        }

        public void IsRecordingRightExecuted(object obj)
        {
            //MessageBox.Show(obj.ToString());

            bool _IsRecording = (bool)obj;

            Channel2.IsRecording = _IsRecording;
            Data_CRUD.UpdateChannelDisplay(Channel2);
        }


        public void MainButtonExecuted(object obj)
        {
            MessageBox.Show("Main Button executed!");



        }


        public void SettingsButtonExecuted(object obj)
        {
            MessageBox.Show("Settings Button executed!");
        }


        public void PlaybackButtonExecuted(object obj)
        {
            //CameraControlWindow _CameraControlWindow = new CameraControlWindow();

            //_CameraControlWindow.Show();


            //var _MainPage = obj as MainPage;

            //(_MainPage.Parent as Shell).Close();

        }

        #endregion



        #region Command Alert Selection

        public ICommand Channel1FirstAlertCommand
        {
            get
            {
                return _Channel1_First_AlertCommand;
            }
            set
            {
                _Channel1_First_AlertCommand = value;
            }
        }
        public ICommand Channel1SecondAlertCommand
        {
            get
            {
                return _Channel1_Second_AlertCommand;
            }
            set
            {
                _Channel1_Second_AlertCommand = value;
            }
        }
        public ICommand Channel1ThirdAlertCommand
        {
            get
            {
                return _Channel1_Third_AlertCommand;
            }
            set
            {
                _Channel1_Third_AlertCommand = value;
            }
        }


        public ICommand Channel2FirstAlertCommand
        {
            get
            {
                return _Channel2_First_AlertCommand;
            }
            set
            {
                _Channel2_First_AlertCommand = value;
            }
        }
        public ICommand Channel2SecondAlertCommand
        {
            get
            {
                return _Channel2_Second_AlertCommand;
            }
            set
            {
                _Channel2_Second_AlertCommand = value;
            }
        }
        public ICommand Channel2ThirdAlertCommand
        {
            get
            {
                return _Channel2_Third_AlertCommand;
            }
            set
            {
                _Channel2_Third_AlertCommand = value;
            }
        }


        #endregion


        #region Commnd Alert Execute
        public void Channel1FirstAlertCommand_Executed(object obj)
        {
            Channel1.SelectedAlerts.First = ((bool)obj) == true ? AlertType.MotionDetection : AlertType.None;
        }

        public void Channel1SecondAlertCommand_Executed(object obj)
        {
            Channel1.SelectedAlerts.Second = ((bool)obj) == true ? AlertType.CameraCover : AlertType.None;
        }

        public void Channel1ThirdAlertCommand_Executed(object obj)
        {
            Channel1.SelectedAlerts.Third = ((bool)obj) == true ? AlertType.CameraDisconnected : AlertType.None;
        }


        public void Channel2FirstAlertCommand_Executed(object obj)
        {
            Channel2.SelectedAlerts.First = ((bool)obj) == true ? AlertType.MotionDetection : AlertType.None;
        }

        public void Channe21SecondAlertCommand_Executed(object obj)
        {
            Channel2.SelectedAlerts.Second = ((bool)obj) == true ? AlertType.CameraCover : AlertType.None;
        }

        public void Channel2ThirdAlertCommand_Executed(object obj)
        {
            Channel2.SelectedAlerts.Third = ((bool)obj) == true ? AlertType.CameraDisconnected : AlertType.None;
        }
        #endregion


        #region ChannelMPlayback Command

        public ICommand Channel1_Playback_Command
        {
            get
            {
                return _Channel1_Playback_Command;
            }
            set
            {
                _Channel1_Playback_Command = value;

            }
        }


        public ICommand Channel2_Playback_Command
        {
            get
            {
                return _Channel2_Playback_Command;
            }
            set
            {
                _Channel2_Playback_Command = value;

            }
        }


        public void Channel2_Playback_Command_Executed(object obj)
        {
            var _MainPage = obj as MainPage;
            _MainPage.Cursor = Cursors.Wait;

            CameraControlWindow _CameraControlWindow = new CameraControlWindow();
            CameraControlPageViewModel.channel = Channel2;


            _CameraControlWindow.Show();


           

            (_MainPage.Parent as Shell).Close();


            _MainPage.Cursor = Cursors.Arrow;
        }

        public void Channel1_Playback_Command_Executed(object obj)
        {
            var _MainPage = obj as MainPage;
            _MainPage.Cursor = Cursors.Wait;

            CameraControlPageViewModel.channel = Channel1;

            CameraControlWindow _CameraControlWindow = new CameraControlWindow();

            _CameraControlWindow.Show();


         

            (_MainPage.Parent as Shell).Close();

            _MainPage.Cursor = Cursors.Arrow;
        }


        #endregion


    }
}
