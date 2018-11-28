using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using CouponReader.Common.Helpers;
using CouponReader.Common.Services;
using CouponReader.Common.ViewModels;
using Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT;
using Microsoft.Toolkit.Wpf.UI.Controls;

namespace CouponReader.Common.Controls
{
    public partial class CouponDetailsControl : UserControl
    {
        public CouponDetailsControl()
        {
            InitializeComponent();
        }

        public void Init()
        {
            ShowSignBoard(false);

            var toolbar = new InkToolbar();
            InkToolbarContainer.Content = toolbar;

            var canvas = new Microsoft.Toolkit.Wpf.UI.Controls.InkCanvas();
            canvas.InkPresenter.InputDeviceTypes = CoreInputDeviceTypes.Mouse | CoreInputDeviceTypes.Touch | CoreInputDeviceTypes.Pen;
            InkCanvasContainer.Content = canvas;

            MapControlContainer.Content = MapControlHelper.Initialize();
        }

        private void OnShowSignatureBoardClick(object sender, RoutedEventArgs e)
        {
            ShowSignBoard(true);
        }

        private void OnRedeemClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var coupon = (CouponViewModel)DataContext;

                CouponsService.Instance.RedeemedCoupon(coupon.Coupon.Code);

                MessageBox.Show("Coupon redeemed");
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void ShowSignBoard(bool show)
        {
            SignControl.Visibility = show ? System.Windows.Visibility.Visible : System.Windows.Visibility.Collapsed;
        }
    }
}