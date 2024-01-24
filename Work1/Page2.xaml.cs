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

namespace Work1
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void CompliteButton_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(NumberATextBox.Text, out double a))
            {
                MessageBox.Show("Число А - только число");
                return;
            }

            if (!double.TryParse(NumberBTextBox.Text, out double b))
            {
                MessageBox.Show("Число B - только число");
                return;
            }

            if (!double.TryParse(NumberCTextBox.Text, out double c))
            {
                MessageBox.Show("Число C - только число");
                return;
            }

            double t = c;
            double v = b;
            c = a;
            b = t;
            a = v;

            TextAnswer.Text = $"A = {a}, B = {b}, C = {c}";
        }
    }
}
