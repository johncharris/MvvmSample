using Acr.UserDialogs;
using MvvmSample.Helpers;
using System;
using Xamarin.Forms;

namespace MvvmSample.ViewModels
{
    public class ViewModel : ObservableObject
    {
        public static string PageName { get; set; }
        public static string PreviousPageName { get; set; }

        protected IUserDialogs dialogService { get { return UserDialogs.Instance; } }

        string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                SetProperty(ref _title, value);
                Page.Title = value;
            }
        }

        public ContentPage Page;
        protected INavigation Navigation;

        public ViewModel(ContentPage page)
        {
            this.Page = page;
            this.Navigation = page.Navigation;

            if (Title == null)
            {
                Title = page.Title;
            }

            page.Appearing += page_Appearing;
        }

        void page_Appearing(object sender, EventArgs e)
        {
            PreviousPageName = PageName;
            PageName = Page.GetType().Name;
        }

        bool _isBusy;
        public bool IsBusy { get { return _isBusy; } set { SetProperty(ref _isBusy, value); } }
    }
}
