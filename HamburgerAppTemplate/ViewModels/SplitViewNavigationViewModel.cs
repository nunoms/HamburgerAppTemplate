using HamburgerAppTemplate.Models;
using System.Collections.Generic;

namespace HamburgerAppTemplate.ViewModels
{
    public class SplitViewNavigationViewModel
    {
        public List<SplitViewNavigationItem> NavLinks { get; set; }

        public SplitViewNavigationViewModel()
        {
            SetupNavigation();
        }

        private void SetupNavigation()
        {
            NavLinks = new List<SplitViewNavigationItem>
            {
                new SplitViewNavigationItem { Label = "Home", Glyph = "\uE10F", TargetPage = typeof(Views.Home) },
                new SplitViewNavigationItem { Label = "Other Page", Glyph = "\uE158", TargetPage = typeof(Views.Other) }
            };
        }
    }
}
