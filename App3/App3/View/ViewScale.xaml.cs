using SkiaSharp.Views.Forms;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewScale : ContentPage
    {
        public ViewScale()
        {
            InitializeComponent();
            
        }

        internal class GraphicScale : SKCanvasView
        {
            double maxv, minv, v;
            public string maxv_s, minv_s, v_s;
            public GraphicScale()
            {
                ViewModel vm = new ViewModel();
                maxv = int.Parse(vm.maxValue);
                minv = int.Parse(vm.minValue);
                v = int.Parse(vm.data);
                maxv_s = maxv.ToString();
                minv_s = minv.ToString();
                v_s = v.ToString();
                
                
            }
            public void FillDataValue(Label l0)
            {
                string standart_unit = "уе";
                l0.Text = v_s + standart_unit;
            }
            public void FillDataPercent(Label l0)
            {
                l0.Text = Math.Round(v / (maxv - minv)*100,2).ToString() + "%";
            }
            public double getPercent()
            {
                return v / (maxv - minv);
            }


        }
        protected void OnPaintSurface0(object sender, SKPaintSurfaceEventArgs e0)
        {
            double percentValue = 0;
            GraphicScale gs = new GraphicScale();          
            gs.FillDataPercent(Percent0);
            gs.FillDataValue(Value0);
            percentValue = gs.getPercent();

            string black = "#000000",
                scaleColor = "#ffa62b";
            double scaleH = 2.75;
            double scaleW = 2.75;
            var surface = e0.Surface;
            var canvas = e0.Surface.Canvas;
            var info = e0.Info;
            SkiaSharp.SKPaint paintBlack = new SkiaSharp.SKPaint();
            paintBlack.Color = SkiaSharp.SKColor.Parse(black);
            SkiaSharp.SKPaint paintScale = new SkiaSharp.SKPaint();
            paintScale.Color = SkiaSharp.SKColor.Parse(scaleColor);

            double h = Scale0.Height;
            double w = Scale0.Width;
            canvas.DrawRect(0, (float)((h * scaleH) - (h * scaleH * percentValue)), (float)(w * scaleW), (float)(h * scaleH * percentValue), paintScale);
            //canvas.DrawText
            double height = Application.Current.MainPage.Height;
            double width = Application.Current.MainPage.Width;
            DrawAllLines(e0, h, w, scaleH, scaleW, paintBlack);
            PrintDigits(height, width, h, w, Value0, Lvl0, Percent0, StLScale0,
                Scale0_l0, Scale0_l1, Scale0_l2, Scale0_l3, Scale0_l4, Scale0_l5, Scale0_l6, Scale0_l7, Scale0_l8, Scale0_l9, Scale0_l10); 
        }
        protected void OnPaintSurface1(object sender, SKPaintSurfaceEventArgs e1)
        {
            double percentValue = 0;
            GraphicScale gs = new GraphicScale();
            gs.FillDataPercent(Percent1);
            gs.FillDataValue(Value1);
            percentValue = gs.getPercent();

            string black = "#000000",
                scaleColor = "#ffa62b";
            double scaleH = 2.75;
            double scaleW = 2.75;
            var surface = e1.Surface;
            var canvas = e1.Surface.Canvas;
            var info = e1.Info;
            SkiaSharp.SKPaint paintBlack = new SkiaSharp.SKPaint();
            paintBlack.Color = SkiaSharp.SKColor.Parse(black);
            SkiaSharp.SKPaint paintScale = new SkiaSharp.SKPaint();
            paintScale.Color = SkiaSharp.SKColor.Parse(scaleColor);

            double h = Scale1.Height;
            double w = Scale1.Width;
            canvas.DrawRect(0, (float)((h * scaleH) - (h * scaleH * percentValue)), (float)(w * scaleW), (float)(h * scaleH * percentValue), paintScale);
            double height = Application.Current.MainPage.Height;
            double width = Application.Current.MainPage.Width;
            DrawAllLines(e1, h, w, scaleH, scaleW, paintBlack);
            PrintDigits(height, width, h, w, Value1, Lvl1, Percent1, StLScale1,
                Scale1_l0, Scale1_l1, Scale1_l2, Scale1_l3, Scale1_l4, Scale1_l5, Scale1_l6, Scale1_l7, Scale1_l8, Scale1_l9, Scale1_l10);
        }
        protected void OnPaintSurface2(object sender, SKPaintSurfaceEventArgs e2)
        {
            double percentValue = 0;
            GraphicScale gs = new GraphicScale();
            gs.FillDataPercent(Percent2);
            gs.FillDataValue(Value2);
            percentValue = gs.getPercent();

            string black = "#000000",
                scaleColor = "#ffa62b";
            double scaleH = 2.75;
            double scaleW = 2.75;
            var surface = e2.Surface;
            var canvas = e2.Surface.Canvas;
            var info = e2.Info;
            SkiaSharp.SKPaint paintBlack = new SkiaSharp.SKPaint();
            paintBlack.Color = SkiaSharp.SKColor.Parse(black);
            SkiaSharp.SKPaint paintScale = new SkiaSharp.SKPaint();
            paintScale.Color = SkiaSharp.SKColor.Parse(scaleColor);

            double h = Scale2.Height;
            double w = Scale2.Width;
            canvas.DrawRect(0, (float)((h * scaleH) - (h * scaleH * percentValue)), (float)(w * scaleW), (float)(h * scaleH * percentValue), paintScale);
            double height = Application.Current.MainPage.Height;
            double width = Application.Current.MainPage.Width;
            DrawAllLines(e2, h, w, scaleH, scaleW, paintBlack);
            PrintDigits(height, width, h, w, Value2, Lvl2, Percent2, StLScale2,
                Scale2_l0, Scale2_l1, Scale2_l2, Scale2_l3, Scale2_l4, Scale2_l5, Scale2_l6, Scale2_l7, Scale2_l8, Scale2_l9, Scale2_l10);
        }
        protected void OnPaintSurface3(object sender, SKPaintSurfaceEventArgs e3)
        {
            double percentValue = 0;
            GraphicScale gs = new GraphicScale();
            gs.FillDataPercent(Percent3);
            gs.FillDataValue(Value3);
            percentValue = gs.getPercent();

            string black = "#000000",
                scaleColor = "#ffa62b";
            double scaleH = 2.75;
            double scaleW = 2.75;
            var surface = e3.Surface;
            var canvas = e3.Surface.Canvas;
            var info = e3.Info;
            SkiaSharp.SKPaint paintBlack = new SkiaSharp.SKPaint();
            paintBlack.Color = SkiaSharp.SKColor.Parse(black);
            SkiaSharp.SKPaint paintScale = new SkiaSharp.SKPaint();
            paintScale.Color = SkiaSharp.SKColor.Parse(scaleColor);

            double h = Scale3.Height;
            double w = Scale3.Width;
            canvas.DrawRect(0, (float)((h * scaleH) - (h * scaleH * percentValue)), (float)(w * scaleW), (float)(h * scaleH * percentValue), paintScale);
            double height = Application.Current.MainPage.Height;
            double width = Application.Current.MainPage.Width;
            DrawAllLines(e3, h, w, scaleH, scaleW, paintBlack);
            PrintDigits(height, width, h, w, Value3, Lvl3, Percent3, StLScale3,
                Scale3_l0, Scale3_l1, Scale3_l2, Scale3_l3, Scale3_l4, Scale3_l5, Scale3_l6, Scale3_l7, Scale3_l8, Scale3_l9, Scale3_l10);
        }
        protected void OnPaintSurface4(object sender, SKPaintSurfaceEventArgs e4)
        {
            double percentValue = 0;
            GraphicScale gs = new GraphicScale();
            gs.FillDataPercent(Percent4);
            gs.FillDataValue(Value4);
            percentValue = gs.getPercent();

            string black = "#000000",
                scaleColor = "#ffa62b";
            double scaleH = 2.75;
            double scaleW = 2.75;
            var surface = e4.Surface;
            var canvas = e4.Surface.Canvas;
            var info = e4.Info;
            SkiaSharp.SKPaint paintBlack = new SkiaSharp.SKPaint();
            paintBlack.Color = SkiaSharp.SKColor.Parse(black);
            SkiaSharp.SKPaint paintScale = new SkiaSharp.SKPaint();
            paintScale.Color = SkiaSharp.SKColor.Parse(scaleColor);

            double h = Scale4.Height;
            double w = Scale4.Width;
            canvas.DrawRect(0, (float)((h * scaleH) - (h * scaleH * percentValue)), (float)(w * scaleW), (float)(h * scaleH * percentValue), paintScale);
            double height = Application.Current.MainPage.Height;
            double width = Application.Current.MainPage.Width;
            DrawAllLines(e4, h, w, scaleH, scaleW, paintBlack);
            PrintDigits(height, width, h, w, Value4, Lvl4, Percent4, StLScale4,
                Scale4_l0, Scale4_l1, Scale4_l2, Scale4_l3, Scale4_l4, Scale4_l5, Scale4_l6, Scale4_l7, Scale4_l8, Scale4_l9, Scale4_l10);
        }
        protected void OnPaintSurface5(object sender, SKPaintSurfaceEventArgs e5)
        {
            double percentValue = 0;
            GraphicScale gs = new GraphicScale();
            gs.FillDataPercent(Percent5);
            gs.FillDataValue(Value5);
            percentValue = gs.getPercent();

            string black = "#000000",
                scaleColor = "#ffa62b";
            double scaleH = 2.75;
            double scaleW = 2.75;
            var surface = e5.Surface;
            var canvas = e5.Surface.Canvas;
            var info = e5.Info;
            SkiaSharp.SKPaint paintBlack = new SkiaSharp.SKPaint();
            paintBlack.Color = SkiaSharp.SKColor.Parse(black);
            SkiaSharp.SKPaint paintScale = new SkiaSharp.SKPaint();
            paintScale.Color = SkiaSharp.SKColor.Parse(scaleColor);
            
            double h = Scale5.Height;
            double w = Scale5.Width;
            canvas.DrawRect(0, (float)((h * scaleH) - (h * scaleH * percentValue)), (float)(w * scaleW), (float)(h * scaleH * percentValue), paintScale);
            double height = Application.Current.MainPage.Height;
            double width = Application.Current.MainPage.Width;
            DrawAllLines(e5, h, w, scaleH, scaleW, paintBlack);
            PrintDigits(height, width, h, w, Value5, Lvl5, Percent5, StLScale5,
                Scale5_l0, Scale5_l1, Scale5_l2, Scale5_l3, Scale5_l4, Scale5_l5, Scale5_l6, Scale5_l7, Scale5_l8, Scale5_l9, Scale5_l10);
        }
        private void DrawAllLines(SKPaintSurfaceEventArgs e, double h,double w, double scaleH, double scaleW, SkiaSharp.SKPaint paint)
        {
            var canvas = e.Surface.Canvas;
            //обводка
            canvas.DrawLine(0, 0, 0, (float)(h * scaleH), paint);
            canvas.DrawLine(1, 0, 1, (float)(h * scaleH), paint);
            canvas.DrawLine(2, 0, 2, (float)(h * scaleH), paint);
            canvas.DrawLine(0, 0, (float)(w * scaleW), 0, paint);
            canvas.DrawLine(0, 1, (float)(w * scaleW), 1, paint);
            canvas.DrawLine(0, 2, (float)(w * scaleW), 2, paint);
            canvas.DrawLine((float)(w * scaleW), 0, (float)(w * scaleW), (float)(h * scaleH), paint);
            canvas.DrawLine((float)(w * scaleW) - 1, 0, (float)(w * scaleW) - 1, (float)(h * scaleH), paint);
            canvas.DrawLine((float)(w * scaleW) - 2, 0, (float)(w * scaleW) - 2, (float)(h * scaleH), paint);
            canvas.DrawLine(0, (float)(h * scaleH), (float)(w * scaleW), (float)(h * scaleH), paint);
            canvas.DrawLine(0, (float)(h * scaleH) - 1, (float)(w * scaleW), (float)(h * scaleH) - 1, paint);
            canvas.DrawLine(0, (float)(h * scaleH) - 2, (float)(w * scaleW), (float)(h * scaleH) - 2, paint);
            //деления
            for (int i = 1; i < 10; i++)
            {
                canvas.DrawLine(0, (float)(h * scaleH / 10 * i), (float)(w * scaleH), (float)(h * scaleH / 10 * i), paint);
            }
        }
        private void PrintDigits(double height, double width, double h, double w, 
            Label v, Label lvl, Label prc, StackLayout stl,
            Label l0,Label l1, Label l2, Label l3, Label l4, Label l5,
            Label l6, Label l7, Label l8, Label l9, Label l10)
        {
            if (height > width)
            {
                if ((h / w) > 3)
                {
                    double d = 50;
                    v.FontSize = w / 3;
                    lvl.FontSize = w / 3;
                    prc.FontSize = w / 3;

                    //stl.HeightRequest=h;
                    stl.Spacing = (h-h/d)/11;
                    l0.FontSize = h / d;
                    l1.FontSize = h / d;
                    l2.FontSize = h / d;
                    l3.FontSize = h / d;
                    l4.FontSize = h / d;
                    l5.FontSize = h / d;
                    l6.FontSize = h / d;
                    l7.FontSize = h / d;
                    l8.FontSize = h / d;
                    l9.FontSize = h / d;
                    l10.FontSize = h / d;
                }
                else if (h > w)
                {
                    double d = 16;
                    v.FontSize = h / 8;
                    lvl.FontSize = h / 8;
                    prc.FontSize = h / 10;

                    stl.Spacing = h / 22;
                    l0.FontSize = h / d;
                    l1.FontSize = h / d;
                    l2.FontSize = h / d;
                    l3.FontSize = h / d;
                    l4.FontSize = h / d;
                    l5.FontSize = h / d;
                    l6.FontSize = h / d;
                    l7.FontSize = h / d;
                    l8.FontSize = h / d;
                    l9.FontSize = h / d;
                    l10.FontSize = h / d;

                }
                else
                {
                    double d = 9.5;
                    v.FontSize = h / 8.2;
                    lvl.FontSize = h / 8.2;
                    prc.FontSize = h / 8;

                    stl.Spacing = 0;
                    l0.FontSize = h / d;
                    l1.FontSize = h / d;
                    l2.FontSize = h / d;
                    l3.FontSize = h / d;
                    l4.FontSize = h / d;
                    l5.FontSize = h / d;
                    l6.FontSize = h / d;
                    l7.FontSize = h / d;
                    l8.FontSize = h / d;
                    l9.FontSize = h / d;
                    l10.FontSize = h / d;
                }
            }
            else
            {
                if (h > w)
                {
                    double d = 16;
                    v.FontSize = h / 8;
                    lvl.FontSize = h / 8;
                    prc.FontSize = h / 10;

                    stl.Spacing = (h / 10 - h / d / 3) * 0.75;
                    l0.FontSize = h / d;
                    l1.FontSize = h / d;
                    l2.FontSize = h / d;
                    l3.FontSize = h / d;
                    l4.FontSize = h / d;
                    l5.FontSize = h / d;
                    l6.FontSize = h / d;
                    l7.FontSize = h / d;
                    l8.FontSize = h / d;
                    l9.FontSize = h / d;
                    l10.FontSize = h / d;

                }
                else
                {
                    double d = 7.8;
                    v.FontSize = h / 7;
                    lvl.FontSize = h / 7;
                    prc.FontSize = h / 10;

                    stl.Spacing = 0;
                    l0.FontSize = h / d;
                    l1.FontSize = h / d;
                    l2.FontSize = h / d;
                    l3.FontSize = h / d;
                    l4.FontSize = h / d;
                    l5.FontSize = h / d;
                    l6.FontSize = h / d;
                    l7.FontSize = h / d;
                    l8.FontSize = h / d;
                    l9.FontSize = h / d;
                    l10.FontSize = h / d;
                }
            }
        }
    }


}