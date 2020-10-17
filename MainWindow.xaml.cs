using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace HomeworkManager
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void NavBar_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {

        }

        object cont_h = null;
        private void Homework_Click(object sender, RoutedEventArgs e)
        {
            //NavigationWindow window = new NavigationWindow();
            if (cont_h==null)
            {
                homework h = new homework();
                MainPage.Content = h;
                cont_h = h;
            }
            else
            {
                MainPage.Content = cont_h;
            }


        }

        private void Button_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        bool MaxOrMin = false;
        private void Button_Maxium(object sender, RoutedEventArgs e)
        {
            if (MaxOrMin)
            {
                this.WindowState = WindowState.Normal;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
            }
            MaxOrMin = !MaxOrMin;
        }

        private void Button_Minium(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void NavBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.bakamashiro.xyz");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("更多功能添加中！");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MainPage.Content = new help();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("更多功能添加中！");

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MainPage.Content = new help();
        }
    }
}
