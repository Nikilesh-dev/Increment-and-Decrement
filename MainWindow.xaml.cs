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

namespace Imcrement_and_decrement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        String Print = "";


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int Start = Convert.ToInt16(txtStart.Text);
            int End = Convert.ToInt16(txtEnd.Text);
            int Increment = Convert.ToInt16(txtIncrement.Text);
            if (Start >= 1000 || End >= 1000 || Increment >= 100)
            {
                MessageBoxResult result = MessageBox.Show("Invalid Input please give valid Input", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                if (result == MessageBoxResult.OK)
                {
                    txtStart.Clear();
                    txtEnd.Clear();
                    txtIncrement.Clear();
                }
            }
            else
            {
                for (int i = Start; i <= End; i = i + Increment)
                {
                    Print = i.ToString();
                    if (Print == "")
                    {
                        Display1.Content = Print;
                    }
                    else if (Print == End.ToString())
                    {
                        Display1.Content += Print;
                    }
                    else
                    {
                        Display1.Content += Print + ",";
                    }
                }
            }

        }
             
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int Start1 = Convert.ToInt16(txtStart2.Text);
            int End1 = Convert.ToInt16(txtEnd2.Text);
            int Decrement = Convert.ToInt16(txtDecrement.Text);
            if (Start1 >= 1000 || End1 >= 1000 || Decrement > 100)
            {
                MessageBoxResult result = MessageBox.Show("Invalid Input Please give valid Input", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                if (result == MessageBoxResult.OK)
                {
                    txtStart2.Clear();
                    txtEnd2.Clear();
                    txtDecrement.Clear();
                }
            }
            else
            {

                for (int j = Start1; j >= End1; j = j - Decrement)
                {
                   Print = j.ToString();
                    
                    if (Print == "")
                    {
                        Display2.Content = Print;
                    }
                    else if (Print == End1.ToString())
                    {
                        Display2.Content += Print;
                    }
                    else
                    {
                        Display2.Content += Print + ",";
                    }
                }
            }
        }
    }
}
