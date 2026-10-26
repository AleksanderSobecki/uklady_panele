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

namespace uklady_panele
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnWitaj_Click(object sender, RoutedEventArgs e)
        {
            
            if(String.IsNullOrEmpty(txtImie.Text)) {
                lblKomunikat.Content = "Witaj nieznajomy.";
            } else {
                lblKomunikat.Content = "Witaj " + txtImie.Text.Trim() + "!";
            }
        }
    }
    
}