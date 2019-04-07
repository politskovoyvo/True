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
    public class FirstViewModel : BaseClassElement
    {
        public FirstViewModel()
        {
            //Тестовая инициализация без БД 
            persons = new List<Person>()
            {
                new Person () {Password = "1234", Login = "name1"},
                new Person () {Password = "2341", Login = "name2"}
            };

            _newlogin = new Command(AddWindow, MetodTrueCommand);
        }
        View.MainWindow firstView = new View.MainWindow();
        List<Person> persons;

        private bool MetodTrueCommand (object i)
        {
            return !string.IsNullOrEmpty(_textlogin) && !string.IsNullOrEmpty(_textpassword); 
        }
        private ICommand _newlogin; 
        public ICommand LoginCommand
        {
            get => _newlogin;
            set
            {
                _newlogin = value;
                RaisePropertyChanged("LoginCommand");
            }
        }
        private void AddWindow(object obj)
        {
            foreach (var i in persons)
            {
                if (i.Login == _textlogin && i.Password == _textpassword)
                {
                    firstView.Show();
                }
            }   
        }

        private string _textlogin; 
        public string TextLogin {
            get => _textlogin;
            set
            {
                _textlogin = value;
                RaisePropertyChanged("TextLogin");
            }
        }
        private string _textpassword; 
        public string TextPassword
        {
            get => _textpassword;
            set
            {
                _textpassword = value;
                RaisePropertyChanged("TextPassword");
            }
        }
    }
}
