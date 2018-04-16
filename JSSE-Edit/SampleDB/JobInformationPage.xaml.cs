using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SampleDB
{
    public partial class JobInformationPage : ContentPage
    {
        public JobInformationPage(EditUserListModel JobInformation)
        {
            
            InitializeComponent();

            observerRef.Text = JobInformation.Observer.FullName;
            if (JobInformation.Observees.Count > 0)
            {
                observeeref.Text = JobInformation.Observees[0].FullName;
            }

            jsseDateRef.Date = JobInformation.JSSEDate;
            regionRef.Title = JobInformation.Region;
            locationRef.Text = JobInformation.Location;

            cancelRef.Clicked += (sender, e) => {
                observerRef.IsEnabled = false;
                observeeref.IsEnabled = false;
                jsseDateRef.IsEnabled = false;
                regionRef.IsEnabled = false;
                locationRef.IsEnabled = false;
                editRef.Text = "Edit";
            };

            editRef.Clicked += (sender, e) => {
                observerRef.IsEnabled = true;
                observeeref.IsEnabled = true;
                jsseDateRef.IsEnabled = true;
                regionRef.IsEnabled = true;
                locationRef.IsEnabled = true;
                editRef.Text = "Update";
            };

            resetRef.Clicked += (sender, e) =>
            {
                //Navigation.PushAsync(new CommunicationsPage(12,"12345"));
                //Navigation.PushAsync(new EditCommunicationsPage(12, "12345"));
            };
        }
    }
}
