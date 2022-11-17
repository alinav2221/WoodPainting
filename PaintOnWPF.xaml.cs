using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using MouseEventArgs = System.Windows.Input.MouseEventArgs;
using UserControl = System.Windows.Controls.UserControl;
using System.Windows.Media.Effects;
using System.Windows.Media.Animation;

namespace WoodPainting2
{
    /// <summary>
    /// Логика взаимодействия для PaintOnWPF.xaml
    /// </summary>
    public partial class PaintOnWPF : UserControl
    {
        Rect rectangle = new Rect();
        DoubleCollection doubleCollection = new DoubleCollection();
        PointCollection points = new PointCollection();
        ModePaint mode;
        Polygon polygon;
        Ellipse ellipse;
        Rectangle rect;
        Rectangle lineRect, boundsRect;
        Line line;
        Point previousPoint, currentPoint;
        private AdornerLayer myAdornerLayer;
        List<Shape> shapes = new List<Shape>();
        List<Image> images = new List<Image>();
        List<Shape> selected = new List<Shape>();
        List<Image> selectedImages = new List<Image>();
        List<StackPanel> stackPanels = new List<StackPanel>();
        double heightLine;
        string fileName = "";

        enum ModePaint
        {
            None,
            Ellipse,
            Line,
            Pen,
            Rectangle,
            Triangle,
            Template,
            Move,
            Pointer,
            Eraser,
            Clear,
            Save
        }

        public PaintOnWPF()
        {
            InitializeComponent();

            mode = ModePaint.None;

            StackPanels();

            AddImages("Мезенская роспись", mezenTemplatePanel);
            AddImages("Борецкая роспись", boretskayaTemplatePanel);
            AddImages("Онежская роспись", onegskayaTemplatePanel);
            AddImages("Пермогорская роспись", permogorskayaTemplatePanel);
            AddImages("Пижемская роспись", pigemskayaTemplatePanel);
            AddImages("Пучужская роспись", puchugskayaTemplatePanel);
            AddImages("Ракульская роспись", raculskayaTemplatePanel);
            AddImages("Уфтюжская роспись", uftyuzhskayaTemplatePanel);
            AddImages("Шенкурская роспись", shenkurskayaTemplatePanel);
        }

        private void OpenFile(string region)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Images |*.png;*.jpg";
                dialog.InitialDirectory = $"{System.Windows.Forms.Application.StartupPath}\\{region}\\Дорисовать композиции";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    VisualBrush visualBrush = new VisualBrush();
                    BitmapImage bitmapImage = new BitmapImage(new Uri(dialog.FileName, UriKind.Absolute));
                    Image image = new Image
                    {
                        Source = bitmapImage,
                        Stretch = Stretch.Uniform
                    };
                    visualBrush.Visual = image;
                    canvas.Background = visualBrush;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void TemplatePictureOpenOnClick(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.Button btn = sender as System.Windows.Controls.Button;
            if (btn.Name == "mezenPictureOpen")
            {
                OpenFile("Мезенская роспись");
            }
            if (btn.Name == "pigmaPictureOpen")
            {
                OpenFile("Пижемская роспись");
            }
            if (btn.Name == "raculskayaPictureOpen")
            {
                OpenFile("Ракульская роспись");
            }
            if (btn.Name == "boretskayaPictureOpen")
            {
                OpenFile("Борецкая роспись");
            }
            if (btn.Name == "permogorskayaPictureOpen")
            {
                OpenFile("Пермогорская роспись");
            }
            if (btn.Name == "puchugskayaPictureOpen")
            {
                OpenFile("Пучужская роспись");
            }
            if (btn.Name == "uftyuzhskayaPictureOpen")
            {
                OpenFile("Уфтюжская роспись");
            }
            if (btn.Name == "shenkurskayaPictureOpen")
            {
                OpenFile("Шенкурская роспись");
            }
            if (btn.Name == "onegskayaPictureOpen")
            {
                OpenFile("Онежская роспись");
            }
        }
        private void TemplatePictureAddOnClick(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.Button btn = sender as System.Windows.Controls.Button;
            if (btn.Name == "mezenPictureAdd")
            {
                AddTemplate("Мезенская роспись", mezenTemplatePanel);
                Animation(mezenPanel);
            }
            if (btn.Name == "pigmaPictureAdd")
            {
                AddTemplate("Пижемская роспись", pigemskayaTemplatePanel);
                Animation(pigemskayaPanel);
            }
            if (btn.Name == "raculskayaPictureAdd")
            {
                AddTemplate("Ракульская роспись", raculskayaTemplatePanel);
                Animation(raculskayaPanel);
            }
            if (btn.Name == "boretskayaPictureAdd")
            {
                AddTemplate("Борецкая роспись", boretskayaTemplatePanel);
                Animation(boretskayaPanel);
            }
            if (btn.Name == "permogorskayaPictureAdd")
            {
                AddTemplate("Пермогорская роспись", permogorskayaTemplatePanel);
                Animation(permogorskayaPanel);
            }
            if (btn.Name == "puchugskayaPictureAdd")
            { 
                AddTemplate("Пучужская роспись", puchugskayaTemplatePanel);
                Animation(puchugskayaPanel);
            }
            if (btn.Name == "uftyuzhskayaPictureAdd")
            {
                AddTemplate("Уфтюжская роспись", uftyuzhskayaTemplatePanel);
                Animation(uftyuzhskayaPanel);
            }
            if (btn.Name == "shenkurskayaPictureAdd")
            {
                AddTemplate("Шенкурская роспись", shenkurskayaTemplatePanel);
                Animation(shenkurskayaPanel);
            }
            if (btn.Name == "onegskayaPictureAdd")
            {
                AddTemplate("Онежская роспись", onegskayaTemplatePanel);
                Animation(onegskayaPanel);
            }
        }
        private void StackPanels()
        {
            stackPanels.Add(mezenPanel);
            stackPanels.Add(pigemskayaPanel);
            stackPanels.Add(raculskayaPanel);
            stackPanels.Add(boretskayaPanel);
            stackPanels.Add(permogorskayaPanel);
            stackPanels.Add(puchugskayaPanel);
            stackPanels.Add(uftyuzhskayaPanel);
            stackPanels.Add(shenkurskayaPanel);
            stackPanels.Add(onegskayaPanel);
        }

