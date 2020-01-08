using System;
using System.Windows;

namespace Kitness
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Tutorial : Window
    {
        int page = 1;
        public Tutorial()
        {
            InitializeComponent();
            page = 1;
        }

        private void BtExit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Btinfo(object sender, RoutedEventArgs e)
        {
            Information info = new Information();
            info.ShowDialog();
        }

        private void Btback(object sender, RoutedEventArgs e)
        {
            if (page == 1) return;
            if (page == 2) bt_back.Opacity = 0.5;
            chage_tutoimg(--page);
            bt_front.Opacity = 1;
        }

        private void chage_tutoimg(int page)
        {
            try
            {
                var uriSource = new Uri(@"pack://application:,,,/image/tutorial/tutorial" + page.ToString() + ".gif", UriKind.Absolute);
                var image = new System.Windows.Media.Imaging.BitmapImage();
                image.BeginInit();
                image.UriSource = uriSource;
                image.EndInit();
                WpfAnimatedGif.ImageBehavior.SetAnimatedSource(img_gif, image);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Btfront(object sender, RoutedEventArgs e)
        {
            if (page == 5) return;
            if (page == 4) bt_front.Opacity = 0.5;
            chage_tutoimg(++page);
            bt_back.Opacity = 1;
        }
    }
}
