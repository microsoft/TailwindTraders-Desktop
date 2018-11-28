using System;
using System.Threading.Tasks;
using CouponReader.Wpf.Module.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace CouponReader.Wpf.Module.ViewModels
{
    public class LoginViewModel : BindableBase, INavigationAware
    {
        private DelegateCommand _loginCommand;
        private string _message;

        IRegionManager _regionManager;
        LoginService _loginService;
        public LoginViewModel(IRegionManager regionManager, LoginService loginService)
        {
            _regionManager = regionManager;
            _loginService = loginService;
        }

        public DelegateCommand LoginCommand =>
            _loginCommand ?? (_loginCommand = new DelegateCommand(async () => await ExecuteLoginAsync()));

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public async Task ExecuteLoginAsync()
        {
            try
            {
                var success = await _loginService.SignInAsync();

                if (success)
                {
                    Message = string.Empty;

                    _regionManager.RequestNavigate(RegionNames.ContentRegion, "MainView");
                }
                else
                {
                    Message = "The Sign In process could not be completed successfully.";
                }
            }
            catch(Exception ex)
            {
                Message = ex.Message;
            }
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
   
        }
    }
}