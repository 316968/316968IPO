/* Quinn Parker-joyes
february 11 2019
ipo model*/
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

namespace _316968IPO
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            decimal length = 0;
            decimal width = 0;
            decimal.TryParse(txtLength.Text, out length);
            decimal.TryParse(txtWidth.Text, out width);

            decimal area = length * width;

            if (area > 0)
                MessageBox.Show(area.ToString());
            else if (area <= 0)
                MessageBox.Show("area cannot be less or equal to 0");
        }
    }
}
