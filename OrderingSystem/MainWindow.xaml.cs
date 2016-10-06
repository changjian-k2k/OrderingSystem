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
        public OrderForm orderForm = new OrderForm();
        ObservableCollection<OrderForm> orderData = new ObservableCollection<OrderForm>();
        ObservableCollection<OrderingSystemForm> osData = new ObservableCollection<OrderingSystemForm>();
        ObservableCollection<ClientForm> clientData = new ObservableCollection<ClientForm>();
        ObservableCollection<GoodForm> goodData = new ObservableCollection<GoodForm>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            buttonAdd.Click += ButtonAdd_Click;
            buttonDefault.Click += ButtonDefault_Click;
            buttonChange.Click += ButtonChange_Click;
            dataGrid.DataContext = orderData;
            gridNewOrder.DataContext = orderForm;

            List<OrderForm> _orderList = OrderingSystemDB.GetOrder();
            foreach (var item in _orderList)
            {
                orderData.Add(item);
            }

            List<OrderingSystemForm> _osList = OrderingSystemDB.GetOrderingSystem();
            foreach (var item in _osList)
            {
                osData.Add(item);
            }

            List<ClientForm> _clientList = OrderingSystemDB.GetClient();
            foreach (var item in _clientList)
            {
                clientData.Add(item);
            }

            List<GoodForm> _goodList = OrderingSystemDB.GetGood();
            foreach (var item in _goodList)
            {
                goodData.Add(item);
            }
        }

        private void ButtonChange_Click(object sender, RoutedEventArgs e)
        {
            orderForm.Buyer = "Penny";
        }

        private void ButtonDefault_Click(object sender, RoutedEventArgs e)
        {
            NewOrderBinding();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            orderData.Add(orderForm);
            OrderingSystemDB.AddOrder(orderForm);
        }

        private void NewOrderBinding()
        {
            orderForm.Id = 0;
            orderForm.Buyer = null;
            orderForm.Good = null;
            orderForm.Price = null;
            orderForm.Quantity = null;
            orderForm.GoodColor = null;
            orderForm.GoodSize = null;
            orderForm.Remark = null;
            orderForm.Address = null;
            orderForm.OrderDate = DateTime.Now;
            orderForm.ShipDate = DateTime.Now;
            orderForm.Photo = null;
            orderForm.PaymentStatus = null;
        }

        private void buttonTestAdd_Click(object sender, RoutedEventArgs e)
        {
            TestTableDB.AddItem(textBoxName.Text);
        }
    }
}
