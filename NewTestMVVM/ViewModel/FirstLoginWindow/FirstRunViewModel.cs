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
            CommandLoginIn = new Command(LoginIn);
            NewLoginCommand = new Command(NewLoginAdd);
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

        private void LoginIn (object i)
        {
            ContentFirstRun = new FirstViewModel(); 
        }
        private void NewLoginAdd(object i)
        {
            ContentFirstRun = new NewLoginViewModel();
        }
        public Command CommandLoginIn { get; set; }
        public Command NewLoginCommand{ get; set; }
    }
    
}
