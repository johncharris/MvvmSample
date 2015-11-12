using MvvmSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MvvmSample.ViewModels
{
    public class UserViewModel : ViewModel
    {
        User _user;
        public User User { get { return _user; } set { SetProperty(ref _user, value); } }

        public UserViewModel(ContentPage page, User user) : base(page)
        {
            this.User = user;
        }
    }
}
