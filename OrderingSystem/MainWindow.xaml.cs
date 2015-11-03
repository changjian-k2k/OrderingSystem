using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace OrderingSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Ordering> orderData = new ObservableCollection<Ordering>();
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            buttonAdd.Click += ButtonAdd_Click;
            dataGrid.DataContext = orderData;
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            orderData.Add(new Ordering()
            {
                Buyer = this.textBoxBuyer.Text,
                Good = this.textBoxGood.Text,
                Price = Convert.ToDouble(this.textBoxPrice.Text),
                Quantity = Convert.ToInt16(this.textBoxQuantity.Text),
                Remark = this.textBoxRemark.Text
            });
        }
    }

    public class Ordering
    {
        public string Buyer { get; set; }
        public string Good { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Remark { get; set; }
    }
}
