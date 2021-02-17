
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ofir_Shtainfeld.os.model
{
    public interface I_UI_Channel_Display : I_UI_Base
    {
        string Description { get; set; }

        Byte[] Image { get; set; }

        bool IsConnected { get; set; }

        bool IsInDB { get; set; }

        bool IsRecording { get; set; }

        List<Status> Last_Alert { get; set; }

        string Name { get; set; }

        UI_AlertSelection SelectedAlerts {get;set;}

    }

}

