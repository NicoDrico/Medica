using Medica.ViewModels.AddViewModel;
using Medica.View;
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
using Medica.View.AddItem;

namespace Medica
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


        public void OnManageEmployeesClick(object sender, RoutedEventArgs e)
        {
            // Open Employees management window
            //var window = new Employee.EmployeeManagementWindow();
            //window.Show();
            AddEmployeesWindow addEmployeesWindow = new AddEmployeesWindow();
            addEmployeesWindow.Show();
        }

        public void OnManageEquipmentClick(object sender, RoutedEventArgs e)
        {
            // Open Equipment management window
            //var window = new Equipment.EquipmentManagementWindow();
            //window.Show();
            AddEquipmentWindow addEquipmentWindow = new AddEquipmentWindow();
            addEquipmentWindow.Show();
        }

        public void OnManageMedicationsClick(object sender, RoutedEventArgs e)
        {
            // Open Medications management window
            //var window = new Medication.MedicationManagementWindow();
            //window.Show();
            AddMedicationWindow addMedicationWindow = new AddMedicationWindow();
            addMedicationWindow.Show();
        }

        public void OnManageProvidersClick(object sender, RoutedEventArgs e)
        {
            // Open Providers management window
            //var window = new Providers.ProviderManagementWindow();
            //window.Show();
            AddProviderWindow addProviderWindow = new AddProviderWindow();
            addProviderWindow.Show();
        }

        /*public void OnManageEquipmentClick(object sender, RoutedEventArgs e)
        {
            // Open Orders management window
            //var window = new Order.OrderManagementWindow();
            //window.Show();
            AddEquipmentWindow addEquipmentWindow = new AddEquipmentWindow();
            addEquipmentWindow.Show();
        }*/
        public void OnManageMedicationClick(object sender, RoutedEventArgs e)
        {
            // Open Orders management window
            //var window = new Order.OrderManagementWindow();
            //window.Show();
            AddMedicationWindow addMedicationWindow = new AddMedicationWindow();
            addMedicationWindow.Show();
        }

        public void OnLogoutClick(object sender, RoutedEventArgs e)
        {

            Environment.Exit(0);

        }

        private void FuckClick(object sender, RoutedEventArgs e)
        {
            MainMenuWindow mainMenuWindow = new MainMenuWindow();
            this.Hide();
            mainMenuWindow.Show();
        }

        private void OnManageOrdersEquipmentClick(object sender, RoutedEventArgs e)
        {
            AddOrderEquipmentWindow addOrderEquipmentWindow = new AddOrderEquipmentWindow();
            addOrderEquipmentWindow.Show();
        }

        private void OnManageOrdersMedicationClick(object sender, RoutedEventArgs e)
        {
            AddOrderMedicationWindow addOrderMedicationWindow = new AddOrderMedicationWindow();
            addOrderMedicationWindow.Show();

        }
    }
}
    

