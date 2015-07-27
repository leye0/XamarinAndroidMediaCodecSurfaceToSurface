using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using MediaCodecHelper;
using System.Threading.Tasks;

namespace surfacetosurface
{
	[Activity (Label = "surfacetosurface", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);

			//var myCodec = new CameraToMp4 (this);
			//var myCodec = new GeneratedVideoToMp4();
			var myCodec = new FileToMp4 (this, 24, 1, null);

			button.Click += delegate {
				Task.Run(() => {
					myCodec.Start();	
				});
			};
		}
	}
}


