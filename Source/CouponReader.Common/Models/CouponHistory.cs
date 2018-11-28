using System;

namespace CouponReader.Common.Models
{
    public class CouponHistory
    {
        public DateTime Date { get; set; }
        public Coupon Coupon { get; set; }
    }
}