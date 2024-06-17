﻿using Bloxstrap.UI.ViewModels.Menu;

namespace Bloxstrap.UI.Elements.Menu.Pages
{
    /// <summary>
    /// Interaction logic for AppearancePage.xaml
    /// </summary>
    public partial class AppearancePage
    {
        public AppearancePage()
        {
            DataContext = new AppearanceViewModel(this);
            InitializeComponent();
        }
    }
}
