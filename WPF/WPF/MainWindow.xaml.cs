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

namespace WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<OrderStatus> orderStatus = new List<OrderStatus>();
            orderStatus.Add(new OrderStatus("New"));
            orderStatus.Add(new OrderStatus("Old"));
            ddd.ItemsSource = orderStatus;
            List<Customer> custdata = new List<Customer>();
            Customer customer = new Customer();
            customer.FirstName = "fefe";
            customer.Status = orderStatus[1];
            custdata.Add(customer);
            
            //Bind the DataGrid to the customer data
            DG1.ItemsSource = custdata;
        }
    }

    //Defines the customer object
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Uri Email { get; set; }
        public bool IsMember { get; set; }
        public OrderStatus Status { get; set; }
    }
    
    public class OrderStatus
    {
        public OrderStatus(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public override string ToString()
        {

            return Name;
        }
    }
    //public enum OrderStatus { None, New, Processing, Shipped, Received };
}
