using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lab9
{
    public class RegistrationModel : INotifyPropertyChanged
    {
        private bool accept;
        private string repeatedPassword;
        private string password;
        private string name;

        public RegistrationModel()
        {

        }
        public RegistrationModel(string name, string password, string repeatedPassword, bool accept)
        {
            Name = name;
            Password = password;
            RepeatedPassword = repeatedPassword;
            Accept = accept;
        }

        public string Name 
        { 
            get => name; 
            set 
            { 
                name = value; 
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name))); 
            } 
        }
        public string Password 
        { 
            get => password; 
            set 
            { 
                password = value; 
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Password))); 
            } 
        }
        public string RepeatedPassword 
        { 
            get => repeatedPassword; 
            set 
            { 
                repeatedPassword = value; 
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RepeatedPassword))); 
            } 
        }
        public bool Accept
        {
            get => accept;
            set
            {
                accept = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Accept)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
