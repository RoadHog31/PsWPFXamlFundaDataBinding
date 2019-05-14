using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PsWPFXamlFundaDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person src = new Person { Name = "Steve", Age = 37 };
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = src;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string message = src.Name + " is " + src.Age;
            MessageBox.Show(message);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            src.Age += 0.1;

            //ageTextBox.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
        }
    }
}
