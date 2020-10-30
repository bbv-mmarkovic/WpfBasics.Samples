using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace StyleTriggers
{
    public class MyViewModel : INotifyPropertyChanged
    {
        private string input;
        public event PropertyChangedEventHandler PropertyChanged;

        public string Input
        {
            get
            {
                return input;
            }
            set
            {
                input = value;
                this.OnPropertyChanged();
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}