using System.ComponentModel;


namespace App3
{
    internal class ViewModel : INotifyPropertyChanged
    {

        private Data _Data;

        public event PropertyChangedEventHandler PropertyChanged;

        public ViewModel()
        {
            _Data = new Data();
        }
        public string data
        {
            get
            {
                return _Data.getData().ToString();
            }
        }
        public string percent
        {
            get
            {
                return _Data.getPercent().ToString();
            }
        }
        public string maxValue
        {
            get
            {
                return _Data.getMaxValue().ToString();
            }
        }
        public string minValue
        {
            get
            {
                return _Data.getMinValue().ToString();
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }


    }
}
