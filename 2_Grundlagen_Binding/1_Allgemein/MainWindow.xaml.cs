namespace Allgemein
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            this.InitializeComponent();
            
            this.DataContext = new MyClrViewModel();
            //this.DataContext = new MyNotifyableViewModel();
            //this.DataContext = new MyDependencyObjectViewModel();
        }
    }
}
