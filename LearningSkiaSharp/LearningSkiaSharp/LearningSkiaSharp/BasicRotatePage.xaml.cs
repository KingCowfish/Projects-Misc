using SkiaSharp;
using SkiaSharp.Views.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LearningSkiaSharp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasicRotatePage : ContentPage
    {
        public BasicRotatePage()
        {
            InitializeComponent();
        }

        void sliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            if (canvasView != null)
            {
                canvasView.InvalidateSurface();
            }
        }

        void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            using (SKPaint textPaint = new SKPaint
            {
                Style = SKPaintStyle.Fill,
                Color = SKColors.Blue,
                TextAlign = SKTextAlign.Center,
                TextSize = 100
            })
            {
                canvas.RotateDegrees((float)rotateSlider.Value);
                canvas.DrawText(Title, info.Width / 2, info.Height / 2, textPaint);
            }
        }
    }
}