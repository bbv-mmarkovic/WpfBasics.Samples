using System.Windows;

namespace Allgemein
{
    public class MySpecialAttachedProperty : DependencyObject
    {
        public static string GetMyAttachable(DependencyObject obj)
        {
            return (string)obj.GetValue(MyAttachableProperty);
        }

        public static void SetMyAttachable(DependencyObject obj, string value)
        {
            obj.SetValue(MyAttachableProperty, value);
        }

        public static readonly DependencyProperty MyAttachableProperty =
            DependencyProperty.RegisterAttached("MyAttachable", typeof(string), typeof(MySpecialAttachedProperty), new PropertyMetadata(string.Empty));
    }
}