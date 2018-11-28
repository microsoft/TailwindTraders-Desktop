using System;
using System.Windows;
using System.Windows.Forms;
using CouponReader.Common.Services;
using CouponReader.Common.ViewModels;

namespace CouponReader
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            InitButtons();

            ShowCouponDetails(false);
        }

        private void InitButtons()
        {
            scanButton.Click += new EventHandler(OnScanButtonClick);
            clearButton.Click += new EventHandler(OnClearButtonClick);
        }

        private void OnScanButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInputCode.Text))
            {
                return;
            }

            var coupon = CouponsService.Instance.FindCouponByCode(txtInputCode.Text);

            if (coupon == null)
            {
                return;
            }

            couponDetails.Init();
            couponDetails.DataContext = new CouponViewModel(coupon);

            ShowCouponDetails(true);
        }

        private void OnClearButtonClick(object sender, EventArgs e)
        {
            txtInputCode.Text = string.Empty;

            ShowCouponDetails(false);
        }

        private void OnHistoryButtonClick(object sender, EventArgs e)
        {
            couponsHistory.Visible = true;
            couponsHistoryControl.Visibility = Visibility.Visible;
        }

        private void ShowCouponDetails(bool show)
        {
            couponsHistoryControl.DataContext = new CouponViewModel(null);
            couponsHistoryControl.Visibility = Visibility.Collapsed;
            couponsHistory.Visible = false;

            couponDetails.Visibility = show ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}