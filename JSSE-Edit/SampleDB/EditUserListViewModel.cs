using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace SampleDB
{
    public class EditUserListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<EditUserListModel> _listeviewItemSource = new ObservableCollection<EditUserListModel>();

        public ObservableCollection<EditUserListModel> ListeviewItemSource
        {
            set
            {
                _listeviewItemSource = value;
                OnPropertyChanged("ListeviewItemSource");
            }
            get { return _listeviewItemSource; }
        }

        public INavigation Navigation { get; set; }

        EditUserListModel _yourSelectedItem;
        public EditUserListModel YourSelectedItem
        {
            get
            {
                return _yourSelectedItem;
            }

            set
            {
                _yourSelectedItem = value;
                OnPropertyChanged("YourSelectedItem");
                Navigation.PushAsync(new EditCommunicationsPage(12, "12345", value));

            }
        }

        public EditUserListViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
            var assembly = typeof(DynamicScreen).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("SampleDB.EditUserJson.json");
            using (var reader = new System.IO.StreamReader(stream))
            {

                var json = reader.ReadToEnd();
                ObservableCollection<EditUserListModel> userGroupModel = JsonConvert.DeserializeObject<ObservableCollection<EditUserListModel>>(json);

                ListeviewItemSource = userGroupModel;

               
            }

        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
