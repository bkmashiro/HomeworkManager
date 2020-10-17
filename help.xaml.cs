using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace HomeworkManager
{
    /// <summary>
    /// help.xaml 的交互逻辑
    /// </summary>
    public partial class help : Page
    {
        public help()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var alphaAnimation = new DoubleAnimationUsingKeyFrames();
            var keyFrames = alphaAnimation.KeyFrames;
            keyFrames.Add(new SplineDoubleKeyFrame(1, TimeSpan.FromSeconds(0)));
            keyFrames.Add(new SplineDoubleKeyFrame(0, TimeSpan.FromSeconds(4)));
            l1.BeginAnimation(OpacityProperty, alphaAnimation);
            l2.BeginAnimation(OpacityProperty, alphaAnimation);
            b1.BeginAnimation(OpacityProperty, alphaAnimation);
            l2_Copy1.BeginAnimation(OpacityProperty, alphaAnimation);
            var alphaAnimation2 = new DoubleAnimationUsingKeyFrames();
            var keyFrames2 = alphaAnimation2.KeyFrames;
            keyFrames2.Add(new SplineDoubleKeyFrame(0, TimeSpan.FromSeconds(0)));
            keyFrames2.Add(new SplineDoubleKeyFrame(1, TimeSpan.FromSeconds(4)));
            info.BeginAnimation(OpacityProperty, alphaAnimation2);
            
        }
    }
}
