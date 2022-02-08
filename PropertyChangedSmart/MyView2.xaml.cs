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

namespace PropertyChangedSmart1
{
    /// <summary>
    /// Interaction logic for MyView2.xaml
    /// </summary>
    public partial class MyView2 : UserControl, INotifyPropertyChanged
    {

        private int counter = -1;

        public int Counter
        {
            get { return counter; }
            set
            {
                counter = value;
                OnPropertyChanged("Counter");
            }
        }

        public MyView2()
        {
            InitializeComponent();
            DataContext = this;
        }    

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Counter--;
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

    }
}
