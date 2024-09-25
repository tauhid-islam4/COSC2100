using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataBindingDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person person = new Person()
        {
            FirstName = "John",
            LastName = "Snow",
            Address = "Nights Watch"
        };
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = person;

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ButtonShow_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{person.FirstName}");
        }
    }

    public class Person {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public String Address { get; set; }

        public Person()
        {
        }
    }
}