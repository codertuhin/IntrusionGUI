
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ofir_Shtainfeld
{
    public interface I_Status
    {
        AlertTypes AlertType { get; set; }

        DateTime Date { get; set; }

        string OriginOfStatus { get; set; }

    }

}