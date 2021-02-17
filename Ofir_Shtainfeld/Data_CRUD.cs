using Ofir_Shtainfeld.os.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ServiceImplementation;
//using Shared_Data;
using System.Drawing;
using System.IO;

namespace Ofir_Shtainfeld
{
    public static class Data_CRUD
    {
        //How and when this function will be called//
        internal static void UpdateBasicChannel(I_UI_Channel_Display p_data)
        {
            //Database CRUD functions//

        }

        //Have functionality to store data in DB
        //But the method should have return type of 'UI_Channel_Display' to get and pass data from DB
        internal static void UpdateChannelDisplay(I_UI_Channel_Display p_data)
        {
            //Database CRUD functions//

            var _IsRecording = p_data.IsRecording;
            var _IsConnected = p_data.IsConnected;

        }


        internal static void UpdateChannelDisplay(I_UI_PTZ p_ptz)
        {
            //Database CRUD functions//   

            var _Direction = p_ptz.Direction;
            var _Zoom = p_ptz.Zoom;
        }

        internal static List<I_UI_Channel_Display> GetChannels()
        {
            var ChannelList = MockChannel();
            //var ChannelList =Colibri_Service_Implementation.Instance.GetChannels("");
            //Database CRUD functions//
            //var ChannelList = new List<UI_Channel_Display>();

            return ChannelList;
        }
        private static List<I_UI_Channel_Display> MockChannel()
        {
            List<I_UI_Channel_Display> channelList = new List<I_UI_Channel_Display>();
            var bitmap = Bitmap.FromFile(System.IO.Path.Combine(System.Environment.CurrentDirectory, "657676.jpg"));
            //var channel2Bitmap = File.ReadAllBytes("Sample_Camera_Image_2.jpg");

            var imageBin = ImageToByte(bitmap);
            var base64Img = Convert.ToBase64String(imageBin);
            UI_Channel_Display ch = new UI_Channel_Display
            {
                ID = 1,
                Description = "Kitchen",
                IsConnected = true,
                IsInDB = true,
                IsRecording = false,
                Name = "MICROSEVEN",
                Last_Alert = new List<Status> { new Status(DateTime.Now, AlertType.CameraCover), new Status(DateTime.Now.AddMinutes(10), AlertType.MotionDetection), new Status(DateTime.Now.AddMinutes(15), AlertType.EnterROI), new Status(DateTime.Now.AddMinutes(20), AlertType.ExitROI), new Status(DateTime.Now, AlertType.MotionDetection) },
                Image = imageBin,
                SelectedAlerts = new UI_AlertSelection()
                {
                    First = AlertType.MotionDetection,
                    Second = AlertType.None,
                    Third = AlertType.None
                }

            };

            channelList.Add(ch);
            UI_AlertSelection a = new UI_AlertSelection();



            ch = new UI_Channel_Display
            {
                ID = 2,
                Description = "Back door",
                IsConnected = false,
                IsInDB = true,
                IsRecording = false,
                Name = "DAHUA",
                Last_Alert = new List<Status> { new Status(DateTime.Now, AlertType.CameraCover), new Status(DateTime.Now.AddMinutes(10), AlertType.MotionDetection), new Status(DateTime.Now.AddMinutes(15), AlertType.EnterROI), new Status(DateTime.Now.AddMinutes(20), AlertType.ExitROI), new Status(DateTime.Now, AlertType.MotionDetection) },
                Image = imageBin,
                SelectedAlerts = new UI_AlertSelection()
                {
                    First = AlertType.MotionDetection,
                    Second = AlertType.CameraCover,
                    Third = AlertType.CameraDisconnected
                }
            };


            channelList.Add(ch);
            return channelList;

        }

        private static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
    }
}
