using HamburgerAppTemplate.UserControls;
using HamburgerAppTemplate.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace HamburgerAppTemplate.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Shell : Page
    {
        public SplitViewNavigationViewModel SplitViewNavigationViewModel { get; set; }

        public string ProgressText { get; set; }

        public Shell()
        {
            this.InitializeComponent();

            // this hook allows all pages and user controls to access the methods on the Shell
            App.Shell = this;

            SplitViewNavigationViewModel = new SplitViewNavigationViewModel();
        }

       private void navigationContainer_NavigationItemClicked(object sender, SplitViewNavigationEventArgs e)
        {
            if (e.NavItem.TargetPage != null)
            {
                mainFrame.Navigate(e.NavItem.TargetPage);
            }

            if (screenStates.CurrentState == Narrow)
            {
                splitView.IsPaneOpen = false;
            }
        }

        /// <summary>
        /// Shows a progress ring with a status text
        /// </summary>
        /// <param name="text"></param>
        public void ShowProgress(string text)
        {
            progressLabel.Text = text;
            VisualStateManager.GoToState(this, "ProgressShown", true);
        }

        /// <summary>
        /// Hides the progress indicator
        /// </summary>
        public void HideProgress()
        {
             VisualStateManager.GoToState(this, "ProgressHidden", true);
        }

        /// <summary>
        /// Shows a Modal window with the provided content
        /// </summary>
        /// <param name="content"></param>
        public void ShowModal(UIElement content)
        {
            modalContent.Children.Clear();
            modalContent.Children.Add(content);
            VisualStateManager.GoToState(this, "ModalShown", true);
        }

        public void HideModal()
        {
            VisualStateManager.GoToState(this, "ModalHidden", true);
            modalContent.Children.Clear();
        }
    }
}
