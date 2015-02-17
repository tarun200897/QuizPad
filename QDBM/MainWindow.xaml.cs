using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QPAD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int index = -1;
        Viewmodel vm = new Viewmodel();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = vm;
        }
        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TabControl tc = (TabControl)sender;
            if (tc.SelectedIndex != index)
            {
                Grid cont = (Grid)((TabItem)(tc.SelectedItem)).Content;
                ThicknessAnimation thick = new ThicknessAnimation { Duration = TimeSpan.FromSeconds(0.2), From = new Thickness(25, 0, -25, 0), To = new Thickness(0, 0, 0, 0) };
                DoubleAnimation op = new DoubleAnimation { Duration = TimeSpan.FromSeconds(0.2), From = 0, To = 1 };
                cont.BeginAnimation(MarginProperty, thick);
                cont.BeginAnimation(OpacityProperty, op);
                index = tc.SelectedIndex;
            }
        }

        private void btnmin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void ButtonRestore_Click(object sender, RoutedEventArgs e)
        {
            if(this.WindowState == System.Windows.WindowState.Maximized)
                this.WindowState = System.Windows.WindowState.Normal;
            else
                this.WindowState = System.Windows.WindowState.Maximized;
        }
        private void btnclose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    //DoubleAnimation op = new DoubleAnimation { To = 0, Duration = TimeSpan.FromSeconds(0.2) };
        //    //gridadd.BeginAnimation(OpacityProperty, op);
        //}

        //private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        //{
        //    DoubleAnimation op = new DoubleAnimation { To = 1, Duration = TimeSpan.FromSeconds(0.2) };
        //    gridadd.BeginAnimation(OpacityProperty, op);
        //}



    }
}