        private void PanelsOnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            StackPanel stackPanel = sender as StackPanel;
            Animation(stackPanel);
        }

        bool isShow = false;
        private void Animation(StackPanel stackPanel)
        {
            DoubleAnimation stackPanelDoubleAnimation = new DoubleAnimation();
            stackPanelDoubleAnimation.Duration = TimeSpan.FromMilliseconds(500);
            stackPanelDoubleAnimation.AccelerationRatio = 0.6;
            stackPanelDoubleAnimation.DecelerationRatio = 0.4;
            foreach (StackPanel item in stackPanels)
            {
                if (stackPanel.Name == item.Name)
                {
                    string region = (stackPanel.Children[0] as System.Windows.Controls.Label).Content.ToString();
                    var files = Directory.GetFiles($"{System.Windows.Forms.Application.StartupPath}\\{region}\\Шаблоны");
                    int n = files.Count();
                    int rows = n / 3 + ((n % 3) > 0 ? 1 : 0);
                    stackPanelDoubleAnimation.To = 100 + 55 * rows;
                }
                else
                {
                    stackPanelDoubleAnimation.To = 50;
                }
                item.BeginAnimation(StackPanel.HeightProperty, stackPanelDoubleAnimation);
            }
        }

        private void AddImages(string region, WrapPanel imageContainer)
        {
            try
            {
                var files = Directory.GetFiles($"{System.Windows.Forms.Application.StartupPath}\\{region}\\Шаблоны");
                foreach (var item in files)
                {
                    Image image = new Image();
                    image.Source = new BitmapImage(new Uri($"file:///{item}"));
                    image.MouseLeftButtonDown += ImageOnMouseLeftButtonDown;
                    imageContainer.Children.Add(image);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void AddTemplate(string region, WrapPanel imageContainer)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Файлы изображений|*.bmp;*.jpg;*.png";
                openFileDialog.Multiselect = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (var item in openFileDialog.FileNames)
                    {
                        File.Copy(item, $"{System.Windows.Forms.Application.StartupPath}\\{region}\\Шаблоны\\" + System.IO.Path.GetFileName(item));
                        Image image = new Image();
                        image.Source = new BitmapImage(new Uri($"{System.Windows.Forms.Application.StartupPath}\\{region}\\Шаблоны\\" + System.IO.Path.GetFileName(item)));
                        image.MouseLeftButtonDown += ImageOnMouseLeftButtonDown;
                        //image.AllowDrop = true;
                        imageContainer.Children.Add(image);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        string currentTempate="";
        private void ImageOnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            currentTempate = (sender as Image).Source.ToString();
            SelectButton(ModePaint.Template, "templateButton");
        }

        UIElement targetElement; 
        Point targetPoint;
        FrameworkElement frameworkElement;
        
        private void CanvasOnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            targetElement = e.Source as UIElement;
            frameworkElement = e.Source as FrameworkElement;
            if (e.ButtonState == MouseButtonState.Pressed)
                previousPoint = e.GetPosition(canvas);

            if (mode == ModePaint.Pointer)
            {
                myAdornerLayer = AdornerLayer.GetAdornerLayer(targetElement);
                myAdornerLayer.Add(new SimpleCircleAdorner(frameworkElement, canvas, frameworkElement));

                //для фигур
                if (e.OriginalSource is Shape)
                {
                    var shape = (Shape)e.OriginalSource;
                    if (!selected.Contains(shape)) //if it wasnt selected - deselect all and select only this 
                    {
                        foreach (var s in selected)
                        {
                            System.Windows.Controls.Panel.SetZIndex(s, 0);
                            s.Effect = null;
                        }
                        selected.Clear();

                        Select(shape);
                    }
                }
                else //all the selected shapes are deselected when click on canvas 
                {
                    foreach (var s in selected)
                    {
                        System.Windows.Controls.Panel.SetZIndex(s, 0);
                        s.Effect = null;
                    }
                    selected.Clear();
                }

                //для шаблонов
                if (e.OriginalSource is Image)
                {
                    var image = (Image)e.OriginalSource;
                    if (!selectedImages.Contains(image)) //if it wasnt selected - deselect all and select only this 
                    {
                        foreach (var s in selectedImages)
                        {
                            System.Windows.Controls.Panel.SetZIndex(s, 0);
                            s.Effect = null;
                        }
                        selectedImages.Clear();

                        SelectImages(image);
                    }
                }
                else //all the selected shapes are deselected when click on canvas 
                {
                    foreach (var s in selectedImages)
                    {
                        System.Windows.Controls.Panel.SetZIndex(s, 0);
                        s.Effect = null;
                    }
                    selectedImages.Clear();
                }
            }
            if (mode == ModePaint.Rectangle)
            {
                rect = new Rectangle
                {
                    StrokeThickness = sizeSlider.Value,
                    Fill = colorFillTextBox.Background,
                    Stroke = colorCircuitTextBox.Background
                };
                canvas.Children.Add(rect);
                rect.ClipToBounds=true;
                shapes.Add(rect);
            }
            if (mode == ModePaint.Line)
            {
                line = new Line
                {
                    StrokeThickness = sizeSlider.Value,
                    Stroke = colorCircuitTextBox.Background
                };
                lineRect = new Rectangle
                {
                    Fill = colorCircuitTextBox.Background
                };
                canvas.Children.Add(lineRect);
                lineRect.Name = "Line";
                lineRect.ClipToBounds = true;
                shapes.Add(lineRect);
            }
            if (mode == ModePaint.Ellipse)
            {
                ellipse = new Ellipse
                {
                    StrokeThickness = sizeSlider.Value,
                    Fill = colorFillTextBox.Background,
                    Stroke = colorCircuitTextBox.Background
                };
                canvas.Children.Add(ellipse);
                ellipse.ClipToBounds = true;
                shapes.Add(ellipse);
            }
            if (mode == ModePaint.Triangle)
            {
                polygon = new Polygon
                {
                    Stroke = colorCircuitTextBox.Background,
                    Fill = colorFillTextBox.Background,
                    StrokeThickness = sizeSlider.Value
                };

                canvas.Children.Add(polygon);
                polygon.ClipToBounds = true;
                shapes.Add(polygon);
            }
            if (mode == ModePaint.Move)
            {
                if (targetElement != null)
                {
                    targetPoint = e.GetPosition(targetElement);
                    // Начинаем захватывать мышь
                    targetElement.CaptureMouse();
                }
            }
        }

        private void SelectImages(Image image)
        {
            if (mode == ModePaint.Pointer)
            {
                DropShadowEffect glow = new DropShadowEffect();
                glow.Color = Colors.White;
                glow.BlurRadius = 50;
                glow.Direction = 270;

                selectedImages.Add(image);
                System.Windows.Controls.Panel.SetZIndex(image, 1);
            }
        }

        private void Select(Shape shape)
        {
            if (mode == ModePaint.Pointer)
            {
                DropShadowEffect glow = new DropShadowEffect();
                glow.Color = Colors.White;
                glow.BlurRadius = 50;
                glow.Direction = 270;

                selected.Add(shape);
                System.Windows.Controls.Panel.SetZIndex(shape, 1);
            }
        }

        private void CanvasOnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (mode == ModePaint.Move)
            {
                Mouse.Capture(null);
            }
            if (mode == ModePaint.Template)
            {
                Image image = new Image();
                image.Source = new BitmapImage(new Uri(currentTempate));
                image.Width = image.Source.Width;
                image.Height = image.Source.Height;

                var x = e.GetPosition(canvas).X;
                var y = e.GetPosition(canvas).Y;

                var width = image.Source.Width /2;
                var height = image.Source.Height/2;

                x = x < width ? 0 : x - width;
                y = y < height ? 0 : y - height;

                canvas.Children.Add(image);
                Canvas.SetTop(image, y);
                Canvas.SetLeft(image, x);
                images.Add(image);
            }
        }


        private void CanvasOnMouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                currentPoint = e.GetPosition(canvas);
            }
            if (mode == ModePaint.Pen)
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    Line pen = new Line();
                    pen.Stroke = colorCircuitTextBox.Background;
                    pen.X1 = previousPoint.X;
                    pen.Y1 = previousPoint.Y;
                    pen.X2 = currentPoint.X;
                    pen.Y2 = currentPoint.Y;
                    pen.StrokeThickness = sizeSlider.Value;
                    previousPoint = e.GetPosition(canvas); 
                    canvas.Children.Add(pen);
                }
            }
            if (mode == ModePaint.Eraser)
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    Line eraser = new Line();
                    eraser.Stroke = new SolidColorBrush(Colors.White);
                    eraser.StrokeThickness = sizeSlider.Value;
                    eraser.X1 = previousPoint.X;
                    eraser.Y1 = previousPoint.Y;
                    eraser.X2 = currentPoint.X;
                    eraser.Y2 = currentPoint.Y;
                    previousPoint = e.GetPosition(canvas);
                    canvas.Children.Add(eraser);
                }
            }
            if (mode == ModePaint.Line)
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    line.X1 = previousPoint.X;
                    line.Y1 = previousPoint.Y;
                    line.X2 = currentPoint.X;
                    line.Y2 = currentPoint.Y;
                    line.StrokeThickness = sizeSlider.Value;

                    lineRect.SetValue(Canvas.LeftProperty, line.X1);
                    lineRect.SetValue(Canvas.TopProperty, line.Y1);
                    lineRect.Width = Math.Sqrt(Math.Pow(line.X2 - line.X1, 2) + Math.Pow(line.Y2 - line.Y1,2));
                    lineRect.Height = Math.Abs(sizeSlider.Value);
                    var angle = Math.Atan2(line.Y2 - line.Y1, line.X2-line.X1)*180/Math.PI;
                    RotateTransform rotateTransform = new RotateTransform();
                    var trGroup = new TransformGroup();
                    trGroup.Children.Add(rotateTransform);
                    lineRect.RenderTransform = trGroup;
                    rotateTransform.Angle = angle;
                }
            }
            if (mode == ModePaint.Ellipse)
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    ellipse.SetValue(Canvas.LeftProperty, Math.Min(currentPoint.X, previousPoint.X));
                    ellipse.SetValue(Canvas.TopProperty, Math.Min(currentPoint.Y, previousPoint.Y));
                    if (isShift)
                    {
                        double diameter = Math.Min(
                            Math.Abs(currentPoint.X - previousPoint.X),
                            Math.Abs(currentPoint.Y - previousPoint.Y));
                        ellipse.Width = ellipse.Height = diameter;
                    }
                    else
                    {
                        ellipse.Width = Math.Abs(currentPoint.X - previousPoint.X);
                        ellipse.Height = Math.Abs(currentPoint.Y - previousPoint.Y);
                    }
                }
            }
            if (mode == ModePaint.Rectangle)
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    rect.SetValue(Canvas.LeftProperty, Math.Min(currentPoint.X, previousPoint.X));
                    rect.SetValue(Canvas.TopProperty, Math.Min(currentPoint.Y, previousPoint.Y));
                    rect.Width = Math.Abs(currentPoint.X - previousPoint.X);
                    rect.Height = Math.Abs(currentPoint.Y - previousPoint.Y);
                }
            }
            if (mode == ModePaint.Triangle)
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    double aY = 0;
                    double bY = Math.Abs(previousPoint.Y - currentPoint.Y);
                    if (currentPoint.Y < previousPoint.Y)
                    {
                        (aY, bY) = (bY, aY);
                    }
                    points = new PointCollection
                    {
                        new Point(0, bY),
                        new Point(Math.Abs(previousPoint.X - currentPoint.X)/2, aY),
                        new Point(Math.Abs(previousPoint.X - currentPoint.X), bY),
                        new Point(0, bY),
                    };
                    polygon.Points = points;
                    polygon.Margin = new Thickness(
                        Math.Min(currentPoint.X, previousPoint.X),
                        Math.Min(currentPoint.Y, previousPoint.Y),
                        0, 0);
                }
            }
            if (mode == ModePaint.Move)
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    targetElement = Mouse.Captured as UIElement;
                    if (targetElement != null)
                    {
                        var pCanvas = e.GetPosition(canvas);
                        if (targetElement is Polygon)
                        {
                            var frameworkElement = Mouse.Captured as FrameworkElement;
                            frameworkElement.Margin = new Thickness(pCanvas.X, pCanvas.Y, 0, 0);
                        }
                        else
                        {
                            // Установить конечную позицию
                            Canvas.SetLeft(targetElement, pCanvas.X - targetPoint.X);
                            Canvas.SetTop(targetElement, pCanvas.Y - targetPoint.Y);
                        }
                    }
                }
            }
        }

        private void ArrowButtonOnClick(object sender, RoutedEventArgs e)
        {
            SelectButton(ModePaint.Pointer, "arrowButton");
        }

        private void PenButtonOnClick(object sender, RoutedEventArgs e)
        {
            SelectButton(ModePaint.Pen, "penButton");
        }

        private void LineButtonOnClick(object sender, RoutedEventArgs e)
        {
            SelectButton(ModePaint.Line, "lineButton");
        }

        private void RoundButtonOnClick(object sender, RoutedEventArgs e)
        {
            SelectButton(ModePaint.Ellipse, "roundButton");
        }

        private void RectangleButtonOnClick(object sender, RoutedEventArgs e)
        {
            SelectButton(ModePaint.Rectangle, "rectangleButton");
        }

        private void TriangleButtonOnClick(object sender, RoutedEventArgs e)
        {
            SelectButton(ModePaint.Triangle, "triangleButton");
        }

        private void EraserButtonOnClick(object sender, RoutedEventArgs e)
        {
            SelectButton(ModePaint.Eraser, "eraserButton");
        }

        private void MoveButtonOnClick(object sender, RoutedEventArgs e)
        {
            SelectButton(ModePaint.Move, "moveButton");
        }

        private void SelectButton(ModePaint currentMode, string buttonName)
        {
            mode = currentMode;
            selected.Clear();
            selectedImages.Clear();
            rotateSlider.Value = 0;
            foreach (System.Windows.Controls.Button item in toolStackPanel.Children)
            {
                Color buttonColor = (item.Name != buttonName) ? Color.FromRgb(242, 203, 38) : Colors.White;
                item.Background = new SolidColorBrush(buttonColor);
            }
        }
        private void ColorCircuitButtonOnClick(object sender, RoutedEventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                colorCircuitTextBox.Background = new SolidColorBrush(Color.FromArgb(colorDialog.Color.A, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B));
                if (selected != null && selected.Count > 0)
                {
                    var last = selected.Last();
                    last.Stroke = colorCircuitTextBox.Background;
                }                
            }
            else
            {
                colorFillTextBox.Background = new SolidColorBrush(Colors.Black);
            }
        }

        private void ClearButtonOnClick(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
        }

        private void SaveButtonOnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                Rect bounds = VisualTreeHelper.GetDescendantBounds(canvas);
                double dpi = 96d;
                RenderTargetBitmap image = new RenderTargetBitmap((int)bounds.Width, (int)bounds.Height, dpi, dpi, System.Windows.Media.PixelFormats.Default);
                DrawingVisual drawingVisual = new DrawingVisual();
                using (DrawingContext drawingContext = drawingVisual.RenderOpen())
                {
                    VisualBrush visualBrush = new VisualBrush(canvas);
                    drawingContext.DrawRectangle(visualBrush, null, new Rect(new Point(), bounds.Size));
                }
                image.Render(drawingVisual);
                PngBitmapEncoder encoder = new PngBitmapEncoder();  //конвертируем в png формат
                encoder.Frames.Add(BitmapFrame.Create(image));

                if (fileName == "")
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "*.png|*.png";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream file = File.Create(saveFileDialog.FileName))
                        {
                            encoder.Save(file);
                            fileName = saveFileDialog.FileName;
                        }
                    }
                }
                else
                {
                    using (FileStream file = File.OpenWrite(fileName))
                    {
                        encoder.Save(file);
                    }
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка сохранения файла!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool isShift = false;
        private void CanvasOnKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.KeyboardDevice.Modifiers == ModifierKeys.Control && e.Key == Key.X)
            {
                if (selected.Count > 0)
                {
                    foreach (Shape shape in selected)
                    {
                        canvas.Children.Remove(shape);
                    }
                    selected.Clear();
                }
                if (selectedImages.Count > 0)
                {
                    foreach (Image shape in selectedImages)
                    {
                        canvas.Children.Remove(shape);
                    }
                    selectedImages.Clear();
                }
            }
            else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
            {
                isShift = true;
            }
        }

        private void UserControlOnKeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            isShift = false;
        }

        private void RotateSliderOnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (selected != null && selected.Count > 0)
            {
                var trRotate = new RotateTransform();
                var trGroup = new TransformGroup();
                trGroup.Children.Add(trRotate);

                var last = selected.Last();
                last.ClipToBounds = true;
                last.RenderTransform = trGroup;
                trRotate.Angle = rotateSlider.Value;
                if (last.Name == "Line")
                {
                    //RotateTransform rotate = (last.RenderTransform as TransformGroup).Children.OfType<RotateTransform>().FirstOrDefault();
                    //var angle = last.RenderTransform;
                    //var d = last.Width / Math.Sin(angle.Value.M22);
                    //var h = Math.Sqrt(Math.Pow(d, 2) - Math.Pow(last.Width, 2));
                    ////var w = Math.Sqrt(Math.Pow(d, 2) + Math.Pow(h, 2));
                    trRotate.CenterX = last.RenderSize.Width/2;
                    trRotate.CenterY = last.RenderSize.Height / 2;
                }
                else if (last is Polygon)
                {
                    trRotate.CenterX = last.RenderSize.Width / 2;
                    trRotate.CenterY = last.RenderSize.Height / 2;
                }
                else
                {
                    trRotate.CenterX = last.Width / 2;
                    trRotate.CenterY = last.Height / 2;
                }
            }
            else if (selectedImages != null && selectedImages.Count > 0)
            {
                var trRotate = new RotateTransform();
                var trGroup = new TransformGroup();
                trGroup.Children.Add(trRotate);

                var last = selectedImages.Last();
                last.ClipToBounds = true;
                last.RenderTransform = trGroup;
                trRotate.Angle = rotateSlider.Value;
                trRotate.CenterX = last.Width / 2;
                trRotate.CenterY = last.Height / 2;
            }
        }

        private void ColorFillButtonOnClick(object sender, RoutedEventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                colorFillTextBox.Background = new SolidColorBrush(Color.FromArgb(colorDialog.Color.A, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B));
                if (selected != null && selected.Count > 0)
                {
                    var last = selected.Last();
                    last.Fill = colorFillTextBox.Background;
                }
            }
            else
            {
                colorFillTextBox.Background = new SolidColorBrush(Colors.Transparent);
            }
        }

        private void SizeSliderOnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (selected != null && selected.Count > 0)
            {
                var last = selected.Last();
                last.StrokeThickness = sizeSlider.Value;
            }
        }

        private void BackgroundImageButtonOnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Images |*.png;*.jpg";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ImageBrush brush = new ImageBrush();
                    brush.ImageSource = new BitmapImage(new Uri(dialog.FileName, UriKind.Absolute));
                    canvas.Background = brush;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void BackgroundColorButtonOnClick(object sender, RoutedEventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                canvas.Background = new SolidColorBrush(Color.FromArgb(colorDialog.Color.A, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B));
            }
        }
    }
}
