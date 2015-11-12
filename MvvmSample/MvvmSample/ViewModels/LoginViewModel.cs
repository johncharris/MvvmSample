using MvvmSample.Pages;
using MvvmSample.Services;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MvvmSample.ViewModels
{
    public class LoginViewModel : ViewModel
    {
        string _email, _password;
        public string Email { get { return _email; } set { SetProperty(ref _email, value); } }
        public string Password
        {
            get { return _password; }
            set
            {
                SetProperty(ref _password, value);
                NotifyPropertyChanged(() => PasswordToShortVisible);
            }
        }

        public bool PasswordToShortVisible { get { return (Password ?? string.Empty).Length < 3; } }

        public ICommand LoginCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var user = await LoginService.Login(Email, Password);
                    await Navigation.PushAsync(new UserPage(user));
                });
            }
        }


        public LoginViewModel(ContentPage page) : base(page)
        {
        }
}
}
