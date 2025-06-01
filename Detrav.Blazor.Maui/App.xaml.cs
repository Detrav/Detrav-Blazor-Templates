﻿using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace Detrav.Blazor.Maui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MainPage()) { Title = "Detrav.Blazor.Maui" };
        }
    }
}
