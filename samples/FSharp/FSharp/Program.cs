﻿using BlazorRedux;
using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FSharp
{
    internal class Program
    {
        private static void Main()
        {
            var serviceProvider = new BrowserServiceProvider(configure =>
            {
                configure.AddSingleton(new Store<MyModel>(Reducers.MainReducer, new MyModel()));
            });

            new BrowserRenderer(serviceProvider).AddComponent<App>("app");
        }
    }
}