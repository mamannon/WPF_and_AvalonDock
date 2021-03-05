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
using System.ComponentModel;

namespace PropertyChangedTest
{
    /// <summary>
    /// Interaction logic for MyTemplate.xaml
    /// </summary>
    public partial class MyView : UserControl
    {

        /// <summary>
        /// This class implements INotifyPropertyChanged interface, which has
        /// difficulties to get working with Avalon Dock, but here it is working.
        /// Class CountModel is copy-pasted from solution PropertyChangedTest1.
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

         private CountModel countModel = new CountModel();

        public MyView()
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
