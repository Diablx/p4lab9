using System.Windows;

namespace p4lab9
{
    internal class FakeDB
    {
        public void RegisterUser(RegistrationModel model)
        {
            MessageBox.Show($"User {model.Name} Successfully registered!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}