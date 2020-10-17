using MaterialDesignThemes.Wpf;
using System;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace HomeworkManager
{
    /// <summary>
    /// LessonDemo.xaml 的交互逻辑
    /// </summary>
    public partial class LessonDemo : Page
    {
        public LessonDemo(Frame f, WrapPanel panel, pv.Task t)
        {
            InitializeComponent();
            frame = f;
            panel1 = panel;
            tt = t;
        }
        pv.Task tt = new pv.Task();
        Frame frame = null;
        WrapPanel panel1 = null;
        private void StackPanel_Loaded(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("init!");
            lesson.Content = tt.name;
            task.Content = tt.Content;
            tmp.SelectedTime = tt.EndTime;
            changelesson.Text = tt.Content;
            if (tt.EndTime.Year>2050)
            {
                endingtime.Content = "截止时间：无限制";
            }
            else
            {
                endingtime.Content = tt.EndTime.ToLongDateString() + tt.EndTime.ToShortTimeString();
            }
            if (tt.Appendix!="")
            {
                endingtime.Content += Environment.NewLine + tt.Appendix;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            panel1.Children.Remove(frame);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)//set
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            System.Timers.Timer timer = new System.Timers.Timer();

            timer.Interval = 10000;
            timer.Elapsed += new ElapsedEventHandler((_sender, eventArgs) =>
            {
                if (ExecDateDiff(DateTime.Now, tt.EndTime).Ticks < 0)
                {

                    this.stkpn.Dispatcher.Invoke(new Action(delegate
                    {
                        var alphaAnimation = new DoubleAnimationUsingKeyFrames();
                        var keyFrames = alphaAnimation.KeyFrames;
                        keyFrames.Add(new SplineDoubleKeyFrame(0, TimeSpan.FromSeconds(0)));
                        keyFrames.Add(new SplineDoubleKeyFrame(1, TimeSpan.FromSeconds(4)));
                        keyFrames.Add(new SplineDoubleKeyFrame(0, TimeSpan.FromSeconds(8)));
                        alphaAnimation.RepeatBehavior = RepeatBehavior.Forever;
                        stkpn.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                        stkpn.BeginAnimation(OpacityProperty, alphaAnimation);

                    }));
                    this.lesson.Dispatcher.Invoke(new Action(delegate
                    {
                        lesson.Content = lesson.Content + "(超时)";
                    }));
                    timer.Stop();
                }
            });
            timer.Start();


        }
        public static TimeSpan ExecDateDiff(DateTime dateBegin, DateTime dateEnd)
        {
            TimeSpan ts1 = new TimeSpan(dateBegin.Ticks);
            TimeSpan ts2 = new TimeSpan(dateEnd.Ticks);
            TimeSpan ts3 = ts2.Subtract(ts1);
            return ts3;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (changelesson.Text!="")
            {
                task.Content = changelesson.Text;
            }
            task.Foreground = new SolidColorBrush(c1);
            task.Background = new SolidColorBrush(c2);
            tt.EndTime = (DateTime)tmp.SelectedTime;
            endingtime.Content = ((DateTime)tmp.SelectedTime.Value).ToShortTimeString();

            dialoguehost.IsOpen = false;
        }

        Color c1 = Colors.Black;
        Color c2 = Colors.Transparent;

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                c1 = Color.FromArgb(colorDialog.Color.A, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
                cbut1.Foreground = new SolidColorBrush(c1);
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                c2 = Color.FromArgb(colorDialog.Color.A, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
                cbut2.Foreground = new SolidColorBrush(c2);
            }
        }
    }
}
