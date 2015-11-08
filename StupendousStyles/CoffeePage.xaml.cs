using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace StupendousStyles
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CoffeePage : Page
    {
        private string _Roast = "None";
        private string _Sweetener = "None";
        private string _Cream = "None";

        public CoffeePage()
        {
            this.InitializeComponent();
        }

        private void RoastClick(object sender, RoutedEventArgs e)
        {
            var selection = (MenuFlyoutItem)sender;
            _Roast = selection.Text;
            DisplayCoffee();
        }

        private void SweetenerClick(object sender, RoutedEventArgs e)
        {
            var selection = (MenuFlyoutItem)sender;
            _Sweetener = selection.Text;
            DisplayCoffee();
        }

        private void CreamClick(object sender, RoutedEventArgs e)
        {
            var selection = (MenuFlyoutItem)sender;
            _Cream = selection.Text;
            DisplayCoffee();
        }

        private void DisplayCoffee()
        {
            if (!_Roast.Equals("None"))
            {
                string Output = _Roast;

                if (!_Sweetener.Equals("None"))
                {
                    Output = Output + " + " + _Sweetener;
                }

                if (!_Cream.Equals("None"))
                {
                    Output = Output + " + " + _Cream;
                }

                CoffeeDisplayTextBlock.Text = Output;
            }
            else
            {
                CoffeeDisplayTextBlock.Text = "";
            }
        }
    }
}
