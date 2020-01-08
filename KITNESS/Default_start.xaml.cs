using System;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;
using Microsoft.Kinect;

namespace Kitness
{
    /// <summary>
    /// Leg1_ready.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Default_start : Window
    {
        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        int time_stack = 0, check_stack = 0, cnt = 1;
        Boolean end = false;
        SplashScreen splashScreen = new SplashScreen("image/exercise/" + Kinect_Point.user_choice + "_btn.png");

        public Default_start()
        {
            Kinect_Point.kinect_x = 300;
            Kinect_Point.kinect_y = 20;
            InitializeComponent();
            set_first();

            time_stack = 0; check_stack = 1; cnt = 1;
            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);  // 1초 타이머
            dispatcherTimer.Start();
        }

        private void set_first()
        {
            try
            {
                part_name.Source = new BitmapImage(new Uri(@"pack://application:,,,/image/exercise/" + Kinect_Point.user_choice + "_btn.png", UriKind.Absolute)); //해당 운동명으로 변경
                
                bt_connect.Uid = Kinect_Point.points[(int)JointType.Head].X == 0 && Kinect_Point.points[(int)JointType.Head].Y == 0 ?
                                    (Kinect_View.kinectmove_stopcheck() ? "kinect_movebtn" : "kinect_stopbtn") : "kinect_okbtn";
                bt_connect_img.Source = new BitmapImage(new Uri(@"pack://application:,,,/image/guide/" + bt_connect.Uid + ".jpg", UriKind.Absolute));
                guide_img.Visibility = Kinect_Point.points[(int)JointType.Head].X == 0 && Kinect_Point.points[(int)JointType.Head].Y == 0 ? Visibility.Visible : Visibility.Hidden;
                part_img.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (cnt >= 11)
            {
                if (end)
                {
                    Kinect_View.default_color();
                    img_chage("part", 0);
                    cheer_img.Visibility = Visibility.Hidden;
                    guide_img.Source = new BitmapImage(new Uri(@"pack://application:,,,/image/exercise_etc/exercise_finish.png", UriKind.Absolute));
                    guide_img.Visibility = Visibility.Visible;
                    part_img.Source = new BitmapImage(new Uri(@"pack://application:,,,/image/guide/guide_restart.png", UriKind.Absolute));
                    part_img.Opacity = 0.5;
                    end = false;
                }
                //10회를 다 했고, 다시시작 자세를 취한다면 다시 시작
                if (Kinect_Point.gostart()) restart(this, null);
                return; //10회를 완료했으므로, 아래 자세를 검사하는 switch문을 실행시킬 필요없다. 따라서 return
            }


            time_stack = Kinect_Point.points[(int)JointType.Head].X == 0 && Kinect_Point.points[(int)JointType.Head].Y == 0 ? time_stack : time_stack + 1;
            //사람이 인식될 때부터 타임스택을 1씩 늘려준다

            if (time_stack >= 4)
            {
                //guide_img.Visibility = Visibility.Hidden;
                if (time_stack % 4 == 0)
                {//이미지 변경
                    cheer_img.Visibility = Visibility.Hidden;
                    guide_img.Visibility = Visibility.Hidden;
                    if (check_stack % 2 == 1 || check_stack % 2 == 3)
                    {
                        Kinect_View.default_color();
                        if (check_stack % 2 == 1) count.Content = Convert.ToString(cnt);
                        img_chage("part", 0);
                        if (cnt >= 10) end = true;
                    }
                    else if ((check_stack / 2) % 2 == 1) img_chage("part", 1);
                    else if ((check_stack / 2) % 2 == 0) img_chage("part", 2);
                    return;
                }
                if (time_stack % 4 == 3)
                {
                    check_stack++;
                    return;
                }

                switch (Kinect_Point.user_choice)
                {
                    case "leg1":
                        //1. 3. 차렷
                        //2. 오른쪽
                        if (time_stack % 4 == 2 && (time_stack / 4) % 4 == 2 && (check_stack / 2) % 2 == 1)
                        { //검사 - 화이팅 이미지 띄우기
                            check_start(Leg.leg1.Right());
                            break;
                        }

                        //4. 왼쪽
                        if (time_stack % 4 == 2 && (time_stack / 4) % 4 == 0 && (check_stack / 2) % 2 == 0)
                        { //검사 - 화이팅 이미지 띄우기
                            check_start(Leg.leg1.Left());
                            cnt++;
                            if (cnt == 9 && !filecheck()) Kinect_View.SavePng(); //현재 날짜에 현자세의 사진이 한번도 저장되지 않았다면 저장
                            break;
                        }
                        break;

                    case "leg2":
                        //1. 3. 차렷
                        //2. 오른쪽
                        if (time_stack % 4 == 2 && (time_stack / 4) % 4 == 2 && (check_stack / 2) % 2 == 1)
                        { //검사 - 화이팅 이미지 띄우기
                            check_start(Leg.leg2.Right());
                            break;
                        }

                        //4. 왼쪽
                        if (time_stack % 4 == 2 && (time_stack / 4) % 4 == 0 && (check_stack / 2) % 2 == 0)
                        { //검사 - 화이팅 이미지 띄우기
                            check_start(Leg.leg2.Left());
                            cnt++;
                            if (cnt == 9 && !filecheck()) Kinect_View.SavePng(); //현재 날짜에 현자세의 사진이 한번도 저장되지 않았다면 저장
                            break;
                        }
                        break;

                    case "leg3":
                        //1. 3. 차렷
                        //2. 오른쪽
                        if (time_stack % 4 == 2 && (time_stack / 4) % 4 == 2 && (check_stack / 2) % 2 == 1)
                        { //검사 - 화이팅 이미지 띄우기
                            check_start(Leg.leg3.Check());
                            if (Leg.leg3.Check() == 3) Kinect_View.change_color(4);
                            break;
                        }

                        //4. 왼쪽
                        if (time_stack % 4 == 2 && (time_stack / 4) % 4 == 0 && (check_stack / 2) % 2 == 0)
                        { //검사 - 화이팅 이미지 띄우기
                            check_start(Leg.leg3.Check());
                            if (Leg.leg3.Check() == 3) Kinect_View.change_color(4);
                            cnt++;
                            if (cnt == 9 && !filecheck()) Kinect_View.SavePng(); //현재 날짜에 현자세의 사진이 한번도 저장되지 않았다면 저장
                            break;
                        }
                        break;

                    case "neck1":
                        //1. 3. 차렷
                        //2. 오른쪽
                        if (time_stack % 4 == 2 && (time_stack / 4) % 4 == 2 && (check_stack / 2) % 2 == 1)
                        { //검사 - 화이팅 이미지 띄우기
                            check_start(Neck.neck1.Check());
                            break;
                        }

                        //4. 왼쪽
                        if (time_stack % 4 == 2 && (time_stack / 4) % 4 == 0 && (check_stack / 2) % 2 == 0)
                        { //검사 - 화이팅 이미지 띄우기
                            check_start(Neck.neck1.Check());
                            cnt++;
                            if (cnt == 9 && !filecheck()) Kinect_View.SavePng(); //현재 날짜에 현자세의 사진이 한번도 저장되지 않았다면 저장
                            break;
                        }
                        break;

                    case "neck2":
                        //1. 3. 차렷
                        //2. 오른쪽 팔로 고개 꺽기
                        if (time_stack % 4 == 2 && (time_stack / 4) % 4 == 2 && (check_stack / 2) % 2 == 1)
                        { //검사 - 화이팅 이미지 띄우기
                            check_start(Neck.neck2.Right());
                            break;
                        }

                        //4. 왼쪽 팔로 고개 꺽기
                        if (time_stack % 4 == 2 && (time_stack / 4) % 4 == 0 && (check_stack / 2) % 2 == 0)
                        { //검사 - 화이팅 이미지 띄우기
                            check_start(Neck.neck2.Left());
                            cnt++;
                            if (cnt == 9 && !filecheck()) Kinect_View.SavePng(); //현재 날짜에 현자세의 사진이 한번도 저장되지 않았다면 저장
                            break;
                        }
                        break;

                    case "neck3":
                        //1. 3. 차렷
                        //2. 오른쪽
                        if (time_stack % 4 == 2 && (time_stack / 4) % 4 == 2 && (check_stack / 2) % 2 == 1)
                        { //검사 - 화이팅 이미지 띄우기
                            check_start(Neck.neck3.Check());
                            break;
                        }

                        //4. 왼쪽
                        if (time_stack % 4 == 2 && (time_stack / 4) % 4 == 0 && (check_stack / 2) % 2 == 0)
                        { //검사 - 화이팅 이미지 띄우기
                            check_start(Neck.neck3.Check());
                            cnt++;
                            if (cnt == 9 && !filecheck()) Kinect_View.SavePng(); //현재 날짜에 현자세의 사진이 한번도 저장되지 않았다면 저장
                            break;
                        }
                        break;

                    case "spine1":
                        //1. 3. 차렷
                        //2. 오른쪽
                        if (time_stack % 4 == 2 && (time_stack / 4) % 4 == 2 && (check_stack / 2) % 2 == 1)
                        { //검사 - 화이팅 이미지 띄우기
                            check_start(Spine.spine1.Right());
                            break;
                        }

                        //4. 왼쪽
                        if (time_stack % 4 == 2 && (time_stack / 4) % 4 == 0 && (check_stack / 2) % 2 == 0)
                        { //검사 - 화이팅 이미지 띄우기
                            check_start(Spine.spine1.Left());
                            cnt++;
                            if (cnt == 9 && !filecheck()) Kinect_View.SavePng(); //현재 날짜에 현자세의 사진이 한번도 저장되지 않았다면 저장
                            break;
                        }
                        break;

                    case "spine2":
                        //1. 3. 차렷
                        //2. 오른쪽
                        if (time_stack % 4 == 2 && (time_stack / 4) % 4 == 2 && (check_stack / 2) % 2 == 1)
                        { //검사 - 화이팅 이미지 띄우기
                            check_start(Spine.spine2.Right());
                            break;
                        }

                        //4. 왼쪽
                        if (time_stack % 4 == 2 && (time_stack / 4) % 4 == 0 && (check_stack / 2) % 2 == 0)
                        { //검사 - 화이팅 이미지 띄우기
                            check_start(Spine.spine2.Left());
                            cnt++;
                            if (cnt == 9 && !filecheck()) Kinect_View.SavePng(); //현재 날짜에 현자세의 사진이 한번도 저장되지 않았다면 저장
                            break;
                        }
                        break;

                    case "spine3":
                        //1. 3. 차렷
                        //2. 오른쪽
                        if (time_stack % 4 == 2 && (time_stack / 4) % 4 == 2 && (check_stack / 2) % 2 == 1)
                        { //검사 - 화이팅 이미지 띄우기
                            check_start(Spine.spine3.Right());
                            if (Spine.spine3.Right() == 1)
                            {
                                Kinect_View.change_color(1);
                                Kinect_View.change_color(2);
                            }
                            break;
                        }

                        //4. 왼쪽
                        if (time_stack % 4 == 2 && (time_stack / 4) % 4 == 0 && (check_stack / 2) % 2 == 0)
                        { //검사 - 화이팅 이미지 띄우기
                            check_start(Spine.spine3.Left());
                            if (Spine.spine3.Left() == 1)
                            {
                                Kinect_View.change_color(1);
                                Kinect_View.change_color(2);
                            }
                            cnt++;
                            if (cnt == 9 && !filecheck()) Kinect_View.SavePng(); //현재 날짜에 현자세의 사진이 한번도 저장되지 않았다면 저장
                            break;
                        }
                        break;

                    default:
                        Console.WriteLine("에러");
                        return;
                }
            }
            else
            {
                switch (time_stack)
                {
                    case 0:
                        guide_img.Visibility = Visibility.Visible;
                        guide_img.Source = new BitmapImage(new Uri(@"pack://application:,,,/image/guide/kinect_dis.png", UriKind.Absolute));
                        break;
                    case 1:
                        guide_img.Visibility = Visibility.Visible;
                        guide_img.Source = new BitmapImage(new Uri(@"pack://application:,,,/image/exercise_etc/exercise_recognizing.png", UriKind.Absolute));
                        break;
                    case 2:
                        guide_img.Visibility = Visibility.Visible;
                        guide_img.Source = new BitmapImage(new Uri(@"pack://application:,,,/image/exercise_etc/exercise_recognize.png", UriKind.Absolute));
                        break;
                    case 3:
                        guide_img.Visibility = Visibility.Visible;
                        guide_img.Source = new BitmapImage(new Uri(@"pack://application:,,,/image/exercise_etc/exercise_start.png", UriKind.Absolute));
                        break;
                    default:
                        guide_img.Visibility = Visibility.Hidden;
                        return;
                }
            }
        }

        private void check_start(int red)
        {
            if (red >= 10)
            {
                img_chage("cheer", 3); //자세가 올바르다면
                Kinect_View.SavePng();
            }
            else
            {
                img_chage("cheer", 4);
                Kinect_View.change_color(red);
            }
        }

        private void img_chage(string where = "part", int step = 0)
        {
            try
            {
                switch (step)
                {
                    case 0: //차렷이미지
                        part_img.Source = new BitmapImage(new Uri(@"pack://application:,,,/image/exercise/ready.png", UriKind.Absolute));
                        break;
                    case 1: //오른쪽 이미지
                        part_img.Source = new BitmapImage(new Uri(@"pack://application:,,,/image/exercise/" + Kinect_Point.user_choice + "_right.png", UriKind.Absolute));
                        break;
                    case 2: //왼쪽 이미지
                        part_img.Source = new BitmapImage(new Uri(@"pack://application:,,,/image/exercise/" + Kinect_Point.user_choice + "_left.png", UriKind.Absolute));
                        break;
                    case 3: //자세 올바름 - 화이팅이미지
                        cheer_img.Source = new BitmapImage(new Uri(@"pack://application:,,,/image/exercise_etc/exercise_good.png", UriKind.Absolute));
                        cheer_img.Visibility = Visibility.Visible;
                        guide_img.Source = new BitmapImage(new Uri(@"pack://application:,,,/image/guide/guide_good.png", UriKind.Absolute));
                        guide_img.Visibility = Visibility.Visible;
                        Kinect_View.SavePng();
                        break;
                    case 4: //자세 틀림 - 화이팅이미지
                        cheer_img.Source = new BitmapImage(new Uri(@"pack://application:,,,/image/exercise_etc/exercise_cheer.png", UriKind.Absolute));
                        cheer_img.Visibility = Visibility.Visible;
                        guide_img.Source = new BitmapImage(new Uri(@"pack://application:,,,/image/guide/guide_cheer.png", UriKind.Absolute));
                        guide_img.Visibility = Visibility.Visible;
                        break;
                    default:
                        return; ;
                }
            }
            catch (Exception ex) //이미지가 없는 경우
            {
                Console.WriteLine(ex.Message);
                cheer_img.Visibility = Visibility.Hidden;
                part_img.Source = new BitmapImage(new Uri(@"pack://application:,,,/image/exercise/ready.png", UriKind.Absolute));
            }
        }

        private Boolean filecheck()
        {
            String strFilename = @"user_history\" + System.DateTime.Now.ToShortDateString() + "_" + Kinect_Point.user_choice_name + ".png";
            System.IO.FileInfo file = new System.IO.FileInfo(strFilename);
            if (!file.Exists) return false; //저장된 사진이 없다
            return true; //저장된 사진이 있다 (한번이라도 올바르게 자세를 한 적이 있다
        }

        private void restart(object sender, RoutedEventArgs e)
        {
            part_img.Source = new BitmapImage(new Uri(@"pack://application:,,,/image/exercise/ready.png", UriKind.Absolute));
            part_img.Opacity = 1;
            if (cnt >= 10) setcount.Content = Convert.ToString(Int32.Parse(setcount.Content.ToString()) + 1);
            time_stack = 0;
            check_stack = 1;
            cnt = 1;
            count.Content = Convert.ToString(cnt);
        }

        private void kinect_refresh(object sender, RoutedEventArgs e)
        {
            if (bt_connect.Uid.Equals("kinect_stopbtn"))
            {
                bt_connect.Uid = "kinect_movebtn";
                Kinect_View.kinectmove_stop();
            }
            else if (bt_connect.Uid.Equals("kinect_movebtn"))
            {
                bt_connect.Uid = "kinect_stopbtn";
                Kinect_View.kinectmove_start();
            }
            else if (bt_connect.Uid.Equals("kinect_okbtn"))
            {
                //좌표 인식완료
                bt_connect.Uid = "kinect_okbtn";
            }
            else
            {   //키넥트 연결안됨
                splashScreen = new SplashScreen("image/etc/loading.gif");
                splashScreen.Show(true);
                kinect_test.NavigationService.Refresh();
            }
            bt_connect_img.Source = new BitmapImage(new Uri(@"pack://application:,,,/image/guide/" + bt_connect.Uid + ".jpg", UriKind.Absolute));
        }

        private void BtTutorial_Click(object sender, RoutedEventArgs e)
        {
            if (!Kinect_Point.tutorial_check()) splashScreen = new SplashScreen("image/guide/tuto_start.png");
            else splashScreen = new SplashScreen("image/guide/tuto_restart.png");
            splashScreen.Show(false);
            System.Threading.Thread.Sleep(1000);
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

        private void Btback(object sender, RoutedEventArgs e)
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
