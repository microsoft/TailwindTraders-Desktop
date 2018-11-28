using System;
using System.Collections.Generic;
using CouponReader.Common.Models;
using CouponReader.Common.Services;
using Prism.Mvvm;

namespace CouponReader.Common.ViewModels
{
    public class CouponViewModel : BindableBase
    {
        bool expired;

        public string Title { get; set; }
        public string Username { get; set; }
        public string User { get; set; }
        public string CouponImage { get; set; }
        public string CouponText { get; set; }
        public string Expiration { get; set; }
        public bool ReadyToRedeem { get; set; }

        public bool Expired
        {
            get { return expired; }
            set { SetProperty(ref expired, value); }
        }

        public Coupon Coupon { get; set; }

        public List<CouponHistory> CouponHistory
        {
            get { return CouponsService.Instance.CouponHistory; }
        }

        public CouponViewModel(Coupon coupon)
        {
            this.Coupon = coupon;

            if (coupon != null)
            {
                Title = coupon.CouponText;
                Username = coupon.UserName;
                User = coupon.User;
                CouponImage = coupon.ImageUrl;
                CouponText = coupon.CouponText;
                ReadyToRedeem = !coupon.Redeemed;
                Expiration = coupon.Expiration.ToLongDateString();

                Expired = coupon.Expiration < DateTime.Now;
            }
        }
    }
}