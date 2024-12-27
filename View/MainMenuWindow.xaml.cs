using Medica.Model.Models;
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
using System.Windows.Shapes;
using Medica.ViewModels.AddViewModel;
using System.Runtime.Hosting;
using System.Windows.Media.Animation;
namespace Medica.View
{
    /// <summary>
    /// Логика взаимодействия для MainMenuWindow.xaml
    /// </summary>
    public partial class MainMenuWindow : Window
    {
        public MainMenuWindow()
        {
            InitializeComponent();
        }

        public void OnManageEmployeesClick(object sender, RoutedEventArgs e)
        {
            Collections.Employees aEmployees = new Collections.Employees();
            aEmployees.Show();
            
        }

        public void OnManageEquipmentClick(object sender, RoutedEventArgs e)
        {

            Collections.Equipment aEquipment = new Collections.Equipment();
            aEquipment.Show();
            
        }

        public void OnManageMedicationsClick(object sender, RoutedEventArgs e)
        {
            Collections.Medications aEquipment = new Collections.Medications();
            aEquipment.Show();
            

        }

        public void OnManageProvidersClick(object sender, RoutedEventArgs e)
        {
            Collections.Providers aProviders = new Collections.Providers();
            aProviders.Show();
            


        }

        public void OnManageOrdersMedicationClick(object sender, RoutedEventArgs e)
        {
            Collections.OrdersMedications aOrdersMedication = new Collections.OrdersMedications();
            aOrdersMedication.Show();
            


        }
        public void OnManageOrdersEquipmentClick(object sender, RoutedEventArgs e)
        {
            Collections.OrdersEquipments aOrdersEquipments = new Collections.OrdersEquipments();
            aOrdersEquipments.Show();
            


        }

        public void OnLogoutClick(object sender, RoutedEventArgs e)
        {
            
            Environment.Exit(0);
            
        }

        private void FuckClick(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Hide();
            mainWindow.Show();
        }
    }
}
