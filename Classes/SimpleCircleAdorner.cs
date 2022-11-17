using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WoodPainting2
{
    public class SimpleCircleAdorner : Adorner
    {
        // TL-top left TR - top right BL - bottom left BR - bottom right
        enum MousePosition
        {
            TL,
            TR, 
            BL, 
            BR
        }
        Canvas canvas;
        FrameworkElement frameworkElement;
        private bool isDraging;
        private Point startPosition;

        public SimpleCircleAdorner(UIElement adornedElement, Canvas canvasPaint, FrameworkElement fwElement) : base(adornedElement)
        {
            canvas = canvasPaint;
            frameworkElement= fwElement;
        }
        Rect conturRectangle;

        protected override void OnRender(DrawingContext drawingContext)
        {
            if (frameworkElement is Polygon)
            {
                conturRectangle = new Rect(0, 0, frameworkElement.ActualWidth, frameworkElement.ActualHeight);
                SolidColorBrush adornedBrush = new SolidColorBrush(Colors.Red);
                adornedBrush.Opacity = 0.2;
                Pen adornedPen = new Pen(new SolidColorBrush(Colors.Navy), 1.5);
                double renderRadius = 5.0;
                drawingContext.DrawEllipse(adornedBrush, adornedPen, conturRectangle.BottomRight, renderRadius, renderRadius);
                drawingContext.DrawRectangle(adornedBrush, adornedPen, conturRectangle);
            }
            else if (frameworkElement is Canvas)
            {
                return;
            }
            else
            {
                Rect adornedElementRect = new Rect(AdornedElement.DesiredSize);
                SolidColorBrush adornedBrush = new SolidColorBrush(Colors.Red);
                adornedBrush.Opacity = 0.2;
                Pen adornedPen = new Pen(new SolidColorBrush(Colors.Navy), 1.5);
                double renderRadius = 5.0;
                drawingContext.DrawEllipse(adornedBrush, adornedPen, adornedElementRect.BottomRight, renderRadius, renderRadius);
                drawingContext.DrawRectangle(adornedBrush, adornedPen, adornedElementRect);
            }
        }

        protected override void OnPreviewMouseMove(MouseEventArgs e)
        {
            if (isDraging)
            {
                Point newPosition = Mouse.GetPosition(canvas);
                double diffX = (newPosition.X - startPosition.X);
                double diffY = (newPosition.Y - startPosition.Y);
                double diffXP = newPosition.X - frameworkElement.Margin.Left;
                double diffYP = newPosition.Y - frameworkElement.Margin.Top;
                if (Math.Abs(diffX) >= 1 || Math.Abs(diffY) >= 1)
                {
                    if (frameworkElement is Polygon)
                    {
                        var aX = 0.0;
                        var aY = 0.0;
                        var bX = diffXP;
                        var bY = diffYP;

                        bool isDown = (frameworkElement as Polygon).Points[1].Y > 0;
                        if (isDown)
                        {
                            (aY, bY) = (bY, aY);
                        }
                        (frameworkElement as Polygon).Points[0] =
                            (frameworkElement as Polygon).Points[3] = new Point(aX, bY);
                        (frameworkElement as Polygon).Points[1] = new Point((aX + bX) / 2, aY);
                        (frameworkElement as Polygon).Points[2] = new Point(bX, bY);
                    }
                    else if (frameworkElement is Image)
                    {
                        frameworkElement.Width = Math.Max(0, frameworkElement.Width + diffX);
                        frameworkElement.Height = Math.Max(0, frameworkElement.Height + diffY);
                    }
                    else
                    {
                        frameworkElement.Width = Math.Max(0, frameworkElement.Width + diffX);
                        frameworkElement.Height = Math.Max(0, frameworkElement.Height + diffY);
                    }
                
                }
                startPosition = newPosition;
            }        
        }
        protected override void OnPreviewMouseLeftButtonUp(MouseButtonEventArgs e)
        {
            if (isDraging)
            {
                Mouse.Capture(null);
                isDraging = false;
            }
        }

        protected override void OnPreviewMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            if (Mouse.Capture(this))
            {
                isDraging = true;
                startPosition = Mouse.GetPosition(canvas);
            }
        }

        protected override void OnMouseLeave(MouseEventArgs e)
        {
            AdornerLayer adornerLayer = AdornerLayer.GetAdornerLayer(frameworkElement);
            if (adornerLayer != null)
            {
                Adorner[] adorners = adornerLayer.GetAdorners(frameworkElement);
                if(adorners != null)
                {
                    foreach(Adorner adorner in adorners)
                    {
                        adornerLayer.Remove(adorner);
                    }
                }
            }
        }

        private MousePosition getMousePosition(Point point)
        {
            double h2 = ActualHeight / 2;
            double w2 = ActualHeight / 2;
            if (point.X < w2 && point.Y < h2)
            {
                return MousePosition.TL;
            }
            else if (point.X > w2 && point.Y > h2)
            {
                return MousePosition.BR;
            }
            else if (point.X > w2 && point.Y < h2)
            {
                return MousePosition.TR;
            }
            else
            {
                return MousePosition.BL;
            }
        }
    }
}

