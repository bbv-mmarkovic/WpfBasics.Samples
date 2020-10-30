using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BindingDataContext
{
    public class PartViewModel : INotifyPropertyChanged
    {
        private string propOne;
        private long propTwo;

        public event PropertyChangedEventHandler PropertyChanged;

        public string PropOne
        {
            get
            {
                return this.propOne;
            }
            set
            {
                this.propOne = value;
                this.OnPropertyChanged();
            }
        }

        public long PropTwo
        {
            get
            {
                return this.propTwo;
            }
            set
            {
                this.propTwo = value;
                this.OnPropertyChanged();
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}