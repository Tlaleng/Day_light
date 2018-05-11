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

namespace Daylight
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

        private void Checkbtn_Click(object sender, RoutedEventArgs e)
        {

        }

        public class Daylightdetector
        {
            public Daylightdetector()
            {

            }

            public bool getState(DateTime time)
            {
                if ((time.Hour > 6) && (time.Hour < 18))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
