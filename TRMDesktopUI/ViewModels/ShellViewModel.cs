using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace TRMDesktopUI.ViewModels
{
    public class ShellViewModel: Conductor<object>
    {
        private LoginViewModel _loginWM;

        public ShellViewModel(LoginViewModel loginVM)
        {
            _loginWM = loginVM;
            ActivateItemAsync(_loginWM);
        }



    }
}
