using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Hardware.Camera2;
using Android.Graphics.Drawables;

namespace InterphoneSAM
{
    class CameraPreviewU : SurfaceView, ISurfaceHolderCallback
    {
        private ISurfaceHolder _surfaceFolder;
        private CameraU _camera;
        public CameraPreviewU(Context context, CameraU camera):base(context)
        {
            _camera = camera;
            _surfaceFolder.AddCallback(this);

        }

        //Implement ISurfaceHolderCallBack interface
        public void SurfaceChanged(ISurfaceHolder holder, [GeneratedEnum] Format format, int width, int height)
        {
            throw new NotImplementedException();
        }

        public void SurfaceCreated(ISurfaceHolder holder)
        {
            throw new NotImplementedException();
        }

        public void SurfaceDestroyed(ISurfaceHolder holder)
        {
            throw new NotImplementedException();
        }
    }
}
