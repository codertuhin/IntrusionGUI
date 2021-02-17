using Ofir_Shtainfeld.os.model;
//using Shared_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Ofir_Shtainfeld
{
    public class CameraControlPageViewModel : INotifyPropertyChanged
    {

        public static UI_Channel_Display channel;

        #region Fields


        ICommand _TutorialButtonCommand;
        ICommand _BasicButtonCommand;
        ICommand _ControlButtonCommand;
        ICommand _TriggerButtonCommand;
        ICommand _MainButtonCommand;

        ICommand _PTZUpButtonCommand;
        ICommand _PTZDownButtonCommand;
        ICommand _PTZLeftButtonCommand;
        ICommand _PTZRightButtonCommand;

        ICommand _PTZUpRightButtonCommand;
        ICommand _PTZUpLeftButtonCommand;
        ICommand _PTZDownRightButtonCommand;
        ICommand _PTZDownLeftButtonCommand;



        ICommand _PTZZoomInButtonCommand;
        ICommand _PTZZoomOutButtonCommand;
      



        private bool canExecute = true;

        private bool canMainButtonExecute = false;


        UI_PTZ _UI_PTZ;



        #endregion

        #region Constructor
        public CameraControlPageViewModel()
        {
            //Get channels from database//
            var channels = Data_CRUD.GetChannels();

            MainButtonCommand = new MainPageCommand(MainButtonCommandExecuted, param => this.CanExecute);
            BasicButtonCommand = new MainPageCommand(BasicButtonCommandExecuted, param => this.canExecute);
            ControlButtonCommand = new MainPageCommand(ControlButtonCommandExecuted, param => this.canExecute);
            TriggerButtonCommand = new MainPageCommand(TriggerButtonCommandExecuted, param => this.CanExecute);
            TutorialButtonCommand = new MainPageCommand(TutorialButtonCommandExecuted, param => this.CanExecute);


            PTZUpButtonCommand = new MainPageCommand(PTZUpButtonCommandExecuted, param => this.CanExecute);
            PTZDownButtonCommand = new MainPageCommand(PTZDownButtonCommandExecuted, param => this.canExecute);
            PTZLeftButtonCommand = new MainPageCommand(PTZLeftButtonCommandExecuted, param => this.canExecute);
            PTZRightButtonCommand = new MainPageCommand(PTZRightButtonCommandExecuted, param => this.CanExecute);


            PTZUpRightButtonCommand = new MainPageCommand(PTZUpRigntButtonCommandExecuted, param => this.CanExecute);
            PTZUpLeftButtonCommand = new MainPageCommand(PTZUpLeftButtonCommandExecuted, param => this.canExecute);
            PTZDownRightButtonCommand = new MainPageCommand(PTZDownRightButtonCommandExecuted, param => this.canExecute);
            PTZDownLeftButtonCommand = new MainPageCommand(PTZDownLeftButtonCommandExecuted, param => this.CanExecute);




            PTZZoomInButtonCommand = new MainPageCommand(PTZZoomInButtonCommandExecuted, param => this.CanExecute);
            PTZZoomOutButtonCommand = new MainPageCommand(PTZZoomOutButtonCommandExecuted, param => this.CanExecute);


            _UI_PTZ = new  UI_PTZ();

        }

        #endregion


        #region Properties

        public PTZDirection Direction
        {
            get
            {
                return _UI_PTZ.Direction;
            }
            set
            {
                if (_UI_PTZ.Direction != value)
                {
                    _UI_PTZ.Direction = value;
                    InvokePropertyChanged("Direction");
                }
            }
        }


        public PTZoom Zoom
        {
            get
            {
                return _UI_PTZ.Zoom;
            }
            set
            {
                if (_UI_PTZ.Zoom != value)
                {
                    _UI_PTZ.Zoom = value;
                    InvokePropertyChanged("Zoom");
                }
            }
        }


        public bool Enabled
        {
            get
            {
                return _UI_PTZ.Enabled;
            }
            set
            {
                if (_UI_PTZ.Enabled != value)
                {
                    _UI_PTZ.Enabled = value;
                    InvokePropertyChanged("Enabled");
                }
            }
        }



        //Testing purpose only Property//
        //
        


        public event PropertyChangedEventHandler PropertyChanged;
        private void InvokePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        #endregion

        #region Channel Properties
        public List<Status> ChannelLastAlert
        {
            get
            {
                return channel.Last_Alert.OrderByDescending(v => v.Date).ToList();
            }
            set
            {
                if (channel.Last_Alert != value)
                {
                    channel.Last_Alert = value;
                    InvokePropertyChanged("ChannelLastAlert");
                }
            }
        }


        public string ChannelDescription
        {
            get
            {
                return channel.Description;
            }
            set
            {
                if (channel.Description != value)
                {
                    channel.Description = value;
                    InvokePropertyChanged("ChannelDescription");
                }
            }
        }

        public string ChannelName
        {
            get
            {
                return channel.Name;
            }
            set
            {
                if (channel.Name != value)
                {
                    channel.Name = value;
                    InvokePropertyChanged("ChannelName");
                }
            }
        }

        public int ChannelID
        {
            get
            {
                return channel.ID;
            }
            set
            {
                if (channel.ID != value)
                {
                    channel.ID = value;
                    InvokePropertyChanged("ChannelID");
                }
            }
        }

        public bool ChannelIsConnected
        {
            get
            {
                return channel.IsConnected;
            }
            set
            {
                if (channel.IsConnected != value)
                {
                    channel.IsConnected = value;
                    InvokePropertyChanged("ChannelIsConnected");
                }
            }
        }

        public byte[] ChannelImage
        {
            get
            {
                return channel.Image;
            }
            set
            {
                if (channel.Image != value)
                {
                    channel.Image = value;
                    InvokePropertyChanged("ChannelImage");
                }
            }
        }

        public bool ChannelIsInDB
        {
            get
            {
                return channel.IsInDB;
            }
            set
            {
                if (channel.IsInDB != value)
                {
                    channel.IsInDB = value;
                    InvokePropertyChanged("ChannelIsInDB");
                }
            }
        }

        public bool ChannelIsRecording
        {
            get
            {
                return channel.IsRecording;
            }
            set
            {


                if (channel.IsRecording != value)
                {
                    channel.IsRecording = value;
                    InvokePropertyChanged("ChannelIsRecording");
                }
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




       
        public ICommand TutorialButtonCommand
        {
            get
            {
                return _TutorialButtonCommand;
            }
            set
            {
                _TutorialButtonCommand = value;
            }
        }


        public ICommand BasicButtonCommand
        {
            get
            {
                return _BasicButtonCommand;
            }
            set
            {
                _BasicButtonCommand = value;
            }
        }


        public ICommand ControlButtonCommand
        {
            get
            {
                return _ControlButtonCommand;
            }
            set
            {
                _ControlButtonCommand = value;
            }
        }



        public ICommand TriggerButtonCommand
        {
            get
            {
                return _TriggerButtonCommand;
            }
            set
            {
                _TriggerButtonCommand = value;
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

        public void TutorialButtonCommandExecuted(object obj)
        {
            MessageBox.Show("TutorialButtonCommandExecuted Button executed!");
        }


        public void BasicButtonCommandExecuted(object obj)
        {
            MessageBox.Show("BasicButtonCommandExecuted Button executed!");
        }


        public void ControlButtonCommandExecuted(object obj)
        {
            MessageBox.Show("ControlButtonCommandExecuted Button executed!");
        }


        public void TriggerButtonCommandExecuted(object obj)
        {
            MessageBox.Show("TriggerButtonCommandExecuted Button executed!");
        }

        public void MainButtonCommandExecuted(object obj)
        {
            //MessageBox.Show("MainButtonCommandExecuted Button executed!");

            Shell _MainPageWindow = new Shell();

            _MainPageWindow.Show();


            var _CameraControlPage = obj as CameraControl2;

            (_CameraControlPage.Parent as CameraControlWindow).Close();

        }

        #region Command Execute
        public void PTZUpButtonCommandExecuted(object obj)
        {
            //MessageBox.Show("PTZUpButtonCommandExecuted Button executed!");
            _UI_PTZ.Direction = PTZDirection.Up;
            _UI_PTZ.Zoom = PTZoom.None;


            Data_CRUD.UpdateChannelDisplay(_UI_PTZ);
        }
        public void PTZDownButtonCommandExecuted(object obj)
        {
            //MessageBox.Show("PTZDownButtonCommandExecuted Button executed!");
            _UI_PTZ.Direction = PTZDirection.Down;
            _UI_PTZ.Zoom = PTZoom.None;
            Data_CRUD.UpdateChannelDisplay(_UI_PTZ);
        }
        public void PTZLeftButtonCommandExecuted(object obj)
        {
            //MessageBox.Show("PTZLeftButtonCommandExecuted Button executed!");
            _UI_PTZ.Direction = PTZDirection.Left;
            _UI_PTZ.Zoom = PTZoom.None;
            Data_CRUD.UpdateChannelDisplay(_UI_PTZ);
        }
        public void PTZRightButtonCommandExecuted(object obj)
        {
            //MessageBox.Show("PTZRightButtonCommandExecuted Button executed!");
            _UI_PTZ.Direction = PTZDirection.Right;
            _UI_PTZ.Zoom = PTZoom.None;
            Data_CRUD.UpdateChannelDisplay(_UI_PTZ);
        }
        

        public void PTZUpRigntButtonCommandExecuted(object obj)
        {
            //MessageBox.Show("PTZRightButtonCommandExecuted Button executed!");
            _UI_PTZ.Direction = PTZDirection.UpRignt;
            _UI_PTZ.Zoom = PTZoom.None;
            Data_CRUD.UpdateChannelDisplay(_UI_PTZ);
        }
        public void PTZUpLeftButtonCommandExecuted(object obj)
        {
            //MessageBox.Show("PTZRightButtonCommandExecuted Button executed!");
            _UI_PTZ.Direction = PTZDirection.UpLeft;
            _UI_PTZ.Zoom = PTZoom.None;
            Data_CRUD.UpdateChannelDisplay(_UI_PTZ);
        }
        public void PTZDownRightButtonCommandExecuted(object obj)
        {
            //MessageBox.Show("PTZRightButtonCommandExecuted Button executed!");
            _UI_PTZ.Direction = PTZDirection.DownRight;
            _UI_PTZ.Zoom = PTZoom.None;
            Data_CRUD.UpdateChannelDisplay(_UI_PTZ);
        }
        public void PTZDownLeftButtonCommandExecuted(object obj)
        {
            //MessageBox.Show("PTZRightButtonCommandExecuted Button executed!");
            _UI_PTZ.Direction = PTZDirection.DownLeft;
            _UI_PTZ.Zoom = PTZoom.None;
            Data_CRUD.UpdateChannelDisplay(_UI_PTZ);
        }


        public void PTZZoomInButtonCommandExecuted(object obj)
        {
            //MessageBox.Show("PTZZoomInButtonCommandExecuted Button executed!");
            _UI_PTZ.Zoom = PTZoom.In;
            _UI_PTZ.Direction = PTZDirection.None;

            Data_CRUD.UpdateChannelDisplay(_UI_PTZ);
        }

        public void PTZZoomOutButtonCommandExecuted(object obj)
        {
            //MessageBox.Show("PTZZoomOutButtonCommandExecuted Button executed!");
            _UI_PTZ.Zoom = PTZoom.Out;
            _UI_PTZ.Direction = PTZDirection.None;
            Data_CRUD.UpdateChannelDisplay(_UI_PTZ);
        }

        #endregion



        #endregion


        #region PTZ Commands


        public ICommand PTZUpButtonCommand
        {
            get
            {
                return _PTZUpButtonCommand;
            }
            set
            {
                _PTZUpButtonCommand = value;
            }
        }


        public ICommand PTZDownButtonCommand
        {
            get
            {
                return _PTZDownButtonCommand;
            }
            set
            {
                _PTZDownButtonCommand = value;
            }
        }


        public ICommand PTZLeftButtonCommand
        {
            get
            {
                return _PTZLeftButtonCommand;
            }
            set
            {
                _PTZLeftButtonCommand = value;
            }
        }


        public ICommand PTZRightButtonCommand
        {
            get
            {
                return _PTZRightButtonCommand;
            }
            set
            {
                _PTZRightButtonCommand = value;
            }
        }



        public ICommand PTZUpRightButtonCommand
        {
            get
            {
                return _PTZUpRightButtonCommand;
            }
            set
            {
                _PTZUpRightButtonCommand = value;
            }
        }

        public ICommand PTZUpLeftButtonCommand
        {
            get
            {
                return _PTZUpLeftButtonCommand;
            }
            set
            {
                _PTZUpLeftButtonCommand = value;
            }
        }

        public ICommand PTZDownRightButtonCommand
        {
            get
            {
                return _PTZDownRightButtonCommand;
            }
            set
            {
                _PTZDownRightButtonCommand = value;
            }
        }


        public ICommand PTZDownLeftButtonCommand
        {
            get
            {
                return _PTZDownLeftButtonCommand;
            }
            set
            {
                _PTZDownLeftButtonCommand = value;
            }
        }



        public ICommand PTZZoomInButtonCommand
        {
            get
            {
                return _PTZZoomInButtonCommand;
            }
            set
            {
                _PTZZoomInButtonCommand = value;
            }
        }


        public ICommand PTZZoomOutButtonCommand
        {
            get
            {
                return _PTZZoomOutButtonCommand;
            }
            set
            {
                _PTZZoomOutButtonCommand = value;
            }
        }



        #endregion

        

    }
}
