using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using NewTestMVVM.Model;

namespace NewTestMVVM.ViewModel
{
    public class NewLoginViewModel : BaseClassElement
    {
        public NewLoginViewModel () {

        }
        private string _nameproperty; 
        public string NameProperty {
            get => _nameproperty; 
            set {
                _nameproperty = value; 
                RaisePropertyChanged("NameProperty"); 
            }
        }
        private string _fnameproperty; 
        public string FNameProperty {
            get => _fnameproperty; 
            set {
                _fnameproperty = value;
                RaisePropertyChanged("FNameProperty");
            }
        }
        private string _profession;
        public string Profession
        {
            get => _profession;
            set
            {
                _profession = value;
                RaisePropertyChanged("Profession");
            }
        }
        private string _loginproperty;
        public string LoginProperty
        {
            get => _loginproperty;
            set
            {
                _loginproperty = value;
                RaisePropertyChanged("LoginProperty");
            }
        }
    }
}