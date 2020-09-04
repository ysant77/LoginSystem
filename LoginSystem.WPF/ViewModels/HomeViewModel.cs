using LoginSystem.WPF.Commands;
using LoginSystem.WPF.State.Authenticators;
using LoginSystem.WPF.State.Navigators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LoginSystem.WPF.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        

        public ICommand LogoutCommand { get; set; }
        public HomeViewModel(IAuthenticator authenticator, IReNavigator renavigator)
        {
            LogoutCommand = new LogoutCommand(this, authenticator, renavigator);
        }
    }
}
