using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SampleDB
{
    public partial class EditUserListPage : ContentPage
    {
        public EditUserListPage()
        {
            InitializeComponent();
            var userGroupPageViewModel = new EditUserListViewModel(Navigation);
            this.BindingContext = userGroupPageViewModel;

            //homeListView.SelectedItem += 
        }

        public void OnView(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            EditUserListModel obj = mi.CommandParameter as EditUserListModel;
            DisplayAlert("", obj.JSSE_ID.ToString(), "OK");
        }

        public void OnEdit(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            EditUserListModel obj = mi.CommandParameter as EditUserListModel;
            DisplayAlert("", obj.JSSE_ID.ToString(), "OK");
        }


    }
}
