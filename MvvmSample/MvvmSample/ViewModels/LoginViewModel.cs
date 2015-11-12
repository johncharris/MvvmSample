using MvvmSample.Pages;
using MvvmSample.Services;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MvvmSample.ViewModels
{
    class LoginViewModel : ViewModel
    {
        string _email, _password;
        public string Email { get { return _email; } set { SetProperty(ref _email, value); } }
        public string Password { get { return _password; } set { SetProperty(ref _password, value); } }

        public Command LoginCommand;

        public LoginViewModel(ContentPage page) : base(page)
        {
            LoginCommand = new Command(async () => await RunLogin());
        }

        async Task RunLogin()
        {
            var user = await LoginService.Login(Email, Password);

            await Navigation.PushAsync(new LoginPage());
        }
    }
}
