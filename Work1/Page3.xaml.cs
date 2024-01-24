using System.Windows;
using System.Windows.Controls;

namespace Work1
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void CompliteButton_Click(object sender, RoutedEventArgs e)
        {
            const double PI = 3.14f;
            if (!double.TryParse(NumberATextBox.Text, out double a) || a < 0 || a > 360)
            {
                MessageBox.Show("Число А - только число");
                return;
            }

            double result = a * PI / 180;
            TextAnswer.Text = $"{result}";
        }
    }
}
