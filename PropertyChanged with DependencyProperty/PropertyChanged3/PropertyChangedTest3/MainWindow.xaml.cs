/*
 * This Project is the second one to find out when and where
 * PropertyChangedEventHandler fails. Here we have added UserControl
 * compared to the first project. However, PropertyChangedEventHandler 
 * works in this project.
 * */

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


namespace PropertyChangedTest
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// We don't do anything here, but MainWindow.xaml includes UserControlWindow...
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
