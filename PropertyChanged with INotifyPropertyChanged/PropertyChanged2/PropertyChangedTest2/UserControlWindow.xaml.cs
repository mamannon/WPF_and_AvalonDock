
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

namespace PropertyChangedTest2
{
    /// <summary>
    /// Interaction logic for UserControlWindow.xaml
    /// </summary>
    public partial class UserControlWindow : UserControl
    {

        /// <summary>
        /// This class implements INotifyPropertyChanged interface, which has
        /// difficulties to get working with Avalon Dock, but here it is trivial.
        /// </summary>
        public class CountModel : INotifyPropertyChanged //using System.ComponentModel;
        {
            private int _counter;

            public int Counter
            {
                get { return _counter; }
                set
                {
                    _counter = value;
                    OnPropertyChanged("Counter");
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;

            protected void OnPropertyChanged(string propertyName)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }
        }

        CountModel countModel = new CountModel();

        public UserControlWindow()
        {
            InitializeComponent();
            counterLabel.DataContext = countModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            countModel.Counter++;
        }
    }
}
