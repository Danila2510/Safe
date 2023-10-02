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

namespace Safe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IView
    {
        public event EventHandler<EventArgs> Ok_button;
        public MainWindow()
        {
            InitializeComponent();
        }
        public string Password { get { return num_block.Text; } }
        
        private void click_num(object sender, RoutedEventArgs e)
        {
            Button temp = (Button)sender;
            num_block.Text += temp.Content.ToString();
        }

        private void C_click(object sender, RoutedEventArgs e)
        {
            num_block.Text = "";
        }

        private void Ok_click(object sender, RoutedEventArgs e)
        {
            try
            {
                string temp = Password;
                Ok_button?.Invoke(this, EventArgs.Empty);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
