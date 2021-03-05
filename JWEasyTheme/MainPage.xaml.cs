using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace JWEasyTheme
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public static async Task SetRequestedThemeAsync(string themename)
        {
            ElementTheme Theme = ElementTheme.Default;
            switch (themename)
            {
                case "Light":
                    Theme = ElementTheme.Light;
                    break;
                case "Dark":
                    Theme = ElementTheme.Dark;
                    break;
                case "Default":
                    Theme = ElementTheme.Default;
                    break;

            }
            foreach (var view in CoreApplication.Views)
            {
                await view.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    if (Window.Current.Content is FrameworkElement frameworkElement)
                    {
                        frameworkElement.RequestedTheme = Theme;
                    }
                });
            }
        }
        public static async Task SetRequestedThemeAsync(string themename, FrameworkElement fe)
        {
            ElementTheme Theme = ElementTheme.Default;
            switch (themename)
            {
                case "Light":
                    Theme = ElementTheme.Light;
                    break;
                case "Dark":
                    Theme = ElementTheme.Dark;
                    break;
                case "Default":
                    Theme = ElementTheme.Default;
                    break;

            }
            await fe.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                fe.RequestedTheme = Theme;
            });
        }

        private async void CB1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selection = CB1.SelectedIndex;
            switch (selection)
            {
                case 0:
                    await SetRequestedThemeAsync("Default");
                    break;
                case 1:
                    await SetRequestedThemeAsync("Light");
                    break;
                case 2:
                    await SetRequestedThemeAsync("Dark");
                    break;
            }
        }
        private async void CB2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (G2 != null && G2.IsLoaded)
            {
                var selection = CB2.SelectedIndex;
                switch (selection)
                {
                    case 0:
                        await SetRequestedThemeAsync("Default", G2);
                        var brsh = (SolidColorBrush)this.Resources["Brush1"];
                        G2.Children.Add(new Grid() {Background=brsh });
                        break;
                    case 1:
                        await SetRequestedThemeAsync("Light", G2);
                        break;
                    case 2:
                        await SetRequestedThemeAsync("Dark", G2);
                        break;
                }
            }
        }

        private async void CB3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MP != null && MP.IsLoaded)
            {
                var selection = CB3.SelectedIndex;
                switch (selection)
                {
                    case 0:
                        await SetRequestedThemeAsync("Default", MP);
                        break;
                    case 1:
                        await SetRequestedThemeAsync("Light", MP);
                        break;
                    case 2:
                        await SetRequestedThemeAsync("Dark", MP);
                        break;
                }
            }
        }

        private async void CB4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (BaseGrid != null && BaseGrid.IsLoaded)
            {
                var selection = CB4.SelectedIndex;
                switch (selection)
                {
                    case 0:
                        await SetRequestedThemeAsync("Default", BaseGrid);
                        break;
                    case 1:
                        await SetRequestedThemeAsync("Light", BaseGrid);
                        break;
                    case 2:
                        await SetRequestedThemeAsync("Dark", BaseGrid);
                        break;
                }
            }
        }
    }
}
