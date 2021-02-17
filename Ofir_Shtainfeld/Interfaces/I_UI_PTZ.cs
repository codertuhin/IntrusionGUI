
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ofir_Shtainfeld
{
    public interface I_UI_PTZ
    {
        PTZDirections Direction { get; set; }

        bool Enabled { get; set; }

        PTZoom Zoom { get; set; }

    }
}
