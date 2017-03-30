using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace HamburgerAppTemplate.UserControls
{
    public sealed partial class PageHeader : UserControl
    {
        public PageHeader()
        {
            this.InitializeComponent();

            titleText.Margin = new Thickness(20, 0, 20, 0);
            myCommandBar.PrimaryCommands.VectorChanged += Commands_VectorChanged;
            myCommandBar.SecondaryCommands.VectorChanged += Commands_VectorChanged;
        }

        private void Commands_VectorChanged(IObservableVector<ICommandBarElement> sender, IVectorChangedEventArgs @event)
        {
            if (myCommandBar.PrimaryCommands.Count > 0 || myCommandBar.SecondaryCommands.Count > 0)
            {
                titleText.Margin = new Thickness(20, -12, 20, 0);
            }
            else
            {
                titleText.Margin = new Thickness(20, 0, 20, 0);
            }
        }

        public IObservableVector<ICommandBarElement> PrimaryCommands
        {
            get { return (IObservableVector<ICommandBarElement>)myCommandBar.PrimaryCommands;  }
        }

        public IObservableVector<ICommandBarElement> SecondaryCommands
        {
            get { return (IObservableVector<ICommandBarElement>)myCommandBar.SecondaryCommands; }
        }


        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(PageHeader), new PropertyMetadata(""));

    }
}
