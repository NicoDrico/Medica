﻿using System;
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

namespace Medica.ViewModels.EditViewModel
{
    /// <summary>
    /// Логика взаимодействия для EditMedicationWindow.xaml
    /// </summary>
    public partial class EditMedicationWindow : Window
    {
        public EditMedicationWindow()
        {
            InitializeComponent();
        }

        private void OnSaveButtonClick(object sender, RoutedEventArgs e)
        {
            // Logic to save edited medication
        }
    }
}

