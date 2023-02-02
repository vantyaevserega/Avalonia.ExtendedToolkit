﻿using System.Linq;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Avalonia.ExampleApp.Views
{
    public class TreeViewExample : UserControl
    {
        private TreeView myTreeView;

        public TreeViewExample()
        {
            this.InitializeComponent();

            myTreeView = this.FindControl<TreeView>("disableTree");

            myTreeView.PropertyChanged += MyTreeView_PropertyChanged;
        }

        private void MyTreeView_PropertyChanged(object sender, AvaloniaPropertyChangedEventArgs e)
        {
            if (e.Property.Name == nameof(TreeView.Items) && myTreeView.Items != null)
            {
                //does not work?
                myTreeView.SelectedItem = myTreeView.Items.OfType<object>().FirstOrDefault();
            }
        }



        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
