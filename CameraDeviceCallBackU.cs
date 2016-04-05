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

namespace InterphoneSAM
{
    class CameraDeviceStateCallBackU : CameraDevice.StateCallback
    {
        private CameraCaptureSessionCallbackU _ccssc; //Camera Capture Session CallBack   

        public CameraDeviceStateCallBackU()
        {
            _ccssc = new CameraCaptureSessionCallbackU();
        }
        //Reimplements methods
        public override void OnDisconnected(CameraDevice camera)
        {
            throw new NotImplementedException();
        }

        public override void OnError(CameraDevice camera, [GeneratedEnum] CameraError error)
        {
            throw new NotImplementedException();
        }

        public override void OnOpened(CameraDevice camera)
        {
            camera.CreateCaptureSession(new List<Surface>(),_ccssc,null);
        }
    }
}