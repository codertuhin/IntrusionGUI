using Ofir_Shtainfeld.os.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ofir_Shtainfeld.os.model
{
    public class UI_AlertSelection
    {
        public AlertType First { get; set; } = AlertType.MotionDetection;

        public AlertType Second { get; set; } = AlertType.None;

        public AlertType Third { get; set; } = AlertType.None;


    }
}
