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

namespace HomeworkManager
{
    /// <summary>
    /// homework.xaml 的交互逻辑
    /// </summary>
    public partial class homework : Page
    {
        public homework()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Frame frame = new Frame();
            //LessonDemo ls = new LessonDemo(frame, HomeWorkHolder);
            //ls.Margin = new Thickness(1, 1, 1, 1);
            //frame.Content = ls;
            //frame.Background = Brushes.Transparent;
            //frame.NavigationUIVisibility = NavigationUIVisibility.Hidden;

            //Label l = new Label();
            //l.Content = "1232141";
            //HomeWorkHolder.Children.Add(frame);

            AddLesson ads = new AddLesson(HomeWorkHolder);
            ads.WindowState = WindowState.Normal;
            ads.Show();

        }

    }
}
