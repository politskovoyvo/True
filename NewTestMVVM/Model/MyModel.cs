using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using NewTestMVVM.ViewModel; 

namespace NewTestMVVM.Model
{
    public class MyModel : INotifyPropertyChanged
    {
        #region BaseProperty
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            if (string.IsNullOrWhiteSpace(propertyName))
            {
                return;
            }

            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        private object _mycontentcontroll; 
        public object MyContentControll
        {
            get => _mycontentcontroll;
            set
            {
                _mycontentcontroll = value;
                RaisePropertyChanged("MyContentControll");
            } 
        }

        public void AddMetod(object i)
        {

            MyContentControll = new PersonViewModel();
            //MessageBox.Show("Window");
        }
    }
}