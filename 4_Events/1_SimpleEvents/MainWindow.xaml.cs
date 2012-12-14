using System.Windows;

namespace _1_SimpleEvents
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExampleButton_Click(object sender, RoutedEventArgs e)
        {
            EventOutput.Items.Add("Click");
        }

        private void ExampleButton_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            EventOutput.Items.Add("MouseEnter");
        }

        private void ExampleButton_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            EventOutput.Items.Add("MouseDown");
        }

        private void ExampleButton_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            EventOutput.Items.Add("MouseDoubleClick");
        }
        
        private void ExampleButton_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            EventOutput.Items.Add("KeyDown");
        }

        private void ExampleButton_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            EventOutput.Items.Add("MouseLeave");
        }
    }
}
