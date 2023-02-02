﻿using Avalonia.ExampleApp.Model.PropertyGrid_CustomTypeEditors;
using Avalonia.ExtendedToolkit.Controls.PropertyGrid;
using System;
using System.IO;
using System.Linq;

using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Avalonia.ExampleApp.Views
{
    public class PropertyGridExample_CustomTypeEditors : UserControl
    {
        static Random random = new Random();
        private CategoryItem _tempItem;
        private int _tempIndex;
        readonly BusinessObject bo;
        private readonly PropertyGrid propertyGrid;

        public PropertyGridExample_CustomTypeEditors()
        {
            this.InitializeComponent();

            bo = new BusinessObject();

            propertyGrid = this.Find<PropertyGrid>("propertyGrid");
            propertyGrid.SelectedObjectsChanged += PropertyGrid_SelectedObjectsChanged;
            propertyGrid.SelectedObject = bo;
            propertyGrid.PropertyValueChanged += PropertyGrid_PropertyValueChanged;

            Button btnTest = this.Find<Button>("btnTest");
            btnTest.Click += BtnTest_Click;

            Button btnSwitchObjects = this.Find<Button>("btnSwitchObjects");
            btnSwitchObjects.Click += BtnSwitchObjects_Click;

            Button btnSelectMultiple = this.Find<Button>("btnSelectMultiple");
            btnSelectMultiple.Click += BtnSelectMultiple_Click;


        }

        private void BtnSelectMultiple_Click(object sender, Interactivity.RoutedEventArgs e)
        {
            object[] objects = new object[]
            {
                new BusinessObject { Name = "AC DC", Integer1 = 10 },
                new BusinessObject { Name = "Marilyn Manson", Integer1 = 10 },
                new BusinessObject { Name = "Charles Darvin", Integer1 = 10 }
            };

            this.propertyGrid.SelectedObjects = objects;
        }

        private void BtnSwitchObjects_Click(object sender, Interactivity.RoutedEventArgs e)
        {
            propertyGrid.SelectedObject = new BusinessObject
            {
                Name = Path.GetRandomFileName(),
                Password = Path.GetRandomFileName(),
                RegisteredDate = DateTime.Now,
                Integer1 = random.Next(1000),
                Integer2 = random.Next(1000),
                Integer3 = random.Next(1000),
                Integer4 = random.Next(1000),
                Attachment = Path.GetRandomFileName()
            };
        }

        private void BtnTest_Click(object sender, Interactivity.RoutedEventArgs e)
        {
            PropertyItem prop = propertyGrid.Properties["Name"];
            if (prop != null)
            {
                //workaround because setting isbrowsable is not working right now
                var result = propertyGrid.Categories.FirstOrDefault(x => x.Properties.Contains(prop));

                if (result != null)
                {
                    _tempItem = result;
                    _tempIndex = propertyGrid.Categories.IndexOf(result);
                    propertyGrid.Categories.Remove(result);
                }
                else
                {
                    propertyGrid.Categories.Insert(_tempIndex, _tempItem);
                }



                //prop.IsReadOnly = !prop.IsReadOnly;
                //prop.IsReadOnly = !prop.IsReadOnly;

                // propertyGrid.ReloadCommand.Execute(null);
            }
        }

        private void PropertyGrid_PropertyValueChanged(object sender, System.EventArgs e)
        {

        }

        private void PropertyGrid_SelectedObjectsChanged(object sender, System.EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
