﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace JWEasyTheme.Controls
{
    [ContentProperty(Name = "Children")]
    public sealed partial class ThemeGrid : UserControl
    {
        public static readonly DependencyProperty ChildrenProperty = DependencyProperty.Register(
           nameof(Children),
           typeof(UIElementCollection),
           typeof(ThemeGrid),
           new PropertyMetadata(default));

        public UIElementCollection Children
        {
            get { return (UIElementCollection)GetValue(ChildrenProperty); }
            private set { SetValue(ChildrenProperty, value); }
        }


        public ThemeGrid()
        {
            this.InitializeComponent();
            Children = BaseG.Children;
        }
    }
}
