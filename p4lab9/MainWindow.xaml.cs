using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace p4lab9
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MWViewModel Model { get; set; }
        private FakeDB _database { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Model = new MWViewModel();
            _database = new FakeDB();
        }

        private void RegisterControl_RegisterAttempt( object sender, RegisterEventArgs e)
        {
            Model.RegistrationModel.Name = e.Name;
            Model.RegistrationModel.Password = e.Password;
            Model.RegistrationModel.RepeatedPassword = e.RepeatedPassword;
            Model.RegistrationModel.Accept = e.Accept;
            var result = Model.RegistrationModelValidator.Validate(Model.RegistrationModel);
            Errors.Text = string.Join("|", result.Errors);

            if (result.IsValid)
                _database.RegisterUser(Model.RegistrationModel);
            else
                MessageBox.Show(string.Join(" ", result.Errors), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
