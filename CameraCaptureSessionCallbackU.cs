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
    class CameraCaptureSessionCallbackU : CameraCaptureSession.StateCallback
    {
        public CameraCaptureSessionCallbackU()
        {

        }
        public override void OnConfigured(CameraCaptureSession session)
        {
            throw new NotImplementedException();
        }

        public override void OnConfigureFailed(CameraCaptureSession session)
        {
            throw new NotImplementedException();
        }
    }
}