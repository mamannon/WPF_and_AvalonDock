
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
using System.Windows.Shapes;
using System.ComponentModel;

namespace PropertyChangedTest
{
    /// <summary>
    /// Interaction logic for UserControlWindow.xaml
    /// </summary>
    public partial class UserControlWindow : UserControl
    {

        public UserControlWindow()
        {
            InitializeComponent();

            //To get Avalon Dock working, we need to create all needed ViewModels somewhere,
            //and here UserControlWindowViewModel will create all other ViewModels.
            var userControlWindowViewModel = new UserControlWindowViewModel();
            this.DataContext = userControlWindowViewModel;

        }

    }
}
