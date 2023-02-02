using Avalonia.ExtendedToolkit.Controls;
using System;
using System.Collections.ObjectModel;
using System.Linq;

using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Avalonia.ExampleApp.Views
{
    public class IndexListDemoView : UserControl
    {
        private IndexItemsControl _indexItemsList;

        private static string[] _defaultIndexes = new string[]
        {"#","A","B","C","D","E","F","G","H",
         "I","J","K","L","M","N","O","P","Q",
         "R","S","T","U","V","W","X","Y","Z"};

        private static string[] _reverseIndexes = _defaultIndexes.Reverse().ToArray();



        public IndexListDemoView()
        {
            this.InitializeComponent();

            _indexItemsList = this.FindControl<IndexItemsControl>("indexItemsList");

            this.FindControl<RadioButton>("rbDefaultSort").Checked += (o, e) =>
            {

                _indexItemsList.IndexSectionItems = new ObservableCollection<string>(_defaultIndexes);

            };

            this.FindControl<RadioButton>("rbDefaultReverse").Checked += (o, e) =>
              {
                  _indexItemsList.IndexSectionItems = new ObservableCollection<string>(_reverseIndexes);
              };


        }


        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }



    }
}
