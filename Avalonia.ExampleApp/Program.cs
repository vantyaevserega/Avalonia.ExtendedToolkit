﻿using Avalonia.ExtendedToolkit.Extensions;
using Avalonia.ReactiveUI;
using System;
using System.Linq;

namespace Avalonia.ExampleApp
{
    class Program
    {
        private static string[] currentArgs = null;

        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        public static int Main(string[] args)
        {
            currentArgs = args;
            AppBuilder appBuilder = BuildAvaloniaApp();
            return appBuilder.StartWithClassicDesktopLifetime(args);


        }

        public static AppBuilder BuildAvaloniaApp()
        {
            AppBuilder appBuilder = null;
            if (currentArgs?.Contains("testing") == true)
            {
                appBuilder = AppBuilder.Configure<AppTesting>();
            }
            else
            {
                appBuilder = AppBuilder.Configure<App>();
            }

            appBuilder.UsePlatformDetect()
                .UseSkia()
                .UseReactiveUI()
                .UseAvaloniaExtended()
                //.UseDataGrid()
                .LogToTrace();


            return appBuilder;
        }


    }
}
