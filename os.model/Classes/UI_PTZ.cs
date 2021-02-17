
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ofir_Shtainfeld.os.model
{
    public class UI_PTZ : I_UI_PTZ
    {
        public PTZDirection Direction
        {
            get; set;
        }

        public bool Enabled
        {
            get; set;
        }

        public PTZoom Zoom
        {
            get; set;
        }


        ///Where is the List<Status> member???
    }

}