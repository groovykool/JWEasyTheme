using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;

// The Templated Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234235

namespace JWEasyTheme.Controls
{
    [ContentProperty(Name = "Children")]
    public sealed class BetterGrid : Control
    {
        public static readonly DependencyProperty ChildrenProperty = DependencyProperty.Register(
          nameof(Children),
          typeof(UIElementCollection),
          typeof(BetterGrid),
          new PropertyMetadata(default));

        public UIElementCollection Children
        {
            get { return (UIElementCollection)GetValue(ChildrenProperty); }
            private set { SetValue(ChildrenProperty, value); }
        }
        public BetterGrid()
        {
            this.DefaultStyleKey = typeof(BetterGrid);
        }     
    }
}
