using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lab9
{
    public class MWViewModel
    {
        public MWViewModel()
        {
            RegistrationModel = new RegistrationModel();
            RegistrationModelValidator = new RegistrationModelValidator();
        }
        public MWViewModel(RegistrationModel registrationModel)
        {
            RegistrationModel = new RegistrationModel();
            RegistrationModelValidator = new RegistrationModelValidator();
        }

        public RegistrationModel RegistrationModel { get; set; }
        public RegistrationModelValidator RegistrationModelValidator { get; set; }

    }
}
