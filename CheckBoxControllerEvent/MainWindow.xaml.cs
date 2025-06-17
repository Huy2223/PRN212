using System.Windows;

namespace CheckBoxControlEvent
{
    public partial class MainWindow : Window
    {
        private bool isUpdatingCheckboxes = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChkToanBo_Checked(object sender, RoutedEventArgs e)
        {
            if (isUpdatingCheckboxes) return;
            
            isUpdatingCheckboxes = true;
            chkCongNghe.IsChecked = true;
            chkDuLich.IsChecked = true;
            chkDaBong.IsChecked = true;
            chkXemPhim.IsChecked = true;
            isUpdatingCheckboxes = false;
        }

        private void ChkToanBo_Unchecked(object sender, RoutedEventArgs e)
        {
            if (isUpdatingCheckboxes) return;
            
            isUpdatingCheckboxes = true;
            chkCongNghe.IsChecked = false;
            chkDuLich.IsChecked = false;
            chkDaBong.IsChecked = false;
            chkXemPhim.IsChecked = false;
            isUpdatingCheckboxes = false;
        }

        private void chkSub_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if (isUpdatingCheckboxes) return;
            
            isUpdatingCheckboxes = true;
            
            if (chkCongNghe.IsChecked == true &&
                chkDuLich.IsChecked == true &&
                chkDaBong.IsChecked == true &&
                chkXemPhim.IsChecked == true)
            {
                chkToanBo.IsChecked = true; // checked toàn bộ
            }
            else if (chkCongNghe.IsChecked == false &&
                     chkDuLich.IsChecked == false &&
                     chkDaBong.IsChecked == false &&
                     chkXemPhim.IsChecked == false)
            {
                chkToanBo.IsChecked = false; // unchecked toàn bộ
            }
            else
            {
                chkToanBo.IsChecked = null; // indeterminate state when only some are checked
            }
            
            isUpdatingCheckboxes = false;
        }
    }
}