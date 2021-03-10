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
            //var resd = this.Resources.MergedDictionaries.ElementAt(0);
            ColorTheme CTheme;
            //var lst = resd.Values.ToList();
            //var lst2 = resd.Keys.ToList();
            //lst = lst.OrderBy(x => x);
            //SCBrush = (SolidColorBrush)this.Resources[item.ToString() + "Brush"]
            //var i = 0;
            //foreach (var item in lst)
            //{

            //    var brsh = (SolidColorBrush)item;
            //    CTheme = new ColorTheme()
            //    {
            //        TName = lst2.ElementAt(i).ToString(),
            //        SCBrush = brsh

            //    };
            //    Source.Add(CTheme);
            //    i++;
            //}

            //foreach (var item in SomeThemes3)
            //{
            //    //var brsh = new SolidColorBrush((Color)Application.Current.Resources[item]);
            //    var brsh = (SolidColorBrush)this.Resources[item];
            //    CTheme = new ColorTheme()
            //    {
            //        TName = item,
            //        SCBrush = brsh

            //    };
            //    Source.Add(CTheme);
            //}
            //var resd = this.Resources.MergedDictionaries.ElementAt(0);

            //var lst = resd.Values.ToList();
            //var lst2 = resd.Keys.ToList();
            ////lst = lst.OrderBy(x => x);
            ////var brsh = (SolidColorBrush)this.Resources[]
            //var i = 0;
            //foreach (var item in lst)
            //{

            //    var brsh = (SolidColorBrush)item;
            //    CTheme = new ColorTheme()
            //    {
            //        TName = (string)lst2.ElementAt(i),
            //        SCBrush = brsh

            //    };
            //    Source.Add(CTheme);
            //    i++;
            //}
            //TList.ItemsSource = Source;
            
        }
        string[] SomeThemes2 =
            {
                    "SystemAltHighColor",
                    "SystemAltLowColor",
                    "SystemAltMediumColor",
                    "SystemAltMediumHighColor",
                    "SystemAltMediumLowColor",
                    "SystemBaseHighColor",
                    "SystemBaseLowColor",
            };
        string[] SomeThemes3 =
           {
                    "Brush1",
                    
            };

        string[] SomeThemes =
            {
                    
                    
                    
                   
                    "SystemAltMediumLowColor",
                    
                    
                   
                    
                    "SystemBaseMediumLowColor",
                    
                    "SystemChromeBlackHighColor",
                    "SystemChromeBlackLowColor",
                    "SystemChromeBlackMediumLowColor",
                    "SystemChromeBlackMediumColor",
                    "SystemChromeDisabledHighColor",
                    "SystemChromeDisabledLowColor",
                    
                    
                    
                    "SystemChromeMediumLowColor",
                    "SystemChromeWhiteColor",
                    "SystemChromeGrayColor",
                    "SystemListLowColor",
                    "SystemListMediumColor",
                    "SystemErrorTextColor",
                    
                    
                    "SystemColorControlAccentColor",
                    "SystemAccentColor",
                    "SystemListAccentLowColor",
                    "SystemListAccentMediumColor",
                    "SystemListAccentHighColor",
            };

        private void MP_Loaded(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
