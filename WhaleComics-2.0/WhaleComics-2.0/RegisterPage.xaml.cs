using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using WhaleComics_2._0.MyService;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace WhaleComics_2._0
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RegisterPage : Page
    {
        MethodsClient manager = new MethodsClient();
        public RegisterPage()
        {
            this.InitializeComponent();
        }

        private async void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            User u = new User();
            u.UserAddress = UserAddressTextBox.Text;
            u.UserName = UserNameTextBox.Text;
            u.UserEmail = UserEmailTextBox.Text;
            u.UserPassword = PasswordTextBox.Password;
            u.UserPhoneNumber = UserPhoneNumberTextBox.Text;
            

            try
            {
                await manager.InsertNewUserAsync(u);
                var dialog = new MessageDialog("Registered succesfully, please log in");
                await dialog.ShowAsync();
                Frame.Navigate(typeof(LoginPage));
            }
            catch (Exception)
            {
                var dialog = new MessageDialog("Registers failed");
                await dialog.ShowAsync();
            }
        }

        private void CheckBox_Changed(object sender, RoutedEventArgs e)
        {
            if (revealModeCheckBox.IsChecked == true)
            {
                PasswordTextBox.PasswordRevealMode = PasswordRevealMode.Visible;
            }
            else
            {
                PasswordTextBox.PasswordRevealMode = PasswordRevealMode.Hidden;
            }
        }
    }
}
