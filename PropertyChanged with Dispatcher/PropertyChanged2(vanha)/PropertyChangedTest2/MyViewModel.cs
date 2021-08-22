using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyChangedTest
{

    /// <summary>
    /// This class is empty, but it needs to exist!
    /// </summary>
    public class MyViewModel
    {
        /*
        public int Counter
        {
            get;
            set;
        }

        public MyViewModel()
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
        */
    }
}
