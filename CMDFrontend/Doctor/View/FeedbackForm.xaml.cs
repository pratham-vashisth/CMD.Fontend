﻿using CMDFrontend.Patient.View;
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

namespace CMDFrontend.Doctor.View
{
    /// <summary>
    /// Interaction logic for FeedbackForm.xaml
    /// </summary>
    public partial class FeedbackForm : Window
    {
        public FeedbackForm()
        {
              SizeChanged += (o, e) =>
                {
                    var r = SystemParameters.WorkArea;
                    Left = r.Right - ActualWidth;
                    Top = r.Bottom - ActualHeight;
                };
                InitializeComponent();
        }

        private void ExitButton(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
