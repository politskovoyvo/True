using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Threading;
using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace NewTestMVVM.ViewModel
{
    class MainWindowVM : INotifyPropertyChanged
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

        #region MainWindowVM
        public MainWindowVM()
        {
            ModelElement = new Model.MyModel(); 

            Comm = new Command(ModelElement.AddMetod);
            TaskCommand = new Command(ModelElement.TaskMetod); 
        }

        public Command Comm { get; set; }
        public Command TaskCommand { get; set; }
        public Model.MyModel ModelElement { get; set; }
        #endregion
    }
}