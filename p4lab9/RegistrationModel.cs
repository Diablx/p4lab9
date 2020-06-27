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
        private bool? accept;

        public RegistrationModel()
        {

        }
        public RegistrationModel(string name, string password, string repeatedPassword, bool? accept)
        {
            Name = name;
            Password = password;
            RepeatedPassword = repeatedPassword;
            Accept = accept;
        }

        public string Name { get; set; }
        public string Password { get; set; }
        public string RepeatedPassword { get; set; }
        public bool? Accept { get; set; }
        private bool? _Accept 
        { 
            get => accept;
            set { accept = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
