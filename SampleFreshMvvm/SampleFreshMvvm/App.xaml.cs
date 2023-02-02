using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SampleFreshMvvm.PageModels;

namespace SampleFreshMvvm
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            var contactList = FreshMvvm.FreshPageModelResolver.ResolvePageModel<ContactListPageModel>();
            var navContainer = new FreshMvvm.FreshNavigationContainer(contactList);

            MainPage = navContainer;
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

