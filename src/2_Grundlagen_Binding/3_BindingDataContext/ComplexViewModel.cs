using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BindingDataContext
{
    public class ComplexViewModel : INotifyPropertyChanged
    {
        private string simplyText;
        private IEnumerable<PartViewModel> parts;

        public event PropertyChangedEventHandler PropertyChanged;

        public string SimplyText
        {
            get
            {
                return this.simplyText;
            }

            set
            {
                this.simplyText = value;
                this.OnPropertyChanged();
            }
        }

        public IEnumerable<PartViewModel> Parts
        {
            get
            {
                return this.parts;
            }
            set
            {
                this.parts = value;
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