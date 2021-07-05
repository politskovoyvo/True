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
    class MainWindowVM : NewTestMVVM.Model.BaseClassElement
    {

        public MainWindowVM()
        {
            ModelElement = new Model.MyModel();

            Comm = new Command(ModelElement.AddMetod);                      //Window 1
            TaskCommand = new Command(ModelElement.TaskMetod);              //Window 2
            AddVisualCommand = new Command(ModelElement.AddVisualView);     //Window 3

        }
            
        public Command Comm { get; set; }
        public Command TaskCommand { get; set; }
        public Command AddVisualCommand { get; set; }
        public Model.MyModel ModelElement { get; set; }




    }
}