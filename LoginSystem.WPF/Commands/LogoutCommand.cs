using LoginSystem.WPF.State.Authenticators;
using LoginSystem.WPF.State.Navigators;
using LoginSystem.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem.WPF.Commands
{
    public class LogoutCommand : AsyncCommandBase
    {
        private readonly HomeViewModel _homeViewModel;
        private readonly IAuthenticator _authenticator;
        private readonly IReNavigator _renavigator;

        public LogoutCommand(HomeViewModel homeViewModel, IAuthenticator authenticator, IReNavigator renavigator)
        {
            _homeViewModel = homeViewModel;
            _authenticator = authenticator;
            _renavigator = renavigator;
        }

        public override async Task ExecuteAsync(object parameter = null)
        {
            await _authenticator.Logout();
            _renavigator.Renavigate();
        }
    }
}
