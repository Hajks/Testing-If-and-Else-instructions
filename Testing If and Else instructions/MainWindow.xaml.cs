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

namespace Testing_If_and_Else_instructions
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
        //one more task for if/else 
        //simple task, if checkbox is unchecked then show message about checking it
        //if it is checked, change label text to left and set position of label to left and vice versa about right side.
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (myCheckBox.IsChecked == true)
            {
                if(myLabel.HorizontalAlignment == HorizontalAlignment.Left)
                {
                    myLabel.HorizontalAlignment = HorizontalAlignment.Right;
                    myLabel.Content = "Z prawej";
                }
                else
                {
                    myLabel.HorizontalAlignment = HorizontalAlignment.Left;
                    myLabel.Content = "Z lewej";
                }
            }
            else
            {
                myLabel.HorizontalAlignment = HorizontalAlignment.Center;
                myLabel.Content = "Możliwość tekstu została wyłączona";
            }
        }
    }
}
