using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerAppTemplate.Models
{
    public class SplitViewNavigationItem
    {
        public string Label { get; set; }
        public string Glyph { get; set; }
        public Type TargetPage { get; set; }
    }
}
