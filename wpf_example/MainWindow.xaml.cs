using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_example
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private bool _isMoving;
        private Point? _buttonPosition;
        private double deltaX, deltaY;
        private TranslateTransform _currentTT;

        private void Samplebutton_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (_buttonPosition == null)
                _buttonPosition = Samplebutton.TransformToAncestor(myGrid).Transform(new Point(0, 0));
            var mousePosition = Mouse.GetPosition(myGrid);
            deltaX = mousePosition.X - _buttonPosition.Value.X;
            deltaY = mousePosition.Y - _buttonPosition.Value.Y;
            _isMoving = true;
        }

        private void Samplebutton_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            _currentTT = Samplebutton.RenderTransform as TranslateTransform;
            _isMoving = false;
        }

        private void myGrid_Loaded(object sender, RoutedEventArgs e)
        {
            Button btn = new Button();
            btn.Content = "New Button";
            btn.Width = 100;
            btn.Height = 100;
            btn.VerticalAlignment = VerticalAlignment.Top;
            btn.Click += mouseClick;
            myGrid.Children.Add(btn);   
        }
        private void mouseClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((sender as Button).Content.ToString());
        }
        private void Samplebutton_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (!_isMoving) return;

            var mousePoint = Mouse.GetPosition(myGrid);

            var offsetX = (_currentTT == null ? _buttonPosition.Value.X : _buttonPosition.Value.X - _currentTT.X) + deltaX - mousePoint.X;
            var offsetY = (_currentTT == null ? _buttonPosition.Value.Y : _buttonPosition.Value.Y - _currentTT.Y) + deltaY - mousePoint.Y;

            this.Samplebutton.RenderTransform = new TranslateTransform(-offsetX, -offsetY);
        }
    }
}
