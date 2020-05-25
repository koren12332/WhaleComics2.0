using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WhaleComics_2._0
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        MethodsClient manager = new MethodsClient();
        public string UserName { get; set; }
        List<String> suggestions = new List<string>();
        public User MyUser { get; set; }
        public ObservableCollection<Product> CartProducts;
        public MainPage()
        {
            this.InitializeComponent();
            CartProducts = new ObservableCollection<Product>();
            MyFrame.Navigate(typeof(HomePage));
            BackButton.Visibility = Visibility.Collapsed;
            UserGreetingsTextBlock.Text = "Hello, Pal!";
            LogInButton.Visibility = Visibility.Visible;
            //LogOutButton.Visibility = Visibility.Collapsed;
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            UserName = (string)e.Parameter;
            if (UserName != "")
            {
                UserGreetingsTextBlock.Text = "Hello, " + UserName;
                LogInButton.Visibility = Visibility.Collapsed;
                LogOutButton.Visibility = Visibility.Visible;
                MyUser = await manager.SelectUserByNameAsync(UserName);
                //(UserGreetingsTextBlock.Text != "")
                //{
                //    ToolTip toolTip = new ToolTip();
                //    toolTip.Content = "Log Out";
                //    ToolTipService.SetToolTip(LogInButton, toolTip);
                //    LogInButton.Click += LogOut;
                //}
                //else
                //{
                //    ToolTip toolTip = new ToolTip();
                //    toolTip.Content = "Log in";
                //    ToolTipService.SetToolTip(LogInButton, toolTip);
                //    LogInButton.Click += LogOut;
                //}
            }
            else
            {
                UserGreetingsTextBlock.Text = "Hello, Pal!";
                LogInButton.Visibility = Visibility.Visible;
                //LogOutButton.Visibility = Visibility.Collapsed;
            }
        }

        /*private async void LogOut(object sender, RoutedEventArgs e)
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
                Frame.Navigate(typeof(MainPage));
            }
        }*/

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void ProductsMenuListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MyUser = MyUser;
            if (FunkoPop.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(FunkoPopPage),CartProducts);
            }

        }

        private async void MyAutoSuggestPops_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            ProductList products = await manager.SelectAllProductAsync();
            suggestions = products.Where(p => p.ProductName.StartsWith(sender.Text)).Select(p => p.ProductName).ToList();
            MyAutoSuggestPops.ItemsSource = suggestions;
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

        private async void LogOutButton_Click(object sender, RoutedEventArgs e)
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
                Frame.Navigate(typeof(MainPage),"");
            }
        }

        private void CartButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(CartPage),null);
        }
    }
}
