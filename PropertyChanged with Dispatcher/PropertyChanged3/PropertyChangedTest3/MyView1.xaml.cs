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
using System.Threading;

namespace PropertyChangedTest
{
    /*
    /// <summary>
    /// This class implements INotifyPropertyChanged interface, which has
    /// difficulties to get working with Avalon Dock, but here it is working.
    /// Class CountModel is copy-pasted from solution PropertyChangedTest1.
    /// </summary>
    public class CountModel : INotifyPropertyChanged //using System.ComponentModel;
    {

        private int _counter = 0;
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
    */
    /// <summary>
    /// Interaction logic for MyView1.xaml
    /// </summary>
    public partial class MyView1 : UserControl
    {
        public int Counter
        {
            get;
            set;
        }

        public MyView1()
        {
            Counter = 1;
            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Counter++;

            // Because we don't use INotifyPropertyChanged interface or DependencyObject, the only
            // way to refresh UI is via thread. 
            ThreadPool.QueueUserWorkItem(ignored =>
            {
                counterLabel.Dispatcher.BeginInvoke(
                        new Action(() => counterLabel.Content = Counter.ToString()));
            });
        }
    }
}

