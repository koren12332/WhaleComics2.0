using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using WhaleComics_2._0.MyService;
using Windows.ApplicationModel.Core;
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
    public sealed partial class LoginPage : Page
    {
        MethodsClient manager = new MethodsClient();
        public User myUser { get; set; }
        public LoginPage()
        {
            this.InitializeComponent();
            myUser = new User();
        }
        private async void LogInConfirm_Click(object sender, RoutedEventArgs e)
        {
            string name = UserNameTextBox.Text;
            string password = PasswordTextBox.Text;
            try
            {
                // checking if the user exists in the DB
                myUser = await manager.SelectUserByNameAndPasswordAsync(name, password);
                // if exists
                if (myUser != null)
                {
                    var dialog = new MessageDialog("Welcome!");
                    await dialog.ShowAsync();
                    Frame.Navigate(typeof(MainPage), name);
                    await CoreApplication.RequestRestartAsync(name);
                }
                else
                {
                    var dialog = new MessageDialog("User not found");
                    await dialog.ShowAsync();
                    Frame.Navigate(typeof(HomePage));

                }


            }
            catch (Exception)
            {
                var dialog = new MessageDialog("ERROR, return to HomePage");
                await dialog.ShowAsync();
                Frame.Navigate(typeof(HomePage));
            }
        }

        private void Page_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
                this.LogInConfirm_Click(LogInConfirm, e);
        }
    }

}
