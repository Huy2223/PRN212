using System;
using System.Windows;

namespace RadioButtonControl
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGui_Click(object sender, RoutedEventArgs e)
        {
            string binhChon = "";
            if (radRatTot.IsChecked == true)
            {
                binhChon = radRatTot.Content + "";
            }
            else if (radTot.IsChecked == true)
            {
                binhChon = radTot.Content + "";
            }
            else if (radTamDuoc.IsChecked == true)
            {
                binhChon = radTamDuoc.Content + "";
            }
            else if (radKhongTot.IsChecked == true)
            {
                binhChon = radKhongTot.Content + "";
            }

            string gioiTinh = "";
            if (radNam.IsChecked == true)
            {
                gioiTinh = radNam.Content + "";
            }
            else if (radNu.IsChecked == true)
            {
                gioiTinh = radNu.Content + "";
            }

            string infor = "Bạn bình chọn Hệ Thống: " + binhChon + Environment.NewLine +
                           "Giới tính của bạn: " + gioiTinh;

            MessageBoxResult ret;
            ret = MessageBox.Show(infor, "Mời bạn xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (ret == MessageBoxResult.Yes)
            {

            }
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }
    }
}