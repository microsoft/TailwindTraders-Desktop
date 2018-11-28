using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CouponReader.Common.Controls
{
    public partial class CouponsHistoryControl : UserControl
    {
        public CouponsHistoryControl()
        {
            InitializeComponent();
        }

        private void OnRowHeaderToggleButtonClick(object sender, RoutedEventArgs e)
        {
            var obj = (DependencyObject)e.OriginalSource;

            while (!(obj is DataGridRow) && obj != null)
                obj = VisualTreeHelper.GetParent(obj);

            if (obj is DataGridRow)
            {
                if ((obj as DataGridRow).DetailsVisibility == Visibility.Visible)
                {
                    (obj as DataGridRow).IsSelected = false;
                }
                else
                {
                    (obj as DataGridRow).IsSelected = true;
                }
            }
        }
    }
}