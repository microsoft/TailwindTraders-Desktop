using System.Collections.Generic;
using CouponReader.Common.Models;
using CouponReader.Common.Services;
using Prism.Commands;
using Prism.Events;
using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;
using Prism.Regions;

namespace CouponReader.Wpf.Module.ViewModels
{
    public class MainViewModel : BindableBase, INavigationAware
    {
        private string _search;
        private List<CouponHistory> _couponHistory;
        private bool _isCouponHistory;
        private DelegateCommand _scanCommand;
        private DelegateCommand _cleanCommand;
        private DelegateCommand _historyCommand;

        private IEventAggregator _eventAggregator;

        public MainViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

            CouponHistory = new List<CouponHistory>();
            NotificationRequest = new InteractionRequest<INotification>();
        }

        public string Search
        {
            get { return _search; }
            set { SetProperty(ref _search, value); }
        }

        public bool IsCouponHistory
        {
            get { return _isCouponHistory; }
            set { SetProperty(ref _isCouponHistory, value); }
        }

        public List<CouponHistory> CouponHistory
        {
            get { return _couponHistory; }
            set { SetProperty(ref _couponHistory, value); }
        }

        public DelegateCommand ScanCommand =>
            _scanCommand ?? (_scanCommand = new DelegateCommand(ExecuteScan));

        public DelegateCommand CleanCommand =>
            _cleanCommand ?? (_cleanCommand = new DelegateCommand(ExecuteClean));

        public DelegateCommand HistoryCommand =>
            _historyCommand ?? (_historyCommand = new DelegateCommand(ExecuteHistory));

        public InteractionRequest<INotification> NotificationRequest { get; set; }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            var couponHistory = CouponsService.Instance.CouponHistory; 

            foreach(var coupon in couponHistory)
            {
                CouponHistory.Add(coupon);
            }
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }

        private void ExecuteScan()
        {
            if (string.IsNullOrEmpty(Search))
            {
                NotificationRequest.Raise(new Notification { Content = "Enter a valid coupon code", Title = "Invalid Coupon" }, r => r.Title = "Notified");
                return;
            }
            var coupon =  CouponsService.Instance.FindCouponByCode(Search);

            if (coupon == default)
            {
                return;
            }

            // Publish event 
            _eventAggregator.GetEvent<PubSubEvent<Coupon>>().Publish(coupon);
        }

        private void ExecuteClean()
        {
            Search = string.Empty;
        }

        private void ExecuteHistory()
        {
            IsCouponHistory = !IsCouponHistory;
        }
    }
}