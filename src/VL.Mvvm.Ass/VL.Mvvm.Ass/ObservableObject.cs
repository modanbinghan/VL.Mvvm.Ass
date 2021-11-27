using System;
using System.ComponentModel;

namespace VL.Mvvm.Ass
{
    public class ObservableObject : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged 接口

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
