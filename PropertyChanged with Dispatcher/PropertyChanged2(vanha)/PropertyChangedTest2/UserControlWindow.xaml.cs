
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
using System.Threading;

namespace PropertyChangedTest
{

    /// <summary>
    /// This class makes template sorting possible. We don't use 'new' anywhere to create
    /// this, but we have included this to UserControlWindow.xaml.
    /// </summary>
    public class MyTemplateSelector : DataTemplateSelector
    {

        public MyTemplateSelector()
        {
        }

        public DataTemplate MyTemplate { 
            get; 
            set; 
        }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {

            if (item is MyViewModel)
                return MyTemplate;

            return base.SelectTemplate(item, container);
        }

    }

    /// <summary>
    /// Interaction logic for UserControlWindow.xaml
    /// </summary>
    public partial class UserControlWindow : UserControl
    {
        /*
        public int Counter
        {
            get;
            set;
        }
        */
        public UserControlWindow()
        {

            ///Counter = -1;
            InitializeComponent();
            ///DataContext = this;

            //To get Avalon Dock working, we need to create all needed ViewModels somewhere,
            //and here UserControlWindowViewModel will create all other ViewModels.
            var dockingManagerViewModel = new DockingManagerViewModel();
            this.DataContext = dockingManagerViewModel;
        }
        /*
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Counter++;

            // Because we don't use INotifyPropertyChanged interface or DependencyObject, the only
            // way to refresh UI is via thread. 
            ThreadPool.QueueUserWorkItem(ignored =>
            {
                dockingManager.Dispatcher.BeginInvoke(
                        new Action(() => testLabel.Content = Counter.ToString()));
            });
        }
        */
    }
}
