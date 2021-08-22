using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for MyView.xaml
    /// </summary>
    public partial class MyView : UserControl
    {
        public int Counter
        {
            get;
            set;
        }

        public MyView()
        {
            Counter = -1;
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
