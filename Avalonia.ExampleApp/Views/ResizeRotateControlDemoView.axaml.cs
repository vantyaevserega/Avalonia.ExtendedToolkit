using Avalonia.Controls;
using Avalonia.ExtendedToolkit.Controls;
using System;
using Avalonia.Markup.Xaml;

namespace Avalonia.ExampleApp.Views
{
    public class ResizeRotateControlDemoView : UserControl
    {

        public ResizeRotateControlDemoView()
        {
            InitializeComponent();
            this.Find<ResizeRotateControl>("resizeRotateControl").PositionChanged += (o, e) =>
            {
                Console.WriteLine(e);
            };
        }



        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
