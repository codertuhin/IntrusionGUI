
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ofir_Shtainfeld.os.model
{
    public interface I_Status
    {
        AlertType AlertType { get; set; }

        DateTime Date { get; set; }

        string OriginOfStatus { get; set; }

    }

}