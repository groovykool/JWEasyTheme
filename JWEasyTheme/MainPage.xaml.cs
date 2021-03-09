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
            //SCBrush = (SolidColorBrush)this.Resources[item.ToString()+"Brush"]
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

            //foreach (var item in SomeThemes)
            //{
            //    CTheme = new ColorTheme()
            //    {
            //        TName = item,
            //        SCBrush = (SolidColorBrush)this.Resources[item]

            //    };
            //    Source.Add(CTheme);
            //}
            //TList.ItemsSource = Source;
            //this.Bindings.Update();
        }

        string[] SomeThemes =
            {
                    "SystemAltHighColor",
                    "SystemAltLowColor",
                    "SystemAltMediumColor",
                    "SystemAltMediumHighColor",
                    "SystemAltMediumLowColor",
                    "SystemBaseHighColor",
                    "SystemBaseLowColor",
                    "SystemBaseMediumColor",
                    "SystemBaseMediumHighColor",
                    "SystemBaseMediumLowColor",
                    "SystemChromeAltLowColor",
                    "SystemChromeBlackHighColor",
                    "SystemChromeBlackLowColor",
                    "SystemChromeBlackMediumLowColor",
                    "SystemChromeBlackMediumColor",
                    "SystemChromeDisabledHighColor",
                    "SystemChromeDisabledLowColor",
                    "SystemChromeHighColor",
                    "SystemChromeLowColor",
                    "SystemChromeMediumColor",
                    "SystemChromeMediumLowColor",
                    "SystemChromeWhiteColor",
                    "SystemChromeGrayColor",
                    "SystemListLowColor",
                    "SystemListMediumColor",
                    "SystemErrorTextColor",
                    "SystemChromeAltMediumHighColor",
                    "SystemChromeAltHighColor",
                    "SystemRevealAltHighColor",
                    "SystemRevealAltLowColor",
                    "SystemRevealAltMediumColor",
                    "SystemRevealAltMediumHighColor",
                    "SystemRevealAltMediumLowColor",
                    "SystemRevealBaseHighColor",
                    "SystemRevealBaseLowColor",
                    "SystemRevealBaseMediumColor",
                    "SystemRevealBaseMediumHighColor",
                    "SystemRevealBaseMediumLowColor",
                    "SystemRevealChromeAltLowColor",
                    "SystemRevealChromeBlackHighColor",
                    "SystemRevealChromeBlackLowColor",
                    "SystemRevealChromeBlackMediumLowColor",
                    "SystemRevealChromeBlackMediumColor",
                    "SystemRevealChromeHighColor",
                    "SystemRevealChromeLowColor",
                    "SystemRevealChromeMediumColor",
                    "SystemRevealChromeMediumLowColor",
                    "SystemRevealChromeWhiteColor",
                    "SystemRevealChromeGrayColor",
                    "SystemRevealListLowColor",
                    "SystemRevealListMediumColor",
                    "SystemChromeMediumHighColor",
                    "SystemColorControlAccentColor",
                    "SystemAccentColor",
                    "SystemListAccentLowColor",
                    "SystemListAccentMediumColor",
                    "SystemListAccentHighColor",
            };
    }
}
