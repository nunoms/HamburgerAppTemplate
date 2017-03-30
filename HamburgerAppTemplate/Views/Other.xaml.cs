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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace HamburgerAppTemplate.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Other : Page
    {
        public Other()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Grid g = new Grid();
            g.Padding = new Thickness(12);

            TextBlock tb = new TextBlock();
            tb.Text = "Sample Content";
            tb.Style = App.Current.Resources["TitleTextBlockStyle"] as Style;
            tb.VerticalAlignment = VerticalAlignment.Center;
            tb.HorizontalAlignment = HorizontalAlignment.Center;

            Button b = new Button();
            b.Content = "Close";
            b.VerticalAlignment = VerticalAlignment.Bottom;
            b.HorizontalAlignment = HorizontalAlignment.Right;
            b.Click += B_Click;

            g.Children.Add(tb);
            g.Children.Add(b);

            App.Shell.ShowModal(g);
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            App.Shell.HideModal();
        }
    }
}
