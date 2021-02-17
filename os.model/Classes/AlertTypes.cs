
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ofir_Shtainfeld.os.model
{
    public enum AlertType
    {
        /// <summary>
        /// setect motion with in a frame, by default is working, the rest by default not working
        /// </summary>
       // [DataMember]
        MotionDetection = 0,
        /// <summary>
        /// Camera communication problem or disconnection or power off
        /// </summary>
       // [DataMember]
        CameraDisconnected = 1,
        /// <summary>
        /// an object was put on the camera lens port of view
        /// </summary>
       // [DataMember]
        CameraCover = 2,
        /// <summary>
        /// an object enter selected ROI
        /// </summary>
       // [DataMember]
        EnterROI = 3,
        /// <summary>
        /// an object exit selected ROI
        /// </summary>
       // [DataMember]
        ExitROI = 4,

        None =5,
    }

}
