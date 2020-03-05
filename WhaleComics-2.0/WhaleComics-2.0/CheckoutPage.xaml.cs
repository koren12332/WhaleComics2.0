using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using WhaleComics_2._0.MyService;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class CheckoutPage : Page
    {
        public ObservableCollection<MyCartProduct> CustomerOrder;
        public CheckoutPage()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            CustomerOrder = (ObservableCollection<MyCartProduct>)e.Parameter;
            double sum = CustomerOrder.Sum(p => p.ProductPrice * p.CurrQuantity);
            SumText.Text = sum.ToString();
        }
    }
}
