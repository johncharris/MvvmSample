using MvvmSample.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmSample.Models
{
    public class User : ObservableObject
    {
        string _firstName;
        string _lastName;

        public string FirstName { get { return _firstName; } set { SetProperty(ref _firstName, value); } }
        public string LastName { get { return _lastName; } set { SetProperty(ref _lastName, value); } }
    }
}
