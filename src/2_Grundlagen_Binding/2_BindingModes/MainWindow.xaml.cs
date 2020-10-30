namespace BindingModes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private MyNotifyableViewModel dataContext;

        public MainWindow()
        {
            this.InitializeComponent();

            dataContext = new MyNotifyableViewModel {Text = "Initial Value!"};
            this.DataContext = dataContext;
        }

        protected override void OnActivated(System.EventArgs e)
        {
            dataContext.Text = "OnActivated Value!";
        }
    }
}
