using Foundation;
using System;
using UIKit;
using CoreGraphics;
using Foundation;
using AVFoundation;

namespace App4_Acceso
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            btnVideoLocal.TouchUpInside += delegate
            {
                AVPlayer Reproductor;
                AVPlayerLayer CapadeReproductor;
                AVAsset Recurso;
                AVPlayerItem RecursoReproducir;

                Recurso = AVAsset.FromUrl(NSUrl.FromFilename("warningsigns.mp4"));
                RecursoReproducir = new AVPlayerItem(Recurso);
                Reproductor = new AVPlayer(RecursoReproducir);
                CapadeReproductor = AVPlayerLayer.FromPlayer(Reproductor);
                CapadeReproductor.Frame = new CGRect(50, 100, 300, 300);
                View.Layer.AddSublayer(CapadeReproductor);
                Reproductor.Play();
            };
            btnVideoInternet.TouchUpInside += delegate
            {
                AVPlayer Reproductor;
                AVPlayerLayer CapadeReproductor;
                AVAsset Recurso;
                AVPlayerItem RecursoReproducir;

                Recurso = AVAsset.FromUrl(NSUrl.FromString("https://example-files.online-convert.com/video/mp4/example.mp4"));
                RecursoReproducir = new AVPlayerItem(Recurso);
                Reproductor = new AVPlayer(RecursoReproducir);
                CapadeReproductor = AVPlayerLayer.FromPlayer(Reproductor);
                CapadeReproductor.Frame = new CGRect(50, 340, 300, 300);
                View.Layer.AddSublayer(CapadeReproductor);
                Reproductor.Play();
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}