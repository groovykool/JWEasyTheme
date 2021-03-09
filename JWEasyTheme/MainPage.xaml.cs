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
using Windows.Storage;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using JWEasyTheme.Models;


namespace JWEasyTheme
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ObservableCollection<ColorTheme> Source = new ObservableCollection<ColorTheme>();
        public MainPage()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var resd = this.Resources.MergedDictionaries.ElementAt(0);
            ColorTheme CTheme;
            var lst = resd.Keys.ToList();
            foreach (var item in lst)
            {
                CTheme = new ColorTheme()
                {
                    TName = item.ToString(),
                    SCBrush = (SolidColorBrush)this.Resources[item.ToString()]
                };
                Source.Add(CTheme);
            }
            TList.ItemsSource = Source;
        }
    }
}
