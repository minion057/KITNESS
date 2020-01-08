using System;
using System.ComponentModel;
using System.Threading;
using System.Windows;
using System.Windows.Media.Imaging;
using Microsoft.Kinect;

namespace Kitness
{
    /// <summary>
    /// Leg1_ready.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Default_ready : Window
    {
        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        SplashScreen splashScreen = new SplashScreen("image/etc/loading.gif");
        Boolean connect_click = false;

        public Default_ready()
        {
            Kinect_Point.kinect_x = 20;
            Kinect_Point.kinect_y = 0;
            splashScreen.Show(true);
            InitializeComponent();

            set_part();
            //connect_click = Kinect_View.kinectmove_stopcheck(); >> ready 를 들어오면 자동으로 좌표찾기가 시작되도록 주석처리
            
            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0);  // 0초 타이머
            dispatcherTimer.Start();
        }

        private void set_part()
        {
            try
            {
                var uriSource = new Uri(@"pack://application:,,,/image/exercise/" + Kinect_Point.user_choice + "_m.gif", UriKind.Absolute);//.Relative > 상대경로
                var image = new BitmapImage();
                image.BeginInit();
                image.UriSource = uriSource;
                image.EndInit();
                WpfAnimatedGif.ImageBehavior.SetAnimatedSource(part_img, image);
                kinect_connect.Visibility = Visibility.Hidden;
                ex_img.Source = new BitmapImage(new Uri(@"pack://application:,,,/image/exercise/" + Kinect_Point.user_choice + "_ex.png", UriKind.Absolute));
            }
            catch (Exception ex) //이미지가 없는 경우
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (Kinect_Point.kinect_c) //키넥트가 연결되었다면
            {
                bt_connect.Uid = Kinect_Point.points[(int)JointType.Head].X == 0 && Kinect_Point.points[(int)JointType.Head].Y == 0 ?
                                (connect_click ? "kinect_movebtn" : "kinect_stopbtn") : "kinect_okbtn";
                bt_connect_img.Source = new BitmapImage(new Uri(@"pack://application:,,,/image/guide/" + bt_connect.Uid + ".jpg", UriKind.Absolute));
                kinect_img.Visibility = Visibility.Visible;
                next_img.Visibility = Visibility.Visible;
                if (bt_connect.Uid.Equals("kinect_stopbtn") && Kinect_View.kinectmove_stopcheck()) Kinect_View.kinectmove_start();

                btStart.IsEnabled = true;
                btStart.Opacity = 1;
                if (Kinect_Point.gostart()) start(this, null);
            }
            else btStart.IsEnabled = false; //키넥트 연결x > 운동을 시작할 수 없음
        }

        private void start(object sender, RoutedEventArgs e)
        {
            Kinect_Point.start_open = !Kinect_Point.start_open; //처음 열릴 때는 true로 페이지가 열림
            if (!Kinect_Point.start_open) //처음 열리고 나서는 false가 될 것임
            {
                Kinect_Point.start_open = true; //그럼 두 번 페이지가 열리려는 것이므로
                //이미 페이지가 열렸다고 다시 true로 고치고
                //페이지 열리는 것을 멈춘다(return)
                return; //start 페이지에서 다시 시작을 행동으로 하게 되면(kinect_point의 gostart호출시 true 반환할 때)새창이 열리는 걸 방지
            }

            dispatcherTimer.Stop();
            Default_start st = new Default_start();
            Close();
            st.ShowDialog();
        }

        private void kinect_refresh(object sender, RoutedEventArgs e)
        {
            if (bt_connect.Uid.Equals("kinect_stopbtn"))
            {
                connect_click = true;
                Kinect_View.kinectmove_stop();
            }
            else if (bt_connect.Uid.Equals("kinect_movebtn"))
            {
                connect_click = false;
                Kinect_View.kinectmove_start();
            }
            else if (!bt_connect.Uid.Equals("kinect_okbtn"))
            {
                //키넥트 연결안됨
                splashScreen = new SplashScreen("image/etc/loading.gif");
                splashScreen.Show(true);
                kinect_test.NavigationService.Refresh();
            }
        }

        private void BtTutorial_Click(object sender, RoutedEventArgs e)
        {
            if (!Kinect_Point.tutorial_check()) splashScreen = new SplashScreen("image/guide/tuto_start.png");
            else splashScreen = new SplashScreen("image/guide/tuto_restart.png");
            splashScreen.Show(false);
            Thread.Sleep(1000);
            splashScreen.Close(new TimeSpan(0));
            Tutorial t = new Tutorial();
            t.ShowDialog();
        }

        private void BtExit(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
            Exit exit = new Exit();
            Close();
            exit.ShowDialog();
        }

        private void Btinfo(object sender, RoutedEventArgs e)
        {
            Information info = new Information();
            info.ShowDialog();
        }

        private void BtBack(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
            Kinect_View.kinectmove_stop();
            Kinect_Point.start_open = false;
            PartSelection part = new PartSelection();
            Close();
            part.ShowDialog();
        }
    }
}