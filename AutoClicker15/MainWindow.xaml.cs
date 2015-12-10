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
using System.Windows.Threading;

namespace AutoClicker15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer sweetsTimer = new DispatcherTimer();
            sweetsTimer.Interval = TimeSpan.FromSeconds(5);
            sweetsTimer.Tick += SweetsTimer_Tick;
            DispatcherTimer autoPlayTimer = new DispatcherTimer();
            autoPlayTimer.Interval = TimeSpan.FromSeconds(10);
            autoPlayTimer.Tick += AutoPlayTimer_Tick;
        }

        private void AutoPlayTimer_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SweetsTimer_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btn_AutoPlay_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Sweets_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
