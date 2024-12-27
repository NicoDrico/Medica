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

namespace Medica.View.Collections
{
    /// <summary>
    /// Логика взаимодействия для Providers.xaml
    /// </summary>
    public partial class Providers : Window
    {
        public Providers()
        {
            InitializeComponent();
            DB db = new DB();
            List<Model.Models.Provider> providers = db.getAllProviders();
            DataProviders.ItemsSource = providers;
        }
    }
}
