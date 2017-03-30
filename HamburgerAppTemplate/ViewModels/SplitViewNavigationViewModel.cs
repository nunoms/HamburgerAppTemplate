using HamburgerAppTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            NavLinks = new List<SplitViewNavigationItem>();
            NavLinks.Add(new SplitViewNavigationItem { Label = "Home", Glyph = "\uE10F", TargetPage = typeof(Views.Home) });
            NavLinks.Add(new SplitViewNavigationItem { Label = "Other Page", Glyph = "\uE158", TargetPage = typeof(Views.Other) });
        }
    }
}
