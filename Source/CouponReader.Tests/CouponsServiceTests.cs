using CouponReader.Common.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CouponReader.Tests
{
    [TestClass]
    public class CouponsServiceTests
    {
        [TestMethod]
        public void GetCouponsTest()
        {
            var coupons = CouponsService.Instance.Coupons;

            Assert.AreNotEqual(coupons.Count, 0);
        }

        [TestMethod]
        public void GetCouponHistoryTest()
        {
            var couponHistory = CouponsService.Instance.CouponHistory;

            Assert.AreNotEqual(couponHistory.Count, 0);
        }

        [TestMethod]
        public void FindCouponByCodeTest()
        {
            var code = "Code50";
            var coupon = CouponsService.Instance.FindCouponByCode(code);

            Assert.IsNotNull(coupon);
        }

        [TestMethod]
        public void RedeemedCouponTest()
        {
            var code = "Code10";
            var coupon = CouponsService.Instance.FindCouponByCode(code);

            Assert.IsNotNull(coupon);
            Assert.AreEqual(coupon.Redeemed, false);

            CouponsService.Instance.RedeemedCoupon(code);
        }
    }
}