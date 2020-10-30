namespace BindingDataContext
{
    using System.Collections.Generic;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            this.InitializeComponent();

            var parts = new List<PartViewModel>
                {
                    new PartViewModel
                        {
                            PropOne = "Teil 1, mit einem sehr langen Text!",
                            PropTwo = 1
                        },
                    new PartViewModel
                        {
                            PropOne = "Teil 2",
                            PropTwo = 2
                        },
                    new PartViewModel
                        {
                            PropOne = "Teil 3",
                            PropTwo = 3565768432
                        }
                };

            this.DataContext = new ComplexViewModel {Parts = parts, SimplyText = "Einfach nur Text"};
        }
    }
}
