
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ofir_Shtainfeld
{
    public interface I_UI_Channel_Basic : I_UI_Base
    {
        Byte[] MaskedImage { get; set; }

        string Model { get; set; }

        string Password { get; set; }

        string Port { get; set; }

        int[][] RelativeObject { get; set; }

        int[][] ROI { get; set; }

        string User_Name { get; set; }

        string Vendor { get; set; }

    }

}

