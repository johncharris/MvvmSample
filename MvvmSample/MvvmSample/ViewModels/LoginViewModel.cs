using Xamarin.Forms;

namespace MvvmSample.ViewModels
{
    class LoginViewModel : ViewModel
    {
        string _email, _password;
        public string Email { get { return _email; } set { SetProperty(ref _email, value); } }
        public string Password { get { return _password; } set { SetProperty(ref _password, value); } }

        public LoginViewModel(ContentPage page) : base(page)
        {

        }
    }
}
