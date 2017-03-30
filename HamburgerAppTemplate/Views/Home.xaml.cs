using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace HamburgerAppTemplate.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        public Home()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Shell.ShowProgress("doing something important");
            await Task.Delay(5000);
            App.Shell.ShowProgress("applying final touches");
            await Task.Delay(2000);
            App.Shell.HideProgress();
        }
    }
}
