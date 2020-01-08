using System;
using System.Windows;
using System.Windows.Media;

namespace Kitness
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Exit : Window
    {
        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();

        public Exit()
        {
            InitializeComponent();
            System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo(@"user_history\");
            System.IO.FileInfo[] files = directory.GetFiles(System.DateTime.Now.ToShortDateString() + "*.png");
            if (files.Length == 0) //오늘 저장된 사진이 없다면
            {
                files = directory.GetFiles("*.png"); //그 전에 저장된 사진이 있는지 확인
                if (files.Length == 0) file_src.Content = ""; //사진 파일이 아예 없는 것 >> 운동을 한번도안함
                else set_name(files[files.Length - 1]);
            }
            else
            {
                System.IO.FileInfo[] tmp = directory.GetFiles(System.DateTime.Now.ToShortDateString() + "_" + Kinect_Point.user_choice_name + ".png");
                if (tmp.Length == 0) set_name(files[files.Length - 1]);
                else set_name(tmp[tmp.Length - 1]);
            }

            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(close);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 5);  // 5초 타이머
            dispatcherTimer.Start();
        }

        private void set_name(System.IO.FileInfo file)
        {
            user_img.Source = new ImageSourceConverter().ConvertFromString(file.FullName) as ImageSource;
            string[] file_name = file.Name.Substring(0, file.Name.Length - 4).Split('_');
            file_src.Content = file_name[1] + " ( " + file_name[0] + " )";
        }

        private void close(object sender, EventArgs e)
        {
            Close();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            PartSelection ps = new PartSelection();
            Close();
            ps.ShowDialog();
        }
    }
}
