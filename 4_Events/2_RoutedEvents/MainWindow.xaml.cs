namespace RoutedEvents
{
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static readonly RoutedEvent TapEvent = EventManager.RegisterRoutedEvent(
            "Tap", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(MyButtonSimple));

        // Provide CLR accessors for the event 
        public event RoutedEventHandler Tap
        {
            add { AddHandler(TapEvent, value); }
            remove { RemoveHandler(TapEvent, value); }
        }

        private void CommonClickHandler(object sender, RoutedEventArgs e)
        {
            var source = (Button)e.Source;
            MessageBox.Show("The button " + source.Content + " raised the event.");
        }

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            OutputLabel.Content = "Yes clicked";
        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
            OutputLabel.Content = "No clicked";
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            OutputLabel.Content = "Cancel clicked";
        }
    }
}
