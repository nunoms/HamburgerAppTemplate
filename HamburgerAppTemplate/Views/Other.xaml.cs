using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

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
            Grid g = new Grid()
            {
                Padding = new Thickness(12)
            };
            TextBlock tb = new TextBlock()
            {
                Text = "Sample Content",
                Style = App.Current.Resources["TitleTextBlockStyle"] as Style,
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center
            };
            Button b = new Button()
            {
                Content = "Close",
                VerticalAlignment = VerticalAlignment.Bottom,
                HorizontalAlignment = HorizontalAlignment.Right
            };
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
