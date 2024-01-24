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
using static System.Math;

namespace Work1
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void CompliteButton_Click(object sender, RoutedEventArgs e)
        {
            double chast, total, product, different;

            if (!double.TryParse(NumberATextBox.Text, out double a) || a == 0)
            {
                MessageBox.Show("Число А - ненулевое число");
                return;
            }

            if (!double.TryParse(NumberBTextBox.Text, out double b) || b == 0)
            {
                MessageBox.Show("Число B - ненулевое число");
                return;
            }

            total = Abs(a) + Abs(b);
            product = Abs(a) * Abs(b);
            different = Abs(a) - Abs(b);
            chast = Abs(a) / Abs(b);

            TextAnswer.Text = $"Сложение: {total}\nПроизведение: {product}\nВычитание: {different}\nЧастное: {chast:f3}";
        }
    }
}
