
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ofir_Shtainfeld.os.model
{
    public class Status : I_Status
    {
        public Status()
        {

        }

        public Status(DateTime p_date, AlertType p_alertType)
        {
            Date = p_date;
            AlertType = p_alertType;
        }
        public Status(DateTime p_date, AlertType p_alertType, string p_originOfStatus)
        {
            Date = p_date;
            AlertType = p_alertType;
            OriginOfStatus = p_originOfStatus;
        }
        public AlertType AlertType
        {
            get; set;
        }

        public DateTime Date
        {
            get; set;
        }

        public string OriginOfStatus
        {
            get; set;
        }
    }

}