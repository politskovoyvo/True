using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewTestMVVM.Model;

namespace NewTestMVVM.ViewModel
{
    public class FirstRunViewModel : BaseClassElement
    {
        public FirstRunViewModel ()
        {
            NextView = new Command(AddObject);
        }
        private object _contentfirst; 
        public object ContentFirstRun
        {
            get => _contentfirst;
            set
            {
                _contentfirst = value;
                RaisePropertyChanged("ContentFirstRun");
            }
        }

        private void AddObject (object i)
        {
            ContentFirstRun = new FirstViewModel(); 
        }
        public Command NextView { get; set; } 
    }
    
}
