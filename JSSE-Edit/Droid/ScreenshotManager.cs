using System;
using System.IO;
using Android.App;
using Android.Graphics;
using SampleDB.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(ScreenshotManager))]
namespace SampleDB.Droid
{
    public class ScreenshotManager : IScreenshotManager
    {
        public static Activity Activity { get; set; }

        public async System.Threading.Tasks.Task<byte[]> CaptureAsync()
        {
            if (Activity == null)
            {
                throw new Exception("You have to set ScreenshotManager.Activity in your Android project");
            }

            var view = Activity.Window.DecorView;
            view.DrawingCacheEnabled = true;

            Bitmap bitmap = view.GetDrawingCache(true);

            byte[] bitmapData;

            using (var stream = new MemoryStream())
            {
                bitmap.Compress(Bitmap.CompressFormat.Png, 0, stream);
                bitmapData = stream.ToArray();
            }

            return bitmapData;
        }
    }
}
