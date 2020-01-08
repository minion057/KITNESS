using System;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

namespace Kitness
{
    /// <summary>
    /// PartSelection.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class PartSelection : Window
    {
        SplashScreen splashScreen = new SplashScreen("image/etc/loading.gif");
        //로딩 이미지 먼저 띄우기 위한 변수 >> gif 파일이지만 wpf는 splashScreen에 정적이미지만 지원하므로 멈춘 gif파일이 보인다

        public PartSelection()
        {
            splashScreen.Show(true);
            InitializeComponent();
            Thread.Sleep(500);
            if(!Kinect_Point.tutorial_check()) tutorial();
        }

        private void tutorial()
        { //튜토리얼 진행여부 확인 >> 로딩이미지 튜토리얼한 적이 없다고 알리기, 만약 알고있다면 창 끄라고 알리는 이미지로 변경하기
            splashScreen = new SplashScreen("image/guide/tuto_start.png");
            splashScreen.Show(false);
            //splashScreen.Close(new TimeSpan(0, 0, 3));
            //2초동안 사진이 보이며 사라진다
            Thread.Sleep(2000);
            //timeSpan이 먹히지 않아 강제로 쓰레드를 멈춘다
            splashScreen.Close(new TimeSpan(0));

            Tutorial t = new Tutorial();
            t.ShowDialog();
        }

        private void Btpart_Click(object sender, RoutedEventArgs e)
        {
            Kinect_Point.user_choice_name = ((Button)sender).Uid;
            Kinect_Point.user_choice = ((Button)sender).Name;
            Default_ready part = new Default_ready();
            Close();
            part.ShowDialog();
        }

        private void BtTutorial_Click(object sender, RoutedEventArgs e)
        {
            if (!Kinect_Point.tutorial_check())
            {
                tutorial();
                return;
            }
            splashScreen = new SplashScreen("image/guide/tuto_restart.png");
            splashScreen.Show(false);
            //splashScreen.Close(new TimeSpan(0, 0, 3));
            //3초동안 사진이 보이며 사라진다
            Thread.Sleep(1000);
            //timeSpan이 먹히지 않아 강제로 쓰레드를 멈춘다
            splashScreen.Close(new TimeSpan(0));
            Tutorial t = new Tutorial();
            t.ShowDialog();
        }

        private void BtExit(object sender, RoutedEventArgs e)
        {
            Exit exit = new Exit();
            Close();

            splashScreen.Show(true);
            exit.ShowDialog();
        }

        private void Btinfo(object sender, RoutedEventArgs e)
        {
            Information info = new Information();
            info.ShowDialog();
        }

        private void part_mouseover(object sender, RoutedEventArgs e)
        {
            try
            {
                var uriSource = new Uri(@"pack://application:,,,/image/exercise/" + ((Button)sender).Name.ToString() + ".gif", UriKind.Absolute);
                var image = new System.Windows.Media.Imaging.BitmapImage();
                image.BeginInit();
                image.UriSource = uriSource;
                image.EndInit();
                WpfAnimatedGif.ImageBehavior.SetAnimatedSource(img_gif, image);
                img_gif.Visibility = Visibility.Visible;
            }
            catch (Exception ex) //이미지가 없는 경우
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void part_mouseleave(object sender, RoutedEventArgs e)
        {
            img_gif.Visibility = Visibility.Hidden;
        }
    }
}
