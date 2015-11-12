using MvvmSample.Models;
using MvvmSample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MvvmSample.Pages
{
    public partial class UserPage : ContentPage
    {
        public UserPage(User user)
        {
            InitializeComponent();

            BindingContext = new UserViewModel(this, user);
        }
    }
}
