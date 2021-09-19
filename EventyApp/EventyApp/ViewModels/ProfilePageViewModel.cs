using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using EventyApp.Services;
using EventyApp.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace EventyApp.ViewModels
{
    class ProfilePageViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public ProfilePageViewModel()
        {
            Test();
        }

        public async void Test()
        {
            EventyAPIProxy proxy = EventyAPIProxy.CreateProxy();
            S = await proxy.HelloWorldAsync();
        }

        private string s;
        public string S
        {
            get
            {
                return this.s;
            }
            set
            {
                if (this.s != value)
                {

                    this.s = value;
                    OnPropertyChanged("S");
                }
            }
        }
    }
}
