
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ofir_Shtainfeld.os.model
{
    public interface I_UI_PTZ
    {
        PTZDirection Direction { get; set; }

        bool Enabled { get; set; }

        PTZoom Zoom { get; set; }

    }
}
