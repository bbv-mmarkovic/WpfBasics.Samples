using System.Windows;

namespace Allgemein
{
    public class MyDependencyObjectViewModel : DependencyObject, IMyViewModel
    {
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(MyDependencyObjectViewModel), new PropertyMetadata(string.Empty));
    }
}