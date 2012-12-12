using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Allgemein
{
    public class MyNotifyableViewModel : IMyViewModel, INotifyPropertyChanged
    {
        private string text;
        public string Text
        {
            get { return text; }
            set
            {
                this.text = value;
                this.OnPropertyChanged("Text");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        // Tip: instead of using a dumb non-refactorable magic-string parameter, one can use following (compiler support):
        //protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}