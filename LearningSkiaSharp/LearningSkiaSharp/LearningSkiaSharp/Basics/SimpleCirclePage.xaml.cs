using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SkiaSharp;
using SkiaSharp.Views.Forms;

namespace LearningSkiaSharp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimpleCirclePage : ContentPage
    {

        //constructor of CanvasView and Event handler
        public SimpleCirclePage()
        {
            Title = "Simple Circle";

            SKCanvasView canvasView = new SKCanvasView();
            canvasView.PaintSurface += OnCanvasViewPaintSurface;
            Content = canvasView;
        }

        //event handler where all drawing is done
        void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas canvas = surface.Canvas;

            //clears surface with transparent color
            canvas.Clear();

            //create an SKPaint object to create outline of circle
            SKPaint paint = new SKPaint
            {
                Style = SKPaintStyle.Stroke,
                Color = Color.Red.ToSKColor(),
                StrokeWidth = 25
            };

            //draw the circle
            canvas.DrawCircle(info.Width / 2, info.Height / 2, 100, paint);

            //draw the interior of the circle
            paint.Style = SKPaintStyle.Fill;
            paint.Color = SKColors.Blue;
            canvas.DrawCircle(args.Info.Width / 2, args.Info.Height / 2, 100, paint);
        }
    }
}