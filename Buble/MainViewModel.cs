using System;
using System.ComponentModel;

namespace Buble
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
        }

        #region Members
        private int _bubleTick;
        #endregion Members

        #region Properties
        public int BubleTick
        {
            get
            {
                return _bubleTick;
            }
            set
            {
                _bubleTick = value;
                NotifyPropertyChanged("BubleTick");
            }
        }

        #endregion Properties

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}