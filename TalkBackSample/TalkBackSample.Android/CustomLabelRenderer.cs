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
using TalkBackSample.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Label), typeof(CustomLabelRenderer))]
namespace TalkBackSample.Droid
{
    public class CustomLabelRenderer : LabelRenderer
    {
        public CustomLabelRenderer(Context context) : base(context)
        {

        }
    }
}