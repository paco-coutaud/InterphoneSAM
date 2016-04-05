using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Hardware.Camera2;
using Android.Util;

/*Min API lvl 21*/

namespace InterphoneSAM
{
    class CameraU
    {
        private CameraManager m; //Camera manager
        private CameraDeviceStateCallBackU cb; //CallBack
        private string _id; //_id of the camera which is in use.

        public CameraU(Context context, string type = "FRONT")
        {
            //Initialize
            m = (CameraManager)context.GetSystemService(Context.CameraService); //Instance of CameraManager
            cb = new CameraDeviceStateCallBackU();

            _id = CameraU.getCameraIdFromType(context, type);

            m.OpenCamera(_id,cb, null); //Open Camera in function of type
        }

        /*This static method provide a simple way to obtain id of Back or Front CAMERA on a system
         It takes two arguments, Context c is the context where we want to have camera informations and string type is to know if we want back or front camera
         return the camera id if found otherwise -1*/
        public static string getCameraIdFromType(Context context, string type = "FRONT")
        {
            CameraManager  tmpCM = (CameraManager)context.GetSystemService(Context.CameraService); //Instance of CameraManager
            CameraCharacteristics tmpCC; //Instance of CameraCharacteristics

            string tmpID = "-1"; //_id

            foreach (string currentID in tmpCM.GetCameraIdList())
            {
                tmpCC = tmpCM.GetCameraCharacteristics(currentID);

                if(type == "BACK" && (int)(tmpCC.Get(CameraCharacteristics.LensFacing)) == 1) //It's back Camera
                {
                    tmpID = currentID;
                }
                else if(type == "FRONT" && (int)(tmpCC.Get(CameraCharacteristics.LensFacing)) == 0) //It's front camera
                {
                    tmpID = currentID;
                }
            }

            return tmpID;
        }        
    }
}