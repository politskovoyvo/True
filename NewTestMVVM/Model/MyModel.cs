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
    public class MyModel : BaseClassElement
    {
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
        }

        public void TaskMetod(object j)
        {
            MyContentControll = new TaskViewModel();
        }
    }
}