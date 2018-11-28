namespace CouponReader.Common
{
    internal static class Settings
    {
        // https://docs.microsoft.com/windows/uwp/maps-and-location/authentication-key
        public static string BingMapsKey { get; } = "USE_YOUR_BING_MAPS_KEY";

        public static double DeviceLatitude { get; } = 47.640f;

        public static double DeviceLongitude { get; } = -122.132f;
    }
}