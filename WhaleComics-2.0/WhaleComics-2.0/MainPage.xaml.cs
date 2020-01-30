using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WhaleComics_2._0
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public string UserName { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(HomePage));
            BackButton.Visibility = Visibility.Collapsed;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            //base.OnNavigatedTo(e);
            UserName = (string)e.Parameter;
            UserGreetingsTextBlock.Text = "Hello, " + UserName;
            if (UserGreetingsTextBlock.Text != "")
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Content = "Log Out";
                ToolTipService.SetToolTip(LogInButton, toolTip);
                LogInButton.Click += LogOut;
            }
            else
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Content = "Log in";
                ToolTipService.SetToolTip(LogInButton, toolTip);
                LogInButton.Click += LogOut;
            }
        }

        private async void LogOut(object sender, RoutedEventArgs e)
        {
            string content = "Are you sure you want to log out?";
            string title = "LogOut";
            var dialog = new MessageDialog(content, title);
            var yesCommand = new UICommand("Yes", cmd => { });
            var cancelCommand = new UICommand("Cancel", cmd => { });

            dialog.Options = MessageDialogOptions.None;
            dialog.Commands.Add(yesCommand);

            dialog.DefaultCommandIndex = 0;
            dialog.CancelCommandIndex = 0;

            if (cancelCommand != null)
            {
                dialog.Commands.Add(cancelCommand);
                dialog.CancelCommandIndex = (uint)dialog.Commands.Count - 1;
            }

            var command = await dialog.ShowAsync();

            if (command == yesCommand)
            {
                Frame.Navigate(typeof(HomePage));
            }
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void ProductsMenuListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FunkoPop.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(FunkoPopPage));
            }

        }

        private void MyAutoSuggestPops_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();
                if (!MyFrame.CanGoBack)
                    BackButton.Visibility = Visibility.Collapsed;
            }
            else
                BackButton.Visibility = Visibility.Collapsed;
        }

        private void HeaderImage_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(HomePage));
            BackButton.Visibility = Visibility.Collapsed;
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(LoginPage));
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(RegisterPage));
        }
    }
}
