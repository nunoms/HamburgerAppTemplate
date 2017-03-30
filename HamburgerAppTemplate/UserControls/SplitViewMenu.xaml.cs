using HamburgerAppTemplate.Models;
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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace HamburgerAppTemplate.UserControls
{
    public sealed partial class SplitViewMenu : UserControl
    {
        public SplitViewMenu()
        {
            this.InitializeComponent();
            this.Loaded += SplitViewMenu_Loaded;
        }

        private void SplitViewMenu_Loaded(object sender, RoutedEventArgs e)
        {
            if (navigationList.Items != null && navigationList.Items.Count > 0)
            {
                OnNavRequested(navigationList.Items[0] as SplitViewNavigationItem);
                navigationList.SelectedIndex = 0;
            }
        }

        private void navigationList_ItemClick(object sender, ItemClickEventArgs e)
        {
            OnNavRequested(e.ClickedItem as SplitViewNavigationItem);
        }

        private void bottomNavigationList_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bottomNavigationList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
                navigationList.SelectionChanged -= navItem_Changed;
                navigationList.SelectedIndex = -1;
                navigationList.SelectionChanged += navItem_Changed;
        }

        private void navItem_Changed(object sender, SelectionChangedEventArgs e)
        {
            bottomNavigationList.SelectionChanged -= bottomNavigationList_SelectionChanged;
            bottomNavigationList.SelectedIndex = -1;
            bottomNavigationList.SelectionChanged += bottomNavigationList_SelectionChanged;
        }

        public event EventHandler<SplitViewNavigationEventArgs> NavigationItemClicked;
        private void OnNavRequested(SplitViewNavigationItem item)
        {
            NavigationItemClicked?.Invoke(this, new SplitViewNavigationEventArgs { NavItem = item });
        }

    
    }

    public class SplitViewNavigationEventArgs : EventArgs
    {
        public SplitViewNavigationItem NavItem { get; set; }
    }
}
