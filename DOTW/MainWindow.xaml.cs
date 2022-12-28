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

namespace DOTW
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_p_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int[] r = { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };
                string[] w = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
                bool a = Convert.ToInt32(Y.Text) % 4 == 0 && Convert.ToInt32(Y.Text) % 100 != 0 && Convert.ToInt32(Y.Text) % 400 == 0;
                if (a && Convert.ToInt32(D.Text) <= 29 && Convert.ToInt32(M.Text) == 2 || Convert.ToInt32(D.Text) > 31 || Convert.ToInt32(M.Text) > 12 || Convert.ToInt32(D.Text) <= 28 && Convert.ToInt32(M.Text) == 2)
                {
                    //Convert.ToInt32(D.Text) <= 28 && Convert.ToInt32(M.Text) == 2
                    if (Convert.ToInt32(M.Text) < 3)
                    {
                        int year = Convert.ToInt32(Y.Text) - 1;
                        l.Content = w[(Convert.ToInt32(Y.Text) + Convert.ToInt32(Y.Text) / 4 - Convert.ToInt32(Y.Text) / 100 + Convert.ToInt32(Y.Text) / 400 + r[Convert.ToInt32(M.Text) - 1] + Convert.ToInt32(D.Text)) % 7].ToString();
                    }
                    l.Content = w[(Convert.ToInt32(Y.Text) + Convert.ToInt32(Y.Text) / 4 - Convert.ToInt32(Y.Text) / 100 + Convert.ToInt32(Y.Text) / 400 + r[Convert.ToInt32(M.Text) - 1] + Convert.ToInt32(D.Text)) % 7].ToString();
                }
                else
                {
                    MessageBox.Show("Check ur format", "Invalid data");
                }
            }
            catch
            {
                MessageBox.Show("Check ur format", "Invalid data");
            }
        }

        }
}
