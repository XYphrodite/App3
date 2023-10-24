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
            canvas.DrawRect((float)(w * scaleW / 6), (float)((h * scaleH) - (h * scaleH * percentValue)), (float)(w * scaleW), (float)(h * scaleH * percentValue), paintScale);
            //canvas.DrawText
            double height = Application.Current.MainPage.Height;
            double width = Application.Current.MainPage.Width;
            DrawAllLines(e0, h, w, scaleH, scaleW, paintBlack);
            PrintDigits(h * scaleH, w * scaleW, e0, Lvl0, Value0, Percent0);
            
        }

        private void DrawAllLines(SKPaintSurfaceEventArgs e, double h,double w, double scaleH, double scaleW, SkiaSharp.SKPaint paint)
        {
            var canvas = e.Surface.Canvas;
            //обводка
            canvas.DrawLine((float)(w *scaleW/6), 0, (float)(w * scaleW / 6), (float)(h * scaleH), paint);
            canvas.DrawLine((float)(w * scaleW / 6)+1, 0, (float)(w * scaleW / 6)+1, (float)(h * scaleH), paint);
            canvas.DrawLine((float)(w * scaleW / 6)+2, 0, (float)(w * scaleW / 6)+2, (float)(h * scaleH), paint);
            canvas.DrawLine((float)(w * scaleW / 6), 0, (float)(w * scaleW), 0, paint);
            canvas.DrawLine((float)(w * scaleW / 6), 1, (float)(w * scaleW), 1, paint);
            canvas.DrawLine((float)(w * scaleW / 6), 2, (float)(w * scaleW), 2, paint);
            canvas.DrawLine((float)(w * scaleW), 0, (float)(w * scaleW), (float)(h * scaleH), paint);
            canvas.DrawLine((float)(w * scaleW) - 1, 0, (float)(w * scaleW) - 1, (float)(h * scaleH), paint);
            canvas.DrawLine((float)(w * scaleW) - 2, 0, (float)(w * scaleW) - 2, (float)(h * scaleH), paint);
            canvas.DrawLine((float)(w * scaleW / 6), (float)(h * scaleH), (float)(w * scaleW), (float)(h * scaleH), paint);
            canvas.DrawLine((float)(w * scaleW / 6), (float)(h * scaleH) - 1, (float)(w * scaleW), (float)(h * scaleH) - 1, paint);
            canvas.DrawLine((float)(w * scaleW / 6), (float)(h * scaleH) - 2, (float)(w * scaleW), (float)(h * scaleH) - 2, paint);
            //деления
            for (double i = h*scaleH/75; i <= h*scaleH; i+=h*scaleH/10.27)
            {
                canvas.DrawLine((float)(w * scaleW / 8), (float)(i), (float)(w * scaleH), (float)(i ), paint);
            }
            //числа
            double height = Application.Current.MainPage.Height;
            double width = Application.Current.MainPage.Width;
            SkiaSharp.SKFont font;
            if (height > width)
            {
                if (h > w)
                {
                    font = new SkiaSharp.SKFont(SkiaSharp.SKTypeface.Default, (float)(w / 8), 1, 0);
                    for (double i = h * scaleH / 40, n = 100; i <= h * scaleH; i += h * scaleH / 10.27, n -= 10)
                    {
                        canvas.DrawText(n.ToString(), (float)(w / 10), (float)i, font, paint);
                    }
                }
                else
                {
                    font = new SkiaSharp.SKFont(SkiaSharp.SKTypeface.Default, (float)(w / 10), 1, 0);
                    for (double i = h * scaleH / 24, n = 100; i <= h * scaleH; i += h * scaleH / 10.5, n -= 10)
                    {
                        canvas.DrawText(n.ToString(), (float)(w / 7.5), (float)i, font, paint);
                    }
                }
            }
            else
            {
                if (h > w)
                {
                    font = new SkiaSharp.SKFont(SkiaSharp.SKTypeface.Default, (float)(w / 5), 1, 0);
                    for (double i = h * scaleH / 26, n = 100; i <= h * scaleH; i += h * scaleH / 10.4, n -= 10)
                    {
                        canvas.DrawText(n.ToString(), (float)(w / 10), (float)i, font, paint);
                    }
                }
                else
                {
                    font = new SkiaSharp.SKFont(SkiaSharp.SKTypeface.Default, (float)(h / 5), 1, 0);
                    for (double i = h * scaleH / 19, n = 100; i <= h * scaleH; i += h * scaleH / 10.6, n -= 10)
                    {
                        canvas.DrawText(n.ToString(), (float)(w / 7.5), (float)i, font, paint);
                    }
                }
            }
            

        }
        private void PrintDigits(double h, double w, SKPaintSurfaceEventArgs e,Label lvl, Label v, Label prc)
        {
            double height = Application.Current.MainPage.Height;
            double width = Application.Current.MainPage.Width;
            if (height > width)
            {
                 if (h > w)
                {
                    v.FontSize = w / 20;
                    lvl.FontSize = w / 20;
                    prc.FontSize = w / 20;

                }
                else
                {
                    v.FontSize = h / 20;
                    lvl.FontSize = h / 20;
                    prc.FontSize = h / 25;

                }
            }
            else
            {
                if (h > w)
                {
                    v.FontSize = w / 15;
                    lvl.FontSize = w / 15;
                    prc.FontSize = w / 18;

                }
                else
                {
                    v.FontSize = h / 20;
                    lvl.FontSize = h / 20;
                    prc.FontSize = h / 25;               
                }
            }
        }
    }


}