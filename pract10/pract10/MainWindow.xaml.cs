using System.Collections;
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

namespace pract10
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
        int[] mas;
        ArrayList list = new ArrayList();

        private void bt_add_Click(object sender, RoutedEventArgs e)
        {
            int value;
            bool f1 = int.TryParse(tb_input.Text, out value);
            if (f1)
            {

                    list.Add(value);
                    lb_1.Items.Add(value);
                
            }
            else MessageBox.Show("Введите правильное значение");
        }

        private void bt_remove_Click(object sender, RoutedEventArgs e)
        {
            int nomer = lb_1.SelectedIndex;
            lb_1.Items.RemoveAt(nomer);
            list.RemoveAt(nomer);
        }

        private void bt_clear_Click(object sender, RoutedEventArgs e)
        {
            lb_1.Items.Clear();
            list.Clear();
        }

        private void bt_calc_Click(object sender, RoutedEventArgs e)
        {
            mas = new int[lb_1.Items.Count];
            mas = (int[]) list.ToArray(typeof(int));
            int rez = 0;
            int count = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < 0)
                {
                    rez = rez + mas[i];
                    count++;
                }
                else continue;
            }
            rez = rez/count;
            tb_rez.Text = rez.ToString();
        }

        private void bt_esc_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void bt_inf_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разраб Карпушин А.Д  Составьте программу вычисления среднего арифметического отрицательных \r\nэлементов.", "Информация ");
        }
    }
}