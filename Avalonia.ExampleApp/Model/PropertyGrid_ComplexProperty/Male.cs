
using System;
using System.ComponentModel;
using ReactiveUI;

namespace Avalonia.ExampleApp.Model
{
    public class Male : Human
    {
        private Female _wife = new Female { Name = "Joan", Surname = "Doe" };

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public Female Wife
        {
            get { return _wife; }
            set
            {
                this.RaiseAndSetIfChanged(ref _wife, value);
            }
        }


    }
}
