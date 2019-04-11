using System;
using System.ComponentModel;
using Android.Graphics;
using readmorepoc.Controls;
using readmorepoc.Droid.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MultiLineLabel), typeof(CustomMultiLineLabelRenderer))]
namespace readmorepoc.Droid.Controls
{
    public class CustomMultiLineLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            MultiLineLabel multiLineLabel = (MultiLineLabel)Element;

            Control.Invalidate();

            Rect bounds = new Rect();
            Paint paint = new Paint();
            paint.TextSize = (float)40;

            paint.GetTextBounds(Element.Text, 0, Element.Text.Length, bounds);

            int width = (int)Math.Ceiling((float)bounds.Width() / 40);

            int lines = (int)(width / 40);

            if (multiLineLabel != null && multiLineLabel.Lines != -1)
            {
                Control.SetSingleLine(false);
                Control.SetLines(multiLineLabel.Lines);
            }
        }
    }
}
