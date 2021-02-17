
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ofir_Shtainfeld.os.model
{
    public class UI_Channel_Display : I_UI_Channel_Display
    {
        public string Description
        {
            get; set;
        }

        public int ID
        {
            get; set;
        }

        public byte[] Image
        {
            get; set;
        }

        public bool IsConnected
        {
            get; set;
        }

        public bool IsInDB
        {
            get; set;
        }

        public bool IsRecording
        {
            get; set;
        }

        public List<Status> Last_Alert
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public UI_AlertSelection SelectedAlerts { get; set; }

    }

}