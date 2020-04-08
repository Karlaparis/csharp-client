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

namespace HomeworkApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            //WindowState = WindowState.Maximized; handled by the .xaml
           uxSubmit.IsEnabled = false;
        }

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Submitting password:" + uxPassword.Text);
        }

       private void uxPassword_TextChanged(object sender, TextChangedEventArgs e)
       {
            if (!string.IsNullOrWhiteSpace(uxPassword.Text) && !string.IsNullOrWhiteSpace(uxName.Text))     
            {
                {
                   uxSubmit.IsEnabled = true;

                    if (string.IsNullOrWhiteSpace(uxPassword.Text) || string.IsNullOrWhiteSpace(uxName.Text))
                    { uxSubmit.IsEnabled = false; 
                    }
                }
            }

            else
            {
                if (string.IsNullOrWhiteSpace(uxPassword.Text) && string.IsNullOrWhiteSpace(uxName.Text))
                {
                    uxSubmit.IsEnabled = false;
                }

                else

                if (string.IsNullOrWhiteSpace(uxPassword.Text) || string.IsNullOrWhiteSpace(uxName.Text))
                {
                     uxSubmit.IsEnabled = false;
                }
            }
       }

        private void uxName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(uxName.Text) && !string.IsNullOrWhiteSpace(uxPassword.Text))
            {
                uxSubmit.IsEnabled = true;

                if (string.IsNullOrWhiteSpace(uxName.Text) ||string.IsNullOrWhiteSpace(uxPassword.Text))
                {
                    uxSubmit.IsEnabled = false;
                }
            }

            else
            {
                if (string.IsNullOrWhiteSpace(uxName.Text) && string.IsNullOrWhiteSpace(uxPassword.Text))
                {
                    uxSubmit.IsEnabled = false;
                }

                else

               if (string.IsNullOrWhiteSpace(uxName.Text) || string.IsNullOrWhiteSpace(uxPassword.Text))
               {
                   uxSubmit.IsEnabled = false;
               }
            }
        }

    }
}
