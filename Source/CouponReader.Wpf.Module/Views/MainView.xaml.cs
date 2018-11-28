using System.Windows.Controls;
using CouponReader.Common.Controls;
using CouponReader.Common.Models;
using CouponReader.Common.ViewModels;
using Prism.Events;

namespace CouponReader.Wpf.Module.Views
{
    public partial class MainView : UserControl
    {
        private readonly IEventAggregator _eventAggregator;

        public MainView(IEventAggregator eventAggregator)
        {
            InitializeComponent();
            
            var couponsHistory = new CouponsHistoryControl();
            CouponsHistory.Content = couponsHistory;

            _eventAggregator = eventAggregator;

            _eventAggregator.GetEvent<PubSubEvent<Coupon>>().Subscribe((coupon) =>
            {
                var couponDetails = new CouponDetailsControl();
                couponDetails.Init();

                couponDetails.DataContext = new CouponViewModel(coupon);
                CouponDetails.Content = couponDetails;
            });
        }
    }
}