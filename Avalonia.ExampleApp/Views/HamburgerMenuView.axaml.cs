﻿using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Avalonia.ExampleApp.Views
{
    public class HamburgerMenuView : UserControl
    {
        public HamburgerMenuView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
