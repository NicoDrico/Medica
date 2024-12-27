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
    /// Логика взаимодействия для Medications.xaml
    /// </summary>
    public partial class Medications : Window
    {
        public Medications()
        {
            InitializeComponent();
            DB db = new DB();
            List<Model.Models.Medication> medication = db.getAllMedications();
            DataMedication.ItemsSource = medication;
        }
    }
}
