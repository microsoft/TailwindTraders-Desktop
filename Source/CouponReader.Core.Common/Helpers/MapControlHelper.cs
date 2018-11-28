using System;
using System.Threading.Tasks;
using Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT;
using Microsoft.Toolkit.Wpf.UI.Controls;

namespace CouponReader.Common.Helpers
{
    internal static class MapControlHelper
    {
        private static readonly TimeSpan timeSimulatingGeolocation = TimeSpan.FromSeconds(1);

        public static MapControl Initialize()
        {
            var mapControl = new MapControl
            {
                BusinessLandmarksVisible = true,
                TransitFeaturesVisible = true,
                TrafficFlowVisible = true,
                PedestrianFeaturesVisible = true,
                MapServiceToken = Settings.BingMapsKey,
                LandmarksVisible = true
            };

            var geoposition = new BasicGeoposition
            {
                Latitude = Settings.DeviceLatitude,
                Longitude = Settings.DeviceLongitude
            };

            var point = new Geopoint(geoposition);

            Task.Delay(timeSimulatingGeolocation)
                .ContinueWith(_ => mapControl.TrySetViewAsync(point, 16));

            return mapControl;
        }
    }
}