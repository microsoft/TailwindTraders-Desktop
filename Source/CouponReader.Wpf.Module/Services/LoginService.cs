using System.Threading.Tasks;

namespace CouponReader.Wpf.Module.Services
{
    public class LoginService
    {
        public async Task<bool> SignInAsync()
        {
            await Task.Delay(500);

            return true;
        }
    }
}