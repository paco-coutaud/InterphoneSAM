using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace InterphoneSAM
{
    [Activity(Label = "InterphoneSAM", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        Button button;
        SurfaceView _mCameraView;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //Verification, recuperation du bon ID camera
            System.Diagnostics.Debug.WriteLine("La camera avant a l'id " + CameraU.getCameraIdFromType(this, "FRONT"));
            System.Diagnostics.Debug.WriteLine("La camera arriere a l'id " + CameraU.getCameraIdFromType(this, "BACK"));

            // Get our button from the layout resource,
            // and attach an event to it
            button = FindViewById<Button>(Resource.Id.MyButton);
            _mCameraView = FindViewById<SurfaceView>(Resource.Id.cameraView);

            //CameraU frontCamera = new CameraU(this, "FRONT"); //Obtain front Camera

            //Connect to event
            button.Click += new EventHandler(changeText);
        }

        private void changeText(Object sender, EventArgs e)
        {
            button.Text = string.Format("Vous avez cliqué {0} fois!", count++);
        }
    }
}

