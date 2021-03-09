using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;

namespace JWEasyTheme.Models
{
    class ColorTheme : INotifyPropertyChanged
    {
        private string _TName;
        public string TName
        {
            get { return _TName; }
            set { Set(ref _TName, value, "TName"); }
        }
        private SolidColorBrush _SCBrush;
        public SolidColorBrush SCBrush
        {
            get { return _SCBrush; }
            set { Set(ref _SCBrush, value, "SCBrush"); }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private void Set<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }
    }
    
}
