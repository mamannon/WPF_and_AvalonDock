/*
 * This Project is the last one in a seven project series.
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


namespace PropertyChangedSmart1
{

    /// <summary>
    /// This is a container class for Docking Manager components.
    /// </summary>
    public class DockingManagerContainer
    {
        public DockingManagerViewModel DockingManagerViewModel { get; set; }
    }


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public DockingManagerContainer DockingManagerContainer { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            //To get Avalon Dock working, we need to create all needed components somewhere,
            //and here DocingManagerContainer will create and include everything needed.
            DockingManagerContainer = new DockingManagerContainer()
            {
                DockingManagerViewModel = new DockingManagerViewModel()
            };
            this.DataContext = DockingManagerContainer;
        }
    }
}
