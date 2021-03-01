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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace JWEasyTheme
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {
       
        private SolidColorBrush testbrush;
        public SolidColorBrush TestBrush
        {
            get { return testbrush; }
            set { Set(ref testbrush, value, "TestBrush"); }
        }

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
      
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
                        //SetTitleColors();
                    }
                });
            }
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
        private void B1_Click(object sender, RoutedEventArgs e)
        {
            switch (g1.RequestedTheme)
            {
                case ElementTheme.Default:
                    g1.RequestedTheme = ElementTheme.Light;
                    break;
                case ElementTheme.Light:
                    g1.RequestedTheme = ElementTheme.Dark;
                    break;
                case ElementTheme.Dark:
                    g1.RequestedTheme = ElementTheme.Default;
                    break;
              
            }

        }
        private void B2_Click(object sender, RoutedEventArgs e)
        {
            switch (g2.RequestedTheme)
            {
                case ElementTheme.Default:
                    g2.RequestedTheme = ElementTheme.Light;
                    break;
                case ElementTheme.Light:
                    g2.RequestedTheme = ElementTheme.Dark;
                    break;
                case ElementTheme.Dark:
                    g2.RequestedTheme = ElementTheme.Default;
                    break;

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Set<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
